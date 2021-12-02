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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The model latency threshold.
    /// </summary>
    public partial class ModelLatencyThreshold
    {
        private string _percentile;
        private int? _valueInMilliseconds;

        /// <summary>
        /// Gets and sets the property Percentile. 
        /// <para>
        /// The model latency percentile threshold.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Percentile
        {
            get { return this._percentile; }
            set { this._percentile = value; }
        }

        // Check to see if Percentile property is set
        internal bool IsSetPercentile()
        {
            return this._percentile != null;
        }

        /// <summary>
        /// Gets and sets the property ValueInMilliseconds. 
        /// <para>
        /// The model latency percentile value in milliseconds.
        /// </para>
        /// </summary>
        public int ValueInMilliseconds
        {
            get { return this._valueInMilliseconds.GetValueOrDefault(); }
            set { this._valueInMilliseconds = value; }
        }

        // Check to see if ValueInMilliseconds property is set
        internal bool IsSetValueInMilliseconds()
        {
            return this._valueInMilliseconds.HasValue; 
        }

    }
}