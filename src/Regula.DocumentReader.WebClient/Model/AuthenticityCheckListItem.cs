/*
 * Regula Document Reader Web API
 *
 * Documents recognition as easy as reading two bytes.   # Clients: * [JavaScript](https://github.com/regulaforensics/DocumentReader-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/DocumentReader-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/DocumentReader-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/DocumentReader-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 8.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Regula.DocumentReader.WebClient.Client.FileParameter;
using OpenAPIDateConverter = Regula.DocumentReader.WebClient.Client.OpenAPIDateConverter;

namespace Regula.DocumentReader.WebClient.Model
{
    /// <summary>
    /// AuthenticityCheckListItem
    /// </summary>
    [DataContract(Name = "AuthenticityCheckListItem")]
    public partial class AuthenticityCheckListItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticityCheckListItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticityCheckListItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticityCheckListItem" /> class.
        /// </summary>
        /// <param name="authenticityCheckList">authenticityCheckList (required).</param>
        public AuthenticityCheckListItem(AuthenticityCheckList authenticityCheckList = default(AuthenticityCheckList))
        {
            // to ensure "authenticityCheckList" is required (not null)
            if (authenticityCheckList == null)
            {
                throw new ArgumentNullException("authenticityCheckList is a required property for AuthenticityCheckListItem and cannot be null");
            }
            this.AuthenticityCheckList = authenticityCheckList;
        }

        /// <summary>
        /// Gets or Sets AuthenticityCheckList
        /// </summary>
        [DataMember(Name = "AuthenticityCheckList", IsRequired = true, EmitDefaultValue = true)]
        public AuthenticityCheckList AuthenticityCheckList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthenticityCheckListItem {\n");
            sb.Append("  AuthenticityCheckList: ").Append(AuthenticityCheckList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
