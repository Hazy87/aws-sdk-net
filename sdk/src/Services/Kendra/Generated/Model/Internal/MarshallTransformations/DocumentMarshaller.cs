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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Document Marshaller
    /// </summary>
    public class DocumentMarshaller : IRequestMarshaller<Document, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Document requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccessControlList())
            {
                context.Writer.WritePropertyName("AccessControlList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAccessControlListListValue in requestObject.AccessControlList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PrincipalMarshaller.Instance;
                    marshaller.Marshall(requestObjectAccessControlListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAttributesListValue in requestObject.Attributes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DocumentAttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBlob())
            {
                context.Writer.WritePropertyName("Blob");
                context.Writer.Write(StringUtils.FromMemoryStream(requestObject.Blob));
            }

            if(requestObject.IsSetContentType())
            {
                context.Writer.WritePropertyName("ContentType");
                context.Writer.Write(requestObject.ContentType);
            }

            if(requestObject.IsSetHierarchicalAccessControlList())
            {
                context.Writer.WritePropertyName("HierarchicalAccessControlList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHierarchicalAccessControlListListValue in requestObject.HierarchicalAccessControlList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = HierarchicalPrincipalMarshaller.Instance;
                    marshaller.Marshall(requestObjectHierarchicalAccessControlListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.Write(requestObject.Id);
            }

            if(requestObject.IsSetS3Path())
            {
                context.Writer.WritePropertyName("S3Path");
                context.Writer.WriteObjectStart();

                var marshaller = S3PathMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Path, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.Write(requestObject.Title);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DocumentMarshaller Instance = new DocumentMarshaller();

    }
}