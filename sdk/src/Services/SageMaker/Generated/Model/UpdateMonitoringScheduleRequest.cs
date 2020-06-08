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
    /// Container for the parameters to the UpdateMonitoringSchedule operation.
    /// Updates a previously created schedule.
    /// </summary>
    public partial class UpdateMonitoringScheduleRequest : AmazonSageMakerRequest
    {
        private MonitoringScheduleConfig _monitoringScheduleConfig;
        private string _monitoringScheduleName;

        /// <summary>
        /// Gets and sets the property MonitoringScheduleConfig. 
        /// <para>
        /// The configuration object that specifies the monitoring schedule and defines the monitoring
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringScheduleConfig MonitoringScheduleConfig
        {
            get { return this._monitoringScheduleConfig; }
            set { this._monitoringScheduleConfig = value; }
        }

        // Check to see if MonitoringScheduleConfig property is set
        internal bool IsSetMonitoringScheduleConfig()
        {
            return this._monitoringScheduleConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringScheduleName. 
        /// <para>
        /// The name of the monitoring schedule. The name must be unique within an AWS Region
        /// within an AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string MonitoringScheduleName
        {
            get { return this._monitoringScheduleName; }
            set { this._monitoringScheduleName = value; }
        }

        // Check to see if MonitoringScheduleName property is set
        internal bool IsSetMonitoringScheduleName()
        {
            return this._monitoringScheduleName != null;
        }

    }
}