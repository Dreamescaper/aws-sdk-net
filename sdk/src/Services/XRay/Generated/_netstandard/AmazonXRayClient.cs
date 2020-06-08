/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.XRay.Model;
using Amazon.XRay.Model.Internal.MarshallTransformations;
using Amazon.XRay.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.XRay
{
    /// <summary>
    /// Implementation for accessing XRay
    ///
    /// AWS X-Ray provides APIs for managing debug traces and retrieving service maps and
    /// other data created by processing those traces.
    /// </summary>
    public partial class AmazonXRayClient : AmazonServiceClient, IAmazonXRay
    {
        private static IServiceMetadata serviceMetadata = new AmazonXRayMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonXRayClient with the credentials loaded from the application's
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
        public AmazonXRayClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonXRayConfig()) { }

        /// <summary>
        /// Constructs AmazonXRayClient with the credentials loaded from the application's
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
        public AmazonXRayClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonXRayConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonXRayClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonXRayClient Configuration Object</param>
        public AmazonXRayClient(AmazonXRayConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonXRayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonXRayClient(AWSCredentials credentials)
            : this(credentials, new AmazonXRayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonXRayClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonXRayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Credentials and an
        /// AmazonXRayClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonXRayClient Configuration Object</param>
        public AmazonXRayClient(AWSCredentials credentials, AmazonXRayConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonXRayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonXRayConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonXRayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonXRayClient Configuration Object</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonXRayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonXRayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonXRayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonXRayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonXRayClient Configuration Object</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonXRayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

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


        #region  BatchGetTraces

        internal virtual BatchGetTracesResponse BatchGetTraces(BatchGetTracesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetTracesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTracesResponseUnmarshaller.Instance;

            return Invoke<BatchGetTracesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of traces specified by ID. Each trace is a collection of segment
        /// documents that originates from a single request. Use <code>GetTraceSummaries</code>
        /// to get a list of trace IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTraces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetTraces service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/BatchGetTraces">REST API Reference for BatchGetTraces Operation</seealso>
        public virtual Task<BatchGetTracesResponse> BatchGetTracesAsync(BatchGetTracesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetTracesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTracesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetTracesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGroup

        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a group resource with a name and a filter expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSamplingRule

        internal virtual CreateSamplingRuleResponse CreateSamplingRule(CreateSamplingRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<CreateSamplingRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates a rule to control sampling behavior for instrumented applications. Services
        /// retrieve rules with <a>GetSamplingRules</a>, and evaluate each rule in ascending order
        /// of <i>priority</i> for each request. If a rule matches, the service records a trace,
        /// borrowing it from the reservoir size. After 10 seconds, the service reports back to
        /// X-Ray with <a>GetSamplingTargets</a> to get updated versions of each in-use rule.
        /// The updated rule contains a trace quota that the service can use instead of borrowing
        /// from the reservoir.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSamplingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.RuleLimitExceededException">
        /// You have reached the maximum number of sampling rules.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CreateSamplingRule">REST API Reference for CreateSamplingRule Operation</seealso>
        public virtual Task<CreateSamplingRuleResponse> CreateSamplingRuleAsync(CreateSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSamplingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSamplingRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup

        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a group resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSamplingRule

        internal virtual DeleteSamplingRuleResponse DeleteSamplingRule(DeleteSamplingRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteSamplingRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a sampling rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSamplingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteSamplingRule">REST API Reference for DeleteSamplingRule Operation</seealso>
        public virtual Task<DeleteSamplingRuleResponse> DeleteSamplingRuleAsync(DeleteSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSamplingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSamplingRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEncryptionConfig

        internal virtual GetEncryptionConfigResponse GetEncryptionConfig(GetEncryptionConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<GetEncryptionConfigResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current encryption configuration for X-Ray data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEncryptionConfig service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetEncryptionConfig">REST API Reference for GetEncryptionConfig Operation</seealso>
        public virtual Task<GetEncryptionConfigResponse> GetEncryptionConfigAsync(GetEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetEncryptionConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGroup

        internal virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }



        /// <summary>
        /// Retrieves group resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGroups

        internal virtual GetGroupsResponse GetGroups(GetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupsResponseUnmarshaller.Instance;

            return Invoke<GetGroupsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all active group details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroups service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroups">REST API Reference for GetGroups Operation</seealso>
        public virtual Task<GetGroupsResponse> GetGroupsAsync(GetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSamplingRules

        internal virtual GetSamplingRulesResponse GetSamplingRules(GetSamplingRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingRulesResponseUnmarshaller.Instance;

            return Invoke<GetSamplingRulesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all sampling rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSamplingRules service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingRules">REST API Reference for GetSamplingRules Operation</seealso>
        public virtual Task<GetSamplingRulesResponse> GetSamplingRulesAsync(GetSamplingRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingRulesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSamplingRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSamplingStatisticSummaries

        internal virtual GetSamplingStatisticSummariesResponse GetSamplingStatisticSummaries(GetSamplingStatisticSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingStatisticSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingStatisticSummariesResponseUnmarshaller.Instance;

            return Invoke<GetSamplingStatisticSummariesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about recent sampling results for all sampling rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingStatisticSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSamplingStatisticSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingStatisticSummaries">REST API Reference for GetSamplingStatisticSummaries Operation</seealso>
        public virtual Task<GetSamplingStatisticSummariesResponse> GetSamplingStatisticSummariesAsync(GetSamplingStatisticSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingStatisticSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingStatisticSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSamplingStatisticSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSamplingTargets

        internal virtual GetSamplingTargetsResponse GetSamplingTargets(GetSamplingTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingTargetsResponseUnmarshaller.Instance;

            return Invoke<GetSamplingTargetsResponse>(request, options);
        }



        /// <summary>
        /// Requests a sampling quota for rules that the service is using to sample requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSamplingTargets service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingTargets">REST API Reference for GetSamplingTargets Operation</seealso>
        public virtual Task<GetSamplingTargetsResponse> GetSamplingTargetsAsync(GetSamplingTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSamplingTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceGraph

        internal virtual GetServiceGraphResponse GetServiceGraph(GetServiceGraphRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceGraphResponseUnmarshaller.Instance;

            return Invoke<GetServiceGraphResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a document that describes services that process incoming requests, and downstream
        /// services that they call as a result. Root services process incoming requests and make
        /// calls to downstream services. Root services are applications that use the <a href="https://docs.aws.amazon.com/xray/index.html">AWS
        /// X-Ray SDK</a>. Downstream services can be other applications, AWS resources, HTTP
        /// web APIs, or SQL databases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetServiceGraph">REST API Reference for GetServiceGraph Operation</seealso>
        public virtual Task<GetServiceGraphResponse> GetServiceGraphAsync(GetServiceGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceGraphResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceGraphResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTimeSeriesServiceStatistics

        internal virtual GetTimeSeriesServiceStatisticsResponse GetTimeSeriesServiceStatistics(GetTimeSeriesServiceStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTimeSeriesServiceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeSeriesServiceStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetTimeSeriesServiceStatisticsResponse>(request, options);
        }



        /// <summary>
        /// Get an aggregation of service statistics defined by a specific time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTimeSeriesServiceStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTimeSeriesServiceStatistics service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTimeSeriesServiceStatistics">REST API Reference for GetTimeSeriesServiceStatistics Operation</seealso>
        public virtual Task<GetTimeSeriesServiceStatisticsResponse> GetTimeSeriesServiceStatisticsAsync(GetTimeSeriesServiceStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTimeSeriesServiceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeSeriesServiceStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTimeSeriesServiceStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTraceGraph

        internal virtual GetTraceGraphResponse GetTraceGraph(GetTraceGraphRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceGraphResponseUnmarshaller.Instance;

            return Invoke<GetTraceGraphResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a service graph for one or more specific trace IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTraceGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceGraph">REST API Reference for GetTraceGraph Operation</seealso>
        public virtual Task<GetTraceGraphResponse> GetTraceGraphAsync(GetTraceGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceGraphResponseUnmarshaller.Instance;

            return InvokeAsync<GetTraceGraphResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTraceSummaries

        internal virtual GetTraceSummariesResponse GetTraceSummaries(GetTraceSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceSummariesResponseUnmarshaller.Instance;

            return Invoke<GetTraceSummariesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves IDs and annotations for traces available for a specified time frame using
        /// an optional filter. To get the full traces, pass the trace IDs to <code>BatchGetTraces</code>.
        /// 
        ///  
        /// <para>
        /// A filter expression can target traced requests that hit specific service nodes or
        /// edges, have errors, or come from a known user. For example, the following filter expression
        /// targets traces that pass through <code>api.example.com</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code>service("api.example.com")</code> 
        /// </para>
        ///  
        /// <para>
        /// This filter expression finds traces that have an annotation named <code>account</code>
        /// with the value <code>12345</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code>annotation.account = "12345"</code> 
        /// </para>
        ///  
        /// <para>
        /// For a full list of indexed fields and keywords that you can use in filter expressions,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/xray-console-filters.html">Using
        /// Filter Expressions</a> in the <i>AWS X-Ray Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTraceSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceSummaries">REST API Reference for GetTraceSummaries Operation</seealso>
        public virtual Task<GetTraceSummariesResponse> GetTraceSummariesAsync(GetTraceSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<GetTraceSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEncryptionConfig

        internal virtual PutEncryptionConfigResponse PutEncryptionConfig(PutEncryptionConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<PutEncryptionConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates the encryption configuration for X-Ray data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEncryptionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEncryptionConfig service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutEncryptionConfig">REST API Reference for PutEncryptionConfig Operation</seealso>
        public virtual Task<PutEncryptionConfigResponse> PutEncryptionConfigAsync(PutEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<PutEncryptionConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutTelemetryRecords

        internal virtual PutTelemetryRecordsResponse PutTelemetryRecords(PutTelemetryRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTelemetryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTelemetryRecordsResponseUnmarshaller.Instance;

            return Invoke<PutTelemetryRecordsResponse>(request, options);
        }



        /// <summary>
        /// Used by the AWS X-Ray daemon to upload telemetry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTelemetryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTelemetryRecords service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTelemetryRecords">REST API Reference for PutTelemetryRecords Operation</seealso>
        public virtual Task<PutTelemetryRecordsResponse> PutTelemetryRecordsAsync(PutTelemetryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTelemetryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTelemetryRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<PutTelemetryRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutTraceSegments

        internal virtual PutTraceSegmentsResponse PutTraceSegments(PutTraceSegmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTraceSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTraceSegmentsResponseUnmarshaller.Instance;

            return Invoke<PutTraceSegmentsResponse>(request, options);
        }



        /// <summary>
        /// Uploads segment documents to AWS X-Ray. The <a href="https://docs.aws.amazon.com/xray/index.html">X-Ray
        /// SDK</a> generates segment documents and sends them to the X-Ray daemon, which uploads
        /// them in batches. A segment document can be a completed segment, an in-progress segment,
        /// or an array of subsegments.
        /// 
        ///  
        /// <para>
        /// Segments must include the following fields. For the full segment document schema,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/xray-api-segmentdocuments.html">AWS
        /// X-Ray Segment Documents</a> in the <i>AWS X-Ray Developer Guide</i>.
        /// </para>
        ///  <p class="title"> <b>Required Segment Document Fields</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>name</code> - The name of the service that handled the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>id</code> - A 64-bit identifier for the segment, unique among segments in the
        /// same trace, in 16 hexadecimal digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>trace_id</code> - A unique identifier that connects all segments and subsegments
        /// originating from a single client request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>start_time</code> - Time the segment or subsegment was created, in floating
        /// point seconds in epoch time, accurate to milliseconds. For example, <code>1480615200.010</code>
        /// or <code>1.480615200010E9</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>end_time</code> - Time the segment or subsegment was closed. For example, <code>1480615200.090</code>
        /// or <code>1.480615200090E9</code>. Specify either an <code>end_time</code> or <code>in_progress</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>in_progress</code> - Set to <code>true</code> instead of specifying an <code>end_time</code>
        /// to record that a segment has been started, but is not complete. Send an in progress
        /// segment when your application receives a request that will take a long time to serve,
        /// to trace the fact that the request was received. When the response is sent, send the
        /// complete segment to overwrite the in-progress segment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A <code>trace_id</code> consists of three numbers separated by hyphens. For example,
        /// 1-58406520-a006649127e371903a2de979. This includes:
        /// </para>
        ///  <p class="title"> <b>Trace ID Format</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The version number, i.e. <code>1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The time of the original request, in Unix epoch time, in 8 hexadecimal digits. For
        /// example, 10:00AM December 2nd, 2016 PST in epoch time is <code>1480615200</code> seconds,
        /// or <code>58406520</code> in hexadecimal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A 96-bit identifier for the trace, globally unique, in 24 hexadecimal digits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTraceSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTraceSegments service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTraceSegments">REST API Reference for PutTraceSegments Operation</seealso>
        public virtual Task<PutTraceSegmentsResponse> PutTraceSegmentsAsync(PutTraceSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTraceSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTraceSegmentsResponseUnmarshaller.Instance;

            return InvokeAsync<PutTraceSegmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroup

        internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates a group resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSamplingRule

        internal virtual UpdateSamplingRuleResponse UpdateSamplingRule(UpdateSamplingRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateSamplingRuleResponse>(request, options);
        }



        /// <summary>
        /// Modifies a sampling rule's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSamplingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateSamplingRule">REST API Reference for UpdateSamplingRule Operation</seealso>
        public virtual Task<UpdateSamplingRuleResponse> UpdateSamplingRuleAsync(UpdateSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSamplingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSamplingRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}