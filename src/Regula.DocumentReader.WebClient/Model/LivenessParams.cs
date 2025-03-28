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
    /// LivenessParams
    /// </summary>
    [DataContract]
    public partial class LivenessParams :  IEquatable<LivenessParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LivenessParams" /> class.
        /// </summary>
        /// <param name="checkOVI">This parameter is used to enable OVI check.</param>
        /// <param name="checkMLI">This parameter is used to enable MLI check.</param>
        /// <param name="checkHolo">This parameter is used to enable Hologram detection.</param>
        /// <param name="checkED">This parameter is used to enable Electronic device detection.</param>
        /// <param name="checkBlackAndWhiteCopy">This parameter is used to enable Black and white copy check.</param>
        /// <param name="checkDynaprint">This parameter is used to enable Dynaprint check.</param>
        public LivenessParams(bool? checkOVI = default(bool?), bool? checkMLI = default(bool?), bool? checkHolo = default(bool?), bool? checkED = default(bool?), bool? checkBlackAndWhiteCopy = default(bool?), bool? checkDynaprint = default(bool?))
        {
            this.CheckOVI = checkOVI;
            this.CheckMLI = checkMLI;
            this.CheckHolo = checkHolo;
            this.CheckED = checkED;
            this.CheckBlackAndWhiteCopy = checkBlackAndWhiteCopy;
            this.CheckDynaprint = checkDynaprint;
        }
        
        /// <summary>
        /// This parameter is used to enable OVI check
        /// </summary>
        /// <value>This parameter is used to enable OVI check</value>
        [DataMember(Name="checkOVI", EmitDefaultValue=false)]
        public bool? CheckOVI { get; set; }

        /// <summary>
        /// This parameter is used to enable MLI check
        /// </summary>
        /// <value>This parameter is used to enable MLI check</value>
        [DataMember(Name="checkMLI", EmitDefaultValue=false)]
        public bool? CheckMLI { get; set; }

        /// <summary>
        /// This parameter is used to enable Hologram detection
        /// </summary>
        /// <value>This parameter is used to enable Hologram detection</value>
        [DataMember(Name="checkHolo", EmitDefaultValue=false)]
        public bool? CheckHolo { get; set; }

        /// <summary>
        /// This parameter is used to enable Electronic device detection
        /// </summary>
        /// <value>This parameter is used to enable Electronic device detection</value>
        [DataMember(Name="checkED", EmitDefaultValue=false)]
        public bool? CheckED { get; set; }

        /// <summary>
        /// This parameter is used to enable Black and white copy check
        /// </summary>
        /// <value>This parameter is used to enable Black and white copy check</value>
        [DataMember(Name="checkBlackAndWhiteCopy", EmitDefaultValue=false)]
        public bool? CheckBlackAndWhiteCopy { get; set; }

        /// <summary>
        /// This parameter is used to enable Dynaprint check
        /// </summary>
        /// <value>This parameter is used to enable Dynaprint check</value>
        [DataMember(Name="checkDynaprint", EmitDefaultValue=false)]
        public bool? CheckDynaprint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LivenessParams {\n");
            sb.Append("  CheckOVI: ").Append(CheckOVI).Append("\n");
            sb.Append("  CheckMLI: ").Append(CheckMLI).Append("\n");
            sb.Append("  CheckHolo: ").Append(CheckHolo).Append("\n");
            sb.Append("  CheckED: ").Append(CheckED).Append("\n");
            sb.Append("  CheckBlackAndWhiteCopy: ").Append(CheckBlackAndWhiteCopy).Append("\n");
            sb.Append("  CheckDynaprint: ").Append(CheckDynaprint).Append("\n");
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
            return this.Equals(input as LivenessParams);
        }

        /// <summary>
        /// Returns true if LivenessParams instances are equal
        /// </summary>
        /// <param name="input">Instance of LivenessParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LivenessParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckOVI == input.CheckOVI ||
                    (this.CheckOVI != null &&
                    this.CheckOVI.Equals(input.CheckOVI))
                ) && 
                (
                    this.CheckMLI == input.CheckMLI ||
                    (this.CheckMLI != null &&
                    this.CheckMLI.Equals(input.CheckMLI))
                ) && 
                (
                    this.CheckHolo == input.CheckHolo ||
                    (this.CheckHolo != null &&
                    this.CheckHolo.Equals(input.CheckHolo))
                ) && 
                (
                    this.CheckED == input.CheckED ||
                    (this.CheckED != null &&
                    this.CheckED.Equals(input.CheckED))
                ) && 
                (
                    this.CheckBlackAndWhiteCopy == input.CheckBlackAndWhiteCopy ||
                    (this.CheckBlackAndWhiteCopy != null &&
                    this.CheckBlackAndWhiteCopy.Equals(input.CheckBlackAndWhiteCopy))
                ) && 
                (
                    this.CheckDynaprint == input.CheckDynaprint ||
                    (this.CheckDynaprint != null &&
                    this.CheckDynaprint.Equals(input.CheckDynaprint))
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
                if (this.CheckOVI != null)
                    hashCode = hashCode * 59 + this.CheckOVI.GetHashCode();
                if (this.CheckMLI != null)
                    hashCode = hashCode * 59 + this.CheckMLI.GetHashCode();
                if (this.CheckHolo != null)
                    hashCode = hashCode * 59 + this.CheckHolo.GetHashCode();
                if (this.CheckED != null)
                    hashCode = hashCode * 59 + this.CheckED.GetHashCode();
                if (this.CheckBlackAndWhiteCopy != null)
                    hashCode = hashCode * 59 + this.CheckBlackAndWhiteCopy.GetHashCode();
                if (this.CheckDynaprint != null)
                    hashCode = hashCode * 59 + this.CheckDynaprint.GetHashCode();
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
