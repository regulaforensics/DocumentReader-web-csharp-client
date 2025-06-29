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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Regula.DocumentReader.WebClient.Client.FileParameter;
using OpenAPIDateConverter = Regula.DocumentReader.WebClient.Client.OpenAPIDateConverter;

namespace Regula.DocumentReader.WebClient.Model
{
    /// <summary>
    /// Contains document image.
    /// </summary>
    [DataContract(Name = "DocumentImageResult")]
    public partial class DocumentImageResult : ResultItem, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentImageResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentImageResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentImageResult" /> class.
        /// </summary>
        /// <param name="rawImageContainer">rawImageContainer (required).</param>
        /// <param name="bufLength">bufLength.</param>
        /// <param name="light">light.</param>
        /// <param name="listIdx">listIdx.</param>
        /// <param name="pageIdx">pageIdx.</param>
        /// <param name="resultType">resultType (required) (default to Result.DOCUMENT_IMAGE).</param>
        public DocumentImageResult(ImageData rawImageContainer = default(ImageData), int bufLength = default(int), int light = default(int), int listIdx = default(int), int pageIdx = default(int), Result resultType = Result.DOCUMENT_IMAGE) : base(bufLength, light, listIdx, pageIdx, resultType)
        {
            // to ensure "rawImageContainer" is required (not null)
            if (rawImageContainer == null)
            {
                throw new ArgumentNullException("rawImageContainer is a required property for DocumentImageResult and cannot be null");
            }
            this.RawImageContainer = rawImageContainer;
        }

        /// <summary>
        /// Gets or Sets RawImageContainer
        /// </summary>
        [DataMember(Name = "RawImageContainer", IsRequired = true, EmitDefaultValue = true)]
        public ImageData RawImageContainer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentImageResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RawImageContainer: ").Append(RawImageContainer).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
