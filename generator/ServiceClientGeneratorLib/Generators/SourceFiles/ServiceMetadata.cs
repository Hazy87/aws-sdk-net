﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ServiceMetadata : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"

    AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing Amazon.Runtime.Internal;\r\n\r\n\r\nnamespace ");
            
            #line 14 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Internal\r\n{\r\n    /// <summary>\r\n    /// Service metadata for  Amazon ");
            
            #line 17 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(" service\r\n    /// </summary>\r\n    public partial class Amazon");
            
            #line 19 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Metadata : IServiceMetadata\r\n    {\r\n        /// <summary>\r\n        /// Gets the v" +
                    "alue of the Service Id.\r\n        /// </summary>\r\n        public string ServiceId" +
                    "\r\n        {\r\n            get\r\n            {\r\n");
            
            #line 28 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"

            if(!string.IsNullOrEmpty(this.Config.ServiceId))
            {

            
            #line default
            #line hidden
            this.Write("                return \"");
            
            #line 32 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceId));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 33 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"

            }
            else
            {
                var result = Utils.DetermineServiceId(this.Config.ServiceModel.ServiceAbbreviation, 
                this.Config.ServiceModel.ServiceFullName);
                
                if(!string.IsNullOrEmpty(result))
                {

            
            #line default
            #line hidden
            this.Write("                return \"");
            
            #line 43 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(result));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 44 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"

                }
                else
                {

            
            #line default
            #line hidden
            this.Write("                return \"");
            
            #line 49 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.EndpointPrefix));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 50 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"

                }
            }

            
            #line default
            #line hidden
            this.Write(@"            }
        }

        /// <summary>
        /// Gets the dictionary that gives mapping of renamed operations
        /// </summary>
        public System.Collections.Generic.IDictionary<string, string> OperationNameMapping
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, string>(");
            
            #line 64 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.OperationsNameMapping.Count));
            
            #line default
            #line hidden
            this.Write(")\r\n                {\r\n");
            
            #line 66 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"

            foreach(var entry in this.Config.ServiceModel.OperationsNameMapping)
            {

            
            #line default
            #line hidden
            this.Write("                    {\"");
            
            #line 70 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entry.Key));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 70 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entry.Value));
            
            #line default
            #line hidden
            this.Write("\"},\r\n");
            
            #line 71 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceMetadata.tt"

            }

            
            #line default
            #line hidden
            this.Write("                };\r\n            }\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
