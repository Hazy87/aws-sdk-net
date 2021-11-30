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
    /// Container for the parameters to the GetProject operation.
    /// Returns the details about one launch. You must already know the project name. To retrieve
    /// a list of projects in your account, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_ListProjects.html">ListProjects</a>.
    /// </summary>
    public partial class GetProjectRequest : AmazonCloudWatchEvidentlyRequest
    {
        private string _project;

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that you want to see the details of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

    }
}