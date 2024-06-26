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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure containing information about one service level objective (SLO) that has
    /// been created in Application Signals. Creating SLOs can help you ensure your services
    /// are performing to the level that you expect. SLOs help you set and track a specific
    /// target level for the reliability and availability of your applications and services.
    /// Each SLO uses a service level indicator (SLI), which is a key performance metric,
    /// to calculate how much underperformance can be tolerated before the goal that you set
    /// for the SLO is not achieved.
    /// </summary>
    public partial class ServiceLevelObjective
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private Goal _goal;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private ServiceLevelIndicator _sli;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of this SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time that this SLO was created. When used in a raw HTTP Query API, it
        /// is formatted as <c>yyyy-MM-dd'T'HH:mm:ss</c>. For example, <c>2019-07-01T23:59:59</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description that you created for this SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Goal.
        /// </summary>
        [AWSProperty(Required=true)]
        public Goal Goal
        {
            get { return this._goal; }
            set { this._goal = value; }
        }

        // Check to see if Goal property is set
        internal bool IsSetGoal()
        {
            return this._goal != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time that this SLO was most recently updated. When used in a raw HTTP Query API,
        /// it is formatted as <c>yyyy-MM-dd'T'HH:mm:ss</c>. For example, <c>2019-07-01T23:59:59</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Sli. 
        /// <para>
        /// A structure containing information about the performance metric that this SLO monitors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceLevelIndicator Sli
        {
            get { return this._sli; }
            set { this._sli = value; }
        }

        // Check to see if Sli property is set
        internal bool IsSetSli()
        {
            return this._sli != null;
        }

    }
}