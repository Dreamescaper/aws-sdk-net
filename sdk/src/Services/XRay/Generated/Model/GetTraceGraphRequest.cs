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
    /// Container for the parameters to the GetTraceGraph operation.
    /// Retrieves a service graph for one or more specific trace IDs.
    /// </summary>
    public partial class GetTraceGraphRequest : AmazonXRayRequest
    {
        private string _nextToken;
        private List<string> _traceIds = new List<string>();

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
        /// Gets and sets the property TraceIds. 
        /// <para>
        /// Trace IDs of requests for which to generate a service graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TraceIds
        {
            get { return this._traceIds; }
            set { this._traceIds = value; }
        }

        // Check to see if TraceIds property is set
        internal bool IsSetTraceIds()
        {
            return this._traceIds != null && this._traceIds.Count > 0; 
        }

    }
}