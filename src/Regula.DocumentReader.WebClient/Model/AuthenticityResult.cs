/* 
 * Regula Document Reader Web API
 *
 * Documents recognition as easy as reading two bytes.  # Clients: * [JavaScript](https://github.com/regulaforensics/DocumentReader-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/DocumentReader-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/DocumentReader-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/DocumentReader-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 5.5.0
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
    /// AuthenticityResult
    /// </summary>
    [DataContract]
    public partial class AuthenticityResult : ResultItem,  IEquatable<AuthenticityResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticityResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticityResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticityResult" /> class.
        /// </summary>
        /// <param name="authenticityCheckList">authenticityCheckList (required).</param>
        public AuthenticityResult(AuthenticityCheckList authenticityCheckList = default(AuthenticityCheckList), int bufLength = default(int), int light = default(int), int listIdx = default(int), int pageIdx = default(int), int resultType = 0) : base(bufLength, light, listIdx, pageIdx, resultType)
        {
            // to ensure "authenticityCheckList" is required (not null)
            if (authenticityCheckList == null)
            {
                throw new InvalidDataException("authenticityCheckList is a required property for AuthenticityResult and cannot be null");
            }
            else
            {
                this.AuthenticityCheckList = authenticityCheckList;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets AuthenticityCheckList
        /// </summary>
        [DataMember(Name="AuthenticityCheckList", EmitDefaultValue=true)]
        public AuthenticityCheckList AuthenticityCheckList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticityResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AuthenticityCheckList: ").Append(AuthenticityCheckList).Append("\n");
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
            return this.Equals(input as AuthenticityResult);
        }

        /// <summary>
        /// Returns true if AuthenticityResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticityResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticityResult input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AuthenticityCheckList == input.AuthenticityCheckList ||
                    (this.AuthenticityCheckList != null &&
                    this.AuthenticityCheckList.Equals(input.AuthenticityCheckList))
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
                if (this.AuthenticityCheckList != null)
                    hashCode = hashCode * 59 + this.AuthenticityCheckList.GetHashCode();
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