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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Information about metrics summaries.
    /// </summary>
    public partial class MetricsSummary
    {
        private long? _findingsCount;
        private long? _meteredLinesOfCodeCount;

        /// <summary>
        /// Gets and sets the property FindingsCount. 
        /// <para>
        ///  Total number of recommendations found in the code review. 
        /// </para>
        /// </summary>
        public long FindingsCount
        {
            get { return this._findingsCount.GetValueOrDefault(); }
            set { this._findingsCount = value; }
        }

        // Check to see if FindingsCount property is set
        internal bool IsSetFindingsCount()
        {
            return this._findingsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MeteredLinesOfCodeCount. 
        /// <para>
        ///  Lines of code metered in the code review. 
        /// </para>
        /// </summary>
        public long MeteredLinesOfCodeCount
        {
            get { return this._meteredLinesOfCodeCount.GetValueOrDefault(); }
            set { this._meteredLinesOfCodeCount = value; }
        }

        // Check to see if MeteredLinesOfCodeCount property is set
        internal bool IsSetMeteredLinesOfCodeCount()
        {
            return this._meteredLinesOfCodeCount.HasValue; 
        }

    }
}