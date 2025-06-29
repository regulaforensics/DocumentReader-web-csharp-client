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
    /// FaceItem
    /// </summary>
    [DataContract(Name = "FaceItem")]
    public partial class FaceItem : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LightType
        /// </summary>
        [DataMember(Name = "LightType", IsRequired = true, EmitDefaultValue = true)]
        public Light LightType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FaceItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FaceItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FaceItem" /> class.
        /// </summary>
        /// <param name="coincidenceToPhotoArea">coincidenceToPhotoArea (required).</param>
        /// <param name="faceRect">faceRect (required).</param>
        /// <param name="fieldRect">fieldRect (required).</param>
        /// <param name="graphFieldNumber">graphFieldNumber (required).</param>
        /// <param name="landmarks">landmarks (required).</param>
        /// <param name="lightType">lightType (required).</param>
        /// <param name="orientation">orientation (required).</param>
        /// <param name="probability">probability (required).</param>
        public FaceItem(int coincidenceToPhotoArea = default(int), RectangleCoordinates faceRect = default(RectangleCoordinates), RectangleCoordinates fieldRect = default(RectangleCoordinates), int graphFieldNumber = default(int), List<Point> landmarks = default(List<Point>), Light lightType = default(Light), int orientation = default(int), int probability = default(int))
        {
            this.CoincidenceToPhotoArea = coincidenceToPhotoArea;
            // to ensure "faceRect" is required (not null)
            if (faceRect == null)
            {
                throw new ArgumentNullException("faceRect is a required property for FaceItem and cannot be null");
            }
            this.FaceRect = faceRect;
            // to ensure "fieldRect" is required (not null)
            if (fieldRect == null)
            {
                throw new ArgumentNullException("fieldRect is a required property for FaceItem and cannot be null");
            }
            this.FieldRect = fieldRect;
            this.GraphFieldNumber = graphFieldNumber;
            // to ensure "landmarks" is required (not null)
            if (landmarks == null)
            {
                throw new ArgumentNullException("landmarks is a required property for FaceItem and cannot be null");
            }
            this.Landmarks = landmarks;
            this.LightType = lightType;
            this.Orientation = orientation;
            this.Probability = probability;
        }

        /// <summary>
        /// Gets or Sets CoincidenceToPhotoArea
        /// </summary>
        [DataMember(Name = "CoincidenceToPhotoArea", IsRequired = true, EmitDefaultValue = true)]
        public int CoincidenceToPhotoArea { get; set; }

        /// <summary>
        /// Gets or Sets FaceRect
        /// </summary>
        [DataMember(Name = "FaceRect", IsRequired = true, EmitDefaultValue = true)]
        public RectangleCoordinates FaceRect { get; set; }

        /// <summary>
        /// Gets or Sets FieldRect
        /// </summary>
        [DataMember(Name = "FieldRect", IsRequired = true, EmitDefaultValue = true)]
        public RectangleCoordinates FieldRect { get; set; }

        /// <summary>
        /// Gets or Sets GraphFieldNumber
        /// </summary>
        [DataMember(Name = "GraphFieldNumber", IsRequired = true, EmitDefaultValue = true)]
        public int GraphFieldNumber { get; set; }

        /// <summary>
        /// Gets or Sets Landmarks
        /// </summary>
        [DataMember(Name = "Landmarks", IsRequired = true, EmitDefaultValue = true)]
        public List<Point> Landmarks { get; set; }

        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name = "Orientation", IsRequired = true, EmitDefaultValue = true)]
        public int Orientation { get; set; }

        /// <summary>
        /// Gets or Sets Probability
        /// </summary>
        [DataMember(Name = "Probability", IsRequired = true, EmitDefaultValue = true)]
        public int Probability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FaceItem {\n");
            sb.Append("  CoincidenceToPhotoArea: ").Append(CoincidenceToPhotoArea).Append("\n");
            sb.Append("  FaceRect: ").Append(FaceRect).Append("\n");
            sb.Append("  FieldRect: ").Append(FieldRect).Append("\n");
            sb.Append("  GraphFieldNumber: ").Append(GraphFieldNumber).Append("\n");
            sb.Append("  Landmarks: ").Append(Landmarks).Append("\n");
            sb.Append("  LightType: ").Append(LightType).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  Probability: ").Append(Probability).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
