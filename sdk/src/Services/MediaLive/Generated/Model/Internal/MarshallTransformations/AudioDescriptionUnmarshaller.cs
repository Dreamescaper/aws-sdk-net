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
    /// Response Unmarshaller for AudioDescription Object
    /// </summary>  
    public class AudioDescriptionUnmarshaller : IUnmarshaller<AudioDescription, XmlUnmarshallerContext>, IUnmarshaller<AudioDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AudioDescription IUnmarshaller<AudioDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AudioDescription Unmarshall(JsonUnmarshallerContext context)
        {
            AudioDescription unmarshalledObject = new AudioDescription();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioDashRoles", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AudioDashRoles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioNormalizationSettings", targetDepth))
                {
                    var unmarshaller = AudioNormalizationSettingsUnmarshaller.Instance;
                    unmarshalledObject.AudioNormalizationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioSelectorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioSelectorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioTypeControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioTypeControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioWatermarkingSettings", targetDepth))
                {
                    var unmarshaller = AudioWatermarkSettingsUnmarshaller.Instance;
                    unmarshalledObject.AudioWatermarkingSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codecSettings", targetDepth))
                {
                    var unmarshaller = AudioCodecSettingsUnmarshaller.Instance;
                    unmarshalledObject.CodecSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dvbDashAccessibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DvbDashAccessibility = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("languageCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LanguageCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("languageCodeControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LanguageCodeControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("remixSettings", targetDepth))
                {
                    var unmarshaller = RemixSettingsUnmarshaller.Instance;
                    unmarshalledObject.RemixSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("streamName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AudioDescriptionUnmarshaller _instance = new AudioDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AudioDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}