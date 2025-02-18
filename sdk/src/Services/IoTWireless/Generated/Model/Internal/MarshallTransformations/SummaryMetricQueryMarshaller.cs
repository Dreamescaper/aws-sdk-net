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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SummaryMetricQuery Marshaller
    /// </summary>
    public class SummaryMetricQueryMarshaller : IRequestMarshaller<SummaryMetricQuery, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SummaryMetricQuery requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAggregationPeriod())
            {
                context.Writer.WritePropertyName("AggregationPeriod");
                context.Writer.Write(requestObject.AggregationPeriod);
            }

            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("Dimensions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDimensionsListValue in requestObject.Dimensions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DimensionMarshaller.Instance;
                    marshaller.Marshall(requestObjectDimensionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEndTimestamp())
            {
                context.Writer.WritePropertyName("EndTimestamp");
                context.Writer.Write(requestObject.EndTimestamp);
            }

            if(requestObject.IsSetMetricName())
            {
                context.Writer.WritePropertyName("MetricName");
                context.Writer.Write(requestObject.MetricName);
            }

            if(requestObject.IsSetQueryId())
            {
                context.Writer.WritePropertyName("QueryId");
                context.Writer.Write(requestObject.QueryId);
            }

            if(requestObject.IsSetStartTimestamp())
            {
                context.Writer.WritePropertyName("StartTimestamp");
                context.Writer.Write(requestObject.StartTimestamp);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SummaryMetricQueryMarshaller Instance = new SummaryMetricQueryMarshaller();

    }
}