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
using System.Runtime.Serialization;
using System.Text;
using JsonSubTypes;
using Newtonsoft.Json;

namespace Regula.OpenApi.WebClient.Model
{
    /// <summary>
    /// Common fields for all result objects
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "result_type")]
    [JsonSubtypes.KnownSubType(typeof(ImagesResult), Result.IMAGES)]
    [JsonSubtypes.KnownSubType(typeof(LexicalAnalysisResult), Result.LEXICAL_ANALYSIS)]
    [JsonSubtypes.KnownSubType(typeof(DocumentImageResult), Result.DOCUMENT_IMAGE)]
    [JsonSubtypes.KnownSubType(typeof(TextDataResult), Result.VISUAL_TEXT)]
    [JsonSubtypes.KnownSubType(typeof(DocumentTypesCandidatesResult), Result.DOCUMENT_TYPE_CANDIDATES)]
    [JsonSubtypes.KnownSubType(typeof(StatusResult), Result.STATUS)]
    [JsonSubtypes.KnownSubType(typeof(ChosenDocumentTypeResult), Result.DOCUMENT_TYPE)]
    [JsonSubtypes.KnownSubType(typeof(TextResult), Result.TEXT)]
    [JsonSubtypes.KnownSubType(typeof(GraphicsResult), Result.VISUAL_GRAPHICS)]
    public partial class ResultItem :  IEquatable<ResultItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultItem" /> class.
        /// </summary>
        [JsonConstructor]
        protected ResultItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultItem" /> class.
        /// </summary>
        /// <param name="bufLength">bufLength.</param>
        /// <param name="light">light.</param>
        /// <param name="listIdx">listIdx.</param>
        /// <param name="pageIdx">pageIdx.</param>
        /// <param name="resultType">Same as Result type, but used for safe parsing of not-described values. See Result type. (required).</param>
        public ResultItem(int bufLength = default(int), int light = default(int), int listIdx = default(int), int pageIdx = default(int), int resultType = default(int))
        {
            // to ensure "resultType" is required (not null)
            if (resultType == null)
            {
                throw new InvalidDataException("resultType is a required property for ResultItem and cannot be null");
            }
            else
            {
                this.ResultType = resultType;
            }
            
            this.BufLength = bufLength;
            this.Light = light;
            this.ListIdx = listIdx;
            this.PageIdx = pageIdx;
        }
        
        /// <summary>
        /// Gets or Sets BufLength
        /// </summary>
        [DataMember(Name="buf_length", EmitDefaultValue=false)]
        public int BufLength { get; set; }

        /// <summary>
        /// Gets or Sets Light
        /// </summary>
        [DataMember(Name="light", EmitDefaultValue=false)]
        public int Light { get; set; }

        /// <summary>
        /// Gets or Sets ListIdx
        /// </summary>
        [DataMember(Name="list_idx", EmitDefaultValue=false)]
        public int ListIdx { get; set; }

        /// <summary>
        /// Gets or Sets PageIdx
        /// </summary>
        [DataMember(Name="page_idx", EmitDefaultValue=false)]
        public int PageIdx { get; set; }

        /// <summary>
        /// Same as Result type, but used for safe parsing of not-described values. See Result type.
        /// </summary>
        /// <value>Same as Result type, but used for safe parsing of not-described values. See Result type.</value>
        [DataMember(Name="result_type", EmitDefaultValue=true)]
        public int ResultType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultItem {\n");
            sb.Append("  BufLength: ").Append(BufLength).Append("\n");
            sb.Append("  Light: ").Append(Light).Append("\n");
            sb.Append("  ListIdx: ").Append(ListIdx).Append("\n");
            sb.Append("  PageIdx: ").Append(PageIdx).Append("\n");
            sb.Append("  ResultType: ").Append(ResultType).Append("\n");
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
            return this.Equals(input as ResultItem);
        }

        /// <summary>
        /// Returns true if ResultItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ResultItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BufLength == input.BufLength ||
                    (this.BufLength != null &&
                    this.BufLength.Equals(input.BufLength))
                ) && 
                (
                    this.Light == input.Light ||
                    (this.Light != null &&
                    this.Light.Equals(input.Light))
                ) && 
                (
                    this.ListIdx == input.ListIdx ||
                    (this.ListIdx != null &&
                    this.ListIdx.Equals(input.ListIdx))
                ) && 
                (
                    this.PageIdx == input.PageIdx ||
                    (this.PageIdx != null &&
                    this.PageIdx.Equals(input.PageIdx))
                ) && 
                (
                    this.ResultType == input.ResultType ||
                    (this.ResultType != null &&
                    this.ResultType.Equals(input.ResultType))
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
                if (this.BufLength != null)
                    hashCode = hashCode * 59 + this.BufLength.GetHashCode();
                if (this.Light != null)
                    hashCode = hashCode * 59 + this.Light.GetHashCode();
                if (this.ListIdx != null)
                    hashCode = hashCode * 59 + this.ListIdx.GetHashCode();
                if (this.PageIdx != null)
                    hashCode = hashCode * 59 + this.PageIdx.GetHashCode();
                if (this.ResultType != null)
                    hashCode = hashCode * 59 + this.ResultType.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}