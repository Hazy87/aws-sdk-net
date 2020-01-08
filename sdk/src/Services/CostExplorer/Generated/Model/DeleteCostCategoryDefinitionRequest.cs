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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCostCategoryDefinition operation.
    /// <important> 
    /// <para>
    ///  <i> <b>Cost Category is in public beta for AWS Billing and Cost Management and is
    /// subject to change. Your use of Cost Categories is subject to the Beta Service Participation
    /// terms of the <a href="https://aws.amazon.com/service-terms/">AWS Service Terms</a>
    /// (Section 1.10).</b> </i> 
    /// </para>
    ///  </important> 
    /// <para>
    /// Deletes a Cost Category. Expenses from this month going forward will no longer be
    /// categorized with this Cost Category.
    /// </para>
    /// </summary>
    public partial class DeleteCostCategoryDefinitionRequest : AmazonCostExplorerRequest
    {
        private string _costCategoryArn;

        /// <summary>
        /// Gets and sets the property CostCategoryArn. 
        /// <para>
        ///  The unique identifier for your Cost Category. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string CostCategoryArn
        {
            get { return this._costCategoryArn; }
            set { this._costCategoryArn = value; }
        }

        // Check to see if CostCategoryArn property is set
        internal bool IsSetCostCategoryArn()
        {
            return this._costCategoryArn != null;
        }

    }
}