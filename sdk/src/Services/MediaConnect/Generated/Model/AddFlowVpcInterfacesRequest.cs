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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the AddFlowVpcInterfaces operation.
    /// Adds VPC interfaces to flow
    /// </summary>
    public partial class AddFlowVpcInterfacesRequest : AmazonMediaConnectRequest
    {
        private string _flowArn;
        private List<VpcInterfaceRequest> _vpcInterfaces = new List<VpcInterfaceRequest>();

        /// <summary>
        /// Gets and sets the property FlowArn. The flow that you want to mutate.
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcInterfaces. A list of VPC interfaces that you want to
        /// add.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<VpcInterfaceRequest> VpcInterfaces
        {
            get { return this._vpcInterfaces; }
            set { this._vpcInterfaces = value; }
        }

        // Check to see if VpcInterfaces property is set
        internal bool IsSetVpcInterfaces()
        {
            return this._vpcInterfaces != null && this._vpcInterfaces.Count > 0; 
        }

    }
}