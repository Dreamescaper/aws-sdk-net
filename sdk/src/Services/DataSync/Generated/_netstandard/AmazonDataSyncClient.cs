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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DataSync.Model;
using Amazon.DataSync.Model.Internal.MarshallTransformations;
using Amazon.DataSync.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DataSync
{
    /// <summary>
    /// Implementation for accessing DataSync
    ///
    /// DataSync 
    /// <para>
    /// DataSync is a managed data transfer service that makes it simpler for you to automate
    /// moving data between on-premises storage and Amazon Simple Storage Service (Amazon
    /// S3) or Amazon Elastic File System (Amazon EFS). 
    /// </para>
    ///  
    /// <para>
    /// This API interface reference for DataSync contains documentation for a programming
    /// interface that you can use to manage DataSync.
    /// </para>
    /// </summary>
    public partial class AmazonDataSyncClient : AmazonServiceClient, IAmazonDataSync
    {
        private static IServiceMetadata serviceMetadata = new AmazonDataSyncMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonDataSyncClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataSyncConfig()) { }

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataSyncConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(AmazonDataSyncConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDataSyncClient(AWSCredentials credentials)
            : this(credentials, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDataSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials and an
        /// AmazonDataSyncClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(AWSCredentials credentials, AmazonDataSyncConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataSyncConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IDataSyncPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDataSyncPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DataSyncPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CancelTaskExecution

        internal virtual CancelTaskExecutionResponse CancelTaskExecution(CancelTaskExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelTaskExecutionResponse>(request, options);
        }



        /// <summary>
        /// Cancels execution of a task. 
        /// 
        ///  
        /// <para>
        /// When you cancel a task execution, the transfer of some files is abruptly interrupted.
        /// The contents of files that are transferred to the destination might be incomplete
        /// or inconsistent with the source files. However, if you start a new task execution
        /// on the same task and you allow the task execution to complete, file content on the
        /// destination is complete and consistent. This applies to other unexpected failures
        /// that interrupt a task execution. In all of these cases, DataSync successfully complete
        /// the transfer when you start the next task execution.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        public virtual Task<CancelTaskExecutionResponse> CancelTaskExecutionAsync(CancelTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelTaskExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAgent

        internal virtual CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return Invoke<CreateAgentResponse>(request, options);
        }



        /// <summary>
        /// Activates an DataSync agent that you have deployed on your host. The activation process
        /// associates your agent with your account. In the activation process, you specify information
        /// such as the Amazon Web Services Region that you want to activate the agent in. You
        /// activate the agent in the Amazon Web Services Region where your target locations (in
        /// Amazon S3 or Amazon EFS) reside. Your tasks are created in this Amazon Web Services
        /// Region.
        /// 
        ///  
        /// <para>
        /// You can activate the agent in a VPC (virtual private cloud) or provide the agent access
        /// to a VPC endpoint so you can run tasks without going over the public internet.
        /// </para>
        ///  
        /// <para>
        /// You can use an agent for more than one location. If a task uses multiple agents, all
        /// of them need to have status AVAILABLE for the task to run. If you use multiple agents
        /// for a source location, the status of all the agents must be AVAILABLE for the task
        /// to run. 
        /// </para>
        ///  
        /// <para>
        /// Agents are automatically updated by Amazon Web Services on a regular basis, using
        /// a mechanism that ensures minimal interruption to your tasks.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        public virtual Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationEfs

        internal virtual CreateLocationEfsResponse CreateLocationEfs(CreateLocationEfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationEfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationEfsResponse>(request, options);
        }



        /// <summary>
        /// Creates an endpoint for an Amazon EFS file system that DataSync can access for a transfer.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html">Creating
        /// a location for Amazon EFS</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationEfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        public virtual Task<CreateLocationEfsResponse> CreateLocationEfsAsync(CreateLocationEfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationEfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationEfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationFsxLustre

        internal virtual CreateLocationFsxLustreResponse CreateLocationFsxLustre(CreateLocationFsxLustreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxLustreResponseUnmarshaller.Instance;

            return Invoke<CreateLocationFsxLustreResponse>(request, options);
        }



        /// <summary>
        /// Creates an endpoint for an Amazon FSx for Lustre file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxLustre service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationFsxLustre service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxLustre">REST API Reference for CreateLocationFsxLustre Operation</seealso>
        public virtual Task<CreateLocationFsxLustreResponse> CreateLocationFsxLustreAsync(CreateLocationFsxLustreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxLustreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationFsxLustreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationFsxOpenZfs

        internal virtual CreateLocationFsxOpenZfsResponse CreateLocationFsxOpenZfs(CreateLocationFsxOpenZfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationFsxOpenZfsResponse>(request, options);
        }



        /// <summary>
        /// Creates an endpoint for an Amazon FSx for OpenZFS file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOpenZfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationFsxOpenZfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOpenZfs">REST API Reference for CreateLocationFsxOpenZfs Operation</seealso>
        public virtual Task<CreateLocationFsxOpenZfsResponse> CreateLocationFsxOpenZfsAsync(CreateLocationFsxOpenZfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationFsxOpenZfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationFsxWindows

        internal virtual CreateLocationFsxWindowsResponse CreateLocationFsxWindows(CreateLocationFsxWindowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxWindowsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationFsxWindowsResponse>(request, options);
        }



        /// <summary>
        /// Creates an endpoint for an Amazon FSx for Windows File Server file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxWindows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationFsxWindows service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxWindows">REST API Reference for CreateLocationFsxWindows Operation</seealso>
        public virtual Task<CreateLocationFsxWindowsResponse> CreateLocationFsxWindowsAsync(CreateLocationFsxWindowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxWindowsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationFsxWindowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationHdfs

        internal virtual CreateLocationHdfsResponse CreateLocationHdfs(CreateLocationHdfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationHdfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationHdfsResponse>(request, options);
        }



        /// <summary>
        /// Creates an endpoint for a Hadoop Distributed File System (HDFS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationHdfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationHdfs">REST API Reference for CreateLocationHdfs Operation</seealso>
        public virtual Task<CreateLocationHdfsResponse> CreateLocationHdfsAsync(CreateLocationHdfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationHdfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationHdfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationNfs

        internal virtual CreateLocationNfsResponse CreateLocationNfs(CreateLocationNfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationNfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationNfsResponse>(request, options);
        }



        /// <summary>
        /// Defines a file system on a Network File System (NFS) server that can be read from
        /// or written to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationNfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        public virtual Task<CreateLocationNfsResponse> CreateLocationNfsAsync(CreateLocationNfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationNfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationNfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationObjectStorage

        internal virtual CreateLocationObjectStorageResponse CreateLocationObjectStorage(CreateLocationObjectStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationObjectStorageResponseUnmarshaller.Instance;

            return Invoke<CreateLocationObjectStorageResponse>(request, options);
        }



        /// <summary>
        /// Creates an endpoint for a self-managed object storage bucket. For more information
        /// about self-managed object storage locations, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html">Creating
        /// a location for object storage</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationObjectStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationObjectStorage">REST API Reference for CreateLocationObjectStorage Operation</seealso>
        public virtual Task<CreateLocationObjectStorageResponse> CreateLocationObjectStorageAsync(CreateLocationObjectStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationObjectStorageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationObjectStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationS3

        internal virtual CreateLocationS3Response CreateLocationS3(CreateLocationS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationS3ResponseUnmarshaller.Instance;

            return Invoke<CreateLocationS3Response>(request, options);
        }



        /// <summary>
        /// Creates an endpoint for an Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-locations-cli.html#create-location-s3-cli">Create
        /// an Amazon S3 location</a> in the <i>DataSync User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        public virtual Task<CreateLocationS3Response> CreateLocationS3Async(CreateLocationS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationS3ResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationS3Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationSmb

        internal virtual CreateLocationSmbResponse CreateLocationSmb(CreateLocationSmbRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationSmbResponseUnmarshaller.Instance;

            return Invoke<CreateLocationSmbResponse>(request, options);
        }



        /// <summary>
        /// Defines a file system on a Server Message Block (SMB) server that can be read from
        /// or written to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationSmb service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationSmb">REST API Reference for CreateLocationSmb Operation</seealso>
        public virtual Task<CreateLocationSmbResponse> CreateLocationSmbAsync(CreateLocationSmbRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationSmbResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationSmbResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTask

        internal virtual CreateTaskResponse CreateTask(CreateTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return Invoke<CreateTaskResponse>(request, options);
        }



        /// <summary>
        /// Creates a task.
        /// 
        ///  
        /// <para>
        /// A task includes a source location and a destination location, and a configuration
        /// that specifies how data is transferred. A task always transfers data from the source
        /// location to the destination location. The configuration specifies options such as
        /// task scheduling, bandwidth limits, etc. A task is the complete definition of a data
        /// transfer.
        /// </para>
        ///  
        /// <para>
        /// When you create a task that transfers data between Amazon Web Services services in
        /// different Amazon Web Services Regions, one of the two locations that you specify must
        /// reside in the Region where DataSync is being used. The other location must be specified
        /// in a different Region.
        /// </para>
        ///  
        /// <para>
        /// You can transfer data between commercial Amazon Web Services Regions except for China,
        /// or between Amazon Web Services GovCloud (US) Regions.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you use DataSync to copy files or objects between Amazon Web Services Regions,
        /// you pay for data transfer between Regions. This is billed as data transfer OUT from
        /// your source Region to your destination Region. For more information, see <a href="http://aws.amazon.com/ec2/pricing/on-demand/#Data_Transfer">Data
        /// Transfer pricing</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        public virtual Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAgent

        internal virtual DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentResponse>(request, options);
        }



        /// <summary>
        /// Deletes an agent. To specify which agent to delete, use the Amazon Resource Name (ARN)
        /// of the agent in your request. The operation disassociates the agent from your Amazon
        /// Web Services account. However, it doesn't delete the agent virtual machine (VM) from
        /// your on-premises environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        public virtual Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLocation

        internal virtual DeleteLocationResponse DeleteLocation(DeleteLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return Invoke<DeleteLocationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the configuration of a location used by DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLocation service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        public virtual Task<DeleteLocationResponse> DeleteLocationAsync(DeleteLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTask

        internal virtual DeleteTaskResponse DeleteTask(DeleteTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteTaskResponse>(request, options);
        }



        /// <summary>
        /// Deletes a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        public virtual Task<DeleteTaskResponse> DeleteTaskAsync(DeleteTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAgent

        internal virtual DescribeAgentResponse DescribeAgent(DescribeAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentResponseUnmarshaller.Instance;

            return Invoke<DescribeAgentResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata such as the name, the network interfaces, and the status (that is,
        /// whether the agent is running or not) for an agent. To specify which agent to describe,
        /// use the Amazon Resource Name (ARN) of the agent in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        public virtual Task<DescribeAgentResponse> DescribeAgentAsync(DescribeAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationEfs

        internal virtual DescribeLocationEfsResponse DescribeLocationEfs(DescribeLocationEfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationEfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationEfsResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata about your DataSync location for an Amazon EFS file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationEfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        public virtual Task<DescribeLocationEfsResponse> DescribeLocationEfsAsync(DescribeLocationEfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationEfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationEfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationFsxLustre

        internal virtual DescribeLocationFsxLustreResponse DescribeLocationFsxLustre(DescribeLocationFsxLustreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxLustreResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationFsxLustreResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata about an Amazon FSx for Lustre location, such as information about
        /// its path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxLustre service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationFsxLustre service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxLustre">REST API Reference for DescribeLocationFsxLustre Operation</seealso>
        public virtual Task<DescribeLocationFsxLustreResponse> DescribeLocationFsxLustreAsync(DescribeLocationFsxLustreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxLustreResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationFsxLustreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationFsxOpenZfs

        internal virtual DescribeLocationFsxOpenZfsResponse DescribeLocationFsxOpenZfs(DescribeLocationFsxOpenZfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationFsxOpenZfsResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata about an Amazon FSx for OpenZFS location, such as information about
        /// its path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOpenZfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationFsxOpenZfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOpenZfs">REST API Reference for DescribeLocationFsxOpenZfs Operation</seealso>
        public virtual Task<DescribeLocationFsxOpenZfsResponse> DescribeLocationFsxOpenZfsAsync(DescribeLocationFsxOpenZfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationFsxOpenZfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationFsxWindows

        internal virtual DescribeLocationFsxWindowsResponse DescribeLocationFsxWindows(DescribeLocationFsxWindowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxWindowsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationFsxWindowsResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata about an Amazon FSx for Windows File Server location, such as information
        /// about its path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxWindows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationFsxWindows service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxWindows">REST API Reference for DescribeLocationFsxWindows Operation</seealso>
        public virtual Task<DescribeLocationFsxWindowsResponse> DescribeLocationFsxWindowsAsync(DescribeLocationFsxWindowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxWindowsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationFsxWindowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationHdfs

        internal virtual DescribeLocationHdfsResponse DescribeLocationHdfs(DescribeLocationHdfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationHdfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationHdfsResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata, such as the authentication information about the Hadoop Distributed
        /// File System (HDFS) location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationHdfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationHdfs">REST API Reference for DescribeLocationHdfs Operation</seealso>
        public virtual Task<DescribeLocationHdfsResponse> DescribeLocationHdfsAsync(DescribeLocationHdfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationHdfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationHdfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationNfs

        internal virtual DescribeLocationNfsResponse DescribeLocationNfs(DescribeLocationNfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationNfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationNfsResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata, such as the path information, about an NFS location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationNfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        public virtual Task<DescribeLocationNfsResponse> DescribeLocationNfsAsync(DescribeLocationNfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationNfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationNfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationObjectStorage

        internal virtual DescribeLocationObjectStorageResponse DescribeLocationObjectStorage(DescribeLocationObjectStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationObjectStorageResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationObjectStorageResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata about a self-managed object storage server location. For more information
        /// about self-managed object storage locations, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html">Creating
        /// a location for object storage</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationObjectStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationObjectStorage">REST API Reference for DescribeLocationObjectStorage Operation</seealso>
        public virtual Task<DescribeLocationObjectStorageResponse> DescribeLocationObjectStorageAsync(DescribeLocationObjectStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationObjectStorageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationObjectStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationS3

        internal virtual DescribeLocationS3Response DescribeLocationS3(DescribeLocationS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationS3ResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationS3Response>(request, options);
        }



        /// <summary>
        /// Returns metadata, such as bucket name, about an Amazon S3 bucket location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        public virtual Task<DescribeLocationS3Response> DescribeLocationS3Async(DescribeLocationS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationS3ResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationS3Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationSmb

        internal virtual DescribeLocationSmbResponse DescribeLocationSmb(DescribeLocationSmbRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationSmbResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationSmbResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata, such as the path and user information about an SMB location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationSmb service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationSmb">REST API Reference for DescribeLocationSmb Operation</seealso>
        public virtual Task<DescribeLocationSmbResponse> DescribeLocationSmbAsync(DescribeLocationSmbRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationSmbResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationSmbResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTask

        internal virtual DescribeTaskResponse DescribeTask(DescribeTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata about a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        public virtual Task<DescribeTaskResponse> DescribeTaskAsync(DescribeTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTaskExecution

        internal virtual DescribeTaskExecutionResponse DescribeTaskExecution(DescribeTaskExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskExecutionResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed metadata about a task that is being executed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        public virtual Task<DescribeTaskExecutionResponse> DescribeTaskExecutionAsync(DescribeTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAgents

        internal virtual ListAgentsResponse ListAgents(ListAgentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAgentsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of agents owned by an Amazon Web Services account in the Amazon Web
        /// Services Region specified in the request. The returned list is ordered by agent Amazon
        /// Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, this operation returns a maximum of 100 agents. This operation supports
        /// pagination that enables you to optionally reduce the number of agents returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more agents than are returned in a response (that is, the response returns
        /// only a truncated list of your agents), the response contains a marker that you can
        /// specify in your next request to fetch the next page of agents.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgents service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        public virtual Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLocations

        internal virtual ListLocationsResponse ListLocations(ListLocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return Invoke<ListLocationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of source and destination locations.
        /// 
        ///  
        /// <para>
        /// If you have more locations than are returned in a response (that is, the response
        /// returns only a truncated list of your agents), the response contains a token that
        /// you can specify in your next request to fetch the next page of locations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLocations service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        public virtual Task<ListLocationsResponse> ListLocationsAsync(ListLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLocationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns all the tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTaskExecutions

        internal virtual ListTaskExecutionsResponse ListTaskExecutions(ListTaskExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListTaskExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of executed tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTaskExecutions service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        public virtual Task<ListTaskExecutionsResponse> ListTaskExecutionsAsync(ListTaskExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTaskExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTasks

        internal virtual ListTasksResponse ListTasks(ListTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return Invoke<ListTasksResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTaskExecution

        internal virtual StartTaskExecutionResponse StartTaskExecution(StartTaskExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<StartTaskExecutionResponse>(request, options);
        }



        /// <summary>
        /// Starts a specific invocation of a task. A <code>TaskExecution</code> value represents
        /// an individual run of a task. Each task can have at most one <code>TaskExecution</code>
        /// at a time.
        /// 
        ///  
        /// <para>
        ///  <code>TaskExecution</code> has the following transition phases: INITIALIZING | PREPARING
        /// | TRANSFERRING | VERIFYING | SUCCESS/FAILURE. 
        /// </para>
        ///  
        /// <para>
        /// For detailed information, see the Task Execution section in the Components and Terminology
        /// topic in the <i>DataSync User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        public virtual Task<StartTaskExecutionResponse> StartTaskExecutionAsync(StartTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartTaskExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Applies a key-value pair to an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a tag from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAgent

        internal virtual UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentResponse>(request, options);
        }



        /// <summary>
        /// Updates the name of an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        public virtual Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLocationHdfs

        internal virtual UpdateLocationHdfsResponse UpdateLocationHdfs(UpdateLocationHdfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationHdfsResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationHdfsResponse>(request, options);
        }



        /// <summary>
        /// Updates some parameters of a previously created location for a Hadoop Distributed
        /// File System cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationHdfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationHdfs">REST API Reference for UpdateLocationHdfs Operation</seealso>
        public virtual Task<UpdateLocationHdfsResponse> UpdateLocationHdfsAsync(UpdateLocationHdfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationHdfsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLocationHdfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLocationNfs

        internal virtual UpdateLocationNfsResponse UpdateLocationNfs(UpdateLocationNfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationNfsResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationNfsResponse>(request, options);
        }



        /// <summary>
        /// Updates some of the parameters of a previously created location for Network File System
        /// (NFS) access. For information about creating an NFS location, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html">Creating
        /// a location for NFS</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationNfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationNfs">REST API Reference for UpdateLocationNfs Operation</seealso>
        public virtual Task<UpdateLocationNfsResponse> UpdateLocationNfsAsync(UpdateLocationNfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationNfsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLocationNfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLocationObjectStorage

        internal virtual UpdateLocationObjectStorageResponse UpdateLocationObjectStorage(UpdateLocationObjectStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationObjectStorageResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationObjectStorageResponse>(request, options);
        }



        /// <summary>
        /// Updates some of the parameters of a previously created location for self-managed object
        /// storage server access. For information about creating a self-managed object storage
        /// location, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html">Creating
        /// a location for object storage</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationObjectStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationObjectStorage">REST API Reference for UpdateLocationObjectStorage Operation</seealso>
        public virtual Task<UpdateLocationObjectStorageResponse> UpdateLocationObjectStorageAsync(UpdateLocationObjectStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationObjectStorageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLocationObjectStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLocationSmb

        internal virtual UpdateLocationSmbResponse UpdateLocationSmb(UpdateLocationSmbRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationSmbResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationSmbResponse>(request, options);
        }



        /// <summary>
        /// Updates some of the parameters of a previously created location for Server Message
        /// Block (SMB) file system access. For information about creating an SMB location, see
        /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html">Creating
        /// a location for SMB</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationSmb service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationSmb">REST API Reference for UpdateLocationSmb Operation</seealso>
        public virtual Task<UpdateLocationSmbResponse> UpdateLocationSmbAsync(UpdateLocationSmbRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationSmbResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLocationSmbResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTask

        internal virtual UpdateTaskResponse UpdateTask(UpdateTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskResponse>(request, options);
        }



        /// <summary>
        /// Updates the metadata associated with a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        public virtual Task<UpdateTaskResponse> UpdateTaskAsync(UpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTaskExecution

        internal virtual UpdateTaskExecutionResponse UpdateTaskExecution(UpdateTaskExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskExecutionResponse>(request, options);
        }



        /// <summary>
        /// Updates execution of a task.
        /// 
        ///  
        /// <para>
        /// You can modify bandwidth throttling for a task execution that is running or queued.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/working-with-task-executions.html#adjust-bandwidth-throttling">Adjusting
        /// Bandwidth Throttling for a Task Execution</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The only <code>Option</code> that can be modified by <code>UpdateTaskExecution</code>
        /// is <code> <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-BytesPerSecond">BytesPerSecond</a>
        /// </code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTaskExecution">REST API Reference for UpdateTaskExecution Operation</seealso>
        public virtual Task<UpdateTaskExecutionResponse> UpdateTaskExecutionAsync(UpdateTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTaskExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}