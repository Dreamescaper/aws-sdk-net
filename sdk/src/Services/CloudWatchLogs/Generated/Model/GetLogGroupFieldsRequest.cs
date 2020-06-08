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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the GetLogGroupFields operation.
    /// Returns a list of the fields that are included in log events in the specified log
    /// group, along with the percentage of log events that contain each field. The search
    /// is limited to a time period that you specify.
    /// 
    ///  
    /// <para>
    /// In the results, fields that start with @ are fields generated by CloudWatch Logs.
    /// For example, <code>@timestamp</code> is the timestamp of each log event. For more
    /// information about the fields that are generated by CloudWatch logs, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_AnalyzeLogData-discoverable-fields.html">Supported
    /// Logs and Discovered Fields</a>.
    /// </para>
    ///  
    /// <para>
    /// The response results are sorted by the frequency percentage, starting with the highest
    /// percentage.
    /// </para>
    /// </summary>
    public partial class GetLogGroupFieldsRequest : AmazonCloudWatchLogsRequest
    {
        private string _logGroupName;
        private long? _time;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group to search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The time to set as the center of the query. If you specify <code>time</code>, the
        /// 8 minutes before and 8 minutes after this time are searched. If you omit <code>time</code>,
        /// the past 15 minutes are queried.
        /// </para>
        ///  
        /// <para>
        /// The <code>time</code> value is specified as epoch time, the number of seconds since
        /// January 1, 1970, 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long Time
        {
            get { return this._time.GetValueOrDefault(); }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time.HasValue; 
        }

    }
}