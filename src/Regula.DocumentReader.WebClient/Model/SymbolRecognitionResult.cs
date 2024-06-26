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
    /// Describes a single character recognition results in the text field line
    /// </summary>
    [DataContract]
    public partial class SymbolRecognitionResult :  IEquatable<SymbolRecognitionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SymbolRecognitionResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SymbolRecognitionResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SymbolRecognitionResult" /> class.
        /// </summary>
        /// <param name="symbolRect">symbolRect (required).</param>
        /// <param name="listOfCandidates">Array of candidate characters. Sorted in descending order of recognition probabilities (the first element has highest probability) (required).</param>
        public SymbolRecognitionResult(RectangleCoordinates symbolRect = default(RectangleCoordinates), List<SymbolCandidate> listOfCandidates = default(List<SymbolCandidate>))
        {
            // to ensure "symbolRect" is required (not null)
            if (symbolRect == null)
            {
                throw new InvalidDataException("symbolRect is a required property for SymbolRecognitionResult and cannot be null");
            }
            else
            {
                this.SymbolRect = symbolRect;
            }
            
            // to ensure "listOfCandidates" is required (not null)
            if (listOfCandidates == null)
            {
                throw new InvalidDataException("listOfCandidates is a required property for SymbolRecognitionResult and cannot be null");
            }
            else
            {
                this.ListOfCandidates = listOfCandidates;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets SymbolRect
        /// </summary>
        [DataMember(Name="SymbolRect", EmitDefaultValue=true)]
        public RectangleCoordinates SymbolRect { get; set; }

        /// <summary>
        /// Array of candidate characters. Sorted in descending order of recognition probabilities (the first element has highest probability)
        /// </summary>
        /// <value>Array of candidate characters. Sorted in descending order of recognition probabilities (the first element has highest probability)</value>
        [DataMember(Name="ListOfCandidates", EmitDefaultValue=true)]
        public List<SymbolCandidate> ListOfCandidates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SymbolRecognitionResult {\n");
            sb.Append("  SymbolRect: ").Append(SymbolRect).Append("\n");
            sb.Append("  ListOfCandidates: ").Append(ListOfCandidates).Append("\n");
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
            return this.Equals(input as SymbolRecognitionResult);
        }

        /// <summary>
        /// Returns true if SymbolRecognitionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SymbolRecognitionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SymbolRecognitionResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SymbolRect == input.SymbolRect ||
                    (this.SymbolRect != null &&
                    this.SymbolRect.Equals(input.SymbolRect))
                ) && 
                (
                    this.ListOfCandidates == input.ListOfCandidates ||
                    this.ListOfCandidates != null &&
                    input.ListOfCandidates != null &&
                    this.ListOfCandidates.SequenceEqual(input.ListOfCandidates)
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
                if (this.SymbolRect != null)
                    hashCode = hashCode * 59 + this.SymbolRect.GetHashCode();
                if (this.ListOfCandidates != null)
                    hashCode = hashCode * 59 + this.ListOfCandidates.GetHashCode();
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
