/* 
 * Regula Document Reader Web API
 *
 * Documents recognition as easy as reading two bytes.  # Clients: * [JavaScript](https://github.com/regulaforensics/DocumentReader-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/DocumentReader-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/DocumentReader-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/DocumentReader-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 7.4.0
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
    /// Structure and serves for storing information from one text data field. Variant with field logical type and field rectangular area coordinates on the image.
    /// </summary>
    [DataContract]
    public partial class DocVisualExtendedFieldRect :  IEquatable<DocVisualExtendedFieldRect>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocVisualExtendedFieldRect" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocVisualExtendedFieldRect() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocVisualExtendedFieldRect" /> class.
        /// </summary>
        /// <param name="fieldRect">fieldRect.</param>
        /// <param name="fieldType">fieldType (required).</param>
        /// <param name="wFieldType">wFieldType (required).</param>
        /// <param name="fieldName">Field symbolic name (null-terminated string) (required).</param>
        /// <param name="stringsCount">Number of StringsResult array elements (required).</param>
        /// <param name="stringsResult">Array of recognizing probabilities for a each line of text field. Only for Result.VISUAL_TEXT and Result.MRZ_TEXT results. (required).</param>
        /// <param name="bufLength">Buf_Text text string length (required).</param>
        /// <param name="bufText">Text field data in UTF8 format. Results of reading different lines of a multi-line field are separated by &#39;^&#39; (required).</param>
        /// <param name="fieldMask">fieldMask.</param>
        /// <param name="validity">validity.</param>
        /// <param name="inComparison">inComparison.</param>
        /// <param name="reserved2">reserved2.</param>
        /// <param name="reserved3">reserved3.</param>
        public DocVisualExtendedFieldRect(RectangleCoordinates fieldRect = default(RectangleCoordinates), Object fieldType = default(Object), Integer wFieldType = default(Integer), string fieldName = default(string), decimal stringsCount = default(decimal), List<StringRecognitionResult> stringsResult = default(List<StringRecognitionResult>), decimal bufLength = default(decimal), string bufText = default(string), Object fieldMask = default(Object), Object validity = default(Object), Object inComparison = default(Object), Object reserved2 = default(Object), Object reserved3 = default(Object))
        {
            // to ensure "fieldType" is required (not null)
            if (fieldType == null)
            {
                throw new InvalidDataException("fieldType is a required property for DocVisualExtendedFieldRect and cannot be null");
            }
            else
            {
                this.FieldType = fieldType;
            }
            
            this.FieldType = fieldType;
            // to ensure "wFieldType" is required (not null)
            if (wFieldType == null)
            {
                throw new InvalidDataException("wFieldType is a required property for DocVisualExtendedFieldRect and cannot be null");
            }
            else
            {
                this.WFieldType = wFieldType;
            }
            
            // to ensure "fieldName" is required (not null)
            if (fieldName == null)
            {
                throw new InvalidDataException("fieldName is a required property for DocVisualExtendedFieldRect and cannot be null");
            }
            else
            {
                this.FieldName = fieldName;
            }
            
            // to ensure "stringsCount" is required (not null)
            if (stringsCount == null)
            {
                throw new InvalidDataException("stringsCount is a required property for DocVisualExtendedFieldRect and cannot be null");
            }
            else
            {
                this.StringsCount = stringsCount;
            }
            
            // to ensure "stringsResult" is required (not null)
            if (stringsResult == null)
            {
                throw new InvalidDataException("stringsResult is a required property for DocVisualExtendedFieldRect and cannot be null");
            }
            else
            {
                this.StringsResult = stringsResult;
            }
            
            // to ensure "bufLength" is required (not null)
            if (bufLength == null)
            {
                throw new InvalidDataException("bufLength is a required property for DocVisualExtendedFieldRect and cannot be null");
            }
            else
            {
                this.BufLength = bufLength;
            }
            
            // to ensure "bufText" is required (not null)
            if (bufText == null)
            {
                throw new InvalidDataException("bufText is a required property for DocVisualExtendedFieldRect and cannot be null");
            }
            else
            {
                this.BufText = bufText;
            }
            
            this.FieldMask = fieldMask;
            this.Validity = validity;
            this.InComparison = inComparison;
            this.Reserved2 = reserved2;
            this.Reserved3 = reserved3;
            this.FieldRect = fieldRect;
            this.FieldMask = fieldMask;
            this.Validity = validity;
            this.InComparison = inComparison;
            this.Reserved2 = reserved2;
            this.Reserved3 = reserved3;
        }
        
        /// <summary>
        /// Gets or Sets FieldRect
        /// </summary>
        [DataMember(Name="FieldRect", EmitDefaultValue=false)]
        public RectangleCoordinates FieldRect { get; set; }

        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name="FieldType", EmitDefaultValue=true)]
        public Object FieldType { get; set; }

        /// <summary>
        /// Gets or Sets WFieldType
        /// </summary>
        [DataMember(Name="wFieldType", EmitDefaultValue=true)]
        public Integer WFieldType { get; set; }

        /// <summary>
        /// Field symbolic name (null-terminated string)
        /// </summary>
        /// <value>Field symbolic name (null-terminated string)</value>
        [DataMember(Name="FieldName", EmitDefaultValue=true)]
        public string FieldName { get; set; }

        /// <summary>
        /// Number of StringsResult array elements
        /// </summary>
        /// <value>Number of StringsResult array elements</value>
        [DataMember(Name="StringsCount", EmitDefaultValue=true)]
        public decimal StringsCount { get; set; }

        /// <summary>
        /// Array of recognizing probabilities for a each line of text field. Only for Result.VISUAL_TEXT and Result.MRZ_TEXT results.
        /// </summary>
        /// <value>Array of recognizing probabilities for a each line of text field. Only for Result.VISUAL_TEXT and Result.MRZ_TEXT results.</value>
        [DataMember(Name="StringsResult", EmitDefaultValue=true)]
        public List<StringRecognitionResult> StringsResult { get; set; }

        /// <summary>
        /// Buf_Text text string length
        /// </summary>
        /// <value>Buf_Text text string length</value>
        [DataMember(Name="Buf_Length", EmitDefaultValue=true)]
        public decimal BufLength { get; set; }

        /// <summary>
        /// Text field data in UTF8 format. Results of reading different lines of a multi-line field are separated by &#39;^&#39;
        /// </summary>
        /// <value>Text field data in UTF8 format. Results of reading different lines of a multi-line field are separated by &#39;^&#39;</value>
        [DataMember(Name="Buf_Text", EmitDefaultValue=true)]
        public string BufText { get; set; }

        /// <summary>
        /// Gets or Sets FieldMask
        /// </summary>
        [DataMember(Name="FieldMask", EmitDefaultValue=true)]
        public Object FieldMask { get; set; }

        /// <summary>
        /// Gets or Sets Validity
        /// </summary>
        [DataMember(Name="Validity", EmitDefaultValue=true)]
        public Object Validity { get; set; }

        /// <summary>
        /// Gets or Sets InComparison
        /// </summary>
        [DataMember(Name="InComparison", EmitDefaultValue=true)]
        public Object InComparison { get; set; }

        /// <summary>
        /// Gets or Sets Reserved2
        /// </summary>
        [DataMember(Name="Reserved2", EmitDefaultValue=true)]
        public Object Reserved2 { get; set; }

        /// <summary>
        /// Gets or Sets Reserved3
        /// </summary>
        [DataMember(Name="Reserved3", EmitDefaultValue=true)]
        public Object Reserved3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocVisualExtendedFieldRect {\n");
            sb.Append("  FieldRect: ").Append(FieldRect).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  WFieldType: ").Append(WFieldType).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  StringsCount: ").Append(StringsCount).Append("\n");
            sb.Append("  StringsResult: ").Append(StringsResult).Append("\n");
            sb.Append("  BufLength: ").Append(BufLength).Append("\n");
            sb.Append("  BufText: ").Append(BufText).Append("\n");
            sb.Append("  FieldMask: ").Append(FieldMask).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  InComparison: ").Append(InComparison).Append("\n");
            sb.Append("  Reserved2: ").Append(Reserved2).Append("\n");
            sb.Append("  Reserved3: ").Append(Reserved3).Append("\n");
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
            return this.Equals(input as DocVisualExtendedFieldRect);
        }

        /// <summary>
        /// Returns true if DocVisualExtendedFieldRect instances are equal
        /// </summary>
        /// <param name="input">Instance of DocVisualExtendedFieldRect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocVisualExtendedFieldRect input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldRect == input.FieldRect ||
                    (this.FieldRect != null &&
                    this.FieldRect.Equals(input.FieldRect))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.WFieldType == input.WFieldType ||
                    (this.WFieldType != null &&
                    this.WFieldType.Equals(input.WFieldType))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.StringsCount == input.StringsCount ||
                    (this.StringsCount != null &&
                    this.StringsCount.Equals(input.StringsCount))
                ) && 
                (
                    this.StringsResult == input.StringsResult ||
                    this.StringsResult != null &&
                    input.StringsResult != null &&
                    this.StringsResult.SequenceEqual(input.StringsResult)
                ) && 
                (
                    this.BufLength == input.BufLength ||
                    (this.BufLength != null &&
                    this.BufLength.Equals(input.BufLength))
                ) && 
                (
                    this.BufText == input.BufText ||
                    (this.BufText != null &&
                    this.BufText.Equals(input.BufText))
                ) && 
                (
                    this.FieldMask == input.FieldMask ||
                    (this.FieldMask != null &&
                    this.FieldMask.Equals(input.FieldMask))
                ) && 
                (
                    this.Validity == input.Validity ||
                    (this.Validity != null &&
                    this.Validity.Equals(input.Validity))
                ) && 
                (
                    this.InComparison == input.InComparison ||
                    (this.InComparison != null &&
                    this.InComparison.Equals(input.InComparison))
                ) && 
                (
                    this.Reserved2 == input.Reserved2 ||
                    (this.Reserved2 != null &&
                    this.Reserved2.Equals(input.Reserved2))
                ) && 
                (
                    this.Reserved3 == input.Reserved3 ||
                    (this.Reserved3 != null &&
                    this.Reserved3.Equals(input.Reserved3))
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
                if (this.FieldRect != null)
                    hashCode = hashCode * 59 + this.FieldRect.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.WFieldType != null)
                    hashCode = hashCode * 59 + this.WFieldType.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.StringsCount != null)
                    hashCode = hashCode * 59 + this.StringsCount.GetHashCode();
                if (this.StringsResult != null)
                    hashCode = hashCode * 59 + this.StringsResult.GetHashCode();
                if (this.BufLength != null)
                    hashCode = hashCode * 59 + this.BufLength.GetHashCode();
                if (this.BufText != null)
                    hashCode = hashCode * 59 + this.BufText.GetHashCode();
                if (this.FieldMask != null)
                    hashCode = hashCode * 59 + this.FieldMask.GetHashCode();
                if (this.Validity != null)
                    hashCode = hashCode * 59 + this.Validity.GetHashCode();
                if (this.InComparison != null)
                    hashCode = hashCode * 59 + this.InComparison.GetHashCode();
                if (this.Reserved2 != null)
                    hashCode = hashCode * 59 + this.Reserved2.GetHashCode();
                if (this.Reserved3 != null)
                    hashCode = hashCode * 59 + this.Reserved3.GetHashCode();
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