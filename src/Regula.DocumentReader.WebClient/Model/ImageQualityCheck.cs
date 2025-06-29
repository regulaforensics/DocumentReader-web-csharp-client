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
    /// ImageQualityCheck
    /// </summary>
    [DataContract(Name = "ImageQualityCheck")]
    public partial class ImageQualityCheck : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public ImageQualityCheckType Type { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", IsRequired = true, EmitDefaultValue = true)]
        public CheckResult Result { get; set; }

        /// <summary>
        /// Gets or Sets FeatureType
        /// </summary>
        [DataMember(Name = "featureType", IsRequired = true, EmitDefaultValue = true)]
        public SecurityFeatureType FeatureType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageQualityCheck" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageQualityCheck() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageQualityCheck" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="result">result (required).</param>
        /// <param name="featureType">featureType (required).</param>
        /// <param name="areas">areas.</param>
        /// <param name="mean">Check mean value (required).</param>
        /// <param name="stdDev">Check deviation value (required).</param>
        /// <param name="probability">Check probability value (required).</param>
        public ImageQualityCheck(ImageQualityCheckType type = default(ImageQualityCheckType), CheckResult result = default(CheckResult), SecurityFeatureType featureType = default(SecurityFeatureType), AreaArray areas = default(AreaArray), float mean = default(float), float stdDev = default(float), int probability = default(int))
        {
            this.Type = type;
            this.Result = result;
            this.FeatureType = featureType;
            this.Mean = mean;
            this.StdDev = stdDev;
            this.Probability = probability;
            this.Areas = areas;
        }

        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name = "areas", EmitDefaultValue = false)]
        public AreaArray? Areas { get; set; }

        /// <summary>
        /// Check mean value
        /// </summary>
        /// <value>Check mean value</value>
        [DataMember(Name = "mean", IsRequired = true, EmitDefaultValue = true)]
        public float Mean { get; set; }

        /// <summary>
        /// Check deviation value
        /// </summary>
        /// <value>Check deviation value</value>
        [DataMember(Name = "std_dev", IsRequired = true, EmitDefaultValue = true)]
        public float StdDev { get; set; }

        /// <summary>
        /// Check probability value
        /// </summary>
        /// <value>Check probability value</value>
        [DataMember(Name = "probability", IsRequired = true, EmitDefaultValue = true)]
        public int Probability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImageQualityCheck {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  FeatureType: ").Append(FeatureType).Append("\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  StdDev: ").Append(StdDev).Append("\n");
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
