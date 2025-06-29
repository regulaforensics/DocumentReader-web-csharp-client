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
    /// Coordinates of the rectangle region on a document image(result type 1). Represented by two points - (left, top) + (right, bottom)
    /// </summary>
    [DataContract(Name = "RectangleCoordinates")]
    public partial class RectangleCoordinates : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RectangleCoordinates" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RectangleCoordinates() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RectangleCoordinates" /> class.
        /// </summary>
        /// <param name="left">left (required).</param>
        /// <param name="top">top (required).</param>
        /// <param name="right">right (required).</param>
        /// <param name="bottom">bottom (required).</param>
        public RectangleCoordinates(int left = default(int), int top = default(int), int right = default(int), int bottom = default(int))
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
        }

        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        [DataMember(Name = "left", IsRequired = true, EmitDefaultValue = true)]
        public int Left { get; set; }

        /// <summary>
        /// Gets or Sets Top
        /// </summary>
        [DataMember(Name = "top", IsRequired = true, EmitDefaultValue = true)]
        public int Top { get; set; }

        /// <summary>
        /// Gets or Sets Right
        /// </summary>
        [DataMember(Name = "right", IsRequired = true, EmitDefaultValue = true)]
        public int Right { get; set; }

        /// <summary>
        /// Gets or Sets Bottom
        /// </summary>
        [DataMember(Name = "bottom", IsRequired = true, EmitDefaultValue = true)]
        public int Bottom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RectangleCoordinates {\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  Bottom: ").Append(Bottom).Append("\n");
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
