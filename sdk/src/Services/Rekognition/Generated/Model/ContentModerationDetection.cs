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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Information about an unsafe content label detection in a stored video.
    /// </summary>
    public partial class ContentModerationDetection
    {
        private ModerationLabel _moderationLabel;
        private long? _timestamp;

        /// <summary>
        /// Gets and sets the property ModerationLabel. 
        /// <para>
        /// The unsafe content label detected by in the stored video.
        /// </para>
        /// </summary>
        public ModerationLabel ModerationLabel
        {
            get { return this._moderationLabel; }
            set { this._moderationLabel = value; }
        }

        // Check to see if ModerationLabel property is set
        internal bool IsSetModerationLabel()
        {
            return this._moderationLabel != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time, in milliseconds from the beginning of the video, that the unsafe content label
        /// was detected.
        /// </para>
        /// </summary>
        public long Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}