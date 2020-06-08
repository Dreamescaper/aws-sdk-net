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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// This is the response object from the GetTimeSeriesServiceStatistics operation.
    /// </summary>
    public partial class GetTimeSeriesServiceStatisticsResponse : AmazonWebServiceResponse
    {
        private bool? _containsOldGroupVersions;
        private string _nextToken;
        private List<TimeSeriesServiceStatistics> _timeSeriesServiceStatistics = new List<TimeSeriesServiceStatistics>();

        /// <summary>
        /// Gets and sets the property ContainsOldGroupVersions. 
        /// <para>
        /// A flag indicating whether or not a group's filter expression has been consistent,
        /// or if a returned aggregation may show statistics from an older version of the group's
        /// filter expression.
        /// </para>
        /// </summary>
        public bool ContainsOldGroupVersions
        {
            get { return this._containsOldGroupVersions.GetValueOrDefault(); }
            set { this._containsOldGroupVersions = value; }
        }

        // Check to see if ContainsOldGroupVersions property is set
        internal bool IsSetContainsOldGroupVersions()
        {
            return this._containsOldGroupVersions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesServiceStatistics. 
        /// <para>
        /// The collection of statistics.
        /// </para>
        /// </summary>
        public List<TimeSeriesServiceStatistics> TimeSeriesServiceStatistics
        {
            get { return this._timeSeriesServiceStatistics; }
            set { this._timeSeriesServiceStatistics = value; }
        }

        // Check to see if TimeSeriesServiceStatistics property is set
        internal bool IsSetTimeSeriesServiceStatistics()
        {
            return this._timeSeriesServiceStatistics != null && this._timeSeriesServiceStatistics.Count > 0; 
        }

    }
}