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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the information of an agent
    /// </summary>
    public partial class Agent
    {
        private string _agentArn;
        private string _agentId;
        private string _agentName;
        private string _agentResourceRoleArn;
        private AgentStatus _agentStatus;
        private string _agentVersion;
        private string _clientToken;
        private DateTime? _createdAt;
        private string _customerEncryptionKeyArn;
        private string _description;
        private List<string> _failureReasons = new List<string>();
        private string _foundationModel;
        private int? _idleSessionTTLInSeconds;
        private string _instruction;
        private DateTime? _preparedAt;
        private PromptOverrideConfiguration _promptOverrideConfiguration;
        private List<string> _recommendedActions = new List<string>();
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgentArn.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string AgentArn
        {
            get { return this._agentArn; }
            set { this._agentArn = value; }
        }

        // Check to see if AgentArn property is set
        internal bool IsSetAgentArn()
        {
            return this._agentArn != null;
        }

        /// <summary>
        /// Gets and sets the property AgentId.
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentName.
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentName
        {
            get { return this._agentName; }
            set { this._agentName = value; }
        }

        // Check to see if AgentName property is set
        internal bool IsSetAgentName()
        {
            return this._agentName != null;
        }

        /// <summary>
        /// Gets and sets the property AgentResourceRoleArn.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string AgentResourceRoleArn
        {
            get { return this._agentResourceRoleArn; }
            set { this._agentResourceRoleArn = value; }
        }

        // Check to see if AgentResourceRoleArn property is set
        internal bool IsSetAgentResourceRoleArn()
        {
            return this._agentResourceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property AgentStatus.
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentStatus AgentStatus
        {
            get { return this._agentStatus; }
            set { this._agentStatus = value; }
        }

        // Check to see if AgentStatus property is set
        internal bool IsSetAgentStatus()
        {
            return this._agentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AgentVersion.
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=5)]
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken.
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyArn.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string CustomerEncryptionKeyArn
        {
            get { return this._customerEncryptionKeyArn; }
            set { this._customerEncryptionKeyArn = value; }
        }

        // Check to see if CustomerEncryptionKeyArn property is set
        internal bool IsSetCustomerEncryptionKeyArn()
        {
            return this._customerEncryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property FailureReasons.
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && this._failureReasons.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FoundationModel.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FoundationModel
        {
            get { return this._foundationModel; }
            set { this._foundationModel = value; }
        }

        // Check to see if FoundationModel property is set
        internal bool IsSetFoundationModel()
        {
            return this._foundationModel != null;
        }

        /// <summary>
        /// Gets and sets the property IdleSessionTTLInSeconds.
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=3600)]
        public int? IdleSessionTTLInSeconds
        {
            get { return this._idleSessionTTLInSeconds; }
            set { this._idleSessionTTLInSeconds = value; }
        }

        // Check to see if IdleSessionTTLInSeconds property is set
        internal bool IsSetIdleSessionTTLInSeconds()
        {
            return this._idleSessionTTLInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Instruction.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=40, Max=1200)]
        public string Instruction
        {
            get { return this._instruction; }
            set { this._instruction = value; }
        }

        // Check to see if Instruction property is set
        internal bool IsSetInstruction()
        {
            return this._instruction != null;
        }

        /// <summary>
        /// Gets and sets the property PreparedAt.
        /// </summary>
        public DateTime? PreparedAt
        {
            get { return this._preparedAt; }
            set { this._preparedAt = value; }
        }

        // Check to see if PreparedAt property is set
        internal bool IsSetPreparedAt()
        {
            return this._preparedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PromptOverrideConfiguration.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PromptOverrideConfiguration PromptOverrideConfiguration
        {
            get { return this._promptOverrideConfiguration; }
            set { this._promptOverrideConfiguration = value; }
        }

        // Check to see if PromptOverrideConfiguration property is set
        internal bool IsSetPromptOverrideConfiguration()
        {
            return this._promptOverrideConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedActions.
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public List<string> RecommendedActions
        {
            get { return this._recommendedActions; }
            set { this._recommendedActions = value; }
        }

        // Check to see if RecommendedActions property is set
        internal bool IsSetRecommendedActions()
        {
            return this._recommendedActions != null && this._recommendedActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}