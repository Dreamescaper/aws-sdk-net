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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is the response object from the GetWebACLForResource operation.
    /// </summary>
    public partial class GetWebACLForResourceResponse : AmazonWebServiceResponse
    {
        private WebACL _webACL;

        /// <summary>
        /// Gets and sets the property WebACL. 
        /// <para>
        /// The Web ACL that is associated with the resource. If there is no associated resource,
        /// AWS WAF returns a null Web ACL.
        /// </para>
        /// </summary>
        public WebACL WebACL
        {
            get { return this._webACL; }
            set { this._webACL = value; }
        }

        // Check to see if WebACL property is set
        internal bool IsSetWebACL()
        {
            return this._webACL != null;
        }

    }
}