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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Regula.OpenApi.WebClient.Model
{
    /// <summary>
    /// DocumentTypesCandidatesResultAllOf
    /// </summary>
    [DataContract]
    public partial class DocumentTypesCandidatesResultAllOf :  IEquatable<DocumentTypesCandidatesResultAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTypesCandidatesResultAllOf" /> class.
        /// </summary>
        /// <param name="candidatesList">candidatesList.</param>
        public DocumentTypesCandidatesResultAllOf(DocumentTypesCandidatesList candidatesList = default(DocumentTypesCandidatesList))
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
            sb.Append("class DocumentTypesCandidatesResultAllOf {\n");
            sb.Append("  CandidatesList: ").Append(CandidatesList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as DocumentTypesCandidatesResultAllOf);
        }

        /// <summary>
        /// Returns true if DocumentTypesCandidatesResultAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentTypesCandidatesResultAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTypesCandidatesResultAllOf input)
        {
            if (input == null)
                return false;

            return 
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
                int hashCode = 41;
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
            yield break;
        }
    }

}