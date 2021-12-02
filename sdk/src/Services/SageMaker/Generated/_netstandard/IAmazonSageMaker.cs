/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMaker.Model;

namespace Amazon.SageMaker
{
    /// <summary>
    /// Interface for accessing SageMaker
    ///
    /// Provides APIs for creating and managing Amazon SageMaker resources. 
    /// 
    ///  
    /// <para>
    /// Other Resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/whatis.html#first-time-user">Amazon
    /// SageMaker Developer Guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/augmented-ai/2019-11-07/APIReference/Welcome.html">Amazon
    /// Augmented AI Runtime API Reference</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonSageMaker : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISageMakerPaginatorFactory Paginators { get; }
#endif
                
        #region  AddAssociation



        /// <summary>
        /// Creates an <i>association</i> between the source and the destination. A source can
        /// be associated with multiple destinations, and a destination can be associated with
        /// multiple sources. An association is a lineage tracking entity. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
        /// SageMaker ML Lineage Tracking</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddAssociation service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddAssociation">REST API Reference for AddAssociation Operation</seealso>
        Task<AddAssociationResponse> AddAssociationAsync(AddAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddTags



        /// <summary>
        /// Adds or overwrites one or more tags for the specified Amazon SageMaker resource. You
        /// can add tags to notebook instances, training jobs, hyperparameter tuning jobs, batch
        /// transform jobs, models, labeling jobs, work teams, endpoint configurations, and endpoints.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
        /// For more information about tags, see For more information, see <a href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">Amazon
        /// Web Services Tagging Strategies</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Tags that you add to a hyperparameter tuning job by calling this API are also added
        /// to any training jobs that the hyperparameter tuning job launches after you call this
        /// API, but not to training jobs that the hyperparameter tuning job launched before you
        /// called this API. To make sure that the tags associated with a hyperparameter tuning
        /// job are also added to all training jobs that the hyperparameter tuning job launches,
        /// add the tags when you first create the tuning job by specifying them in the <code>Tags</code>
        /// parameter of <a>CreateHyperParameterTuningJob</a> 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Tags that you add to a SageMaker Studio Domain or User Profile by calling this API
        /// are also added to any Apps that the Domain or User Profile launches after you call
        /// this API, but not to Apps that the Domain or User Profile launched before you called
        /// this API. To make sure that the tags associated with a Domain or User Profile are
        /// also added to all Apps that the Domain or User Profile launches, add the tags when
        /// you first create the Domain or User Profile by specifying them in the <code>Tags</code>
        /// parameter of <a>CreateDomain</a> or <a>CreateUserProfile</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateTrialComponent



        /// <summary>
        /// Associates a trial component with a trial. A trial component can be associated with
        /// multiple trials. To disassociate a trial component from a trial, call the <a>DisassociateTrialComponent</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AssociateTrialComponent">REST API Reference for AssociateTrialComponent Operation</seealso>
        Task<AssociateTrialComponentResponse> AssociateTrialComponentAsync(AssociateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDescribeModelPackage



        /// <summary>
        /// This action batch describes a list of versioned model packages
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeModelPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDescribeModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/BatchDescribeModelPackage">REST API Reference for BatchDescribeModelPackage Operation</seealso>
        Task<BatchDescribeModelPackageResponse> BatchDescribeModelPackageAsync(BatchDescribeModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAction



        /// <summary>
        /// Creates an <i>action</i>. An action is a lineage tracking entity that represents an
        /// action or activity. For example, a model deployment or an HPO job. Generally, an action
        /// involves at least one input or output artifact. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
        /// SageMaker ML Lineage Tracking</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAction">REST API Reference for CreateAction Operation</seealso>
        Task<CreateActionResponse> CreateActionAsync(CreateActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAlgorithm



        /// <summary>
        /// Create a machine learning algorithm that you can use in Amazon SageMaker and list
        /// in the Amazon Web Services Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlgorithm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        Task<CreateAlgorithmResponse> CreateAlgorithmAsync(CreateAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApp



        /// <summary>
        /// Creates a running app for the specified UserProfile. Supported apps are <code>JupyterServer</code>
        /// and <code>KernelGateway</code>. This operation is automatically invoked by Amazon
        /// SageMaker Studio upon access to the associated Domain, and when new kernel configurations
        /// are selected by the user. A user may have multiple Apps active simultaneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAppImageConfig



        /// <summary>
        /// Creates a configuration for running a SageMaker image as a KernelGateway app. The
        /// configuration specifies the Amazon Elastic File System (EFS) storage volume on the
        /// image, and a list of the kernels in the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppImageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAppImageConfig">REST API Reference for CreateAppImageConfig Operation</seealso>
        Task<CreateAppImageConfigResponse> CreateAppImageConfigAsync(CreateAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateArtifact



        /// <summary>
        /// Creates an <i>artifact</i>. An artifact is a lineage tracking entity that represents
        /// a URI addressable object or data. Some examples are the S3 URI of a dataset and the
        /// ECR registry path of an image. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
        /// SageMaker ML Lineage Tracking</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateArtifact">REST API Reference for CreateArtifact Operation</seealso>
        Task<CreateArtifactResponse> CreateArtifactAsync(CreateArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAutoMLJob



        /// <summary>
        /// Creates an Autopilot job.
        /// 
        ///  
        /// <para>
        /// Find the best-performing model after you run an Autopilot job by calling .
        /// </para>
        ///  
        /// <para>
        /// For information about how to use Autopilot, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development.html">Automate
        /// Model Development with Amazon SageMaker Autopilot</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoMLJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAutoMLJob">REST API Reference for CreateAutoMLJob Operation</seealso>
        Task<CreateAutoMLJobResponse> CreateAutoMLJobAsync(CreateAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCodeRepository



        /// <summary>
        /// Creates a Git repository as a resource in your Amazon SageMaker account. You can associate
        /// the repository with notebook instances so that you can use Git source control for
        /// the notebooks you create. The Git repository is a resource in your Amazon SageMaker
        /// account, so it can be associated with more than one notebook instance, and it persists
        /// independently from the lifecycle of any notebook instances it is associated with.
        /// 
        ///  
        /// <para>
        /// The repository can be hosted either in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">Amazon
        /// Web Services CodeCommit</a> or in any other Git repository.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        Task<CreateCodeRepositoryResponse> CreateCodeRepositoryAsync(CreateCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCompilationJob



        /// <summary>
        /// Starts a model compilation job. After the model has been compiled, Amazon SageMaker
        /// saves the resulting model artifacts to an Amazon Simple Storage Service (Amazon S3)
        /// bucket that you specify. 
        /// 
        ///  
        /// <para>
        /// If you choose to host your model using Amazon SageMaker hosting services, you can
        /// use the resulting model artifacts as part of the model. You can also use the artifacts
        /// with Amazon Web Services IoT Greengrass. In that case, deploy them as an ML resource.
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A name for the compilation job
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Information about the input model artifacts 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The output location for the compiled model and the device (target) that the model
        /// runs on 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker assumes to perform
        /// the model compilation job. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also provide a <code>Tag</code> to track the model compilation job's resource
        /// use and costs. The response body contains the <code>CompilationJobArn</code> for the
        /// compiled job.
        /// </para>
        ///  
        /// <para>
        /// To stop a model compilation job, use <a>StopCompilationJob</a>. To get information
        /// about a particular model compilation job, use <a>DescribeCompilationJob</a>. To get
        /// information about multiple model compilation jobs, use <a>ListCompilationJobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCompilationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCompilationJob">REST API Reference for CreateCompilationJob Operation</seealso>
        Task<CreateCompilationJobResponse> CreateCompilationJobAsync(CreateCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateContext



        /// <summary>
        /// Creates a <i>context</i>. A context is a lineage tracking entity that represents a
        /// logical grouping of other tracking or experiment entities. Some examples are an endpoint
        /// and a model package. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
        /// SageMaker ML Lineage Tracking</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateContext">REST API Reference for CreateContext Operation</seealso>
        Task<CreateContextResponse> CreateContextAsync(CreateContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataQualityJobDefinition



        /// <summary>
        /// Creates a definition for a job that monitors data quality and drift. For information
        /// about model monitor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon
        /// SageMaker Model Monitor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDataQualityJobDefinition">REST API Reference for CreateDataQualityJobDefinition Operation</seealso>
        Task<CreateDataQualityJobDefinitionResponse> CreateDataQualityJobDefinitionAsync(CreateDataQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDeviceFleet



        /// <summary>
        /// Creates a device fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeviceFleet service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDeviceFleet">REST API Reference for CreateDeviceFleet Operation</seealso>
        Task<CreateDeviceFleetResponse> CreateDeviceFleetAsync(CreateDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDomain



        /// <summary>
        /// Creates a <code>Domain</code> used by Amazon SageMaker Studio. A domain consists of
        /// an associated Amazon Elastic File System (EFS) volume, a list of authorized users,
        /// and a variety of security, application, policy, and Amazon Virtual Private Cloud (VPC)
        /// configurations. An Amazon Web Services account is limited to one domain per region.
        /// Users within a domain can share notebook files and other artifacts with each other.
        /// 
        ///  
        /// <para>
        ///  <b>EFS storage</b> 
        /// </para>
        ///  
        /// <para>
        /// When a domain is created, an EFS volume is created for use by all of the users within
        /// the domain. Each user receives a private home directory within the EFS volume for
        /// notebooks, Git repositories, and data files.
        /// </para>
        ///  
        /// <para>
        /// SageMaker uses the Amazon Web Services Key Management Service (Amazon Web Services
        /// KMS) to encrypt the EFS volume attached to the domain with an Amazon Web Services
        /// managed key by default. For more control, you can specify a customer managed key.
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/encryption-at-rest.html">Protect
        /// Data at Rest Using Encryption</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>VPC configuration</b> 
        /// </para>
        ///  
        /// <para>
        /// All SageMaker Studio traffic between the domain and the EFS volume is through the
        /// specified VPC and subnets. For other Studio traffic, you can specify the <code>AppNetworkAccessType</code>
        /// parameter. <code>AppNetworkAccessType</code> corresponds to the network access type
        /// that you choose when you onboard to Studio. The following options are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PublicInternetOnly</code> - Non-EFS traffic goes through a VPC managed by Amazon
        /// SageMaker, which allows internet access. This is the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VpcOnly</code> - All Studio traffic is through the specified VPC and subnets.
        /// Internet access is disabled by default. To allow internet access, you must specify
        /// a NAT gateway.
        /// </para>
        ///  
        /// <para>
        /// When internet access is disabled, you won't be able to run a Studio notebook or to
        /// train or host models unless your VPC has an interface endpoint to the SageMaker API
        /// and runtime or a NAT gateway and your security groups allow outbound connections.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// NFS traffic over TCP on port 2049 needs to be allowed in both inbound and outbound
        /// rules in order to launch a SageMaker Studio app successfully.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-notebooks-and-internet-access.html">Connect
        /// SageMaker Studio Notebooks to Resources in a VPC</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEdgePackagingJob



        /// <summary>
        /// Starts a SageMaker Edge Manager model packaging job. Edge Manager will use the model
        /// artifacts from the Amazon Simple Storage Service bucket that you specify. After the
        /// model has been packaged, Amazon SageMaker saves the resulting artifacts to an S3 bucket
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEdgePackagingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEdgePackagingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgePackagingJob">REST API Reference for CreateEdgePackagingJob Operation</seealso>
        Task<CreateEdgePackagingJobResponse> CreateEdgePackagingJobAsync(CreateEdgePackagingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEndpoint



        /// <summary>
        /// Creates an endpoint using the endpoint configuration specified in the request. Amazon
        /// SageMaker uses the endpoint to provision resources and deploy models. You create the
        /// endpoint configuration with the <a>CreateEndpointConfig</a> API. 
        /// 
        ///  
        /// <para>
        ///  Use this API to deploy models using Amazon SageMaker hosting services. 
        /// </para>
        ///  
        /// <para>
        /// For an example that calls this method when deploying a model to Amazon SageMaker hosting
        /// services, see the <a href="https://github.com/aws/amazon-sagemaker-examples/blob/master/sagemaker-fundamentals/create-endpoint/create_endpoint.ipynb">Create
        /// Endpoint example notebook.</a> 
        /// </para>
        ///  <note> 
        /// <para>
        ///  You must not delete an <code>EndpointConfig</code> that is in use by an endpoint
        /// that is live or while the <code>UpdateEndpoint</code> or <code>CreateEndpoint</code>
        /// operations are being performed on the endpoint. To update an endpoint, you must create
        /// a new <code>EndpointConfig</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The endpoint name must be unique within an Amazon Web Services Region in your Amazon
        /// Web Services account. 
        /// </para>
        ///  
        /// <para>
        /// When it receives the request, Amazon SageMaker creates the endpoint, launches the
        /// resources (ML compute instances), and deploys the model(s) on them. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you call <a>CreateEndpoint</a>, a load call is made to DynamoDB to verify that
        /// your endpoint configuration exists. When you read data from a DynamoDB table supporting
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// <code>Eventually Consistent Reads</code> </a>, the response might not reflect the
        /// results of a recently completed write operation. The response might include some stale
        /// data. If the dependent entities are not yet in DynamoDB, this causes a validation
        /// error. If you repeat your read request after a short time, the response should return
        /// the latest data. So retry logic is recommended to handle these possible issues. We
        /// also recommend that customers call <a>DescribeEndpointConfig</a> before calling <a>CreateEndpoint</a>
        /// to minimize the potential impact of a DynamoDB eventually consistent read.
        /// </para>
        ///  </note> 
        /// <para>
        /// When Amazon SageMaker receives the request, it sets the endpoint status to <code>Creating</code>.
        /// After it creates the endpoint, it sets the status to <code>InService</code>. Amazon
        /// SageMaker can then process incoming requests for inferences. To check the status of
        /// an endpoint, use the <a>DescribeEndpoint</a> API.
        /// </para>
        ///  
        /// <para>
        /// If any of the models hosted at this endpoint get model data from an Amazon S3 location,
        /// Amazon SageMaker uses Amazon Web Services Security Token Service to download model
        /// artifacts from the S3 path you provided. Amazon Web Services STS is activated in your
        /// IAM user account by default. If you previously deactivated Amazon Web Services STS
        /// for a region, you need to reactivate Amazon Web Services STS for that region. For
        /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating Amazon Web Services STS in an Amazon Web Services Region</a> in the
        /// <i>Amazon Web Services Identity and Access Management User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  To add the IAM role policies for using this API operation, go to the <a href="https://console.aws.amazon.com/iam/">IAM
        /// console</a>, and choose Roles in the left navigation pane. Search the IAM role that
        /// you want to grant access to use the <a>CreateEndpoint</a> and <a>CreateEndpointConfig</a>
        /// API operations, add the following policies to the role. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Option 1: For a full SageMaker access, search and attach the <code>AmazonSageMakerFullAccess</code>
        /// policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Option 2: For granting a limited access to an IAM role, paste the following Action
        /// elements manually into the JSON file of the IAM role: 
        /// </para>
        ///  
        /// <para>
        ///  <code>"Action": ["sagemaker:CreateEndpoint", "sagemaker:CreateEndpointConfig"]</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>"Resource": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:sagemaker:region:account-id:endpoint/endpointName"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:sagemaker:region:account-id:endpoint-config/endpointConfigName"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>]</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/api-permissions-reference.html">SageMaker
        /// API Permissions: Actions, Permissions, and Resources Reference</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEndpointConfig



        /// <summary>
        /// Creates an endpoint configuration that Amazon SageMaker hosting services uses to deploy
        /// models. In the configuration, you identify one or more models, created using the <code>CreateModel</code>
        /// API, to deploy and the resources that you want Amazon SageMaker to provision. Then
        /// you call the <a>CreateEndpoint</a> API.
        /// 
        ///  <note> 
        /// <para>
        ///  Use this API if you want to use Amazon SageMaker hosting services to deploy models
        /// into production. 
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you define a <code>ProductionVariant</code>, for each model that you
        /// want to deploy. Each <code>ProductionVariant</code> parameter also describes the resources
        /// that you want Amazon SageMaker to provision. This includes the number and type of
        /// ML compute instances to deploy. 
        /// </para>
        ///  
        /// <para>
        /// If you are hosting multiple models, you also assign a <code>VariantWeight</code> to
        /// specify how much traffic you want to allocate to each model. For example, suppose
        /// that you want to host two models, A and B, and you assign traffic weight 2 for model
        /// A and 1 for model B. Amazon SageMaker distributes two-thirds of the traffic to Model
        /// A, and one-third to model B. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you call <a>CreateEndpoint</a>, a load call is made to DynamoDB to verify that
        /// your endpoint configuration exists. When you read data from a DynamoDB table supporting
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// <code>Eventually Consistent Reads</code> </a>, the response might not reflect the
        /// results of a recently completed write operation. The response might include some stale
        /// data. If the dependent entities are not yet in DynamoDB, this causes a validation
        /// error. If you repeat your read request after a short time, the response should return
        /// the latest data. So retry logic is recommended to handle these possible issues. We
        /// also recommend that customers call <a>DescribeEndpointConfig</a> before calling <a>CreateEndpoint</a>
        /// to minimize the potential impact of a DynamoDB eventually consistent read.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpointConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        Task<CreateEndpointConfigResponse> CreateEndpointConfigAsync(CreateEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateExperiment



        /// <summary>
        /// Creates an SageMaker <i>experiment</i>. An experiment is a collection of <i>trials</i>
        /// that are observed, compared and evaluated as a group. A trial is a set of steps, called
        /// <i>trial components</i>, that produce a machine learning model.
        /// 
        ///  
        /// <para>
        /// The goal of an experiment is to determine the components that produce the best model.
        /// Multiple trials are performed, each one isolating and measuring the impact of a change
        /// to one or more inputs, while keeping the remaining inputs constant.
        /// </para>
        ///  
        /// <para>
        /// When you use SageMaker Studio or the SageMaker Python SDK, all experiments, trials,
        /// and trial components are automatically tracked, logged, and indexed. When you use
        /// the Amazon Web Services SDK for Python (Boto), you must use the logging APIs provided
        /// by the SDK.
        /// </para>
        ///  
        /// <para>
        /// You can add tags to experiments, trials, trial components and then use the <a>Search</a>
        /// API to search for the tags.
        /// </para>
        ///  
        /// <para>
        /// To add a description to an experiment, specify the optional <code>Description</code>
        /// parameter. To add a description later, or to change the description, call the <a>UpdateExperiment</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your experiments, call the <a>ListExperiments</a> API. To view
        /// an experiment's properties, call the <a>DescribeExperiment</a> API. To get a list
        /// of all the trials associated with an experiment, call the <a>ListTrials</a> API. To
        /// create a trial call the <a>CreateTrial</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFeatureGroup



        /// <summary>
        /// Create a new <code>FeatureGroup</code>. A <code>FeatureGroup</code> is a group of
        /// <code>Features</code> defined in the <code>FeatureStore</code> to describe a <code>Record</code>.
        /// 
        /// 
        ///  
        /// <para>
        /// The <code>FeatureGroup</code> defines the schema and features contained in the FeatureGroup.
        /// A <code>FeatureGroup</code> definition is composed of a list of <code>Features</code>,
        /// a <code>RecordIdentifierFeatureName</code>, an <code>EventTimeFeatureName</code> and
        /// configurations for its <code>OnlineStore</code> and <code>OfflineStore</code>. Check
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">Amazon
        /// Web Services service quotas</a> to see the <code>FeatureGroup</code>s quota for your
        /// Amazon Web Services account.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must include at least one of <code>OnlineStoreConfig</code> and <code>OfflineStoreConfig</code>
        /// to create a <code>FeatureGroup</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeatureGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateFeatureGroup">REST API Reference for CreateFeatureGroup Operation</seealso>
        Task<CreateFeatureGroupResponse> CreateFeatureGroupAsync(CreateFeatureGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFlowDefinition



        /// <summary>
        /// Creates a flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlowDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateFlowDefinition">REST API Reference for CreateFlowDefinition Operation</seealso>
        Task<CreateFlowDefinitionResponse> CreateFlowDefinitionAsync(CreateFlowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHumanTaskUi



        /// <summary>
        /// Defines the settings you will use for the human review workflow user interface. Reviewers
        /// will see a three-panel interface with an instruction area, the item to review, and
        /// an input area.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHumanTaskUi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHumanTaskUi service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHumanTaskUi">REST API Reference for CreateHumanTaskUi Operation</seealso>
        Task<CreateHumanTaskUiResponse> CreateHumanTaskUiAsync(CreateHumanTaskUiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHyperParameterTuningJob



        /// <summary>
        /// Starts a hyperparameter tuning job. A hyperparameter tuning job finds the best version
        /// of a model by running many training jobs on your dataset using the algorithm you choose
        /// and values for hyperparameters within ranges that you specify. It then chooses the
        /// hyperparameter values that result in a model that performs the best, as measured by
        /// an objective metric that you choose.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHyperParameterTuningJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        Task<CreateHyperParameterTuningJobResponse> CreateHyperParameterTuningJobAsync(CreateHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateImage



        /// <summary>
        /// Creates a custom SageMaker image. A SageMaker image is a set of image versions. Each
        /// image version represents a container image stored in Amazon Container Registry (ECR).
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-byoi.html">Bring
        /// your own SageMaker image</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateImage">REST API Reference for CreateImage Operation</seealso>
        Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateImageVersion



        /// <summary>
        /// Creates a version of the SageMaker image specified by <code>ImageName</code>. The
        /// version represents the Amazon Container Registry (ECR) container image specified by
        /// <code>BaseImage</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateImageVersion service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateImageVersion">REST API Reference for CreateImageVersion Operation</seealso>
        Task<CreateImageVersionResponse> CreateImageVersionAsync(CreateImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInferenceRecommendationsJob



        /// <summary>
        /// Starts a recommendation job. You can create either an instance recommendation or load
        /// test job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceRecommendationsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInferenceRecommendationsJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateInferenceRecommendationsJob">REST API Reference for CreateInferenceRecommendationsJob Operation</seealso>
        Task<CreateInferenceRecommendationsJobResponse> CreateInferenceRecommendationsJobAsync(CreateInferenceRecommendationsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLabelingJob



        /// <summary>
        /// Creates a job that uses workers to label the data objects in your input dataset. You
        /// can use the labeled data to train machine learning models. 
        /// 
        ///  
        /// <para>
        /// You can select your workforce from one of three providers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A private workforce that you create. It can include employees, contractors, and outside
        /// experts. Use a private workforce when want the data to stay within your organization
        /// or when a specific set of skills is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One or more vendors that you select from the Amazon Web Services Marketplace. Vendors
        /// provide expertise in specific areas. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon Mechanical Turk workforce. This is the largest workforce, but it should
        /// only be used for public data or data that has been stripped of any personally identifiable
        /// information.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also use <i>automated data labeling</i> to reduce the number of data objects
        /// that need to be labeled by a human. Automated data labeling uses <i>active learning</i>
        /// to determine if a data object can be labeled by machine or if it needs to be sent
        /// to a human worker. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-automated-labeling.html">Using
        /// Automated Data Labeling</a>.
        /// </para>
        ///  
        /// <para>
        /// The data objects to be labeled are contained in an Amazon S3 bucket. You create a
        /// <i>manifest file</i> that describes the location of each object. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-data.html">Using
        /// Input and Output Data</a>.
        /// </para>
        ///  
        /// <para>
        /// The output can be used as the manifest file for another labeling job or as training
        /// data for your machine learning models.
        /// </para>
        ///  
        /// <para>
        /// You can use this operation to create a static labeling job or a streaming labeling
        /// job. A static labeling job stops if all data objects in the input manifest file identified
        /// in <code>ManifestS3Uri</code> have been labeled. A streaming labeling job runs perpetually
        /// until it is manually stopped, or remains idle for 10 days. You can send new data objects
        /// to an active (<code>InProgress</code>) streaming labeling job in real time. To learn
        /// how to create a static labeling job, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-create-labeling-job-api.html">Create
        /// a Labeling Job (API) </a> in the Amazon SageMaker Developer Guide. To learn how to
        /// create a streaming labeling job, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-streaming-create-job.html">Create
        /// a Streaming Labeling Job</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateLabelingJob">REST API Reference for CreateLabelingJob Operation</seealso>
        Task<CreateLabelingJobResponse> CreateLabelingJobAsync(CreateLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModel



        /// <summary>
        /// Creates a model in Amazon SageMaker. In the request, you name the model and describe
        /// a primary container. For the primary container, you specify the Docker image that
        /// contains inference code, artifacts (from prior training), and a custom environment
        /// map that the inference code uses when you deploy the model for predictions.
        /// 
        ///  
        /// <para>
        /// Use this API to create a model if you want to use Amazon SageMaker hosting services
        /// or run a batch transform job.
        /// </para>
        ///  
        /// <para>
        /// To host your model, you create an endpoint configuration with the <code>CreateEndpointConfig</code>
        /// API, and then create an endpoint with the <code>CreateEndpoint</code> API. Amazon
        /// SageMaker then deploys all of the containers that you defined for the model in the
        /// hosting environment. 
        /// </para>
        ///  
        /// <para>
        /// For an example that calls this method when deploying a model to Amazon SageMaker hosting
        /// services, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/ex1-deploy-model.html#ex1-deploy-model-boto">Deploy
        /// the Model to Amazon SageMaker Hosting Services (Amazon Web Services SDK for Python
        /// (Boto 3)).</a> 
        /// </para>
        ///  
        /// <para>
        /// To run a batch transform using your model, you start a job with the <code>CreateTransformJob</code>
        /// API. Amazon SageMaker uses your model and your dataset to get inferences which are
        /// then saved to a specified S3 location.
        /// </para>
        ///  
        /// <para>
        /// In the <code>CreateModel</code> request, you must define a container with the <code>PrimaryContainer</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// In the request, you also provide an IAM role that Amazon SageMaker can assume to access
        /// model artifacts and docker image for deployment on ML compute hosting instances or
        /// for batch transform jobs. In addition, you also use the IAM role to manage permissions
        /// the inference code needs. For example, if the inference code access any other Amazon
        /// Web Services resources, you grant necessary permissions via this role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelBiasJobDefinition



        /// <summary>
        /// Creates the definition for a model bias job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelBiasJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelBiasJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelBiasJobDefinition">REST API Reference for CreateModelBiasJobDefinition Operation</seealso>
        Task<CreateModelBiasJobDefinitionResponse> CreateModelBiasJobDefinitionAsync(CreateModelBiasJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelExplainabilityJobDefinition



        /// <summary>
        /// Creates the definition for a model explainability job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelExplainabilityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelExplainabilityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelExplainabilityJobDefinition">REST API Reference for CreateModelExplainabilityJobDefinition Operation</seealso>
        Task<CreateModelExplainabilityJobDefinitionResponse> CreateModelExplainabilityJobDefinitionAsync(CreateModelExplainabilityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelPackage



        /// <summary>
        /// Creates a model package that you can use to create Amazon SageMaker models or list
        /// on Amazon Web Services Marketplace, or a versioned model that is part of a model group.
        /// Buyers can subscribe to model packages listed on Amazon Web Services Marketplace to
        /// create models in Amazon SageMaker.
        /// 
        ///  
        /// <para>
        /// To create a model package by specifying a Docker container that contains your inference
        /// code and the Amazon S3 location of your model artifacts, provide values for <code>InferenceSpecification</code>.
        /// To create a model from an algorithm resource that you created or subscribed to in
        /// Amazon Web Services Marketplace, provide a value for <code>SourceAlgorithmSpecification</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// There are two types of model packages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Versioned - a model that is part of a model group in the model registry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unversioned - a model package that is not part of a model group.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelPackage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        Task<CreateModelPackageResponse> CreateModelPackageAsync(CreateModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelPackageGroup



        /// <summary>
        /// Creates a model group. A model group contains a group of model versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelPackageGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackageGroup">REST API Reference for CreateModelPackageGroup Operation</seealso>
        Task<CreateModelPackageGroupResponse> CreateModelPackageGroupAsync(CreateModelPackageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelQualityJobDefinition



        /// <summary>
        /// Creates a definition for a job that monitors model quality and drift. For information
        /// about model monitor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon
        /// SageMaker Model Monitor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelQualityJobDefinition">REST API Reference for CreateModelQualityJobDefinition Operation</seealso>
        Task<CreateModelQualityJobDefinitionResponse> CreateModelQualityJobDefinitionAsync(CreateModelQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMonitoringSchedule



        /// <summary>
        /// Creates a schedule that regularly starts Amazon SageMaker Processing Jobs to monitor
        /// the data captured for an Amazon SageMaker Endoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateMonitoringSchedule">REST API Reference for CreateMonitoringSchedule Operation</seealso>
        Task<CreateMonitoringScheduleResponse> CreateMonitoringScheduleAsync(CreateMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNotebookInstance



        /// <summary>
        /// Creates an Amazon SageMaker notebook instance. A notebook instance is a machine learning
        /// (ML) compute instance running on a Jupyter notebook. 
        /// 
        ///  
        /// <para>
        /// In a <code>CreateNotebookInstance</code> request, specify the type of ML compute instance
        /// that you want to run. Amazon SageMaker launches the instance, installs common libraries
        /// that you can use to explore datasets for model training, and attaches an ML storage
        /// volume to the notebook instance. 
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker also provides a set of example notebooks. Each notebook demonstrates
        /// how to use Amazon SageMaker with a specific algorithm or with a machine learning framework.
        /// 
        /// </para>
        ///  
        /// <para>
        /// After receiving the request, Amazon SageMaker does the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Creates a network interface in the Amazon SageMaker VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Option) If you specified <code>SubnetId</code>, Amazon SageMaker creates a network
        /// interface in your own VPC, which is inferred from the subnet ID that you provide in
        /// the input. When creating this network interface, Amazon SageMaker attaches the security
        /// group that you specified in the request to the network interface that it creates in
        /// your VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Launches an EC2 instance of the type specified in the request in the Amazon SageMaker
        /// VPC. If you specified <code>SubnetId</code> of your VPC, Amazon SageMaker specifies
        /// both network interfaces when launching this instance. This enables inbound traffic
        /// from your own VPC to the notebook instance, assuming that the security groups allow
        /// it.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// After creating the notebook instance, Amazon SageMaker returns its Amazon Resource
        /// Name (ARN). You can't change the name of a notebook instance after you create it.
        /// </para>
        ///  
        /// <para>
        /// After Amazon SageMaker creates the notebook instance, you can connect to the Jupyter
        /// server and work in Jupyter notebooks. For example, you can write code to explore a
        /// dataset that you can use for model training, train a model, host models by creating
        /// Amazon SageMaker endpoints, and validate hosted models. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        Task<CreateNotebookInstanceResponse> CreateNotebookInstanceAsync(CreateNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNotebookInstanceLifecycleConfig



        /// <summary>
        /// Creates a lifecycle configuration that you can associate with a notebook instance.
        /// A <i>lifecycle configuration</i> is a collection of shell scripts that run when you
        /// create or start a notebook instance.
        /// 
        ///  
        /// <para>
        /// Each lifecycle configuration script has a limit of 16384 characters.
        /// </para>
        ///  
        /// <para>
        /// The value of the <code>$PATH</code> environment variable that is available to both
        /// scripts is <code>/sbin:bin:/usr/sbin:/usr/bin</code>.
        /// </para>
        ///  
        /// <para>
        /// View CloudWatch Logs for notebook instance lifecycle configurations in log group <code>/aws/sagemaker/NotebookInstances</code>
        /// in log stream <code>[notebook-instance-name]/[LifecycleConfigHook]</code>.
        /// </para>
        ///  
        /// <para>
        /// Lifecycle configuration scripts cannot run for longer than 5 minutes. If a script
        /// runs for longer than 5 minutes, it fails and the notebook instance is not created
        /// or started.
        /// </para>
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstanceLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        Task<CreateNotebookInstanceLifecycleConfigResponse> CreateNotebookInstanceLifecycleConfigAsync(CreateNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePipeline



        /// <summary>
        /// Creates a pipeline using a JSON pipeline definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePresignedDomainUrl



        /// <summary>
        /// Creates a URL for a specified UserProfile in a Domain. When accessed in a web browser,
        /// the user will be automatically signed in to Amazon SageMaker Studio, and granted access
        /// to all of the Apps and files associated with the Domain's Amazon Elastic File System
        /// (EFS) volume. This operation can only be called when the authentication mode equals
        /// IAM. 
        /// 
        ///  
        /// <para>
        /// The IAM role or user used to call this API defines the permissions to access the app.
        /// Once the presigned URL is created, no additional permission is required to access
        /// this URL. IAM authorization policies for this API are also enforced for every HTTP
        /// request and WebSocket frame that attempts to connect to the app.
        /// </para>
        ///  
        /// <para>
        /// You can restrict access to this API and to the URL that it returns to a list of IP
        /// addresses, Amazon VPCs or Amazon VPC Endpoints that you specify. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-interface-endpoint.html">Connect
        /// to SageMaker Studio Through an Interface VPC Endpoint</a> .
        /// </para>
        ///  <note> 
        /// <para>
        /// The URL that you get from a call to <code>CreatePresignedDomainUrl</code> has a default
        /// timeout of 5 minutes. You can configure this value using <code>ExpiresInSeconds</code>.
        /// If you try to use the URL after the timeout limit expires, you are directed to the
        /// Amazon Web Services console sign-in page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedDomainUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePresignedDomainUrl service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedDomainUrl">REST API Reference for CreatePresignedDomainUrl Operation</seealso>
        Task<CreatePresignedDomainUrlResponse> CreatePresignedDomainUrlAsync(CreatePresignedDomainUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePresignedNotebookInstanceUrl



        /// <summary>
        /// Returns a URL that you can use to connect to the Jupyter server from a notebook instance.
        /// In the Amazon SageMaker console, when you choose <code>Open</code> next to a notebook
        /// instance, Amazon SageMaker opens a new tab showing the Jupyter server home page from
        /// the notebook instance. The console uses this API to get the URL and show the page.
        /// 
        ///  
        /// <para>
        ///  The IAM role or user used to call this API defines the permissions to access the
        /// notebook instance. Once the presigned URL is created, no additional permission is
        /// required to access this URL. IAM authorization policies for this API are also enforced
        /// for every HTTP request and WebSocket frame that attempts to connect to the notebook
        /// instance.
        /// </para>
        ///  
        /// <para>
        /// You can restrict access to this API and to the URL that it returns to a list of IP
        /// addresses that you specify. Use the <code>NotIpAddress</code> condition operator and
        /// the <code>aws:SourceIP</code> condition context key to specify the list of IP addresses
        /// that you want to have access to the notebook instance. For more information, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/security_iam_id-based-policy-examples.html#nbi-ip-filter">Limit
        /// Access to a Notebook Instance by IP Address</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The URL that you get from a call to <a>CreatePresignedNotebookInstanceUrl</a> is valid
        /// only for 5 minutes. If you try to use the URL after the 5-minute limit expires, you
        /// are directed to the Amazon Web Services console sign-in page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookInstanceUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePresignedNotebookInstanceUrl service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        Task<CreatePresignedNotebookInstanceUrlResponse> CreatePresignedNotebookInstanceUrlAsync(CreatePresignedNotebookInstanceUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProcessingJob



        /// <summary>
        /// Creates a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProcessingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProcessingJob">REST API Reference for CreateProcessingJob Operation</seealso>
        Task<CreateProcessingJobResponse> CreateProcessingJobAsync(CreateProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProject



        /// <summary>
        /// Creates a machine learning (ML) project that can contain one or more templates that
        /// set up an ML pipeline from training to deploying an approved model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProject">REST API Reference for CreateProject Operation</seealso>
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStudioLifecycleConfig



        /// <summary>
        /// Creates a new Studio Lifecycle Configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStudioLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateStudioLifecycleConfig">REST API Reference for CreateStudioLifecycleConfig Operation</seealso>
        Task<CreateStudioLifecycleConfigResponse> CreateStudioLifecycleConfigAsync(CreateStudioLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrainingJob



        /// <summary>
        /// Starts a model training job. After training completes, Amazon SageMaker saves the
        /// resulting model artifacts to an Amazon S3 location that you specify. 
        /// 
        ///  
        /// <para>
        /// If you choose to host your model using Amazon SageMaker hosting services, you can
        /// use the resulting model artifacts as part of the model. You can also use the artifacts
        /// in a machine learning service other than Amazon SageMaker, provided that you know
        /// how to use them for inference. 
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AlgorithmSpecification</code> - Identifies the training algorithm to use. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HyperParameters</code> - Specify these algorithm-specific parameters to enable
        /// the estimation of model parameters during training. Hyperparameters can be tuned to
        /// optimize this learning process. For a list of hyperparameters for each training algorithm
        /// provided by Amazon SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InputDataConfig</code> - Describes the training dataset and the Amazon S3,
        /// EFS, or FSx location where it is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OutputDataConfig</code> - Identifies the Amazon S3 bucket where you want Amazon
        /// SageMaker to save the results of model training. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceConfig</code> - Identifies the resources, ML compute instances, and
        /// ML storage volumes to deploy for model training. In distributed training, you specify
        /// more than one instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EnableManagedSpotTraining</code> - Optimize the cost of training machine learning
        /// models by up to 80% by using Amazon EC2 Spot instances. For more information, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-managed-spot-training.html">Managed
        /// Spot Training</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RoleArn</code> - The Amazon Resource Name (ARN) that Amazon SageMaker assumes
        /// to perform tasks on your behalf during model training. You must grant this role the
        /// necessary permissions so that Amazon SageMaker can successfully complete model training.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StoppingCondition</code> - To help cap training costs, use <code>MaxRuntimeInSeconds</code>
        /// to set a time limit for training. Use <code>MaxWaitTimeInSeconds</code> to specify
        /// how long a managed spot training job has to complete. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Environment</code> - The environment variables to set in the Docker container.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RetryStrategy</code> - The number of times to retry the job when the job fails
        /// due to an <code>InternalServerError</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about Amazon SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        Task<CreateTrainingJobResponse> CreateTrainingJobAsync(CreateTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransformJob



        /// <summary>
        /// Starts a transform job. A transform job uses a trained model to get inferences on
        /// a dataset and saves these results to an Amazon S3 location that you specify.
        /// 
        ///  
        /// <para>
        /// To perform batch transformations, you create a transform job and use the data that
        /// you have readily available.
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TransformJobName</code> - Identifies the transform job. The name must be unique
        /// within an Amazon Web Services Region in an Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ModelName</code> - Identifies the model to use. <code>ModelName</code> must
        /// be the name of an existing Amazon SageMaker model in the same Amazon Web Services
        /// Region and Amazon Web Services account. For information on creating a model, see <a>CreateModel</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformInput</code> - Describes the dataset to be transformed and the Amazon
        /// S3 location where it is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformOutput</code> - Identifies the Amazon S3 location where you want Amazon
        /// SageMaker to save the results from the transform job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformResources</code> - Identifies the ML compute instances for the transform
        /// job.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how batch transformation works, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform.html">Batch
        /// Transform</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTransformJob">REST API Reference for CreateTransformJob Operation</seealso>
        Task<CreateTransformJobResponse> CreateTransformJobAsync(CreateTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrial



        /// <summary>
        /// Creates an SageMaker <i>trial</i>. A trial is a set of steps called <i>trial components</i>
        /// that produce a machine learning model. A trial is part of a single SageMaker <i>experiment</i>.
        /// 
        ///  
        /// <para>
        /// When you use SageMaker Studio or the SageMaker Python SDK, all experiments, trials,
        /// and trial components are automatically tracked, logged, and indexed. When you use
        /// the Amazon Web Services SDK for Python (Boto), you must use the logging APIs provided
        /// by the SDK.
        /// </para>
        ///  
        /// <para>
        /// You can add tags to a trial and then use the <a>Search</a> API to search for the tags.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your trials, call the <a>ListTrials</a> API. To view a trial's
        /// properties, call the <a>DescribeTrial</a> API. To create a trial component, call the
        /// <a>CreateTrialComponent</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrial">REST API Reference for CreateTrial Operation</seealso>
        Task<CreateTrialResponse> CreateTrialAsync(CreateTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrialComponent



        /// <summary>
        /// Creates a <i>trial component</i>, which is a stage of a machine learning <i>trial</i>.
        /// A trial is composed of one or more trial components. A trial component can be used
        /// in multiple trials.
        /// 
        ///  
        /// <para>
        /// Trial components include pre-processing jobs, training jobs, and batch transform jobs.
        /// </para>
        ///  
        /// <para>
        /// When you use SageMaker Studio or the SageMaker Python SDK, all experiments, trials,
        /// and trial components are automatically tracked, logged, and indexed. When you use
        /// the Amazon Web Services SDK for Python (Boto), you must use the logging APIs provided
        /// by the SDK.
        /// </para>
        ///  
        /// <para>
        /// You can add tags to a trial component and then use the <a>Search</a> API to search
        /// for the tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrialComponent">REST API Reference for CreateTrialComponent Operation</seealso>
        Task<CreateTrialComponentResponse> CreateTrialComponentAsync(CreateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserProfile



        /// <summary>
        /// Creates a user profile. A user profile represents a single user within a domain, and
        /// is the main way to reference a "person" for the purposes of sharing, reporting, and
        /// other user-oriented features. This entity is created when a user onboards to Amazon
        /// SageMaker Studio. If an administrator invites a person by email or imports them from
        /// SSO, a user profile is automatically created. A user profile is the primary holder
        /// of settings for an individual user and has a reference to the user's private Amazon
        /// Elastic File System (EFS) home directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkforce



        /// <summary>
        /// Use this operation to create a workforce. This operation will return an error if a
        /// workforce already exists in the Amazon Web Services Region that you specify. You can
        /// only create one workforce in each Amazon Web Services Region per Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// If you want to create a new workforce in an Amazon Web Services Region where a workforce
        /// already exists, use the API operation to delete the existing workforce and then use
        /// <code>CreateWorkforce</code> to create a new workforce.
        /// </para>
        ///  
        /// <para>
        /// To create a private workforce using Amazon Cognito, you must specify a Cognito user
        /// pool in <code>CognitoConfig</code>. You can also create an Amazon Cognito workforce
        /// using the Amazon SageMaker console. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-create-private.html">
        /// Create a Private Workforce (Amazon Cognito)</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a private workforce using your own OIDC Identity Provider (IdP), specify
        /// your IdP configuration in <code>OidcConfig</code>. Your OIDC IdP must support <i>groups</i>
        /// because groups are used by Ground Truth and Amazon A2I to create work teams. For more
        /// information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-create-private-oidc.html">
        /// Create a Private Workforce (OIDC IdP)</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkforce service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkforce">REST API Reference for CreateWorkforce Operation</seealso>
        Task<CreateWorkforceResponse> CreateWorkforceAsync(CreateWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkteam



        /// <summary>
        /// Creates a new work team for labeling your data. A work team is defined by one or more
        /// Amazon Cognito user pools. You must first create the user pools before you can create
        /// a work team.
        /// 
        ///  
        /// <para>
        /// You cannot create more than 25 work teams in an account and region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkteam">REST API Reference for CreateWorkteam Operation</seealso>
        Task<CreateWorkteamResponse> CreateWorkteamAsync(CreateWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAction



        /// <summary>
        /// Deletes an action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAction">REST API Reference for DeleteAction Operation</seealso>
        Task<DeleteActionResponse> DeleteActionAsync(DeleteActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAlgorithm



        /// <summary>
        /// Removes the specified algorithm from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlgorithm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        Task<DeleteAlgorithmResponse> DeleteAlgorithmAsync(DeleteAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApp



        /// <summary>
        /// Used to stop and delete an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppImageConfig



        /// <summary>
        /// Deletes an AppImageConfig.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppImageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAppImageConfig">REST API Reference for DeleteAppImageConfig Operation</seealso>
        Task<DeleteAppImageConfigResponse> DeleteAppImageConfigAsync(DeleteAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteArtifact



        /// <summary>
        /// Deletes an artifact. Either <code>ArtifactArn</code> or <code>Source</code> must be
        /// specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteArtifact">REST API Reference for DeleteArtifact Operation</seealso>
        Task<DeleteArtifactResponse> DeleteArtifactAsync(DeleteArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAssociation



        /// <summary>
        /// Deletes an association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        Task<DeleteAssociationResponse> DeleteAssociationAsync(DeleteAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCodeRepository



        /// <summary>
        /// Deletes the specified Git repository from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        Task<DeleteCodeRepositoryResponse> DeleteCodeRepositoryAsync(DeleteCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteContext



        /// <summary>
        /// Deletes an context.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteContext">REST API Reference for DeleteContext Operation</seealso>
        Task<DeleteContextResponse> DeleteContextAsync(DeleteContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataQualityJobDefinition



        /// <summary>
        /// Deletes a data quality monitoring job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDataQualityJobDefinition">REST API Reference for DeleteDataQualityJobDefinition Operation</seealso>
        Task<DeleteDataQualityJobDefinitionResponse> DeleteDataQualityJobDefinitionAsync(DeleteDataQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDeviceFleet



        /// <summary>
        /// Deletes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeviceFleet service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDeviceFleet">REST API Reference for DeleteDeviceFleet Operation</seealso>
        Task<DeleteDeviceFleetResponse> DeleteDeviceFleetAsync(DeleteDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDomain



        /// <summary>
        /// Used to delete a domain. If you onboarded with IAM mode, you will need to delete your
        /// domain to onboard again using SSO. Use with caution. All of the members of the domain
        /// will lose access to their EFS volume, including data, notebooks, and other artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEndpoint



        /// <summary>
        /// Deletes an endpoint. Amazon SageMaker frees up all of the resources that were deployed
        /// when the endpoint was created. 
        /// 
        ///  
        /// <para>
        /// Amazon SageMaker retires any custom KMS key grants associated with the endpoint, meaning
        /// you don't need to use the <a href="http://docs.aws.amazon.com/kms/latest/APIReference/API_RevokeGrant.html">RevokeGrant</a>
        /// API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEndpointConfig



        /// <summary>
        /// Deletes an endpoint configuration. The <code>DeleteEndpointConfig</code> API deletes
        /// only the specified configuration. It does not delete endpoints created using the configuration.
        /// 
        /// 
        ///  
        /// <para>
        /// You must not delete an <code>EndpointConfig</code> in use by an endpoint that is live
        /// or while the <code>UpdateEndpoint</code> or <code>CreateEndpoint</code> operations
        /// are being performed on the endpoint. If you delete the <code>EndpointConfig</code>
        /// of an endpoint that is active or being created or updated you may lose visibility
        /// into the instance type the endpoint is using. The endpoint must be deleted in order
        /// to stop incurring charges.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        Task<DeleteEndpointConfigResponse> DeleteEndpointConfigAsync(DeleteEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteExperiment



        /// <summary>
        /// Deletes an SageMaker experiment. All trials associated with the experiment must be
        /// deleted first. Use the <a>ListTrials</a> API to get a list of the trials associated
        /// with the experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        Task<DeleteExperimentResponse> DeleteExperimentAsync(DeleteExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFeatureGroup



        /// <summary>
        /// Delete the <code>FeatureGroup</code> and any data that was written to the <code>OnlineStore</code>
        /// of the <code>FeatureGroup</code>. Data cannot be accessed from the <code>OnlineStore</code>
        /// immediately after <code>DeleteFeatureGroup</code> is called. 
        /// 
        ///  
        /// <para>
        /// Data written into the <code>OfflineStore</code> will not be deleted. The Amazon Web
        /// Services Glue database and tables that are automatically created for your <code>OfflineStore</code>
        /// are not deleted. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeatureGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFeatureGroup">REST API Reference for DeleteFeatureGroup Operation</seealso>
        Task<DeleteFeatureGroupResponse> DeleteFeatureGroupAsync(DeleteFeatureGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFlowDefinition



        /// <summary>
        /// Deletes the specified flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlowDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFlowDefinition">REST API Reference for DeleteFlowDefinition Operation</seealso>
        Task<DeleteFlowDefinitionResponse> DeleteFlowDefinitionAsync(DeleteFlowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHumanTaskUi



        /// <summary>
        /// Use this operation to delete a human task user interface (worker task template).
        /// 
        ///  
        /// <para>
        ///  To see a list of human task user interfaces (work task templates) in your account,
        /// use . When you delete a worker task template, it no longer appears when you call <code>ListHumanTaskUis</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHumanTaskUi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHumanTaskUi service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHumanTaskUi">REST API Reference for DeleteHumanTaskUi Operation</seealso>
        Task<DeleteHumanTaskUiResponse> DeleteHumanTaskUiAsync(DeleteHumanTaskUiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteImage



        /// <summary>
        /// Deletes a SageMaker image and all versions of the image. The container images aren't
        /// deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteImageVersion



        /// <summary>
        /// Deletes a version of a SageMaker image. The container image the version represents
        /// isn't deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImageVersion service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteImageVersion">REST API Reference for DeleteImageVersion Operation</seealso>
        Task<DeleteImageVersionResponse> DeleteImageVersionAsync(DeleteImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModel



        /// <summary>
        /// Deletes a model. The <code>DeleteModel</code> API deletes only the model entry that
        /// was created in Amazon SageMaker when you called the <code>CreateModel</code> API.
        /// It does not delete model artifacts, inference code, or the IAM role that you specified
        /// when creating the model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelBiasJobDefinition



        /// <summary>
        /// Deletes an Amazon SageMaker model bias job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelBiasJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelBiasJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelBiasJobDefinition">REST API Reference for DeleteModelBiasJobDefinition Operation</seealso>
        Task<DeleteModelBiasJobDefinitionResponse> DeleteModelBiasJobDefinitionAsync(DeleteModelBiasJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelExplainabilityJobDefinition



        /// <summary>
        /// Deletes an Amazon SageMaker model explainability job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelExplainabilityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelExplainabilityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelExplainabilityJobDefinition">REST API Reference for DeleteModelExplainabilityJobDefinition Operation</seealso>
        Task<DeleteModelExplainabilityJobDefinitionResponse> DeleteModelExplainabilityJobDefinitionAsync(DeleteModelExplainabilityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelPackage



        /// <summary>
        /// Deletes a model package.
        /// 
        ///  
        /// <para>
        /// A model package is used to create Amazon SageMaker models or list on Amazon Web Services
        /// Marketplace. Buyers can subscribe to model packages listed on Amazon Web Services
        /// Marketplace to create models in Amazon SageMaker.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelPackage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        Task<DeleteModelPackageResponse> DeleteModelPackageAsync(DeleteModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelPackageGroup



        /// <summary>
        /// Deletes the specified model group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelPackageGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackageGroup">REST API Reference for DeleteModelPackageGroup Operation</seealso>
        Task<DeleteModelPackageGroupResponse> DeleteModelPackageGroupAsync(DeleteModelPackageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelPackageGroupPolicy



        /// <summary>
        /// Deletes a model group resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackageGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelPackageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackageGroupPolicy">REST API Reference for DeleteModelPackageGroupPolicy Operation</seealso>
        Task<DeleteModelPackageGroupPolicyResponse> DeleteModelPackageGroupPolicyAsync(DeleteModelPackageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelQualityJobDefinition



        /// <summary>
        /// Deletes the secified model quality monitoring job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelQualityJobDefinition">REST API Reference for DeleteModelQualityJobDefinition Operation</seealso>
        Task<DeleteModelQualityJobDefinitionResponse> DeleteModelQualityJobDefinitionAsync(DeleteModelQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMonitoringSchedule



        /// <summary>
        /// Deletes a monitoring schedule. Also stops the schedule had not already been stopped.
        /// This does not delete the job execution history of the monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteMonitoringSchedule">REST API Reference for DeleteMonitoringSchedule Operation</seealso>
        Task<DeleteMonitoringScheduleResponse> DeleteMonitoringScheduleAsync(DeleteMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNotebookInstance



        /// <summary>
        /// Deletes an Amazon SageMaker notebook instance. Before you can delete a notebook instance,
        /// you must call the <code>StopNotebookInstance</code> API. 
        /// 
        ///  <important> 
        /// <para>
        /// When you delete a notebook instance, you lose all of your data. Amazon SageMaker removes
        /// the ML compute instance, and deletes the ML storage volume and the network interface
        /// associated with the notebook instance. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        Task<DeleteNotebookInstanceResponse> DeleteNotebookInstanceAsync(DeleteNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNotebookInstanceLifecycleConfig



        /// <summary>
        /// Deletes a notebook instance lifecycle configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstanceLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        Task<DeleteNotebookInstanceLifecycleConfigResponse> DeleteNotebookInstanceLifecycleConfigAsync(DeleteNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePipeline



        /// <summary>
        /// Deletes a pipeline if there are no running instances of the pipeline. To delete a
        /// pipeline, you must stop all running instances of the pipeline using the <code>StopPipelineExecution</code>
        /// API. When you delete a pipeline, all instances of the pipeline are deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProject



        /// <summary>
        /// Delete the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStudioLifecycleConfig



        /// <summary>
        /// Deletes the Studio Lifecycle Configuration. In order to delete the Lifecycle Configuration,
        /// there must be no running apps using the Lifecycle Configuration. You must also remove
        /// the Lifecycle Configuration from UserSettings in all Domains and UserProfiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStudioLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteStudioLifecycleConfig">REST API Reference for DeleteStudioLifecycleConfig Operation</seealso>
        Task<DeleteStudioLifecycleConfigResponse> DeleteStudioLifecycleConfigAsync(DeleteStudioLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTags



        /// <summary>
        /// Deletes the specified tags from an Amazon SageMaker resource.
        /// 
        ///  
        /// <para>
        /// To list a resource's tags, use the <code>ListTags</code> API. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you call this API to delete tags from a hyperparameter tuning job, the deleted
        /// tags are not removed from training jobs that the hyperparameter tuning job launched
        /// before you called this API.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// When you call this API to delete tags from a SageMaker Studio Domain or User Profile,
        /// the deleted tags are not removed from Apps that the SageMaker Studio Domain or User
        /// Profile launched before you called this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrial



        /// <summary>
        /// Deletes the specified trial. All trial components that make up the trial must be deleted
        /// first. Use the <a>DescribeTrialComponent</a> API to get the list of trial components.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrial">REST API Reference for DeleteTrial Operation</seealso>
        Task<DeleteTrialResponse> DeleteTrialAsync(DeleteTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrialComponent



        /// <summary>
        /// Deletes the specified trial component. A trial component must be disassociated from
        /// all trials before the trial component can be deleted. To disassociate a trial component
        /// from a trial, call the <a>DisassociateTrialComponent</a> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrialComponent">REST API Reference for DeleteTrialComponent Operation</seealso>
        Task<DeleteTrialComponentResponse> DeleteTrialComponentAsync(DeleteTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserProfile



        /// <summary>
        /// Deletes a user profile. When a user profile is deleted, the user loses access to their
        /// EFS volume, including data, notebooks, and other artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkforce



        /// <summary>
        /// Use this operation to delete a workforce.
        /// 
        ///  
        /// <para>
        /// If you want to create a new workforce in an Amazon Web Services Region where a workforce
        /// already exists, use this operation to delete the existing workforce and then use to
        /// create a new workforce.
        /// </para>
        ///  <important> 
        /// <para>
        /// If a private workforce contains one or more work teams, you must use the operation
        /// to delete all work teams before you delete the workforce. If you try to delete a workforce
        /// that contains one or more work teams, you will recieve a <code>ResourceInUse</code>
        /// error.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkforce service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkforce">REST API Reference for DeleteWorkforce Operation</seealso>
        Task<DeleteWorkforceResponse> DeleteWorkforceAsync(DeleteWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkteam



        /// <summary>
        /// Deletes an existing work team. This operation can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        Task<DeleteWorkteamResponse> DeleteWorkteamAsync(DeleteWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterDevices



        /// <summary>
        /// Deregisters the specified devices. After you deregister a device, you will need to
        /// re-register the devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterDevices service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeregisterDevices">REST API Reference for DeregisterDevices Operation</seealso>
        Task<DeregisterDevicesResponse> DeregisterDevicesAsync(DeregisterDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAction



        /// <summary>
        /// Describes an action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAction">REST API Reference for DescribeAction Operation</seealso>
        Task<DescribeActionResponse> DescribeActionAsync(DescribeActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAlgorithm



        /// <summary>
        /// Returns a description of the specified algorithm that is in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        Task<DescribeAlgorithmResponse> DescribeAlgorithmAsync(DescribeAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApp



        /// <summary>
        /// Describes the app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        Task<DescribeAppResponse> DescribeAppAsync(DescribeAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppImageConfig



        /// <summary>
        /// Describes an AppImageConfig.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppImageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAppImageConfig">REST API Reference for DescribeAppImageConfig Operation</seealso>
        Task<DescribeAppImageConfigResponse> DescribeAppImageConfigAsync(DescribeAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeArtifact



        /// <summary>
        /// Describes an artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeArtifact">REST API Reference for DescribeArtifact Operation</seealso>
        Task<DescribeArtifactResponse> DescribeArtifactAsync(DescribeArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAutoMLJob



        /// <summary>
        /// Returns information about an Amazon SageMaker AutoML job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoMLJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAutoMLJob">REST API Reference for DescribeAutoMLJob Operation</seealso>
        Task<DescribeAutoMLJobResponse> DescribeAutoMLJobAsync(DescribeAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCodeRepository



        /// <summary>
        /// Gets details about the specified Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        Task<DescribeCodeRepositoryResponse> DescribeCodeRepositoryAsync(DescribeCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCompilationJob



        /// <summary>
        /// Returns information about a model compilation job.
        /// 
        ///  
        /// <para>
        /// To create a model compilation job, use <a>CreateCompilationJob</a>. To get information
        /// about multiple model compilation jobs, use <a>ListCompilationJobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompilationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        Task<DescribeCompilationJobResponse> DescribeCompilationJobAsync(DescribeCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeContext



        /// <summary>
        /// Describes a context.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeContext">REST API Reference for DescribeContext Operation</seealso>
        Task<DescribeContextResponse> DescribeContextAsync(DescribeContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataQualityJobDefinition



        /// <summary>
        /// Gets the details of a data quality monitoring job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDataQualityJobDefinition">REST API Reference for DescribeDataQualityJobDefinition Operation</seealso>
        Task<DescribeDataQualityJobDefinitionResponse> DescribeDataQualityJobDefinitionAsync(DescribeDataQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDevice



        /// <summary>
        /// Describes the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDeviceFleet



        /// <summary>
        /// A description of the fleet the device belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeviceFleet service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDeviceFleet">REST API Reference for DescribeDeviceFleet Operation</seealso>
        Task<DescribeDeviceFleetResponse> DescribeDeviceFleetAsync(DescribeDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDomain



        /// <summary>
        /// The description of the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEdgePackagingJob



        /// <summary>
        /// A description of edge packaging jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEdgePackagingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEdgePackagingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEdgePackagingJob">REST API Reference for DescribeEdgePackagingJob Operation</seealso>
        Task<DescribeEdgePackagingJobResponse> DescribeEdgePackagingJobAsync(DescribeEdgePackagingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEndpoint



        /// <summary>
        /// Returns the description of an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEndpointConfig



        /// <summary>
        /// Returns the description of an endpoint configuration created using the <code>CreateEndpointConfig</code>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        Task<DescribeEndpointConfigResponse> DescribeEndpointConfigAsync(DescribeEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExperiment



        /// <summary>
        /// Provides a list of an experiment's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeExperiment">REST API Reference for DescribeExperiment Operation</seealso>
        Task<DescribeExperimentResponse> DescribeExperimentAsync(DescribeExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFeatureGroup



        /// <summary>
        /// Use this operation to describe a <code>FeatureGroup</code>. The response includes
        /// information on the creation time, <code>FeatureGroup</code> name, the unique identifier
        /// for each <code>FeatureGroup</code>, and more.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeatureGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFeatureGroup">REST API Reference for DescribeFeatureGroup Operation</seealso>
        Task<DescribeFeatureGroupResponse> DescribeFeatureGroupAsync(DescribeFeatureGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFlowDefinition



        /// <summary>
        /// Returns information about the specified flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlowDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFlowDefinition">REST API Reference for DescribeFlowDefinition Operation</seealso>
        Task<DescribeFlowDefinitionResponse> DescribeFlowDefinitionAsync(DescribeFlowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHumanTaskUi



        /// <summary>
        /// Returns information about the requested human task user interface (worker task template).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHumanTaskUi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHumanTaskUi service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHumanTaskUi">REST API Reference for DescribeHumanTaskUi Operation</seealso>
        Task<DescribeHumanTaskUiResponse> DescribeHumanTaskUiAsync(DescribeHumanTaskUiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHyperParameterTuningJob



        /// <summary>
        /// Gets a description of a hyperparameter tuning job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHyperParameterTuningJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        Task<DescribeHyperParameterTuningJobResponse> DescribeHyperParameterTuningJobAsync(DescribeHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImage



        /// <summary>
        /// Describes a SageMaker image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeImage">REST API Reference for DescribeImage Operation</seealso>
        Task<DescribeImageResponse> DescribeImageAsync(DescribeImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImageVersion



        /// <summary>
        /// Describes a version of a SageMaker image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImageVersion service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeImageVersion">REST API Reference for DescribeImageVersion Operation</seealso>
        Task<DescribeImageVersionResponse> DescribeImageVersionAsync(DescribeImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInferenceRecommendationsJob



        /// <summary>
        /// Provides the results of the Inference Recommender job. One or more recommendation
        /// jobs are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceRecommendationsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInferenceRecommendationsJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeInferenceRecommendationsJob">REST API Reference for DescribeInferenceRecommendationsJob Operation</seealso>
        Task<DescribeInferenceRecommendationsJobResponse> DescribeInferenceRecommendationsJobAsync(DescribeInferenceRecommendationsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLabelingJob



        /// <summary>
        /// Gets information about a labeling job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        Task<DescribeLabelingJobResponse> DescribeLabelingJobAsync(DescribeLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLineageGroup



        /// <summary>
        /// Provides a list of properties for the requested lineage group. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/xaccount-lineage-tracking.html">
        /// Cross-Account Lineage Tracking </a> in the <i>Amazon SageMaker Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLineageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLineageGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLineageGroup">REST API Reference for DescribeLineageGroup Operation</seealso>
        Task<DescribeLineageGroupResponse> DescribeLineageGroupAsync(DescribeLineageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModel



        /// <summary>
        /// Describes a model that you created using the <code>CreateModel</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        Task<DescribeModelResponse> DescribeModelAsync(DescribeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelBiasJobDefinition



        /// <summary>
        /// Returns a description of a model bias job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelBiasJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelBiasJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelBiasJobDefinition">REST API Reference for DescribeModelBiasJobDefinition Operation</seealso>
        Task<DescribeModelBiasJobDefinitionResponse> DescribeModelBiasJobDefinitionAsync(DescribeModelBiasJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelExplainabilityJobDefinition



        /// <summary>
        /// Returns a description of a model explainability job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelExplainabilityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelExplainabilityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelExplainabilityJobDefinition">REST API Reference for DescribeModelExplainabilityJobDefinition Operation</seealso>
        Task<DescribeModelExplainabilityJobDefinitionResponse> DescribeModelExplainabilityJobDefinitionAsync(DescribeModelExplainabilityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelPackage



        /// <summary>
        /// Returns a description of the specified model package, which is used to create SageMaker
        /// models or list them on Amazon Web Services Marketplace.
        /// 
        ///  
        /// <para>
        /// To create models in SageMaker, buyers can subscribe to model packages listed on Amazon
        /// Web Services Marketplace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        Task<DescribeModelPackageResponse> DescribeModelPackageAsync(DescribeModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelPackageGroup



        /// <summary>
        /// Gets a description for the specified model group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelPackageGroup service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackageGroup">REST API Reference for DescribeModelPackageGroup Operation</seealso>
        Task<DescribeModelPackageGroupResponse> DescribeModelPackageGroupAsync(DescribeModelPackageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelQualityJobDefinition



        /// <summary>
        /// Returns a description of a model quality job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelQualityJobDefinition">REST API Reference for DescribeModelQualityJobDefinition Operation</seealso>
        Task<DescribeModelQualityJobDefinitionResponse> DescribeModelQualityJobDefinitionAsync(DescribeModelQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMonitoringSchedule



        /// <summary>
        /// Describes the schedule for a monitoring job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeMonitoringSchedule">REST API Reference for DescribeMonitoringSchedule Operation</seealso>
        Task<DescribeMonitoringScheduleResponse> DescribeMonitoringScheduleAsync(DescribeMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNotebookInstance



        /// <summary>
        /// Returns information about a notebook instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        Task<DescribeNotebookInstanceResponse> DescribeNotebookInstanceAsync(DescribeNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNotebookInstanceLifecycleConfig



        /// <summary>
        /// Returns a description of a notebook instance lifecycle configuration.
        /// 
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstanceLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        Task<DescribeNotebookInstanceLifecycleConfigResponse> DescribeNotebookInstanceLifecycleConfigAsync(DescribeNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePipeline



        /// <summary>
        /// Describes the details of a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        Task<DescribePipelineResponse> DescribePipelineAsync(DescribePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePipelineDefinitionForExecution



        /// <summary>
        /// Describes the details of an execution's pipeline definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelineDefinitionForExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipelineDefinitionForExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipelineDefinitionForExecution">REST API Reference for DescribePipelineDefinitionForExecution Operation</seealso>
        Task<DescribePipelineDefinitionForExecutionResponse> DescribePipelineDefinitionForExecutionAsync(DescribePipelineDefinitionForExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePipelineExecution



        /// <summary>
        /// Describes the details of a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipelineExecution">REST API Reference for DescribePipelineExecution Operation</seealso>
        Task<DescribePipelineExecutionResponse> DescribePipelineExecutionAsync(DescribePipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProcessingJob



        /// <summary>
        /// Returns a description of a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProcessingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProcessingJob">REST API Reference for DescribeProcessingJob Operation</seealso>
        Task<DescribeProcessingJobResponse> DescribeProcessingJobAsync(DescribeProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProject



        /// <summary>
        /// Describes the details of a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStudioLifecycleConfig



        /// <summary>
        /// Describes the Studio Lifecycle Configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStudioLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStudioLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeStudioLifecycleConfig">REST API Reference for DescribeStudioLifecycleConfig Operation</seealso>
        Task<DescribeStudioLifecycleConfigResponse> DescribeStudioLifecycleConfigAsync(DescribeStudioLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSubscribedWorkteam



        /// <summary>
        /// Gets information about a work team provided by a vendor. It returns details about
        /// the subscription with a vendor in the Amazon Web Services Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribedWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubscribedWorkteam service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        Task<DescribeSubscribedWorkteamResponse> DescribeSubscribedWorkteamAsync(DescribeSubscribedWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrainingJob



        /// <summary>
        /// Returns information about a training job. 
        /// 
        ///  
        /// <para>
        /// Some of the attributes below only appear if the training job successfully starts.
        /// If the training job fails, <code>TrainingJobStatus</code> is <code>Failed</code> and,
        /// depending on the <code>FailureReason</code>, attributes like <code>TrainingStartTime</code>,
        /// <code>TrainingTimeInSeconds</code>, <code>TrainingEndTime</code>, and <code>BillableTimeInSeconds</code>
        /// may not be present in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        Task<DescribeTrainingJobResponse> DescribeTrainingJobAsync(DescribeTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTransformJob



        /// <summary>
        /// Returns information about a transform job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        Task<DescribeTransformJobResponse> DescribeTransformJobAsync(DescribeTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrial



        /// <summary>
        /// Provides a list of a trial's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrial">REST API Reference for DescribeTrial Operation</seealso>
        Task<DescribeTrialResponse> DescribeTrialAsync(DescribeTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrialComponent



        /// <summary>
        /// Provides a list of a trials component's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrialComponent">REST API Reference for DescribeTrialComponent Operation</seealso>
        Task<DescribeTrialComponentResponse> DescribeTrialComponentAsync(DescribeTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUserProfile



        /// <summary>
        /// Describes a user profile. For more information, see <code>CreateUserProfile</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        Task<DescribeUserProfileResponse> DescribeUserProfileAsync(DescribeUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkforce



        /// <summary>
        /// Lists private workforce information, including workforce name, Amazon Resource Name
        /// (ARN), and, if applicable, allowed IP address ranges (<a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>).
        /// Allowable IP address ranges are the IP addresses that workers can use to access tasks.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// This operation applies only to private workforces.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkforce service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkforce">REST API Reference for DescribeWorkforce Operation</seealso>
        Task<DescribeWorkforceResponse> DescribeWorkforceAsync(DescribeWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkteam



        /// <summary>
        /// Gets information about a specific work team. You can see information such as the create
        /// date, the last updated date, membership information, and the work team's Amazon Resource
        /// Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkteam service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        Task<DescribeWorkteamResponse> DescribeWorkteamAsync(DescribeWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableSagemakerServicecatalogPortfolio



        /// <summary>
        /// Disables using Service Catalog in SageMaker. Service Catalog is used to create SageMaker
        /// projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSagemakerServicecatalogPortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableSagemakerServicecatalogPortfolio service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisableSagemakerServicecatalogPortfolio">REST API Reference for DisableSagemakerServicecatalogPortfolio Operation</seealso>
        Task<DisableSagemakerServicecatalogPortfolioResponse> DisableSagemakerServicecatalogPortfolioAsync(DisableSagemakerServicecatalogPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateTrialComponent



        /// <summary>
        /// Disassociates a trial component from a trial. This doesn't effect other trials the
        /// component is associated with. Before you can delete a component, you must disassociate
        /// the component from all trials it is associated with. To associate a trial component
        /// with a trial, call the <a>AssociateTrialComponent</a> API.
        /// 
        ///  
        /// <para>
        /// To get a list of the trials a component is associated with, use the <a>Search</a>
        /// API. Specify <code>ExperimentTrialComponent</code> for the <code>Resource</code> parameter.
        /// The list appears in the response under <code>Results.TrialComponent.Parents</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisassociateTrialComponent">REST API Reference for DisassociateTrialComponent Operation</seealso>
        Task<DisassociateTrialComponentResponse> DisassociateTrialComponentAsync(DisassociateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableSagemakerServicecatalogPortfolio



        /// <summary>
        /// Enables using Service Catalog in SageMaker. Service Catalog is used to create SageMaker
        /// projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSagemakerServicecatalogPortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableSagemakerServicecatalogPortfolio service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/EnableSagemakerServicecatalogPortfolio">REST API Reference for EnableSagemakerServicecatalogPortfolio Operation</seealso>
        Task<EnableSagemakerServicecatalogPortfolioResponse> EnableSagemakerServicecatalogPortfolioAsync(EnableSagemakerServicecatalogPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeviceFleetReport



        /// <summary>
        /// Describes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceFleetReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeviceFleetReport service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetDeviceFleetReport">REST API Reference for GetDeviceFleetReport Operation</seealso>
        Task<GetDeviceFleetReportResponse> GetDeviceFleetReportAsync(GetDeviceFleetReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLineageGroupPolicy



        /// <summary>
        /// The resource policy for the lineage group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLineageGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLineageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetLineageGroupPolicy">REST API Reference for GetLineageGroupPolicy Operation</seealso>
        Task<GetLineageGroupPolicyResponse> GetLineageGroupPolicyAsync(GetLineageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetModelPackageGroupPolicy



        /// <summary>
        /// Gets a resource policy that manages access for a model group. For information about
        /// resource policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_identity-vs-resource.html">Identity-based
        /// policies and resource-based policies</a> in the <i>Amazon Web Services Identity and
        /// Access Management User Guide.</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelPackageGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelPackageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetModelPackageGroupPolicy">REST API Reference for GetModelPackageGroupPolicy Operation</seealso>
        Task<GetModelPackageGroupPolicyResponse> GetModelPackageGroupPolicyAsync(GetModelPackageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSagemakerServicecatalogPortfolioStatus



        /// <summary>
        /// Gets the status of Service Catalog in SageMaker. Service Catalog is used to create
        /// SageMaker projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSagemakerServicecatalogPortfolioStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSagemakerServicecatalogPortfolioStatus service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSagemakerServicecatalogPortfolioStatus">REST API Reference for GetSagemakerServicecatalogPortfolioStatus Operation</seealso>
        Task<GetSagemakerServicecatalogPortfolioStatusResponse> GetSagemakerServicecatalogPortfolioStatusAsync(GetSagemakerServicecatalogPortfolioStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSearchSuggestions



        /// <summary>
        /// An auto-complete API for the search functionality in the Amazon SageMaker console.
        /// It returns suggestions of possible matches for the property name to use in <code>Search</code>
        /// queries. Provides suggestions for <code>HyperParameters</code>, <code>Tags</code>,
        /// and <code>Metrics</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchSuggestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSearchSuggestions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        Task<GetSearchSuggestionsResponse> GetSearchSuggestionsAsync(GetSearchSuggestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListActions



        /// <summary>
        /// Lists the actions in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListActions">REST API Reference for ListActions Operation</seealso>
        Task<ListActionsResponse> ListActionsAsync(ListActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAlgorithms



        /// <summary>
        /// Lists the machine learning algorithms that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlgorithms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAlgorithms service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        Task<ListAlgorithmsResponse> ListAlgorithmsAsync(ListAlgorithmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppImageConfigs



        /// <summary>
        /// Lists the AppImageConfigs in your account and their properties. The list can be filtered
        /// by creation time or modified time, and whether the AppImageConfig name contains a
        /// specified string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppImageConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppImageConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAppImageConfigs">REST API Reference for ListAppImageConfigs Operation</seealso>
        Task<ListAppImageConfigsResponse> ListAppImageConfigsAsync(ListAppImageConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApps



        /// <summary>
        /// Lists apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListApps">REST API Reference for ListApps Operation</seealso>
        Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListArtifacts



        /// <summary>
        /// Lists the artifacts in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssociations



        /// <summary>
        /// Lists the associations in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        Task<ListAssociationsResponse> ListAssociationsAsync(ListAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAutoMLJobs



        /// <summary>
        /// Request a list of jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutoMLJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutoMLJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAutoMLJobs">REST API Reference for ListAutoMLJobs Operation</seealso>
        Task<ListAutoMLJobsResponse> ListAutoMLJobsAsync(ListAutoMLJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCandidatesForAutoMLJob



        /// <summary>
        /// List the candidates created for the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCandidatesForAutoMLJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCandidatesForAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCandidatesForAutoMLJob">REST API Reference for ListCandidatesForAutoMLJob Operation</seealso>
        Task<ListCandidatesForAutoMLJobResponse> ListCandidatesForAutoMLJobAsync(ListCandidatesForAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCodeRepositories



        /// <summary>
        /// Gets a list of the Git repositories in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeRepositories service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        Task<ListCodeRepositoriesResponse> ListCodeRepositoriesAsync(ListCodeRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCompilationJobs



        /// <summary>
        /// Lists model compilation jobs that satisfy various filters.
        /// 
        ///  
        /// <para>
        /// To create a model compilation job, use <a>CreateCompilationJob</a>. To get information
        /// about a particular model compilation job you have created, use <a>DescribeCompilationJob</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompilationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCompilationJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        Task<ListCompilationJobsResponse> ListCompilationJobsAsync(ListCompilationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContexts



        /// <summary>
        /// Lists the contexts in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContexts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContexts service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListContexts">REST API Reference for ListContexts Operation</seealso>
        Task<ListContextsResponse> ListContextsAsync(ListContextsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataQualityJobDefinitions



        /// <summary>
        /// Lists the data quality job definitions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataQualityJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDataQualityJobDefinitions">REST API Reference for ListDataQualityJobDefinitions Operation</seealso>
        Task<ListDataQualityJobDefinitionsResponse> ListDataQualityJobDefinitionsAsync(ListDataQualityJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeviceFleets



        /// <summary>
        /// Returns a list of devices in the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeviceFleets service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDeviceFleets">REST API Reference for ListDeviceFleets Operation</seealso>
        Task<ListDeviceFleetsResponse> ListDeviceFleetsAsync(ListDeviceFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDevices



        /// <summary>
        /// A list of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDevices">REST API Reference for ListDevices Operation</seealso>
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomains



        /// <summary>
        /// Lists the domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEdgePackagingJobs



        /// <summary>
        /// Returns a list of edge packaging jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEdgePackagingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEdgePackagingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEdgePackagingJobs">REST API Reference for ListEdgePackagingJobs Operation</seealso>
        Task<ListEdgePackagingJobsResponse> ListEdgePackagingJobsAsync(ListEdgePackagingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEndpointConfigs



        /// <summary>
        /// Lists endpoint configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpointConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        Task<ListEndpointConfigsResponse> ListEndpointConfigsAsync(ListEndpointConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEndpoints



        /// <summary>
        /// Lists endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExperiments



        /// <summary>
        /// Lists all the experiments in your account. The list can be filtered to show only experiments
        /// that were created in a specific time range. The list can be sorted by experiment name
        /// or creation time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperiments service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFeatureGroups



        /// <summary>
        /// List <code>FeatureGroup</code>s based on given filter and order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeatureGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFeatureGroups service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFeatureGroups">REST API Reference for ListFeatureGroups Operation</seealso>
        Task<ListFeatureGroupsResponse> ListFeatureGroupsAsync(ListFeatureGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFlowDefinitions



        /// <summary>
        /// Returns information about the flow definitions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlowDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFlowDefinitions">REST API Reference for ListFlowDefinitions Operation</seealso>
        Task<ListFlowDefinitionsResponse> ListFlowDefinitionsAsync(ListFlowDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHumanTaskUis



        /// <summary>
        /// Returns information about the human task user interfaces in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHumanTaskUis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHumanTaskUis service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHumanTaskUis">REST API Reference for ListHumanTaskUis Operation</seealso>
        Task<ListHumanTaskUisResponse> ListHumanTaskUisAsync(ListHumanTaskUisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHyperParameterTuningJobs



        /// <summary>
        /// Gets a list of <a>HyperParameterTuningJobSummary</a> objects that describe the hyperparameter
        /// tuning jobs launched in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHyperParameterTuningJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHyperParameterTuningJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        Task<ListHyperParameterTuningJobsResponse> ListHyperParameterTuningJobsAsync(ListHyperParameterTuningJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListImages



        /// <summary>
        /// Lists the images in your account and their properties. The list can be filtered by
        /// creation time or modified time, and whether the image name contains a specified string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImages service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListImages">REST API Reference for ListImages Operation</seealso>
        Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListImageVersions



        /// <summary>
        /// Lists the versions of a specified image and their properties. The list can be filtered
        /// by creation time or modified time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImageVersions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListImageVersions">REST API Reference for ListImageVersions Operation</seealso>
        Task<ListImageVersionsResponse> ListImageVersionsAsync(ListImageVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInferenceRecommendationsJobs



        /// <summary>
        /// Lists recommendation jobs that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceRecommendationsJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInferenceRecommendationsJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceRecommendationsJobs">REST API Reference for ListInferenceRecommendationsJobs Operation</seealso>
        Task<ListInferenceRecommendationsJobsResponse> ListInferenceRecommendationsJobsAsync(ListInferenceRecommendationsJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLabelingJobs



        /// <summary>
        /// Gets a list of labeling jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLabelingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        Task<ListLabelingJobsResponse> ListLabelingJobsAsync(ListLabelingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLabelingJobsForWorkteam



        /// <summary>
        /// Gets a list of labeling jobs assigned to a specified work team.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobsForWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLabelingJobsForWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        Task<ListLabelingJobsForWorkteamResponse> ListLabelingJobsForWorkteamAsync(ListLabelingJobsForWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLineageGroups



        /// <summary>
        /// A list of lineage groups shared with your Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/xaccount-lineage-tracking.html">
        /// Cross-Account Lineage Tracking </a> in the <i>Amazon SageMaker Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLineageGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLineageGroups service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLineageGroups">REST API Reference for ListLineageGroups Operation</seealso>
        Task<ListLineageGroupsResponse> ListLineageGroupsAsync(ListLineageGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelBiasJobDefinitions



        /// <summary>
        /// Lists model bias jobs definitions that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelBiasJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelBiasJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelBiasJobDefinitions">REST API Reference for ListModelBiasJobDefinitions Operation</seealso>
        Task<ListModelBiasJobDefinitionsResponse> ListModelBiasJobDefinitionsAsync(ListModelBiasJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelExplainabilityJobDefinitions



        /// <summary>
        /// Lists model explainability job definitions that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelExplainabilityJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelExplainabilityJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelExplainabilityJobDefinitions">REST API Reference for ListModelExplainabilityJobDefinitions Operation</seealso>
        Task<ListModelExplainabilityJobDefinitionsResponse> ListModelExplainabilityJobDefinitionsAsync(ListModelExplainabilityJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelMetadata



        /// <summary>
        /// Lists the domain, framework, task, and model name of standard machine learning models
        /// found in common model zoos.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelMetadata service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelMetadata">REST API Reference for ListModelMetadata Operation</seealso>
        Task<ListModelMetadataResponse> ListModelMetadataAsync(ListModelMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelPackageGroups



        /// <summary>
        /// Gets a list of the model groups in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackageGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelPackageGroups service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackageGroups">REST API Reference for ListModelPackageGroups Operation</seealso>
        Task<ListModelPackageGroupsResponse> ListModelPackageGroupsAsync(ListModelPackageGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelPackages



        /// <summary>
        /// Lists the model packages that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelPackages service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        Task<ListModelPackagesResponse> ListModelPackagesAsync(ListModelPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelQualityJobDefinitions



        /// <summary>
        /// Gets a list of model quality monitoring job definitions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelQualityJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelQualityJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelQualityJobDefinitions">REST API Reference for ListModelQualityJobDefinitions Operation</seealso>
        Task<ListModelQualityJobDefinitionsResponse> ListModelQualityJobDefinitionsAsync(ListModelQualityJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModels



        /// <summary>
        /// Lists models created with the <code>CreateModel</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMonitoringExecutions



        /// <summary>
        /// Returns list of all monitoring job executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMonitoringExecutions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringExecutions">REST API Reference for ListMonitoringExecutions Operation</seealso>
        Task<ListMonitoringExecutionsResponse> ListMonitoringExecutionsAsync(ListMonitoringExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMonitoringSchedules



        /// <summary>
        /// Returns list of all monitoring schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMonitoringSchedules service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringSchedules">REST API Reference for ListMonitoringSchedules Operation</seealso>
        Task<ListMonitoringSchedulesResponse> ListMonitoringSchedulesAsync(ListMonitoringSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotebookInstanceLifecycleConfigs



        /// <summary>
        /// Lists notebook instance lifestyle configurations created with the <a>CreateNotebookInstanceLifecycleConfig</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstanceLifecycleConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookInstanceLifecycleConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        Task<ListNotebookInstanceLifecycleConfigsResponse> ListNotebookInstanceLifecycleConfigsAsync(ListNotebookInstanceLifecycleConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotebookInstances



        /// <summary>
        /// Returns a list of the Amazon SageMaker notebook instances in the requester's account
        /// in an Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookInstances service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        Task<ListNotebookInstancesResponse> ListNotebookInstancesAsync(ListNotebookInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelineExecutions



        /// <summary>
        /// Gets a list of the pipeline executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelineExecutions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        Task<ListPipelineExecutionsResponse> ListPipelineExecutionsAsync(ListPipelineExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelineExecutionSteps



        /// <summary>
        /// Gets a list of <code>PipeLineExecutionStep</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutionSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelineExecutionSteps service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineExecutionSteps">REST API Reference for ListPipelineExecutionSteps Operation</seealso>
        Task<ListPipelineExecutionStepsResponse> ListPipelineExecutionStepsAsync(ListPipelineExecutionStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelineParametersForExecution



        /// <summary>
        /// Gets a list of parameters for a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineParametersForExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelineParametersForExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineParametersForExecution">REST API Reference for ListPipelineParametersForExecution Operation</seealso>
        Task<ListPipelineParametersForExecutionResponse> ListPipelineParametersForExecutionAsync(ListPipelineParametersForExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelines



        /// <summary>
        /// Gets a list of pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProcessingJobs



        /// <summary>
        /// Lists processing jobs that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProcessingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProcessingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProcessingJobs">REST API Reference for ListProcessingJobs Operation</seealso>
        Task<ListProcessingJobsResponse> ListProcessingJobsAsync(ListProcessingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProjects



        /// <summary>
        /// Gets a list of the projects in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProjects">REST API Reference for ListProjects Operation</seealso>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStudioLifecycleConfigs



        /// <summary>
        /// Lists the Studio Lifecycle Configurations in your Amazon Web Services Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudioLifecycleConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStudioLifecycleConfigs service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListStudioLifecycleConfigs">REST API Reference for ListStudioLifecycleConfigs Operation</seealso>
        Task<ListStudioLifecycleConfigsResponse> ListStudioLifecycleConfigsAsync(ListStudioLifecycleConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSubscribedWorkteams



        /// <summary>
        /// Gets a list of the work teams that you are subscribed to in the Amazon Web Services
        /// Marketplace. The list may be empty if no work team satisfies the filter specified
        /// in the <code>NameContains</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedWorkteams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscribedWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        Task<ListSubscribedWorkteamsResponse> ListSubscribedWorkteamsAsync(ListSubscribedWorkteamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTags



        /// <summary>
        /// Returns the tags for the specified Amazon SageMaker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrainingJobs



        /// <summary>
        /// Lists training jobs.
        /// 
        ///  <note> 
        /// <para>
        /// When <code>StatusEquals</code> and <code>MaxResults</code> are set at the same time,
        /// the <code>MaxResults</code> number of training jobs are first retrieved ignoring the
        /// <code>StatusEquals</code> parameter and then they are filtered by the <code>StatusEquals</code>
        /// parameter, which is returned as a response.
        /// </para>
        ///  
        /// <para>
        /// For example, if <code>ListTrainingJobs</code> is invoked with the following parameters:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ ... MaxResults: 100, StatusEquals: InProgress ... }</code> 
        /// </para>
        ///  
        /// <para>
        /// First, 100 trainings jobs with any status, including those other than <code>InProgress</code>,
        /// are selected (sorted according to the creation time, from the most current to the
        /// oldest). Next, those with a status of <code>InProgress</code> are returned.
        /// </para>
        ///  
        /// <para>
        /// You can quickly test the API using the following Amazon Web Services CLI code.
        /// </para>
        ///  
        /// <para>
        ///  <code>aws sagemaker list-training-jobs --max-results 100 --status-equals InProgress</code>
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrainingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        Task<ListTrainingJobsResponse> ListTrainingJobsAsync(ListTrainingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrainingJobsForHyperParameterTuningJob



        /// <summary>
        /// Gets a list of <a>TrainingJobSummary</a> objects that describe the training jobs that
        /// a hyperparameter tuning job launched.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobsForHyperParameterTuningJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrainingJobsForHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        Task<ListTrainingJobsForHyperParameterTuningJobResponse> ListTrainingJobsForHyperParameterTuningJobAsync(ListTrainingJobsForHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTransformJobs



        /// <summary>
        /// Lists transform jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransformJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTransformJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        Task<ListTransformJobsResponse> ListTransformJobsAsync(ListTransformJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrialComponents



        /// <summary>
        /// Lists the trial components in your account. You can sort the list by trial component
        /// name or creation time. You can filter the list to show only components that were created
        /// in a specific time range. You can also filter on one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>ExperimentName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceArn</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrialName</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrialComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrialComponents service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrialComponents">REST API Reference for ListTrialComponents Operation</seealso>
        Task<ListTrialComponentsResponse> ListTrialComponentsAsync(ListTrialComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrials



        /// <summary>
        /// Lists the trials in your account. Specify an experiment name to limit the list to
        /// the trials that are part of that experiment. Specify a trial component name to limit
        /// the list to the trials that associated with that trial component. The list can be
        /// filtered to show only trials that were created in a specific time range. The list
        /// can be sorted by trial name or creation time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrials service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrials">REST API Reference for ListTrials Operation</seealso>
        Task<ListTrialsResponse> ListTrialsAsync(ListTrialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUserProfiles



        /// <summary>
        /// Lists user profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserProfiles service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        Task<ListUserProfilesResponse> ListUserProfilesAsync(ListUserProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkforces



        /// <summary>
        /// Use this operation to list all private and vendor workforces in an Amazon Web Services
        /// Region. Note that you can only have one private workforce per Amazon Web Services
        /// Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkforces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkforces service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkforces">REST API Reference for ListWorkforces Operation</seealso>
        Task<ListWorkforcesResponse> ListWorkforcesAsync(ListWorkforcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkteams



        /// <summary>
        /// Gets a list of private work teams that you have defined in a region. The list may
        /// be empty if no work team satisfies the filter specified in the <code>NameContains</code>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkteams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        Task<ListWorkteamsResponse> ListWorkteamsAsync(ListWorkteamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutModelPackageGroupPolicy



        /// <summary>
        /// Adds a resouce policy to control access to a model group. For information about resoure
        /// policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_identity-vs-resource.html">Identity-based
        /// policies and resource-based policies</a> in the <i>Amazon Web Services Identity and
        /// Access Management User Guide.</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutModelPackageGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutModelPackageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/PutModelPackageGroupPolicy">REST API Reference for PutModelPackageGroupPolicy Operation</seealso>
        Task<PutModelPackageGroupPolicyResponse> PutModelPackageGroupPolicyAsync(PutModelPackageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  QueryLineage



        /// <summary>
        /// Use this action to inspect your lineage and discover relationships between entities.
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/querying-lineage-entities.html">
        /// Querying Lineage Entities</a> in the <i>Amazon SageMaker Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryLineage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryLineage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/QueryLineage">REST API Reference for QueryLineage Operation</seealso>
        Task<QueryLineageResponse> QueryLineageAsync(QueryLineageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterDevices



        /// <summary>
        /// Register devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterDevices service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RegisterDevices">REST API Reference for RegisterDevices Operation</seealso>
        Task<RegisterDevicesResponse> RegisterDevicesAsync(RegisterDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RenderUiTemplate



        /// <summary>
        /// Renders the UI template so that you can preview the worker's experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenderUiTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RenderUiTemplate service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        Task<RenderUiTemplateResponse> RenderUiTemplateAsync(RenderUiTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RetryPipelineExecution



        /// <summary>
        /// Retry the execution of the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetryPipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RetryPipelineExecution">REST API Reference for RetryPipelineExecution Operation</seealso>
        Task<RetryPipelineExecutionResponse> RetryPipelineExecutionAsync(RetryPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Search



        /// <summary>
        /// Finds Amazon SageMaker resources that match a search query. Matching resources are
        /// returned as a list of <code>SearchRecord</code> objects in the response. You can sort
        /// the search results by any resource property in a ascending or descending order.
        /// 
        ///  
        /// <para>
        /// You can query against the following value types: numeric, text, Boolean, and timestamp.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Search service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        Task<SearchResponse> SearchAsync(SearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendPipelineExecutionStepFailure



        /// <summary>
        /// Notifies the pipeline that the execution of a callback step failed, along with a message
        /// describing why. When a callback step is run, the pipeline generates a callback token
        /// and includes the token in a message sent to Amazon Simple Queue Service (Amazon SQS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendPipelineExecutionStepFailure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendPipelineExecutionStepFailure service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepFailure">REST API Reference for SendPipelineExecutionStepFailure Operation</seealso>
        Task<SendPipelineExecutionStepFailureResponse> SendPipelineExecutionStepFailureAsync(SendPipelineExecutionStepFailureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendPipelineExecutionStepSuccess



        /// <summary>
        /// Notifies the pipeline that the execution of a callback step succeeded and provides
        /// a list of the step's output parameters. When a callback step is run, the pipeline
        /// generates a callback token and includes the token in a message sent to Amazon Simple
        /// Queue Service (Amazon SQS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendPipelineExecutionStepSuccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendPipelineExecutionStepSuccess service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepSuccess">REST API Reference for SendPipelineExecutionStepSuccess Operation</seealso>
        Task<SendPipelineExecutionStepSuccessResponse> SendPipelineExecutionStepSuccessAsync(SendPipelineExecutionStepSuccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMonitoringSchedule



        /// <summary>
        /// Starts a previously stopped monitoring schedule.
        /// 
        ///  <note> 
        /// <para>
        /// By default, when you successfully create a new schedule, the status of a monitoring
        /// schedule is <code>scheduled</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartMonitoringSchedule">REST API Reference for StartMonitoringSchedule Operation</seealso>
        Task<StartMonitoringScheduleResponse> StartMonitoringScheduleAsync(StartMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartNotebookInstance



        /// <summary>
        /// Launches an ML compute instance with the latest version of the libraries and attaches
        /// your ML storage volume. After configuring the notebook instance, Amazon SageMaker
        /// sets the notebook instance status to <code>InService</code>. A notebook instance's
        /// status must be <code>InService</code> before you can connect to your Jupyter notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        Task<StartNotebookInstanceResponse> StartNotebookInstanceAsync(StartNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartPipelineExecution



        /// <summary>
        /// Starts a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(StartPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopAutoMLJob



        /// <summary>
        /// A method for forcing the termination of a running job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutoMLJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopAutoMLJob">REST API Reference for StopAutoMLJob Operation</seealso>
        Task<StopAutoMLJobResponse> StopAutoMLJobAsync(StopAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopCompilationJob



        /// <summary>
        /// Stops a model compilation job.
        /// 
        ///  
        /// <para>
        ///  To stop a job, Amazon SageMaker sends the algorithm the SIGTERM signal. This gracefully
        /// shuts the job down. If the job hasn't stopped, it sends the SIGKILL signal.
        /// </para>
        ///  
        /// <para>
        /// When it receives a <code>StopCompilationJob</code> request, Amazon SageMaker changes
        /// the <a>CompilationJobSummary$CompilationJobStatus</a> of the job to <code>Stopping</code>.
        /// After Amazon SageMaker stops the job, it sets the <a>CompilationJobSummary$CompilationJobStatus</a>
        /// to <code>Stopped</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCompilationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        Task<StopCompilationJobResponse> StopCompilationJobAsync(StopCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopEdgePackagingJob



        /// <summary>
        /// Request to stop an edge packaging job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEdgePackagingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEdgePackagingJob service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopEdgePackagingJob">REST API Reference for StopEdgePackagingJob Operation</seealso>
        Task<StopEdgePackagingJobResponse> StopEdgePackagingJobAsync(StopEdgePackagingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopHyperParameterTuningJob



        /// <summary>
        /// Stops a running hyperparameter tuning job and all running training jobs that the tuning
        /// job launched.
        /// 
        ///  
        /// <para>
        /// All model artifacts output from the training jobs are stored in Amazon Simple Storage
        /// Service (Amazon S3). All data that the training jobs write to Amazon CloudWatch Logs
        /// are still available in CloudWatch. After the tuning job moves to the <code>Stopped</code>
        /// state, it releases all reserved resources for the tuning job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopHyperParameterTuningJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        Task<StopHyperParameterTuningJobResponse> StopHyperParameterTuningJobAsync(StopHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopInferenceRecommendationsJob



        /// <summary>
        /// Stops an Inference Recommender job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceRecommendationsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopInferenceRecommendationsJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopInferenceRecommendationsJob">REST API Reference for StopInferenceRecommendationsJob Operation</seealso>
        Task<StopInferenceRecommendationsJobResponse> StopInferenceRecommendationsJobAsync(StopInferenceRecommendationsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopLabelingJob



        /// <summary>
        /// Stops a running labeling job. A job that is stopped cannot be restarted. Any results
        /// obtained before the job is stopped are placed in the Amazon S3 output bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLabelingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        Task<StopLabelingJobResponse> StopLabelingJobAsync(StopLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopMonitoringSchedule



        /// <summary>
        /// Stops a previously started monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopMonitoringSchedule">REST API Reference for StopMonitoringSchedule Operation</seealso>
        Task<StopMonitoringScheduleResponse> StopMonitoringScheduleAsync(StopMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopNotebookInstance



        /// <summary>
        /// Terminates the ML compute instance. Before terminating the instance, Amazon SageMaker
        /// disconnects the ML storage volume from it. Amazon SageMaker preserves the ML storage
        /// volume. Amazon SageMaker stops charging you for the ML compute instance when you call
        /// <code>StopNotebookInstance</code>.
        /// 
        ///  
        /// <para>
        /// To access data on the ML storage volume for a notebook instance that has been terminated,
        /// call the <code>StartNotebookInstance</code> API. <code>StartNotebookInstance</code>
        /// launches another ML compute instance, configures it, and attaches the preserved ML
        /// storage volume so you can continue your work. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        Task<StopNotebookInstanceResponse> StopNotebookInstanceAsync(StopNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopPipelineExecution



        /// <summary>
        /// Stops a pipeline execution.
        /// 
        ///  
        /// <para>
        ///  <b>Callback Step</b> 
        /// </para>
        ///  
        /// <para>
        /// A pipeline execution won't stop while a callback step is running. When you call <code>StopPipelineExecution</code>
        /// on a pipeline execution with a running callback step, SageMaker Pipelines sends an
        /// additional Amazon SQS message to the specified SQS queue. The body of the SQS message
        /// contains a "Status" field which is set to "Stopping".
        /// </para>
        ///  
        /// <para>
        /// You should add logic to your Amazon SQS message consumer to take any needed action
        /// (for example, resource cleanup) upon receipt of the message followed by a call to
        /// <code>SendPipelineExecutionStepSuccess</code> or <code>SendPipelineExecutionStepFailure</code>.
        /// </para>
        ///  
        /// <para>
        /// Only when SageMaker Pipelines receives one of these calls will it stop the pipeline
        /// execution.
        /// </para>
        ///  
        /// <para>
        ///  <b>Lambda Step</b> 
        /// </para>
        ///  
        /// <para>
        /// A pipeline execution can't be stopped while a lambda step is running because the Lambda
        /// function invoked by the lambda step can't be stopped. If you attempt to stop the execution
        /// while the Lambda function is running, the pipeline waits for the Lambda function to
        /// finish or until the timeout is hit, whichever occurs first, and then stops. If the
        /// Lambda function finishes, the pipeline execution status is <code>Stopped</code>. If
        /// the timeout is hit the pipeline execution status is <code>Failed</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopPipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopPipelineExecution">REST API Reference for StopPipelineExecution Operation</seealso>
        Task<StopPipelineExecutionResponse> StopPipelineExecutionAsync(StopPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopProcessingJob



        /// <summary>
        /// Stops a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopProcessingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopProcessingJob">REST API Reference for StopProcessingJob Operation</seealso>
        Task<StopProcessingJobResponse> StopProcessingJobAsync(StopProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTrainingJob



        /// <summary>
        /// Stops a training job. To stop a job, Amazon SageMaker sends the algorithm the <code>SIGTERM</code>
        /// signal, which delays job termination for 120 seconds. Algorithms might use this 120-second
        /// window to save the model artifacts, so the results of the training is not lost. 
        /// 
        ///  
        /// <para>
        /// When it receives a <code>StopTrainingJob</code> request, Amazon SageMaker changes
        /// the status of the job to <code>Stopping</code>. After Amazon SageMaker stops the job,
        /// it sets the status to <code>Stopped</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        Task<StopTrainingJobResponse> StopTrainingJobAsync(StopTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTransformJob



        /// <summary>
        /// Stops a transform job.
        /// 
        ///  
        /// <para>
        /// When Amazon SageMaker receives a <code>StopTransformJob</code> request, the status
        /// of the job changes to <code>Stopping</code>. After Amazon SageMaker stops the job,
        /// the status is set to <code>Stopped</code>. When you stop a transform job before it
        /// is completed, Amazon SageMaker doesn't store the job's output in Amazon S3.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        Task<StopTransformJobResponse> StopTransformJobAsync(StopTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAction



        /// <summary>
        /// Updates an action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateAction">REST API Reference for UpdateAction Operation</seealso>
        Task<UpdateActionResponse> UpdateActionAsync(UpdateActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAppImageConfig



        /// <summary>
        /// Updates the properties of an AppImageConfig.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppImageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateAppImageConfig">REST API Reference for UpdateAppImageConfig Operation</seealso>
        Task<UpdateAppImageConfigResponse> UpdateAppImageConfigAsync(UpdateAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateArtifact



        /// <summary>
        /// Updates an artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateArtifact">REST API Reference for UpdateArtifact Operation</seealso>
        Task<UpdateArtifactResponse> UpdateArtifactAsync(UpdateArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCodeRepository



        /// <summary>
        /// Updates the specified Git repository with the specified values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        Task<UpdateCodeRepositoryResponse> UpdateCodeRepositoryAsync(UpdateCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContext



        /// <summary>
        /// Updates a context.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateContext">REST API Reference for UpdateContext Operation</seealso>
        Task<UpdateContextResponse> UpdateContextAsync(UpdateContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDeviceFleet



        /// <summary>
        /// Updates a fleet of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeviceFleet service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDeviceFleet">REST API Reference for UpdateDeviceFleet Operation</seealso>
        Task<UpdateDeviceFleetResponse> UpdateDeviceFleetAsync(UpdateDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDevices



        /// <summary>
        /// Updates one or more devices in a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDevices service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDevices">REST API Reference for UpdateDevices Operation</seealso>
        Task<UpdateDevicesResponse> UpdateDevicesAsync(UpdateDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDomain



        /// <summary>
        /// Updates the default settings for new user profiles in the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEndpoint



        /// <summary>
        /// Deploys the new <code>EndpointConfig</code> specified in the request, switches to
        /// using newly created endpoint, and then deletes resources provisioned for the endpoint
        /// using the previous <code>EndpointConfig</code> (there is no availability loss). 
        /// 
        ///  
        /// <para>
        /// When Amazon SageMaker receives the request, it sets the endpoint status to <code>Updating</code>.
        /// After updating the endpoint, it sets the status to <code>InService</code>. To check
        /// the status of an endpoint, use the <a>DescribeEndpoint</a> API. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must not delete an <code>EndpointConfig</code> in use by an endpoint that is live
        /// or while the <code>UpdateEndpoint</code> or <code>CreateEndpoint</code> operations
        /// are being performed on the endpoint. To update an endpoint, you must create a new
        /// <code>EndpointConfig</code>.
        /// </para>
        ///  
        /// <para>
        /// If you delete the <code>EndpointConfig</code> of an endpoint that is active or being
        /// created or updated you may lose visibility into the instance type the endpoint is
        /// using. The endpoint must be deleted in order to stop incurring charges.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEndpointWeightsAndCapacities



        /// <summary>
        /// Updates variant weight of one or more variants associated with an existing endpoint,
        /// or capacity of one variant associated with an existing endpoint. When it receives
        /// the request, Amazon SageMaker sets the endpoint status to <code>Updating</code>. After
        /// updating the endpoint, it sets the status to <code>InService</code>. To check the
        /// status of an endpoint, use the <a>DescribeEndpoint</a> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEndpointWeightsAndCapacities service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        Task<UpdateEndpointWeightsAndCapacitiesResponse> UpdateEndpointWeightsAndCapacitiesAsync(UpdateEndpointWeightsAndCapacitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateExperiment



        /// <summary>
        /// Adds, updates, or removes the description of an experiment. Updates the display name
        /// of an experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        Task<UpdateExperimentResponse> UpdateExperimentAsync(UpdateExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateImage



        /// <summary>
        /// Updates the properties of a SageMaker image. To change the image's tags, use the <a>AddTags</a>
        /// and <a>DeleteTags</a> APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateImage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateImage">REST API Reference for UpdateImage Operation</seealso>
        Task<UpdateImageResponse> UpdateImageAsync(UpdateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateModelPackage



        /// <summary>
        /// Updates a versioned model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateModelPackage">REST API Reference for UpdateModelPackage Operation</seealso>
        Task<UpdateModelPackageResponse> UpdateModelPackageAsync(UpdateModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMonitoringSchedule



        /// <summary>
        /// Updates a previously created schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateMonitoringSchedule">REST API Reference for UpdateMonitoringSchedule Operation</seealso>
        Task<UpdateMonitoringScheduleResponse> UpdateMonitoringScheduleAsync(UpdateMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotebookInstance



        /// <summary>
        /// Updates a notebook instance. NotebookInstance updates include upgrading or downgrading
        /// the ML compute instance used for your notebook instance to accommodate changes in
        /// your workload requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        Task<UpdateNotebookInstanceResponse> UpdateNotebookInstanceAsync(UpdateNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotebookInstanceLifecycleConfig



        /// <summary>
        /// Updates a notebook instance lifecycle configuration created with the <a>CreateNotebookInstanceLifecycleConfig</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstanceLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        Task<UpdateNotebookInstanceLifecycleConfigResponse> UpdateNotebookInstanceLifecycleConfigAsync(UpdateNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePipeline



        /// <summary>
        /// Updates a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePipelineExecution



        /// <summary>
        /// Updates a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipelineExecution">REST API Reference for UpdatePipelineExecution Operation</seealso>
        Task<UpdatePipelineExecutionResponse> UpdatePipelineExecutionAsync(UpdatePipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProject



        /// <summary>
        /// Updates a machine learning (ML) project that is created from a template that sets
        /// up an ML pipeline from training to deploying an approved model.
        /// 
        ///  <note> 
        /// <para>
        /// You must not update a project that is in use. If you update the <code>ServiceCatalogProvisioningUpdateDetails</code>
        /// of a project that is active or being created, or updated, you may lose resources already
        /// created by the project.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrainingJob



        /// <summary>
        /// Update a model training job to request a new Debugger profiling configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrainingJob">REST API Reference for UpdateTrainingJob Operation</seealso>
        Task<UpdateTrainingJobResponse> UpdateTrainingJobAsync(UpdateTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrial



        /// <summary>
        /// Updates the display name of a trial.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrial">REST API Reference for UpdateTrial Operation</seealso>
        Task<UpdateTrialResponse> UpdateTrialAsync(UpdateTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrialComponent



        /// <summary>
        /// Updates one or more properties of a trial component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrialComponent">REST API Reference for UpdateTrialComponent Operation</seealso>
        Task<UpdateTrialComponentResponse> UpdateTrialComponentAsync(UpdateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserProfile



        /// <summary>
        /// Updates a user profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkforce



        /// <summary>
        /// Use this operation to update your workforce. You can use this operation to require
        /// that workers use specific IP addresses to work on tasks and to update your OpenID
        /// Connect (OIDC) Identity Provider (IdP) workforce configuration.
        /// 
        ///  
        /// <para>
        ///  Use <code>SourceIpConfig</code> to restrict worker access to tasks to a specific
        /// range of IP addresses. You specify allowed IP addresses by creating a list of up to
        /// ten <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>.
        /// By default, a workforce isn't restricted to specific IP addresses. If you specify
        /// a range of IP addresses, workers who attempt to access tasks using any IP address
        /// outside the specified range are denied and get a <code>Not Found</code> error message
        /// on the worker portal.
        /// </para>
        ///  
        /// <para>
        /// Use <code>OidcConfig</code> to update the configuration of a workforce created using
        /// your own OIDC IdP. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can only update your OIDC IdP configuration when there are no work teams associated
        /// with your workforce. You can delete work teams using the operation.
        /// </para>
        ///  </important> 
        /// <para>
        /// After restricting access to a range of IP addresses or updating your OIDC IdP configuration
        /// with this operation, you can view details about your update workforce using the operation.
        /// </para>
        ///  <important> 
        /// <para>
        /// This operation only applies to private workforces.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkforce service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkforce">REST API Reference for UpdateWorkforce Operation</seealso>
        Task<UpdateWorkforceResponse> UpdateWorkforceAsync(UpdateWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkteam



        /// <summary>
        /// Updates an existing work team with new member definitions or description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        Task<UpdateWorkteamResponse> UpdateWorkteamAsync(UpdateWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}