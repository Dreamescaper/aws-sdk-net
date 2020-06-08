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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// This is the response object from the DescribeJournalS3Export operation.
    /// </summary>
    public partial class DescribeJournalS3ExportResponse : AmazonWebServiceResponse
    {
        private JournalS3ExportDescription _exportDescription;

        /// <summary>
        /// Gets and sets the property ExportDescription. 
        /// <para>
        /// Information about the journal export job returned by a <code>DescribeJournalS3Export</code>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JournalS3ExportDescription ExportDescription
        {
            get { return this._exportDescription; }
            set { this._exportDescription = value; }
        }

        // Check to see if ExportDescription property is set
        internal bool IsSetExportDescription()
        {
            return this._exportDescription != null;
        }

    }
}