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
    /// Information about one graphic field, which is a RFID
    /// </summary>
    [DataContract]
    public partial class GraphicFieldRfid :  IEquatable<GraphicFieldRfid>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphicFieldRfid" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GraphicFieldRfid() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphicFieldRfid" /> class.
        /// </summary>
        /// <param name="rFIDOriginDG">rFIDOriginDG (required).</param>
        /// <param name="rFIDOriginDGTag">Index of the source record of the image with biometric information in the information data group. Only for Result.RFID_GRAPHICS result. (required).</param>
        /// <param name="rFIDOriginTagEntry">Index of the template in the record with biometric data. Only for Result.RFID_GRAPHICS result. (required).</param>
        /// <param name="rFIDOriginEntryView">Index of the variant of the biometric data template. Only for Result.RFID_GRAPHICS result. (required).</param>
        /// <param name="fieldType">fieldType (required).</param>
        /// <param name="fieldName">Graphic field symbolic name (required).</param>
        /// <param name="image">image (required).</param>
        public GraphicFieldRfid(Integer rFIDOriginDG = default(Integer), int rFIDOriginDGTag = default(int), int rFIDOriginTagEntry = default(int), int rFIDOriginEntryView = default(int), Integer fieldType = default(Integer), string fieldName = default(string), ImageData image = default(ImageData))
        {
            // to ensure "rFIDOriginDG" is required (not null)
            if (rFIDOriginDG == null)
            {
                throw new InvalidDataException("rFIDOriginDG is a required property for GraphicFieldRfid and cannot be null");
            }
            else
            {
                this.RFIDOriginDG = rFIDOriginDG;
            }
            
            // to ensure "rFIDOriginDGTag" is required (not null)
            if (rFIDOriginDGTag == null)
            {
                throw new InvalidDataException("rFIDOriginDGTag is a required property for GraphicFieldRfid and cannot be null");
            }
            else
            {
                this.RFIDOriginDGTag = rFIDOriginDGTag;
            }
            
            // to ensure "rFIDOriginTagEntry" is required (not null)
            if (rFIDOriginTagEntry == null)
            {
                throw new InvalidDataException("rFIDOriginTagEntry is a required property for GraphicFieldRfid and cannot be null");
            }
            else
            {
                this.RFIDOriginTagEntry = rFIDOriginTagEntry;
            }
            
            // to ensure "rFIDOriginEntryView" is required (not null)
            if (rFIDOriginEntryView == null)
            {
                throw new InvalidDataException("rFIDOriginEntryView is a required property for GraphicFieldRfid and cannot be null");
            }
            else
            {
                this.RFIDOriginEntryView = rFIDOriginEntryView;
            }
            
            // to ensure "fieldType" is required (not null)
            if (fieldType == null)
            {
                throw new InvalidDataException("fieldType is a required property for GraphicFieldRfid and cannot be null");
            }
            else
            {
                this.FieldType = fieldType;
            }
            
            // to ensure "fieldName" is required (not null)
            if (fieldName == null)
            {
                throw new InvalidDataException("fieldName is a required property for GraphicFieldRfid and cannot be null");
            }
            else
            {
                this.FieldName = fieldName;
            }
            
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new InvalidDataException("image is a required property for GraphicFieldRfid and cannot be null");
            }
            else
            {
                this.Image = image;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets RFIDOriginDG
        /// </summary>
        [DataMember(Name="RFID_OriginDG", EmitDefaultValue=true)]
        public Integer RFIDOriginDG { get; set; }

        /// <summary>
        /// Index of the source record of the image with biometric information in the information data group. Only for Result.RFID_GRAPHICS result.
        /// </summary>
        /// <value>Index of the source record of the image with biometric information in the information data group. Only for Result.RFID_GRAPHICS result.</value>
        [DataMember(Name="RFID_OriginDGTag", EmitDefaultValue=true)]
        public int RFIDOriginDGTag { get; set; }

        /// <summary>
        /// Index of the template in the record with biometric data. Only for Result.RFID_GRAPHICS result.
        /// </summary>
        /// <value>Index of the template in the record with biometric data. Only for Result.RFID_GRAPHICS result.</value>
        [DataMember(Name="RFID_OriginTagEntry", EmitDefaultValue=true)]
        public int RFIDOriginTagEntry { get; set; }

        /// <summary>
        /// Index of the variant of the biometric data template. Only for Result.RFID_GRAPHICS result.
        /// </summary>
        /// <value>Index of the variant of the biometric data template. Only for Result.RFID_GRAPHICS result.</value>
        [DataMember(Name="RFID_OriginEntryView", EmitDefaultValue=true)]
        public int RFIDOriginEntryView { get; set; }

        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name="FieldType", EmitDefaultValue=true)]
        public Integer FieldType { get; set; }

        /// <summary>
        /// Graphic field symbolic name
        /// </summary>
        /// <value>Graphic field symbolic name</value>
        [DataMember(Name="FieldName", EmitDefaultValue=true)]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=true)]
        public ImageData Image { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GraphicFieldRfid {\n");
            sb.Append("  RFIDOriginDG: ").Append(RFIDOriginDG).Append("\n");
            sb.Append("  RFIDOriginDGTag: ").Append(RFIDOriginDGTag).Append("\n");
            sb.Append("  RFIDOriginTagEntry: ").Append(RFIDOriginTagEntry).Append("\n");
            sb.Append("  RFIDOriginEntryView: ").Append(RFIDOriginEntryView).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return this.Equals(input as GraphicFieldRfid);
        }

        /// <summary>
        /// Returns true if GraphicFieldRfid instances are equal
        /// </summary>
        /// <param name="input">Instance of GraphicFieldRfid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GraphicFieldRfid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RFIDOriginDG == input.RFIDOriginDG ||
                    (this.RFIDOriginDG != null &&
                    this.RFIDOriginDG.Equals(input.RFIDOriginDG))
                ) && 
                (
                    this.RFIDOriginDGTag == input.RFIDOriginDGTag ||
                    (this.RFIDOriginDGTag != null &&
                    this.RFIDOriginDGTag.Equals(input.RFIDOriginDGTag))
                ) && 
                (
                    this.RFIDOriginTagEntry == input.RFIDOriginTagEntry ||
                    (this.RFIDOriginTagEntry != null &&
                    this.RFIDOriginTagEntry.Equals(input.RFIDOriginTagEntry))
                ) && 
                (
                    this.RFIDOriginEntryView == input.RFIDOriginEntryView ||
                    (this.RFIDOriginEntryView != null &&
                    this.RFIDOriginEntryView.Equals(input.RFIDOriginEntryView))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
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
                if (this.RFIDOriginDG != null)
                    hashCode = hashCode * 59 + this.RFIDOriginDG.GetHashCode();
                if (this.RFIDOriginDGTag != null)
                    hashCode = hashCode * 59 + this.RFIDOriginDGTag.GetHashCode();
                if (this.RFIDOriginTagEntry != null)
                    hashCode = hashCode * 59 + this.RFIDOriginTagEntry.GetHashCode();
                if (this.RFIDOriginEntryView != null)
                    hashCode = hashCode * 59 + this.RFIDOriginEntryView.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
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