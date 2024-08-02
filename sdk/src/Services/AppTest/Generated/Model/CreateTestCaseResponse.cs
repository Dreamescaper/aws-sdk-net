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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// This is the response object from the CreateTestCase operation.
    /// </summary>
    public partial class CreateTestCaseResponse : AmazonWebServiceResponse
    {
        private string _testCaseId;
        private int? _testCaseVersion;

        /// <summary>
        /// Gets and sets the property TestCaseId. 
        /// <para>
        /// The test case ID of the test case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestCaseId
        {
            get { return this._testCaseId; }
            set { this._testCaseId = value; }
        }

        // Check to see if TestCaseId property is set
        internal bool IsSetTestCaseId()
        {
            return this._testCaseId != null;
        }

        /// <summary>
        /// Gets and sets the property TestCaseVersion. 
        /// <para>
        /// The test case version of the test case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int TestCaseVersion
        {
            get { return this._testCaseVersion.GetValueOrDefault(); }
            set { this._testCaseVersion = value; }
        }

        // Check to see if TestCaseVersion property is set
        internal bool IsSetTestCaseVersion()
        {
            return this._testCaseVersion.HasValue; 
        }

    }
}