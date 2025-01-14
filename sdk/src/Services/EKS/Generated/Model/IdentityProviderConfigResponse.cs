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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// The full description of your identity configuration.
    /// </summary>
    public partial class IdentityProviderConfigResponse
    {
        private OidcIdentityProviderConfig _oidc;

        /// <summary>
        /// Gets and sets the property Oidc. 
        /// <para>
        /// An object that represents an OpenID Connect (OIDC) identity provider configuration.
        /// </para>
        /// </summary>
        public OidcIdentityProviderConfig Oidc
        {
            get { return this._oidc; }
            set { this._oidc = value; }
        }

        // Check to see if Oidc property is set
        internal bool IsSetOidc()
        {
            return this._oidc != null;
        }

    }
}