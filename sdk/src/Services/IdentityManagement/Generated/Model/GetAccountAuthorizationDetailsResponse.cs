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
    /// Contains the response to a successful <a>GetAccountAuthorizationDetails</a> request.
    /// </summary>
    public partial class GetAccountAuthorizationDetailsResponse : AmazonWebServiceResponse
    {
        private List<GroupDetail> _groupDetailList = new List<GroupDetail>();
        private bool? _isTruncated;
        private string _marker;
        private List<ManagedPolicyDetail> _policies = new List<ManagedPolicyDetail>();
        private List<RoleDetail> _roleDetailList = new List<RoleDetail>();
        private List<UserDetail> _userDetailList = new List<UserDetail>();

        /// <summary>
        /// Gets and sets the property GroupDetailList. 
        /// <para>
        /// A list containing information about IAM groups.
        /// </para>
        /// </summary>
        public List<GroupDetail> GroupDetailList
        {
            get { return this._groupDetailList; }
            set { this._groupDetailList = value; }
        }

        // Check to see if GroupDetailList property is set
        internal bool IsSetGroupDetailList()
        {
            return this._groupDetailList != null && this._groupDetailList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more items to return. If your results were
        /// truncated, you can make a subsequent pagination request using the <code>Marker</code>
        /// request parameter to retrieve more items. Note that IAM might return fewer than the
        /// <code>MaxItems</code> number of results even when there are more results available.
        /// We recommend that you check <code>IsTruncated</code> after every call to ensure that
        /// you receive all your results.
        /// </para>
        /// </summary>
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// When <code>IsTruncated</code> is <code>true</code>, this element is present and contains
        /// the value to use for the <code>Marker</code> parameter in a subsequent pagination
        /// request.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Policies. 
        /// <para>
        /// A list containing information about managed policies.
        /// </para>
        /// </summary>
        public List<ManagedPolicyDetail> Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null && this._policies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleDetailList. 
        /// <para>
        /// A list containing information about IAM roles.
        /// </para>
        /// </summary>
        public List<RoleDetail> RoleDetailList
        {
            get { return this._roleDetailList; }
            set { this._roleDetailList = value; }
        }

        // Check to see if RoleDetailList property is set
        internal bool IsSetRoleDetailList()
        {
            return this._roleDetailList != null && this._roleDetailList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserDetailList. 
        /// <para>
        /// A list containing information about IAM users.
        /// </para>
        /// </summary>
        public List<UserDetail> UserDetailList
        {
            get { return this._userDetailList; }
            set { this._userDetailList = value; }
        }

        // Check to see if UserDetailList property is set
        internal bool IsSetUserDetailList()
        {
            return this._userDetailList != null && this._userDetailList.Count > 0; 
        }

    }
}