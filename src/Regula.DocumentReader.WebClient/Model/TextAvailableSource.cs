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
    /// TextAvailableSource
    /// </summary>
    [DataContract]
    public partial class TextAvailableSource :  IEquatable<TextAvailableSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextAvailableSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextAvailableSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextAvailableSource" /> class.
        /// </summary>
        /// <param name="source">source (required).</param>
        /// <param name="validityStatus">validityStatus (required).</param>
        /// <param name="containerType">Same as Result type, but used for safe parsing of not-described values. See Result type. (default to 0).</param>
        public TextAvailableSource(string source = default(string), int validityStatus = default(int), int containerType = 0)
        {
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for TextAvailableSource and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            
            // to ensure "validityStatus" is required (not null)
            if (validityStatus == null)
            {
                throw new InvalidDataException("validityStatus is a required property for TextAvailableSource and cannot be null");
            }
            else
            {
                this.ValidityStatus = validityStatus;
            }
            
            // use default value if no "containerType" provided
            if (containerType == null)
            {
                this.ContainerType = 0;
            }
            else
            {
                this.ContainerType = containerType;
            }
        }
        
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=true)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets ValidityStatus
        /// </summary>
        [DataMember(Name="validityStatus", EmitDefaultValue=true)]
        public int ValidityStatus { get; set; }

        /// <summary>
        /// Same as Result type, but used for safe parsing of not-described values. See Result type.
        /// </summary>
        /// <value>Same as Result type, but used for safe parsing of not-described values. See Result type.</value>
        [DataMember(Name="containerType", EmitDefaultValue=false)]
        public int ContainerType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextAvailableSource {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  ValidityStatus: ").Append(ValidityStatus).Append("\n");
            sb.Append("  ContainerType: ").Append(ContainerType).Append("\n");
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
            return this.Equals(input as TextAvailableSource);
        }

        /// <summary>
        /// Returns true if TextAvailableSource instances are equal
        /// </summary>
        /// <param name="input">Instance of TextAvailableSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextAvailableSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.ValidityStatus == input.ValidityStatus ||
                    (this.ValidityStatus != null &&
                    this.ValidityStatus.Equals(input.ValidityStatus))
                ) && 
                (
                    this.ContainerType == input.ContainerType ||
                    (this.ContainerType != null &&
                    this.ContainerType.Equals(input.ContainerType))
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.ValidityStatus != null)
                    hashCode = hashCode * 59 + this.ValidityStatus.GetHashCode();
                if (this.ContainerType != null)
                    hashCode = hashCode * 59 + this.ContainerType.GetHashCode();
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
