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
    /// PhotoIdentResult
    /// </summary>
    [DataContract]
    public partial class PhotoIdentResult : AuthenticityCheckResultItem,  IEquatable<PhotoIdentResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhotoIdentResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PhotoIdentResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhotoIdentResult" /> class.
        /// </summary>
        /// <param name="lightIndex">lightIndex.</param>
        /// <param name="area">area.</param>
        /// <param name="sourceImage">sourceImage.</param>
        /// <param name="resultImages">resultImages.</param>
        /// <param name="fieldTypesCount">fieldTypesCount.</param>
        /// <param name="fieldTypesList">fieldTypesList.</param>
        /// <param name="step">step.</param>
        /// <param name="angle">angle.</param>
        /// <param name="reserved3">reserved3.</param>
        public PhotoIdentResult(int lightIndex = default(int), RectangleCoordinates area = default(RectangleCoordinates), ImageData sourceImage = default(ImageData), RawImageContainerList resultImages = default(RawImageContainerList), int fieldTypesCount = default(int), List<int> fieldTypesList = default(List<int>), int step = default(int), int angle = default(int), int reserved3 = default(int), int type = 0, int elementResult = default(int), int elementDiagnose = default(int)) : base(type, elementResult, elementDiagnose)
        {
            this.LightIndex = lightIndex;
            this.Area = area;
            this.SourceImage = sourceImage;
            this.ResultImages = resultImages;
            this.FieldTypesCount = fieldTypesCount;
            this.FieldTypesList = fieldTypesList;
            this.Step = step;
            this.Angle = angle;
            this.Reserved3 = reserved3;
        }
        
        /// <summary>
        /// Gets or Sets LightIndex
        /// </summary>
        [DataMember(Name="LightIndex", EmitDefaultValue=false)]
        public int LightIndex { get; set; }

        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name="Area", EmitDefaultValue=false)]
        public RectangleCoordinates Area { get; set; }

        /// <summary>
        /// Gets or Sets SourceImage
        /// </summary>
        [DataMember(Name="SourceImage", EmitDefaultValue=false)]
        public ImageData SourceImage { get; set; }

        /// <summary>
        /// Gets or Sets ResultImages
        /// </summary>
        [DataMember(Name="ResultImages", EmitDefaultValue=false)]
        public RawImageContainerList ResultImages { get; set; }

        /// <summary>
        /// Gets or Sets FieldTypesCount
        /// </summary>
        [DataMember(Name="FieldTypesCount", EmitDefaultValue=false)]
        public int FieldTypesCount { get; set; }

        /// <summary>
        /// Gets or Sets FieldTypesList
        /// </summary>
        [DataMember(Name="FieldTypesList", EmitDefaultValue=false)]
        public List<int> FieldTypesList { get; set; }

        /// <summary>
        /// Gets or Sets Step
        /// </summary>
        [DataMember(Name="Step", EmitDefaultValue=false)]
        public int Step { get; set; }

        /// <summary>
        /// Gets or Sets Angle
        /// </summary>
        [DataMember(Name="Angle", EmitDefaultValue=false)]
        public int Angle { get; set; }

        /// <summary>
        /// Gets or Sets Reserved3
        /// </summary>
        [DataMember(Name="Reserved3", EmitDefaultValue=false)]
        public int Reserved3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhotoIdentResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  LightIndex: ").Append(LightIndex).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  SourceImage: ").Append(SourceImage).Append("\n");
            sb.Append("  ResultImages: ").Append(ResultImages).Append("\n");
            sb.Append("  FieldTypesCount: ").Append(FieldTypesCount).Append("\n");
            sb.Append("  FieldTypesList: ").Append(FieldTypesList).Append("\n");
            sb.Append("  Step: ").Append(Step).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
            sb.Append("  Reserved3: ").Append(Reserved3).Append("\n");
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
            return this.Equals(input as PhotoIdentResult);
        }

        /// <summary>
        /// Returns true if PhotoIdentResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PhotoIdentResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhotoIdentResult input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.LightIndex == input.LightIndex ||
                    (this.LightIndex != null &&
                    this.LightIndex.Equals(input.LightIndex))
                ) && base.Equals(input) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && base.Equals(input) && 
                (
                    this.SourceImage == input.SourceImage ||
                    (this.SourceImage != null &&
                    this.SourceImage.Equals(input.SourceImage))
                ) && base.Equals(input) && 
                (
                    this.ResultImages == input.ResultImages ||
                    (this.ResultImages != null &&
                    this.ResultImages.Equals(input.ResultImages))
                ) && base.Equals(input) && 
                (
                    this.FieldTypesCount == input.FieldTypesCount ||
                    (this.FieldTypesCount != null &&
                    this.FieldTypesCount.Equals(input.FieldTypesCount))
                ) && base.Equals(input) && 
                (
                    this.FieldTypesList == input.FieldTypesList ||
                    this.FieldTypesList != null &&
                    input.FieldTypesList != null &&
                    this.FieldTypesList.SequenceEqual(input.FieldTypesList)
                ) && base.Equals(input) && 
                (
                    this.Step == input.Step ||
                    (this.Step != null &&
                    this.Step.Equals(input.Step))
                ) && base.Equals(input) && 
                (
                    this.Angle == input.Angle ||
                    (this.Angle != null &&
                    this.Angle.Equals(input.Angle))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.LightIndex != null)
                    hashCode = hashCode * 59 + this.LightIndex.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.SourceImage != null)
                    hashCode = hashCode * 59 + this.SourceImage.GetHashCode();
                if (this.ResultImages != null)
                    hashCode = hashCode * 59 + this.ResultImages.GetHashCode();
                if (this.FieldTypesCount != null)
                    hashCode = hashCode * 59 + this.FieldTypesCount.GetHashCode();
                if (this.FieldTypesList != null)
                    hashCode = hashCode * 59 + this.FieldTypesList.GetHashCode();
                if (this.Step != null)
                    hashCode = hashCode * 59 + this.Step.GetHashCode();
                if (this.Angle != null)
                    hashCode = hashCode * 59 + this.Angle.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}