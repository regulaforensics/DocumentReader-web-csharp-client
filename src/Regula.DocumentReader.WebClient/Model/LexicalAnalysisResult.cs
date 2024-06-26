/* 
 * Regula Document Reader Web API
 *
 * Documents recognition as easy as reading two bytes.  # Clients: * [JavaScript](https://github.com/regulaforensics/DocumentReader-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/DocumentReader-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/DocumentReader-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/DocumentReader-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 7.2.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Regula.DocumentReader.WebClient.Client.OpenAPIDateConverter;

namespace Regula.DocumentReader.WebClient.Model
{
    /// <summary>
    /// Lexical data analysis allows you to compare the results of reading the text data of the MRZ, the document filling area, barcodes and data from the memory of the RFID chip for an additional assessment of the authenticity of the document. Single result for all pages. Consider using Result.TEXT type for more simplicity. 
    /// </summary>
    [DataContract]
    public partial class LexicalAnalysisResult : ResultItem,  IEquatable<LexicalAnalysisResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LexicalAnalysisResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LexicalAnalysisResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LexicalAnalysisResult" /> class.
        /// </summary>
        /// <param name="listVerifiedFields">listVerifiedFields.</param>
        public LexicalAnalysisResult(ListVerifiedFields listVerifiedFields = default(ListVerifiedFields), int bufLength = default(int), int light = default(int), int listIdx = default(int), int pageIdx = default(int), int resultType = 0) : base(bufLength, light, listIdx, pageIdx, resultType)
        {
            this.ListVerifiedFields = listVerifiedFields;
        }
        
        /// <summary>
        /// Gets or Sets ListVerifiedFields
        /// </summary>
        [DataMember(Name="ListVerifiedFields", EmitDefaultValue=false)]
        public ListVerifiedFields ListVerifiedFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LexicalAnalysisResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ListVerifiedFields: ").Append(ListVerifiedFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LexicalAnalysisResult);
        }

        /// <summary>
        /// Returns true if LexicalAnalysisResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LexicalAnalysisResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LexicalAnalysisResult input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ListVerifiedFields == input.ListVerifiedFields ||
                    (this.ListVerifiedFields != null &&
                    this.ListVerifiedFields.Equals(input.ListVerifiedFields))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.ListVerifiedFields != null)
                    hashCode = hashCode * 59 + this.ListVerifiedFields.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
