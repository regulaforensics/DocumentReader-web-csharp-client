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
    /// VerifiedFieldMap
    /// </summary>
    [DataContract(Name = "VerifiedFieldMap")]
    public partial class VerifiedFieldMap : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets WFieldType
        /// </summary>
        [DataMember(Name = "wFieldType", IsRequired = true, EmitDefaultValue = true)]
        public TextFieldType WFieldType { get; set; }

        /// <summary>
        /// Gets or Sets WLCID
        /// </summary>
        [DataMember(Name = "wLCID", IsRequired = true, EmitDefaultValue = true)]
        public LCID WLCID { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifiedFieldMap" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifiedFieldMap() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifiedFieldMap" /> class.
        /// </summary>
        /// <param name="wFieldType">wFieldType (required).</param>
        /// <param name="wLCID">wLCID (required).</param>
        /// <param name="fieldMRZ">Field data extracted from mrz(machine readable zone).</param>
        /// <param name="fieldVisual">Field data extracted from visual zone.</param>
        /// <param name="fieldBarcode">Field data extracted from barcode.</param>
        /// <param name="fieldRFID">Field data extracted from rfid chip.</param>
        /// <param name="matrix">results comparison matrix. Elements of the matrix with indices 0, 1, 2, 3 take one of the values Disabled(0), Verified(1) or Not_Verified(2), elements with indices 4, 5, 6, 7, 8 are one of the values Disabled(0), Compare_Match(3) or Compare_Not_Match(4). Elements of the Matrix matrix have the following semantic meaning: - element with index 0 –– the result of verification of data from the MRZ; - 1 –– the result of verification of data from the RFID microcircuit; - 2 –– the result of verification of data from text areas of the document; - 3 –– the result of verification data from barcodes; - 4 - the result of comparing MRZ data and RFID microcircuits; - 5 - the result of comparing MRZ data and text areas of document filling; - 6 - the result of comparing MRZ data and bar codes; - 7 - the result of comparing the data of text areas of the document and the RFID chip; - 8 - the result of comparing the data of the text areas of the document and barcodes; - 9 - the result of comparing the data of the RFID chip and barcodes. (required).</param>
        public VerifiedFieldMap(TextFieldType wFieldType = default(TextFieldType), LCID wLCID = default(LCID), string fieldMRZ = default(string), string fieldVisual = default(string), string fieldBarcode = default(string), string fieldRFID = default(string), List<VerificationResult> matrix = default(List<VerificationResult>))
        {
            this.WFieldType = wFieldType;
            this.WLCID = wLCID;
            // to ensure "matrix" is required (not null)
            if (matrix == null)
            {
                throw new ArgumentNullException("matrix is a required property for VerifiedFieldMap and cannot be null");
            }
            this.Matrix = matrix;
            this.FieldMRZ = fieldMRZ;
            this.FieldVisual = fieldVisual;
            this.FieldBarcode = fieldBarcode;
            this.FieldRFID = fieldRFID;
        }

        /// <summary>
        /// Field data extracted from mrz(machine readable zone)
        /// </summary>
        /// <value>Field data extracted from mrz(machine readable zone)</value>
        [DataMember(Name = "Field_MRZ", EmitDefaultValue = false)]
        public string? FieldMRZ { get; set; }

        /// <summary>
        /// Field data extracted from visual zone
        /// </summary>
        /// <value>Field data extracted from visual zone</value>
        [DataMember(Name = "Field_Visual", EmitDefaultValue = false)]
        public string? FieldVisual { get; set; }

        /// <summary>
        /// Field data extracted from barcode
        /// </summary>
        /// <value>Field data extracted from barcode</value>
        [DataMember(Name = "Field_Barcode", EmitDefaultValue = false)]
        public string? FieldBarcode { get; set; }

        /// <summary>
        /// Field data extracted from rfid chip
        /// </summary>
        /// <value>Field data extracted from rfid chip</value>
        [DataMember(Name = "Field_RFID", EmitDefaultValue = false)]
        public string? FieldRFID { get; set; }

        /// <summary>
        /// results comparison matrix. Elements of the matrix with indices 0, 1, 2, 3 take one of the values Disabled(0), Verified(1) or Not_Verified(2), elements with indices 4, 5, 6, 7, 8 are one of the values Disabled(0), Compare_Match(3) or Compare_Not_Match(4). Elements of the Matrix matrix have the following semantic meaning: - element with index 0 –– the result of verification of data from the MRZ; - 1 –– the result of verification of data from the RFID microcircuit; - 2 –– the result of verification of data from text areas of the document; - 3 –– the result of verification data from barcodes; - 4 - the result of comparing MRZ data and RFID microcircuits; - 5 - the result of comparing MRZ data and text areas of document filling; - 6 - the result of comparing MRZ data and bar codes; - 7 - the result of comparing the data of text areas of the document and the RFID chip; - 8 - the result of comparing the data of the text areas of the document and barcodes; - 9 - the result of comparing the data of the RFID chip and barcodes.
        /// </summary>
        /// <value>results comparison matrix. Elements of the matrix with indices 0, 1, 2, 3 take one of the values Disabled(0), Verified(1) or Not_Verified(2), elements with indices 4, 5, 6, 7, 8 are one of the values Disabled(0), Compare_Match(3) or Compare_Not_Match(4). Elements of the Matrix matrix have the following semantic meaning: - element with index 0 –– the result of verification of data from the MRZ; - 1 –– the result of verification of data from the RFID microcircuit; - 2 –– the result of verification of data from text areas of the document; - 3 –– the result of verification data from barcodes; - 4 - the result of comparing MRZ data and RFID microcircuits; - 5 - the result of comparing MRZ data and text areas of document filling; - 6 - the result of comparing MRZ data and bar codes; - 7 - the result of comparing the data of text areas of the document and the RFID chip; - 8 - the result of comparing the data of the text areas of the document and barcodes; - 9 - the result of comparing the data of the RFID chip and barcodes.</value>
        /*
        <example>[1,0,0,0,0,3,0,0,0,0]</example>
        */
        [DataMember(Name = "Matrix", IsRequired = true, EmitDefaultValue = true)]
        public List<VerificationResult> Matrix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerifiedFieldMap {\n");
            sb.Append("  WFieldType: ").Append(WFieldType).Append("\n");
            sb.Append("  WLCID: ").Append(WLCID).Append("\n");
            sb.Append("  FieldMRZ: ").Append(FieldMRZ).Append("\n");
            sb.Append("  FieldVisual: ").Append(FieldVisual).Append("\n");
            sb.Append("  FieldBarcode: ").Append(FieldBarcode).Append("\n");
            sb.Append("  FieldRFID: ").Append(FieldRFID).Append("\n");
            sb.Append("  Matrix: ").Append(Matrix).Append("\n");
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
