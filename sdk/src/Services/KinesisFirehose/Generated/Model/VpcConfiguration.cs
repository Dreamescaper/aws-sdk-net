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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The details of the VPC of the Amazon ES destination.
    /// </summary>
    public partial class VpcConfiguration
    {
        private string _roleARN;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _subnetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The ARN of the IAM role that you want the delivery stream to use to create endpoints
        /// in the destination VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups that you want Kinesis Data Firehose to use when it
        /// creates ENIs in the VPC of the Amazon ES destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The IDs of the subnets that you want Kinesis Data Firehose to use to create ENIs in
        /// the VPC of the Amazon ES destination. Make sure that the routing tables and inbound
        /// and outbound rules allow traffic to flow from the subnets whose IDs are specified
        /// here to the subnets that have the destination Amazon ES endpoints. Kinesis Data Firehose
        /// creates at least one ENI in each of the subnets that are specified here. Do not delete
        /// or modify these ENIs.
        /// </para>
        ///  
        /// <para>
        /// The number of ENIs that Kinesis Data Firehose creates in the subnets specified here
        /// scales up and down automatically based on throughput. To enable Kinesis Data Firehose
        /// to scale up the number of ENIs to match throughput, ensure that you have sufficient
        /// quota. To help you calculate the quota you need, assume that Kinesis Data Firehose
        /// can create up to three ENIs for this delivery stream for each of the subnets specified
        /// here. For more information about ENI quota, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html#vpc-limits-enis">Network
        /// Interfaces </a> in the Amazon VPC Quotas topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

    }
}