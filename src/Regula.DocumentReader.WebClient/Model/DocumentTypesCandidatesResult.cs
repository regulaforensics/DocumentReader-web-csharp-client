/* 
 * Regula Document Reader Web API
 *
 * Regula Document Reader Web API
 *
 * The version of the OpenAPI document: 5.2.0
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
    /// DocumentTypesCandidatesResult
    /// </summary>
    [DataContract]
    public partial class DocumentTypesCandidatesResult : ResultItem,  IEquatable<DocumentTypesCandidatesResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTypesCandidatesResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentTypesCandidatesResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTypesCandidatesResult" /> class.
        /// </summary>
        /// <param name="candidatesList">candidatesList.</param>
        public DocumentTypesCandidatesResult(DocumentTypesCandidatesList candidatesList = default(DocumentTypesCandidatesList), int bufLength = default(int), int light = default(int), int listIdx = default(int), int pageIdx = default(int), int resultType = 0) : base(bufLength, light, listIdx, pageIdx, resultType)
        {
            this.CandidatesList = candidatesList;
        }
        
        /// <summary>
        /// Gets or Sets CandidatesList
        /// </summary>
        [DataMember(Name="CandidatesList", EmitDefaultValue=false)]
        public DocumentTypesCandidatesList CandidatesList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTypesCandidatesResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CandidatesList: ").Append(CandidatesList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentTypesCandidatesResult);
        }

        /// <summary>
        /// Returns true if DocumentTypesCandidatesResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentTypesCandidatesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTypesCandidatesResult input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CandidatesList == input.CandidatesList ||
                    (this.CandidatesList != null &&
                    this.CandidatesList.Equals(input.CandidatesList))
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
                if (this.CandidatesList != null)
                    hashCode = hashCode * 59 + this.CandidatesList.GetHashCode();
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