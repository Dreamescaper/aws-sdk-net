﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.XPath;
using ServiceClientGenerator.Generators.ProjectFiles;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Class used to emit the set of per-platform project files for a service. 
    /// Existing project files are retained, only missing files are generated.
    /// </summary>
    public class ProjectFileCreator
    {
        /// <summary>
        /// On conclusion, the set of project files that were generated for the service.
        /// </summary>
        public Dictionary<string, ProjectConfigurationData> CreatedProjectFiles { get; set; }

        private GeneratorOptions Options;

        public ProjectFileCreator(GeneratorOptions options)
        {
            Options = options;
        }

        public void ExecuteCore(string coreFilesRoot, IEnumerable<ProjectFileConfiguration> projectFileConfigurations)
        {
            CreatedProjectFiles = new Dictionary<string, ProjectConfigurationData>();

            foreach (var projectFileConfiguration in projectFileConfigurations)
            {
                var projectType = projectFileConfiguration.Name;

                var assemblyName = "AWSSDK.Core";
                var projectFilename = string.Concat(assemblyName, ".", projectType, ".csproj");
                bool newProject = false;

                if (projectFileConfiguration.Template.Equals("VS2017ProjectFile", StringComparison.InvariantCultureIgnoreCase))
                {
                    // for vs2017 projects, skip csproject generation
                }
                else
                {
                    string projectGuid;
                    if (File.Exists(Path.Combine(coreFilesRoot, projectFilename)))
                    {
                        Console.WriteLine("...updating existing project file {0}", projectFilename);
                        var projectPath = Path.Combine(coreFilesRoot, projectFilename);
                        projectGuid = Utils.GetProjectGuid(projectPath);
                    }
                    else
                    {
                        newProject = true;
                        projectGuid = Utils.NewProjectGuid;
                        Console.WriteLine("...creating project file {0}", projectFilename);
                    }
                    var projectProperties = new Project();

                    projectProperties.Name = projectFileConfiguration.Name;
                    projectProperties.ProjectGuid = projectGuid;
                    projectProperties.RootNamespace = "Amazon";
                    projectProperties.AssemblyName = assemblyName;
                    projectProperties.SourceDirectories = GetCoreProjectSourceFolders(projectFileConfiguration, coreFilesRoot);
                    projectProperties.IndividualFileIncludes = new List<string>
                    {
                        "endpoints.json",
                    };
                    projectProperties.KeyFilePath = @"..\..\awssdk.dll.snk";
                    projectProperties.SupressWarnings = "419,1570,1591";
                    projectProperties.NugetPackagesLocation = @"..\..\packages\";
                    projectProperties.FxcopAnalyzerRuleSetFilePath = @"..\..\AWSDotNetSDK.ruleset";
                    projectProperties.FxcopAnalyzerRuleSetFilePathForBuild = @"..\..\AWSDotNetSDKForBuild.ruleset";
                    projectProperties.TargetFrameworks = projectFileConfiguration.TargetFrameworkVersions;
                    projectProperties.DefineConstants = projectFileConfiguration.CompilationConstants;
                    projectProperties.BinSubfolder = projectFileConfiguration.BinSubFolder;
                    projectProperties.PackageReferences = projectFileConfiguration.PackageReferences;
                    projectProperties.CustomRoslynAnalyzersDllDirectory = @"..\..\..\buildtools\CustomRoslynAnalyzers.dll";

                    var projectConfigurationData = new ProjectConfigurationData { ProjectGuid = projectGuid };
                    var projectName = Path.GetFileNameWithoutExtension(projectFilename);

                    if (newProject)
                        CreatedProjectFiles[projectName] = projectConfigurationData;

                    var projectReferences = new List<ProjectReference>();
                    projectProperties.ProjectReferences = projectReferences.OrderBy(x => x.Name).ToList();

                    GenerateProjectFile(projectFileConfiguration, projectConfigurationData, projectProperties, coreFilesRoot, projectFilename);
                }
            }
        }

        /// <summary>
        /// Creates the platform-specific project files for the given service configuration
        /// </summary>
        /// <param name="serviceFilesRoot">The folder under which all of the source files for the service will exist</param>
        /// <param name="serviceConfiguration"></param>
        /// <param name="projectFileConfigurations"></param>
        public void Execute(string serviceFilesRoot, ServiceConfiguration serviceConfiguration, IEnumerable<ProjectFileConfiguration> projectFileConfigurations)
        {
            CreatedProjectFiles = new Dictionary<string, ProjectConfigurationData>();
            var assemblyName = "AWSSDK." + serviceConfiguration.Namespace.Split('.')[1];

            foreach (var projectFileConfiguration in projectFileConfigurations)
            {
                var projectType = projectFileConfiguration.Name;

                if (projectType.Equals("NetStandard", StringComparison.InvariantCultureIgnoreCase) && !serviceConfiguration.NetStandardSupport)
                    continue;

                if (projectFileConfiguration.Template.Equals("VS2017ProjectFile", StringComparison.InvariantCultureIgnoreCase))
                {
                    var projectReferenceList = new List<ProjectReference>();
                    foreach (var dependency in serviceConfiguration.ServiceDependencies.Keys)
                    {
                        if (string.Equals(dependency, "Core", StringComparison.InvariantCultureIgnoreCase))
                            continue;

                        projectReferenceList.Add(new ProjectReference
                        {
                            IncludePath = string.Format(@"..\..\Services\{0}\AWSSDK.{1}.{2}.csproj", dependency, dependency, projectType)
                        });
                    }

                    projectReferenceList.Add(new ProjectReference
                    {
                        IncludePath = string.Format(@"..\..\Core\AWSSDK.Core.{0}.csproj", projectType)
                    });

                    projectFileConfiguration.ProjectReferences = projectReferenceList;
                    GenerateVS2017ProjectFile(serviceFilesRoot, serviceConfiguration, projectFileConfiguration);
                    continue;
                }   

                var projectFilename = string.Concat(assemblyName, ".", projectType, ".csproj");
                bool newProject = false;
                string projectGuid;
                if (File.Exists(Path.Combine(serviceFilesRoot, projectFilename)))
                {
                    Console.WriteLine("...updating existing project file {0}", projectFilename);
                    var projectPath = Path.Combine(serviceFilesRoot, projectFilename);
                    projectGuid = Utils.GetProjectGuid(projectPath);
                }
                else
                {
                    newProject = true;
                    projectGuid = Utils.NewProjectGuid;
                    Console.WriteLine("...creating project file {0}", projectFilename);
                }


                var projectProperties = new Project();

                projectProperties.Name = projectFileConfiguration.Name;
                projectProperties.ProjectGuid = projectGuid;
                projectProperties.RootNamespace = serviceConfiguration.Namespace;
                projectProperties.AssemblyName = assemblyName;
                projectProperties.SourceDirectories = GetProjectSourceFolders(projectFileConfiguration, serviceFilesRoot);
                projectProperties.NugetPackagesLocation = @"..\..\..\packages\";
                projectProperties.FxcopAnalyzerRuleSetFilePath = @"..\..\..\AWSDotNetSDK.ruleset";
                projectProperties.FxcopAnalyzerRuleSetFilePathForBuild = @"..\..\..\AWSDotNetSDKForBuild.ruleset";
                projectProperties.TargetFrameworks = projectFileConfiguration.TargetFrameworkVersions;
                projectProperties.DefineConstants = projectFileConfiguration.CompilationConstants;
                projectProperties.BinSubfolder = projectFileConfiguration.BinSubFolder;
                projectProperties.PackageReferences = projectFileConfiguration.PackageReferences;
                projectProperties.CustomRoslynAnalyzersDllDirectory = @"..\..\..\..\buildtools\CustomRoslynAnalyzers.dll";

                var projectConfigurationData = new ProjectConfigurationData { ProjectGuid = projectGuid };
                var projectName = Path.GetFileNameWithoutExtension(projectFilename);

                if (newProject)
                    CreatedProjectFiles[projectName] = projectConfigurationData;

                var projectReferences = new List<ProjectReference>();


                if (serviceConfiguration.ServiceDependencies != null)
                {
                    foreach (var dependency in serviceConfiguration.ServiceDependencies)
                    {
                        var dependencyProjectName = "AWSSDK." + dependency.Key + "." + projectType;
                        string dependencyProject;
                        if (string.Equals(dependency.Key, "Core", StringComparison.InvariantCultureIgnoreCase))
                        {
                            dependencyProject = string.Concat(@"..\..\", dependency.Key, "\\", dependencyProjectName, ".csproj");
                        }
                        else
                        {
                            dependencyProject = string.Concat(@"..\", dependency.Key, "\\", dependencyProjectName, ".csproj");
                        }

                        projectReferences.Add(new ProjectReference
                        {
                            IncludePath = dependencyProject,
                            ProjectGuid = Utils.GetProjectGuid(Path.Combine(serviceFilesRoot, dependencyProject)),
                            Name = dependencyProjectName
                        });
                    }
                }


                projectProperties.ProjectReferences = projectReferences.OrderBy(x => x.Name).ToList();

                if (serviceConfiguration.ReferenceDependencies != null &&
                    serviceConfiguration.ReferenceDependencies.ContainsKey(projectFileConfiguration.Name))
                {
                    projectProperties.ReferenceDependencies = serviceConfiguration.ReferenceDependencies[projectFileConfiguration.Name];
                }

                GenerateProjectFile(projectFileConfiguration, projectConfigurationData, projectProperties, serviceFilesRoot, projectFilename);
            }
        }

        /// <summary>
        /// Invokes the T4 generator to emit a platform-specific project file.
        /// </summary>
        /// <param name="projectFileConfiguration"></param>
        /// <param name="session"></param>
        /// <param name="serviceFilesRoot"></param>
        /// <param name="projectFilename"></param>
        private void GenerateProjectFile(ProjectFileConfiguration projectFileConfiguration,
                                         ProjectConfigurationData projectConfiguration,
                                         Project projectProperties,
                                         string serviceFilesRoot,
                                         string projectFilename)
        {
            var projectName = Path.GetFileNameWithoutExtension(projectFilename);
            string generatedContent = null;
            try
            {
                var projectTemplateType = Type.GetType(
                    "ServiceClientGenerator.Generators.ProjectFiles." +
                    projectFileConfiguration.Template);
                dynamic generator = Activator.CreateInstance(projectTemplateType);
                generator.Project = projectProperties;
                generatedContent = generator.TransformText();
            }
            catch (Exception)
            {
                throw new ArgumentException("Project template name "
                    + projectFileConfiguration.Template + " is not recognized");
            }

            GeneratorDriver.WriteFile(serviceFilesRoot, string.Empty, projectFilename, generatedContent);
            projectConfiguration.ConfigurationPlatforms = projectFileConfiguration.Configurations;
        }
        private void GenerateVS2017ProjectFile(string serviceFilesRoot, ServiceConfiguration serviceConfiguration, ProjectFileConfiguration projectFileConfiguration)
        {
            var assemblyName = "AWSSDK." + serviceConfiguration.Namespace.Split('.')[1];
            var projectType = projectFileConfiguration.Name;

            var projectProperties = new Project();

            projectProperties.AssemblyName          = assemblyName;
            projectProperties.ProjectReferences     = projectFileConfiguration.ProjectReferences;
            projectProperties.TargetFrameworks      = projectFileConfiguration.TargetFrameworkVersions;
            projectProperties.DefineConstants       = projectFileConfiguration.CompilationConstants;
            projectProperties.CompileRemoveList     = projectFileConfiguration.PlatformExcludeFolders;
            projectProperties.FrameworkPathOverride = projectFileConfiguration.FrameworkPathOverride;
            projectProperties.ReferenceDependencies = projectFileConfiguration.DllReferences;
            projectProperties.SupressWarnings       = projectFileConfiguration.NoWarn;
            projectProperties.SignBinaries          = true;
            projectProperties.PackageReferences = projectFileConfiguration.PackageReferences;
            projectProperties.FxcopAnalyzerRuleSetFilePath = @"..\..\..\AWSDotNetSDK.ruleset";
            projectProperties.FxcopAnalyzerRuleSetFilePathForBuild = @"..\..\..\AWSDotNetSDKForBuild.ruleset";
            projectProperties.CustomRoslynAnalyzersDllDirectory = @"..\..\..\..\buildtools\CustomRoslynAnalyzers.dll";

            List<Dependency> dependencies;
            List<PackageReference> references = new List<PackageReference>();
            if (    serviceConfiguration.NugetDependencies != null &&
                    serviceConfiguration.NugetDependencies.TryGetValue(projectFileConfiguration.Name, out dependencies))
            {
                foreach(var dependency in dependencies)
                {
                    references.Add(new PackageReference
                    {
                        Include = dependency.Name,
                        Version = dependency.Version,
                    });
                }

                projectProperties.PackageReferences = references;
            }

            var projectJsonTemplate = new VS2017ProjectFile();
            projectJsonTemplate.Project = projectProperties;

            var content = projectJsonTemplate.TransformText();

            GeneratorDriver.WriteFile(serviceFilesRoot, string.Empty, string.Format("{0}.{1}.csproj", assemblyName, projectType), content);
        }

        /// <summary>
        /// Returns the collection of subfolders containing source code that need to be 
        /// included in the project file. This is comprised the standard platform folders
        /// under Generated, plus any custom folders we find that are not otherwise handled
        /// (eg Properties).
        /// </summary>
        /// <param name="projectFileConfiguration">
        /// The .Net project type we are generating. This governs the platform-specific
        /// subfolders that get included in the project.
        /// </param>
        /// <param name="serviceRootFolder">The root output folder for the service code</param>
        /// <returns></returns>
        private IList<string> GetCoreProjectSourceFolders(ProjectFileConfiguration projectFileConfiguration, string coreRootFolder)
        {
            var exclusionList = new List<string>
            {
                "Properties",
                "bin",
                "obj",
                ".vs"
            };

            // Start with the standard folders for core
            var sourceCodeFolders = new List<string>
            {
                "."
            };

            var childDirectories = Directory.GetDirectories(coreRootFolder, "*", SearchOption.AllDirectories);
            foreach (var childDirectory in childDirectories)
            {
                var folder = childDirectory.Substring(coreRootFolder.Length).TrimStart('\\');

                if (exclusionList.Any(e => folder.Equals(e, StringComparison.InvariantCulture) ||
                    folder.StartsWith(e + "\\", StringComparison.InvariantCulture)))
                    continue;

                if (projectFileConfiguration.IsPlatformCodeFolder(folder))
                {
                    if (projectFileConfiguration.IsValidPlatformPathForProject(folder))
                        sourceCodeFolders.Add(folder);
                }
                else
                {
                    sourceCodeFolders.Add(folder);
                }


            }



            //var platformSubFolders = projectFileConfiguration.PlatformCodeFolders;
            //sourceCodeFolders.AddRange(platformSubFolders.Select(folder => Path.Combine(@"Generated", folder)));

            //// Augment the returned folders with any custom subfolders already in existence. If the custom folder 
            //// ends with a recognised platform, only add it to the set if it matches the platform being generated
            ////if (Directory.Exists(serviceRootFolder))
            //{
            //    var subFolders = Directory.GetDirectories(coreRootFolder, "*", SearchOption.AllDirectories);
            //    subFolders = subFolders.Except(exclusionList).ToArray();
            //    if (subFolders.Any())
            //    {
            //        foreach (var folder in subFolders)
            //        {
            //            var serviceRelativeFolder = folder.Substring(coreRootFolder.Length);

            //            if (!serviceRelativeFolder.StartsWith(@"\Custom", StringComparison.OrdinalIgnoreCase))
            //                continue;

            //            if (projectFileConfiguration.IsPlatformCodeFolder(serviceRelativeFolder))
            //            {
            //                if (projectFileConfiguration.IsValidPlatformCodeFolderForProject(serviceRelativeFolder))
            //                    sourceCodeFolders.Add(serviceRelativeFolder.TrimStart('\\'));
            //            }
            //            else
            //                sourceCodeFolders.Add(serviceRelativeFolder.TrimStart('\\'));
            //        }
            //    }
            //}

            var foldersThatExist = new List<string>();
            foreach (var folder in sourceCodeFolders)
            {
                if (Directory.Exists(Path.Combine(coreRootFolder, folder)))
                    foldersThatExist.Add(folder);
            }

            // sort so we get a predictable layout
            foldersThatExist.Sort(StringComparer.OrdinalIgnoreCase);
            return foldersThatExist;
        }

        /// <summary>
        /// Returns the collection of subfolders containing source code that need to be 
        /// included in the project file. This is comprised the standard platform folders
        /// under Generated, plus any custom folders we find that are not otherwise handled
        /// (eg Properties).
        /// </summary>
        /// <param name="projectFileConfiguration">
        /// The .Net project type we are generating. This governs the platform-specific
        /// subfolders that get included in the project.
        /// </param>
        /// <param name="serviceRootFolder">The root output folder for the service code</param>
        /// <returns></returns>
        private IList<string> GetProjectSourceFolders(ProjectFileConfiguration projectFileConfiguration, string serviceRootFolder)
        {
            // Start with the standard generated code folders for the platform
            var sourceCodeFolders = new List<string>
            {
                "Generated",
                @"Generated\Internal",
                @"Generated\Model", 
                @"Generated\Model\Internal", 
                @"Generated\Model\Internal\MarshallTransformations"
            };

            var platformSubFolders = projectFileConfiguration.PlatformCodeFolders;
            sourceCodeFolders.AddRange(platformSubFolders.Select(folder => Path.Combine(@"Generated", folder)));

            // Augment the returned folders with any custom subfolders already in existence. If the custom folder 
            // ends with a recognised platform, only add it to the set if it matches the platform being generated
            if (Directory.Exists(serviceRootFolder))
            {
                var subFolders = Directory.GetDirectories(serviceRootFolder, "*", SearchOption.AllDirectories);
                if (subFolders.Any())
                {
                    foreach (var folder in subFolders)
                    {
                        var serviceRelativeFolder = folder.Substring(serviceRootFolder.Length);

                        if (!serviceRelativeFolder.StartsWith(@"\Custom", StringComparison.OrdinalIgnoreCase))
                            continue;

                        if (projectFileConfiguration.IsPlatformCodeFolder(serviceRelativeFolder))
                        {
                            if (projectFileConfiguration.IsValidPlatformPathForProject(serviceRelativeFolder))
                                sourceCodeFolders.Add(serviceRelativeFolder.TrimStart('\\'));
                        }
                        else
                            sourceCodeFolders.Add(serviceRelativeFolder.TrimStart('\\'));
                    }
                }
            }

            var foldersThatExist = new List<string>();
            foreach (var folder in sourceCodeFolders)
            {
                if (Directory.Exists(Path.Combine(serviceRootFolder, folder)))
                    foldersThatExist.Add(folder);
            }

            // sort so we get a predictable layout
            foldersThatExist.Sort(StringComparer.OrdinalIgnoreCase);
            return foldersThatExist;
        }

        public class ProjectReference : IComparable<ProjectReference>
        {
            public string IncludePath { get; set; }
            public string ProjectGuid { get; set; }
            public string Name { get; set; }

            int IComparable<ProjectReference>.CompareTo(ProjectReference that)
            {
                return string.Compare(this.Name, that.Name);
            }
        }

        public class ProjectConfigurationData
        {
            public string ProjectGuid { get; set; }
            public IEnumerable<string> ConfigurationPlatforms { get; set; }
        }

        public class PackageReference
        {
            public string Include { get; set; }
            public string Version { get; set; }
            public string PrivateAssets { get; set; } = "none";
            public string IncludeAssets { get; set; }
            public bool IsAnalyzer { get; set; }
            public bool HasPrivateAssets => PrivateAssets != "" && PrivateAssets != "none";
            public static PackageReference ParseJson(Json.LitJson.JsonData data)
            {
                return new PackageReference
                {
                    Include = data.SafeGetString("include"),
                    Version = data.SafeGetString("version"),
                    PrivateAssets = data.SafeGetString("privateAssets"),
                    IncludeAssets = data.SafeGetString("includeAssets"),
                    IsAnalyzer = data.SafeGet("analyzer") != null ? (bool) data.SafeGet("analyzer") : false
                };
            }
        }
    }
}
