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
using System.ComponentModel.DataAnnotations;
using FileParameter = Regula.DocumentReader.WebClient.Client.FileParameter;
using OpenAPIDateConverter = Regula.DocumentReader.WebClient.Client.OpenAPIDateConverter;

namespace Regula.DocumentReader.WebClient.Model
{
    /// <summary>
    /// DocVisualExtendedField
    /// </summary>
    [DataContract(Name = "DocVisualExtendedField")]
    public partial class DocVisualExtendedField : VisualExtendedFieldItem, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocVisualExtendedField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocVisualExtendedField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocVisualExtendedField" /> class.
        /// </summary>
        /// <param name="fieldRect">fieldRect (required).</param>
        /// <param name="wFieldType">wFieldType (required).</param>
        /// <param name="fieldName">Field symbolic name (null-terminated string) (required).</param>
        /// <param name="stringsCount">Number of StringsResult array elements (required).</param>
        /// <param name="stringsResult">Array of recognizing probabilities for a each line of text field. Only for Result.VISUAL_TEXT and Result.MRZ_TEXT results. (required).</param>
        /// <param name="bufLength">Buf_Text text string length (required).</param>
        /// <param name="bufText">Text field data in UTF8 format. Results of reading different lines of a multi-line field are separated by &#39;^&#39; (required).</param>
        /// <param name="fieldMask">fieldMask.</param>
        /// <param name="validity">validity.</param>
        /// <param name="inComparison">inComparison.</param>
        /// <param name="wLCID">wLCID.</param>
        /// <param name="reserved2">reserved2.</param>
        /// <param name="reserved3">reserved3.</param>
        public DocVisualExtendedField(RectangleCoordinates fieldRect = default(RectangleCoordinates), TextFieldType wFieldType = default(TextFieldType), string fieldName = default(string), decimal stringsCount = default(decimal), List<StringRecognitionResult> stringsResult = default(List<StringRecognitionResult>), decimal bufLength = default(decimal), string bufText = default(string), string fieldMask = default(string), int validity = default(int), int inComparison = default(int), LCID? wLCID = default(LCID?), int reserved2 = default(int), int reserved3 = default(int)) : base(wFieldType, fieldName, stringsCount, stringsResult, bufLength, bufText, fieldMask, validity, inComparison, wLCID, reserved2, reserved3)
        {
            // to ensure "fieldRect" is required (not null)
            if (fieldRect == null)
            {
                throw new ArgumentNullException("fieldRect is a required property for DocVisualExtendedField and cannot be null");
            }
            this.FieldRect = fieldRect;
        }

        /// <summary>
        /// Gets or Sets FieldRect
        /// </summary>
        [DataMember(Name = "FieldRect", IsRequired = true, EmitDefaultValue = true)]
        public RectangleCoordinates FieldRect { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocVisualExtendedField {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  FieldRect: ").Append(FieldRect).Append("\n");
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
            foreach (var x in BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
