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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FleetCapabilities Object
    /// </summary>  
    public class FleetCapabilitiesUnmarshaller : IUnmarshaller<FleetCapabilities, XmlUnmarshallerContext>, IUnmarshaller<FleetCapabilities, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FleetCapabilities IUnmarshaller<FleetCapabilities, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public FleetCapabilities Unmarshall(JsonUnmarshallerContext context)
        {
            FleetCapabilities unmarshalledObject = new FleetCapabilities();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("amounts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FleetAmountCapability, FleetAmountCapabilityUnmarshaller>(FleetAmountCapabilityUnmarshaller.Instance);
                    unmarshalledObject.Amounts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("attributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FleetAttributeCapability, FleetAttributeCapabilityUnmarshaller>(FleetAttributeCapabilityUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FleetCapabilitiesUnmarshaller _instance = new FleetCapabilitiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FleetCapabilitiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}