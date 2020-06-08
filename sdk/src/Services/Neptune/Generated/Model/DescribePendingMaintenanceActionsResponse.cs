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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// This is the response object from the DescribePendingMaintenanceActions operation.
    /// </summary>
    public partial class DescribePendingMaintenanceActionsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<ResourcePendingMaintenanceActions> _pendingMaintenanceActions = new List<ResourcePendingMaintenanceActions>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  An optional pagination token provided by a previous <code>DescribePendingMaintenanceActions</code>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to a number of records specified by <code>MaxRecords</code>.
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
        /// Gets and sets the property PendingMaintenanceActions. 
        /// <para>
        /// A list of the pending maintenance actions for the resource.
        /// </para>
        /// </summary>
        public List<ResourcePendingMaintenanceActions> PendingMaintenanceActions
        {
            get { return this._pendingMaintenanceActions; }
            set { this._pendingMaintenanceActions = value; }
        }

        // Check to see if PendingMaintenanceActions property is set
        internal bool IsSetPendingMaintenanceActions()
        {
            return this._pendingMaintenanceActions != null && this._pendingMaintenanceActions.Count > 0; 
        }

    }
}