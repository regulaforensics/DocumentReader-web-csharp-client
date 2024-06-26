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
    /// CrossSourceValueComparison
    /// </summary>
    [DataContract]
    public partial class CrossSourceValueComparison :  IEquatable<CrossSourceValueComparison>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossSourceValueComparison" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CrossSourceValueComparison() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossSourceValueComparison" /> class.
        /// </summary>
        /// <param name="sourceLeft">sourceLeft (required).</param>
        /// <param name="sourceRight">sourceRight (required).</param>
        /// <param name="status">status (required).</param>
        public CrossSourceValueComparison(string sourceLeft = default(string), string sourceRight = default(string), int status = default(int))
        {
            // to ensure "sourceLeft" is required (not null)
            if (sourceLeft == null)
            {
                throw new InvalidDataException("sourceLeft is a required property for CrossSourceValueComparison and cannot be null");
            }
            else
            {
                this.SourceLeft = sourceLeft;
            }
            
            // to ensure "sourceRight" is required (not null)
            if (sourceRight == null)
            {
                throw new InvalidDataException("sourceRight is a required property for CrossSourceValueComparison and cannot be null");
            }
            else
            {
                this.SourceRight = sourceRight;
            }
            
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for CrossSourceValueComparison and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets SourceLeft
        /// </summary>
        [DataMember(Name="sourceLeft", EmitDefaultValue=true)]
        public string SourceLeft { get; set; }

        /// <summary>
        /// Gets or Sets SourceRight
        /// </summary>
        [DataMember(Name="sourceRight", EmitDefaultValue=true)]
        public string SourceRight { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public int Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrossSourceValueComparison {\n");
            sb.Append("  SourceLeft: ").Append(SourceLeft).Append("\n");
            sb.Append("  SourceRight: ").Append(SourceRight).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CrossSourceValueComparison);
        }

        /// <summary>
        /// Returns true if CrossSourceValueComparison instances are equal
        /// </summary>
        /// <param name="input">Instance of CrossSourceValueComparison to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrossSourceValueComparison input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceLeft == input.SourceLeft ||
                    (this.SourceLeft != null &&
                    this.SourceLeft.Equals(input.SourceLeft))
                ) && 
                (
                    this.SourceRight == input.SourceRight ||
                    (this.SourceRight != null &&
                    this.SourceRight.Equals(input.SourceRight))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.SourceLeft != null)
                    hashCode = hashCode * 59 + this.SourceLeft.GetHashCode();
                if (this.SourceRight != null)
                    hashCode = hashCode * 59 + this.SourceRight.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
