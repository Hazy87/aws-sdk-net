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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Proton.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Proton.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateServiceTemplateVersion Request Marshaller
    /// </summary>       
    public class UpdateServiceTemplateVersionRequestMarshaller : IMarshaller<IRequest, UpdateServiceTemplateVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateServiceTemplateVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateServiceTemplateVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Proton");
            string target = "AwsProton20200720.UpdateServiceTemplateVersion";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCompatibleEnvironmentTemplates())
                {
                    context.Writer.WritePropertyName("compatibleEnvironmentTemplates");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCompatibleEnvironmentTemplatesListValue in publicRequest.CompatibleEnvironmentTemplates)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CompatibleEnvironmentTemplateInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestCompatibleEnvironmentTemplatesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetMajorVersion())
                {
                    context.Writer.WritePropertyName("majorVersion");
                    context.Writer.Write(publicRequest.MajorVersion);
                }

                if(publicRequest.IsSetMinorVersion())
                {
                    context.Writer.WritePropertyName("minorVersion");
                    context.Writer.Write(publicRequest.MinorVersion);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("status");
                    context.Writer.Write(publicRequest.Status);
                }

                if(publicRequest.IsSetTemplateName())
                {
                    context.Writer.WritePropertyName("templateName");
                    context.Writer.Write(publicRequest.TemplateName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateServiceTemplateVersionRequestMarshaller _instance = new UpdateServiceTemplateVersionRequestMarshaller();        

        internal static UpdateServiceTemplateVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateServiceTemplateVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}