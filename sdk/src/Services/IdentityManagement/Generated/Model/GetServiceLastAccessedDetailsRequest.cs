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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetServiceLastAccessedDetails operation.
    /// Retrieves a service last accessed report that was created using the <code>GenerateServiceLastAccessedDetails</code>
    /// operation. You can use the <code>JobId</code> parameter in <code>GetServiceLastAccessedDetails</code>
    /// to retrieve the status of your report job. When the report is complete, you can retrieve
    /// the generated report. The report includes a list of AWS services that the resource
    /// (user, group, role, or managed policy) can access.
    /// 
    ///  <note> 
    /// <para>
    /// Service last accessed data does not use other policy types when determining whether
    /// a resource could access a service. These other policy types include resource-based
    /// policies, access control lists, AWS Organizations policies, IAM permissions boundaries,
    /// and AWS STS assume role policies. It only applies permissions policy logic. For more
    /// about the evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
    /// Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For each service that the resource could access using permissions policies, the operation
    /// returns details about the most recent access attempt. If there was no attempt, the
    /// service is listed without details about the most recent attempt to access the service.
    /// If the operation fails, the <code>GetServiceLastAccessedDetails</code> operation returns
    /// the reason that it failed.
    /// </para>
    ///  
    /// <para>
    /// The <code>GetServiceLastAccessedDetails</code> operation returns a list of services.
    /// This list includes the number of entities that have attempted to access the service
    /// and the date and time of the last attempt. It also returns the ARN of the following
    /// entity, depending on the resource ARN that you used to generate the report:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>User</b> – Returns the user ARN that you used to generate the report
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Group</b> – Returns the ARN of the group member (user) that last attempted to
    /// access the service
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Role</b> – Returns the role ARN that you used to generate the report
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Policy</b> – Returns the ARN of the user or role that last used the policy to
    /// attempt to access the service
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// By default, the list is sorted by service namespace.
    /// </para>
    ///  
    /// <para>
    /// If you specified <code>ACTION_LEVEL</code> granularity when you generated the report,
    /// this operation returns service and action last accessed data. This includes the most
    /// recent access attempt for each tracked action within a service. Otherwise, this operation
    /// returns only service data.
    /// </para>
    ///  
    /// <para>
    /// For more information about service and action last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
    /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetServiceLastAccessedDetailsRequest : AmazonIdentityManagementServiceRequest
    {
        private string _jobId;
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the request generated by the <a>GenerateServiceLastAccessedDetails</a> operation.
        /// The <code>JobId</code> returned by <code>GenerateServiceLastAccessedDetail</code>
        /// must be used by the same role within a session, or by the same user when used to call
        /// <code>GetServiceLastAccessedDetail</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results and only after you receive a response
        /// indicating that the results are truncated. Set it to the value of the <code>Marker</code>
        /// element in the response that you received to indicate where the next call should start.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=320)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Use this only when paginating results to indicate the maximum number of items you
        /// want in the response. If additional items exist beyond the maximum you specify, the
        /// <code>IsTruncated</code> response element is <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// If you do not include this parameter, the number of items defaults to 100. Note that
        /// IAM might return fewer results, even when there are more results available. In that
        /// case, the <code>IsTruncated</code> response element returns <code>true</code>, and
        /// <code>Marker</code> contains a value to include in the subsequent call that tells
        /// the service where to continue from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}