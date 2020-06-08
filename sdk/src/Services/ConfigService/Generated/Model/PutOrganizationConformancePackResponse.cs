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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the PutOrganizationConformancePack operation.
    /// </summary>
    public partial class PutOrganizationConformancePackResponse : AmazonWebServiceResponse
    {
        private string _organizationConformancePackArn;

        /// <summary>
        /// Gets and sets the property OrganizationConformancePackArn. 
        /// <para>
        /// ARN of the organization conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string OrganizationConformancePackArn
        {
            get { return this._organizationConformancePackArn; }
            set { this._organizationConformancePackArn = value; }
        }

        // Check to see if OrganizationConformancePackArn property is set
        internal bool IsSetOrganizationConformancePackArn()
        {
            return this._organizationConformancePackArn != null;
        }

    }
}