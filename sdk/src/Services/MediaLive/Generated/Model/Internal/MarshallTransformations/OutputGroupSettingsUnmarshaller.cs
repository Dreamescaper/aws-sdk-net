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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OutputGroupSettings Object
    /// </summary>  
    public class OutputGroupSettingsUnmarshaller : IUnmarshaller<OutputGroupSettings, XmlUnmarshallerContext>, IUnmarshaller<OutputGroupSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OutputGroupSettings IUnmarshaller<OutputGroupSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OutputGroupSettings Unmarshall(JsonUnmarshallerContext context)
        {
            OutputGroupSettings unmarshalledObject = new OutputGroupSettings();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("archiveGroupSettings", targetDepth))
                {
                    var unmarshaller = ArchiveGroupSettingsUnmarshaller.Instance;
                    unmarshalledObject.ArchiveGroupSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cmafIngestGroupSettings", targetDepth))
                {
                    var unmarshaller = CmafIngestGroupSettingsUnmarshaller.Instance;
                    unmarshalledObject.CmafIngestGroupSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("frameCaptureGroupSettings", targetDepth))
                {
                    var unmarshaller = FrameCaptureGroupSettingsUnmarshaller.Instance;
                    unmarshalledObject.FrameCaptureGroupSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hlsGroupSettings", targetDepth))
                {
                    var unmarshaller = HlsGroupSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsGroupSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mediaPackageGroupSettings", targetDepth))
                {
                    var unmarshaller = MediaPackageGroupSettingsUnmarshaller.Instance;
                    unmarshalledObject.MediaPackageGroupSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("msSmoothGroupSettings", targetDepth))
                {
                    var unmarshaller = MsSmoothGroupSettingsUnmarshaller.Instance;
                    unmarshalledObject.MsSmoothGroupSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("multiplexGroupSettings", targetDepth))
                {
                    var unmarshaller = MultiplexGroupSettingsUnmarshaller.Instance;
                    unmarshalledObject.MultiplexGroupSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rtmpGroupSettings", targetDepth))
                {
                    var unmarshaller = RtmpGroupSettingsUnmarshaller.Instance;
                    unmarshalledObject.RtmpGroupSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("udpGroupSettings", targetDepth))
                {
                    var unmarshaller = UdpGroupSettingsUnmarshaller.Instance;
                    unmarshalledObject.UdpGroupSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OutputGroupSettingsUnmarshaller _instance = new OutputGroupSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OutputGroupSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}