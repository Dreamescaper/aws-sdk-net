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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ViewRepresentation Object
    /// </summary>  
    public class ViewRepresentationUnmarshaller : IUnmarshaller<ViewRepresentation, XmlUnmarshallerContext>, IUnmarshaller<ViewRepresentation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ViewRepresentation IUnmarshaller<ViewRepresentation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ViewRepresentation Unmarshall(JsonUnmarshallerContext context)
        {
            ViewRepresentation unmarshalledObject = new ViewRepresentation();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Dialect", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Dialect = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DialectVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DialectVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsStale", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsStale = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViewExpandedText", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ViewExpandedText = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViewOriginalText", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ViewOriginalText = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ViewRepresentationUnmarshaller _instance = new ViewRepresentationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ViewRepresentationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}