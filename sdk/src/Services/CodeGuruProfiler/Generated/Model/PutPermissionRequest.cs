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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the PutPermission operation.
    /// Provides permission to the principals. This overwrites the existing permissions, and
    /// is not additive.
    /// </summary>
    public partial class PutPermissionRequest : AmazonCodeGuruProfilerRequest
    {
        private ActionGroup _actionGroup;
        private List<string> _principals = new List<string>();
        private string _profilingGroupName;
        private string _revisionId;

        /// <summary>
        /// Gets and sets the property ActionGroup. 
        /// <para>
        /// The list of actions that the users and roles can perform on the profiling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionGroup ActionGroup
        {
            get { return this._actionGroup; }
            set { this._actionGroup = value; }
        }

        // Check to see if ActionGroup property is set
        internal bool IsSetActionGroup()
        {
            return this._actionGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// The list of role and user ARNs or the accountId that needs access (wildcards are not
        /// allowed).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && this._principals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProfilingGroupName
        {
            get { return this._profilingGroupName; }
            set { this._profilingGroupName = value; }
        }

        // Check to see if ProfilingGroupName property is set
        internal bool IsSetProfilingGroupName()
        {
            return this._profilingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// A unique identifier for the current revision of the policy. This is required, if a
        /// policy exists for the profiling group. This is not required when creating the policy
        /// for the first time.
        /// </para>
        /// </summary>
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

    }
}