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
    /// Structure is used to store information about the numeric field (4 bytes) that is a part of one of the informational data groups.
    /// </summary>
    [DataContract(Name = "TrfFtString")]
    public partial class TrfFtString : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrfFtString" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrfFtString() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrfFtString" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="status">Result of logical analysis of compliance of the contents of the field with the requirements of the specification.</param>
        /// <param name="format">Mask of format of text information (for example, «YYMMDD» for date of birth).</param>
        /// <param name="data">Numeric value. (required).</param>
        public TrfFtString(int type = default(int), int status = default(int), string format = default(string), string data = default(string))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for TrfFtString and cannot be null");
            }
            this.Data = data;
            this.Type = type;
            this.Status = status;
            this.Format = format;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public int? Type { get; set; }

        /// <summary>
        /// Result of logical analysis of compliance of the contents of the field with the requirements of the specification
        /// </summary>
        /// <value>Result of logical analysis of compliance of the contents of the field with the requirements of the specification</value>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public int? Status { get; set; }

        /// <summary>
        /// Mask of format of text information (for example, «YYMMDD» for date of birth)
        /// </summary>
        /// <value>Mask of format of text information (for example, «YYMMDD» for date of birth)</value>
        [DataMember(Name = "Format", EmitDefaultValue = false)]
        public string? Format { get; set; }

        /// <summary>
        /// Numeric value.
        /// </summary>
        /// <value>Numeric value.</value>
        [DataMember(Name = "Data", IsRequired = true, EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrfFtString {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
