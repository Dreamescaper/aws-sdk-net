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
    /// UpdatedSessionActionInfo Marshaller
    /// </summary>
    public class UpdatedSessionActionInfoMarshaller : IRequestMarshaller<UpdatedSessionActionInfo, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdatedSessionActionInfo requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCompletedStatus())
            {
                context.Writer.WritePropertyName("completedStatus");
                context.Writer.Write(requestObject.CompletedStatus);
            }

            if(requestObject.IsSetEndedAt())
            {
                context.Writer.WritePropertyName("endedAt");
                context.Writer.Write(StringUtils.FromDateTimeToISO8601(requestObject.EndedAt));
            }

            if(requestObject.IsSetProcessExitCode())
            {
                context.Writer.WritePropertyName("processExitCode");
                context.Writer.Write(requestObject.ProcessExitCode);
            }

            if(requestObject.IsSetProgressMessage())
            {
                context.Writer.WritePropertyName("progressMessage");
                context.Writer.Write(requestObject.ProgressMessage);
            }

            if(requestObject.IsSetProgressPercent())
            {
                context.Writer.WritePropertyName("progressPercent");
                context.Writer.Write(requestObject.ProgressPercent);
            }

            if(requestObject.IsSetStartedAt())
            {
                context.Writer.WritePropertyName("startedAt");
                context.Writer.Write(StringUtils.FromDateTimeToISO8601(requestObject.StartedAt));
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("updatedAt");
                context.Writer.Write(StringUtils.FromDateTimeToISO8601(requestObject.UpdatedAt));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdatedSessionActionInfoMarshaller Instance = new UpdatedSessionActionInfoMarshaller();

    }
}