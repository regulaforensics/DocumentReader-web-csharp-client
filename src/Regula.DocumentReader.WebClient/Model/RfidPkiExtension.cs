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
    /// Extension identifier (OID, ASCII string); Contents of the identifier in the format S1 (S2), where S1 – attribute name, S2 – identifier (OID string)
    /// </summary>
    [DataContract(Name = "RfidPkiExtension")]
    public partial class RfidPkiExtension : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RfidPkiExtension" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RfidPkiExtension() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RfidPkiExtension" /> class.
        /// </summary>
        /// <param name="type">Extension identifier (OID, ASCII string); Contents of the identifier in the format S1 (S2), where S1 – attribute name, S2 – identifier (OID string) (required).</param>
        /// <param name="data">Extension binary data. Base64 encoded. (required).</param>
        public RfidPkiExtension(string type = default(string), string data = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for RfidPkiExtension and cannot be null");
            }
            this.Type = type;
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for RfidPkiExtension and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Extension identifier (OID, ASCII string); Contents of the identifier in the format S1 (S2), where S1 – attribute name, S2 – identifier (OID string)
        /// </summary>
        /// <value>Extension identifier (OID, ASCII string); Contents of the identifier in the format S1 (S2), where S1 – attribute name, S2 – identifier (OID string)</value>
        [DataMember(Name = "Type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Extension binary data. Base64 encoded.
        /// </summary>
        /// <value>Extension binary data. Base64 encoded.</value>
        [DataMember(Name = "Data", IsRequired = true, EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RfidPkiExtension {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
