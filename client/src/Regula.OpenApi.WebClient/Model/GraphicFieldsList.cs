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
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Regula.OpenApi.WebClient.Model
{
    /// <summary>
    /// GraphicFieldsList
    /// </summary>
    [DataContract]
    public partial class GraphicFieldsList :  IEquatable<GraphicFieldsList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphicFieldsList" /> class.
        /// </summary>
        [JsonConstructor]
        protected GraphicFieldsList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphicFieldsList" /> class.
        /// </summary>
        /// <param name="pArrayFields">pArrayFields (required).</param>
        public GraphicFieldsList(List<GraphicField> pArrayFields = default(List<GraphicField>))
        {
            // to ensure "pArrayFields" is required (not null)
            if (pArrayFields == null)
            {
                throw new InvalidDataException("pArrayFields is a required property for GraphicFieldsList and cannot be null");
            }
            else
            {
                this.PArrayFields = pArrayFields;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets PArrayFields
        /// </summary>
        [DataMember(Name="pArrayFields", EmitDefaultValue=true)]
        public List<GraphicField> PArrayFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GraphicFieldsList {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GraphicFieldsList);
        }

        /// <summary>
        /// Returns true if GraphicFieldsList instances are equal
        /// </summary>
        /// <param name="input">Instance of GraphicFieldsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GraphicFieldsList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PArrayFields == input.PArrayFields ||
                    this.PArrayFields != null &&
                    input.PArrayFields != null &&
                    this.PArrayFields.SequenceEqual(input.PArrayFields)
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
                if (this.PArrayFields != null)
                    hashCode = hashCode * 59 + this.PArrayFields.GetHashCode();
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