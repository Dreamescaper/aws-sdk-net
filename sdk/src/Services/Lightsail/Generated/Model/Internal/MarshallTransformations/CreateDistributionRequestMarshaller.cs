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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDistribution Request Marshaller
    /// </summary>       
    public class CreateDistributionRequestMarshaller : IMarshaller<IRequest, CreateDistributionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDistributionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDistributionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.CreateDistribution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBundleId())
                {
                    context.Writer.WritePropertyName("bundleId");
                    context.Writer.Write(publicRequest.BundleId);
                }

                if(publicRequest.IsSetCacheBehaviors())
                {
                    context.Writer.WritePropertyName("cacheBehaviors");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCacheBehaviorsListValue in publicRequest.CacheBehaviors)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CacheBehaviorPerPathMarshaller.Instance;
                        marshaller.Marshall(publicRequestCacheBehaviorsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCacheBehaviorSettings())
                {
                    context.Writer.WritePropertyName("cacheBehaviorSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = CacheSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CacheBehaviorSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCertificateName())
                {
                    context.Writer.WritePropertyName("certificateName");
                    context.Writer.Write(publicRequest.CertificateName);
                }

                if(publicRequest.IsSetDefaultCacheBehavior())
                {
                    context.Writer.WritePropertyName("defaultCacheBehavior");
                    context.Writer.WriteObjectStart();

                    var marshaller = CacheBehaviorMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DefaultCacheBehavior, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDistributionName())
                {
                    context.Writer.WritePropertyName("distributionName");
                    context.Writer.Write(publicRequest.DistributionName);
                }

                if(publicRequest.IsSetIpAddressType())
                {
                    context.Writer.WritePropertyName("ipAddressType");
                    context.Writer.Write(publicRequest.IpAddressType);
                }

                if(publicRequest.IsSetOrigin())
                {
                    context.Writer.WritePropertyName("origin");
                    context.Writer.WriteObjectStart();

                    var marshaller = InputOriginMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Origin, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetViewerMinimumTlsProtocolVersion())
                {
                    context.Writer.WritePropertyName("viewerMinimumTlsProtocolVersion");
                    context.Writer.Write(publicRequest.ViewerMinimumTlsProtocolVersion);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDistributionRequestMarshaller _instance = new CreateDistributionRequestMarshaller();        

        internal static CreateDistributionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDistributionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}