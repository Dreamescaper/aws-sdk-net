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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// This is the response object from the GetFindingsStatistics operation.
    /// </summary>
    public partial class GetFindingsStatisticsResponse : AmazonWebServiceResponse
    {
        private FindingStatistics _findingStatistics;

        /// <summary>
        /// Gets and sets the property FindingStatistics. 
        /// <para>
        /// The finding statistics object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FindingStatistics FindingStatistics
        {
            get { return this._findingStatistics; }
            set { this._findingStatistics = value; }
        }

        // Check to see if FindingStatistics property is set
        internal bool IsSetFindingStatistics()
        {
            return this._findingStatistics != null;
        }

    }
}