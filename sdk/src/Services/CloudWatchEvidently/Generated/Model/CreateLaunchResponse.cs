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
    /// This is the response object from the CreateLaunch operation.
    /// </summary>
    public partial class CreateLaunchResponse : AmazonWebServiceResponse
    {
        private Launch _launch;

        /// <summary>
        /// Gets and sets the property Launch. 
        /// <para>
        /// A structure that contains the configuration of the launch that was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Launch Launch
        {
            get { return this._launch; }
            set { this._launch = value; }
        }

        // Check to see if Launch property is set
        internal bool IsSetLaunch()
        {
            return this._launch != null;
        }

    }
}