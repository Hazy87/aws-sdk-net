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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// This is the response object from the EvaluateFeature operation.
    /// </summary>
    public partial class EvaluateFeatureResponse : AmazonWebServiceResponse
    {
        private string _details;
        private string _reason;
        private VariableValue _value;
        private string _variation;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// If this user was assigned to a launch or experiment, this field lists the launch or
        /// experiment name.
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Specifies the reason that the user session was assigned this variation. Possible values
        /// include <code>DEFAULT</code>, meaning the user was served the default variation; <code>LAUNCH_RULE_MATCH</code>,
        /// if the user session was enrolled in a launch; <code>EXPERIMENT_RULE_MATCH</code>,
        /// if the user session was enrolled in an experiment; or <code>ENTITY_OVERRIDES_MATCH</code>,
        /// if the user's <code>entityId</code> matches an override rule.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value assigned to this variation to differentiate it from the other variations
        /// of this feature.
        /// </para>
        /// </summary>
        public VariableValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

        /// <summary>
        /// Gets and sets the property Variation. 
        /// <para>
        /// The name of the variation that was served to the user session.
        /// </para>
        /// </summary>
        public string Variation
        {
            get { return this._variation; }
            set { this._variation = value; }
        }

        // Check to see if Variation property is set
        internal bool IsSetVariation()
        {
            return this._variation != null;
        }

    }
}