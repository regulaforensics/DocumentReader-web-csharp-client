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
    /// DocBarCodeInfoFieldsList
    /// </summary>
    [DataContract(Name = "DocBarCodeInfoFieldsList")]
    public partial class DocBarCodeInfoFieldsList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocBarCodeInfoFieldsList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocBarCodeInfoFieldsList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocBarCodeInfoFieldsList" /> class.
        /// </summary>
        /// <param name="nFields">Count of array fields (required).</param>
        /// <param name="pArrayFields">Data from barcode (required).</param>
        public DocBarCodeInfoFieldsList(int nFields = default(int), List<PArrayField> pArrayFields = default(List<PArrayField>))
        {
            this.NFields = nFields;
            // to ensure "pArrayFields" is required (not null)
            if (pArrayFields == null)
            {
                throw new ArgumentNullException("pArrayFields is a required property for DocBarCodeInfoFieldsList and cannot be null");
            }
            this.PArrayFields = pArrayFields;
        }

        /// <summary>
        /// Count of array fields
        /// </summary>
        /// <value>Count of array fields</value>
        [DataMember(Name = "nFields", IsRequired = true, EmitDefaultValue = true)]
        public int NFields { get; set; }

        /// <summary>
        /// Data from barcode
        /// </summary>
        /// <value>Data from barcode</value>
        [DataMember(Name = "pArrayFields", IsRequired = true, EmitDefaultValue = true)]
        public List<PArrayField> PArrayFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocBarCodeInfoFieldsList {\n");
            sb.Append("  NFields: ").Append(NFields).Append("\n");
            sb.Append("  PArrayFields: ").Append(PArrayFields).Append("\n");
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
