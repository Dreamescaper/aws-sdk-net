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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// In Amazon Pinpoint, <i>events</i> include message sends, deliveries, opens, clicks,
    /// bounces, and complaints. <i>Event destinations</i> are places that you can send information
    /// about these events to. For example, you can send event data to Amazon SNS to receive
    /// notifications when you receive bounces or complaints, or you can use Amazon Kinesis
    /// Data Firehose to stream data to Amazon S3 for long-term storage.
    /// </summary>
    public partial class EventDestination
    {
        private CloudWatchDestination _cloudWatchDestination;
        private bool? _enabled;
        private KinesisFirehoseDestination _kinesisFirehoseDestination;
        private List<string> _matchingEventTypes = new List<string>();
        private string _name;
        private PinpointDestination _pinpointDestination;
        private SnsDestination _snsDestination;

        /// <summary>
        /// Gets and sets the property CloudWatchDestination. 
        /// <para>
        /// An object that defines an Amazon CloudWatch destination for email events. You can
        /// use Amazon CloudWatch to monitor and gain insights on your email sending metrics.
        /// </para>
        /// </summary>
        public CloudWatchDestination CloudWatchDestination
        {
            get { return this._cloudWatchDestination; }
            set { this._cloudWatchDestination = value; }
        }

        // Check to see if CloudWatchDestination property is set
        internal bool IsSetCloudWatchDestination()
        {
            return this._cloudWatchDestination != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If <code>true</code>, the event destination is enabled. When the event destination
        /// is enabled, the specified event types are sent to the destinations in this <code>EventDestinationDefinition</code>.
        /// </para>
        ///  
        /// <para>
        /// If <code>false</code>, the event destination is disabled. When the event destination
        /// is disabled, events aren't sent to the specified destinations.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KinesisFirehoseDestination. 
        /// <para>
        /// An object that defines an Amazon Kinesis Data Firehose destination for email events.
        /// You can use Amazon Kinesis Data Firehose to stream data to other services, such as
        /// Amazon S3 and Amazon Redshift.
        /// </para>
        /// </summary>
        public KinesisFirehoseDestination KinesisFirehoseDestination
        {
            get { return this._kinesisFirehoseDestination; }
            set { this._kinesisFirehoseDestination = value; }
        }

        // Check to see if KinesisFirehoseDestination property is set
        internal bool IsSetKinesisFirehoseDestination()
        {
            return this._kinesisFirehoseDestination != null;
        }

        /// <summary>
        /// Gets and sets the property MatchingEventTypes. 
        /// <para>
        /// The types of events that Amazon Pinpoint sends to the specified event destinations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> MatchingEventTypes
        {
            get { return this._matchingEventTypes; }
            set { this._matchingEventTypes = value; }
        }

        // Check to see if MatchingEventTypes property is set
        internal bool IsSetMatchingEventTypes()
        {
            return this._matchingEventTypes != null && this._matchingEventTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name that identifies the event destination.
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
        /// Gets and sets the property PinpointDestination. 
        /// <para>
        /// An object that defines a Amazon Pinpoint destination for email events. You can use
        /// Amazon Pinpoint events to create attributes in Amazon Pinpoint projects. You can use
        /// these attributes to create segments for your campaigns.
        /// </para>
        /// </summary>
        public PinpointDestination PinpointDestination
        {
            get { return this._pinpointDestination; }
            set { this._pinpointDestination = value; }
        }

        // Check to see if PinpointDestination property is set
        internal bool IsSetPinpointDestination()
        {
            return this._pinpointDestination != null;
        }

        /// <summary>
        /// Gets and sets the property SnsDestination. 
        /// <para>
        /// An object that defines an Amazon SNS destination for email events. You can use Amazon
        /// SNS to send notification when certain email events occur.
        /// </para>
        /// </summary>
        public SnsDestination SnsDestination
        {
            get { return this._snsDestination; }
            set { this._snsDestination = value; }
        }

        // Check to see if SnsDestination property is set
        internal bool IsSetSnsDestination()
        {
            return this._snsDestination != null;
        }

    }
}