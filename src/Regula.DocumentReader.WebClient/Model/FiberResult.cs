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
    /// FiberResult
    /// </summary>
    [DataContract]
    public partial class FiberResult : AuthenticityCheckResultItem,  IEquatable<FiberResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FiberResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FiberResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FiberResult" /> class.
        /// </summary>
        /// <param name="rectCount">For UV_Fibers authenticity result type.</param>
        /// <param name="expectedCount">Expected fibers number. For UV_Fibers authentication result type.</param>
        /// <param name="lightValue">lightValue.</param>
        /// <param name="lightDisp">For UV_Background authentication result type.</param>
        /// <param name="rectArray">Coordinates of located areas for defined fibers type.</param>
        /// <param name="width">Fibers width value for located areas (in pixels).</param>
        /// <param name="length">Fibers length value for located areas (in pixels).</param>
        /// <param name="area">Fibers value for areas (in pixels).</param>
        /// <param name="colorValues">Fibers color value.</param>
        public FiberResult(int rectCount = default(int), int expectedCount = default(int), int lightValue = default(int), int lightDisp = default(int), List<RectangleCoordinates> rectArray = default(List<RectangleCoordinates>), List<int> width = default(List<int>), List<int> length = default(List<int>), List<int> area = default(List<int>), List<int> colorValues = default(List<int>), int type = 0, int elementResult = default(int), int elementDiagnose = default(int)) : base(type, elementResult, elementDiagnose)
        {
            this.RectCount = rectCount;
            this.ExpectedCount = expectedCount;
            this.LightValue = lightValue;
            this.LightDisp = lightDisp;
            this.RectArray = rectArray;
            this.Width = width;
            this.Length = length;
            this.Area = area;
            this.ColorValues = colorValues;
        }
        
        /// <summary>
        /// For UV_Fibers authenticity result type
        /// </summary>
        /// <value>For UV_Fibers authenticity result type</value>
        [DataMember(Name="RectCount", EmitDefaultValue=false)]
        public int RectCount { get; set; }

        /// <summary>
        /// Expected fibers number. For UV_Fibers authentication result type
        /// </summary>
        /// <value>Expected fibers number. For UV_Fibers authentication result type</value>
        [DataMember(Name="ExpectedCount", EmitDefaultValue=false)]
        public int ExpectedCount { get; set; }

        /// <summary>
        /// Gets or Sets LightValue
        /// </summary>
        [DataMember(Name="LightValue", EmitDefaultValue=false)]
        public int LightValue { get; set; }

        /// <summary>
        /// For UV_Background authentication result type
        /// </summary>
        /// <value>For UV_Background authentication result type</value>
        [DataMember(Name="LightDisp", EmitDefaultValue=false)]
        public int LightDisp { get; set; }

        /// <summary>
        /// Coordinates of located areas for defined fibers type
        /// </summary>
        /// <value>Coordinates of located areas for defined fibers type</value>
        [DataMember(Name="RectArray", EmitDefaultValue=false)]
        public List<RectangleCoordinates> RectArray { get; set; }

        /// <summary>
        /// Fibers width value for located areas (in pixels)
        /// </summary>
        /// <value>Fibers width value for located areas (in pixels)</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public List<int> Width { get; set; }

        /// <summary>
        /// Fibers length value for located areas (in pixels)
        /// </summary>
        /// <value>Fibers length value for located areas (in pixels)</value>
        [DataMember(Name="Length", EmitDefaultValue=false)]
        public List<int> Length { get; set; }

        /// <summary>
        /// Fibers value for areas (in pixels)
        /// </summary>
        /// <value>Fibers value for areas (in pixels)</value>
        [DataMember(Name="Area", EmitDefaultValue=false)]
        public List<int> Area { get; set; }

        /// <summary>
        /// Fibers color value
        /// </summary>
        /// <value>Fibers color value</value>
        [DataMember(Name="ColorValues", EmitDefaultValue=false)]
        public List<int> ColorValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FiberResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RectCount: ").Append(RectCount).Append("\n");
            sb.Append("  ExpectedCount: ").Append(ExpectedCount).Append("\n");
            sb.Append("  LightValue: ").Append(LightValue).Append("\n");
            sb.Append("  LightDisp: ").Append(LightDisp).Append("\n");
            sb.Append("  RectArray: ").Append(RectArray).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  ColorValues: ").Append(ColorValues).Append("\n");
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
            return this.Equals(input as FiberResult);
        }

        /// <summary>
        /// Returns true if FiberResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FiberResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FiberResult input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.RectCount == input.RectCount ||
                    (this.RectCount != null &&
                    this.RectCount.Equals(input.RectCount))
                ) && base.Equals(input) && 
                (
                    this.ExpectedCount == input.ExpectedCount ||
                    (this.ExpectedCount != null &&
                    this.ExpectedCount.Equals(input.ExpectedCount))
                ) && base.Equals(input) && 
                (
                    this.LightValue == input.LightValue ||
                    (this.LightValue != null &&
                    this.LightValue.Equals(input.LightValue))
                ) && base.Equals(input) && 
                (
                    this.LightDisp == input.LightDisp ||
                    (this.LightDisp != null &&
                    this.LightDisp.Equals(input.LightDisp))
                ) && base.Equals(input) && 
                (
                    this.RectArray == input.RectArray ||
                    this.RectArray != null &&
                    input.RectArray != null &&
                    this.RectArray.SequenceEqual(input.RectArray)
                ) && base.Equals(input) && 
                (
                    this.Width == input.Width ||
                    this.Width != null &&
                    input.Width != null &&
                    this.Width.SequenceEqual(input.Width)
                ) && base.Equals(input) && 
                (
                    this.Length == input.Length ||
                    this.Length != null &&
                    input.Length != null &&
                    this.Length.SequenceEqual(input.Length)
                ) && base.Equals(input) && 
                (
                    this.Area == input.Area ||
                    this.Area != null &&
                    input.Area != null &&
                    this.Area.SequenceEqual(input.Area)
                ) && base.Equals(input) && 
                (
                    this.ColorValues == input.ColorValues ||
                    this.ColorValues != null &&
                    input.ColorValues != null &&
                    this.ColorValues.SequenceEqual(input.ColorValues)
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
                if (this.RectCount != null)
                    hashCode = hashCode * 59 + this.RectCount.GetHashCode();
                if (this.ExpectedCount != null)
                    hashCode = hashCode * 59 + this.ExpectedCount.GetHashCode();
                if (this.LightValue != null)
                    hashCode = hashCode * 59 + this.LightValue.GetHashCode();
                if (this.LightDisp != null)
                    hashCode = hashCode * 59 + this.LightDisp.GetHashCode();
                if (this.RectArray != null)
                    hashCode = hashCode * 59 + this.RectArray.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.ColorValues != null)
                    hashCode = hashCode * 59 + this.ColorValues.GetHashCode();
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