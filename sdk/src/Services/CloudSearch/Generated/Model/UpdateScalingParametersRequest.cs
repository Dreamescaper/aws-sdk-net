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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateScalingParameters operation.
    /// Configures scaling parameters for a domain. A domain's scaling parameters specify
    /// the desired search instance type and replication count. Amazon CloudSearch will still
    /// automatically scale your domain based on the volume of data and traffic, but not below
    /// the desired instance type and replication count. If the Multi-AZ option is enabled,
    /// these values control the resources used per Availability Zone. For more information,
    /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html"
    /// target="_blank">Configuring Scaling Options</a> in the <i>Amazon CloudSearch Developer
    /// Guide</i>.
    /// </summary>
    public partial class UpdateScalingParametersRequest : AmazonCloudSearchRequest
    {
        private string _domainName;
        private ScalingParameters _scalingParameters;

        /// <summary>
        /// Gets and sets the property DomainName.
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingParameters.
        /// </summary>
        [AWSProperty(Required=true)]
        public ScalingParameters ScalingParameters
        {
            get { return this._scalingParameters; }
            set { this._scalingParameters = value; }
        }

        // Check to see if ScalingParameters property is set
        internal bool IsSetScalingParameters()
        {
            return this._scalingParameters != null;
        }

    }
}