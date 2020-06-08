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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeExportConfigurations operation.
    /// <code>DescribeExportConfigurations</code> is deprecated. Use <a href="https://docs.aws.amazon.com/application-discovery/latest/APIReference/API_DescribeExportTasks.html">DescribeImportTasks</a>,
    /// instead.
    /// </summary>
    public partial class DescribeExportConfigurationsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<string> _exportIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ExportIds. 
        /// <para>
        /// A list of continuous export IDs to search for.
        /// </para>
        /// </summary>
        public List<string> ExportIds
        {
            get { return this._exportIds; }
            set { this._exportIds = value; }
        }

        // Check to see if ExportIds property is set
        internal bool IsSetExportIds()
        {
            return this._exportIds != null && this._exportIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// A number between 1 and 100 specifying the maximum number of continuous export descriptions
        /// returned.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token from the previous call to describe-export-tasks.
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

    }
}