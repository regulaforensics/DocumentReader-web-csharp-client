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
    /// PArrayField
    /// </summary>
    [DataContract(Name = "pArrayField")]
    public partial class PArrayField : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets BcTextFieldType
        /// </summary>
        [DataMember(Name = "bcTextFieldType", EmitDefaultValue = false)]
        public TextFieldType? BcTextFieldType { get; set; }

        /// <summary>
        /// Gets or Sets BcTypeDECODE
        /// </summary>
        [DataMember(Name = "bcType_DECODE", IsRequired = true, EmitDefaultValue = true)]
        public BarcodeType BcTypeDECODE { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PArrayField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PArrayField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PArrayField" /> class.
        /// </summary>
        /// <param name="bcAngleDETECT">bcAngleDETECT (required).</param>
        /// <param name="bcCodeResult">bcCodeResult (required).</param>
        /// <param name="bcCountModule">bcCountModule (required).</param>
        /// <param name="bcDataModule">bcDataModule (required).</param>
        /// <param name="bcPDF417INFO">bcPDF417INFO.</param>
        /// <param name="bcROIDETECT">bcROIDETECT (required).</param>
        /// <param name="bcTextDecoderTypes">bcTextDecoderTypes.</param>
        /// <param name="bcTextFieldType">bcTextFieldType.</param>
        /// <param name="bcTypeDECODE">bcTypeDECODE (required).</param>
        /// <param name="bcTypeDETECT">bcTypeDETECT (required).</param>
        public PArrayField(float bcAngleDETECT = default(float), int bcCodeResult = default(int), int bcCountModule = default(int), List<DataModule> bcDataModule = default(List<DataModule>), BcPDF417INFO bcPDF417INFO = default(BcPDF417INFO), BcROIDETECT bcROIDETECT = default(BcROIDETECT), int bcTextDecoderTypes = default(int), TextFieldType? bcTextFieldType = default(TextFieldType?), BarcodeType bcTypeDECODE = default(BarcodeType), int bcTypeDETECT = default(int))
        {
            this.BcAngleDETECT = bcAngleDETECT;
            this.BcCodeResult = bcCodeResult;
            this.BcCountModule = bcCountModule;
            // to ensure "bcDataModule" is required (not null)
            if (bcDataModule == null)
            {
                throw new ArgumentNullException("bcDataModule is a required property for PArrayField and cannot be null");
            }
            this.BcDataModule = bcDataModule;
            // to ensure "bcROIDETECT" is required (not null)
            if (bcROIDETECT == null)
            {
                throw new ArgumentNullException("bcROIDETECT is a required property for PArrayField and cannot be null");
            }
            this.BcROIDETECT = bcROIDETECT;
            this.BcTypeDECODE = bcTypeDECODE;
            this.BcTypeDETECT = bcTypeDETECT;
            this.BcPDF417INFO = bcPDF417INFO;
            this.BcTextDecoderTypes = bcTextDecoderTypes;
            this.BcTextFieldType = bcTextFieldType;
        }

        /// <summary>
        /// Gets or Sets BcAngleDETECT
        /// </summary>
        [DataMember(Name = "bcAngle_DETECT", IsRequired = true, EmitDefaultValue = true)]
        public float BcAngleDETECT { get; set; }

        /// <summary>
        /// Gets or Sets BcCodeResult
        /// </summary>
        [DataMember(Name = "bcCodeResult", IsRequired = true, EmitDefaultValue = true)]
        public int BcCodeResult { get; set; }

        /// <summary>
        /// Gets or Sets BcCountModule
        /// </summary>
        [DataMember(Name = "bcCountModule", IsRequired = true, EmitDefaultValue = true)]
        public int BcCountModule { get; set; }

        /// <summary>
        /// Gets or Sets BcDataModule
        /// </summary>
        [DataMember(Name = "bcDataModule", IsRequired = true, EmitDefaultValue = true)]
        public List<DataModule> BcDataModule { get; set; }

        /// <summary>
        /// Gets or Sets BcPDF417INFO
        /// </summary>
        [DataMember(Name = "bcPDF417INFO", EmitDefaultValue = false)]
        public BcPDF417INFO? BcPDF417INFO { get; set; }

        /// <summary>
        /// Gets or Sets BcROIDETECT
        /// </summary>
        [DataMember(Name = "bcROI_DETECT", IsRequired = true, EmitDefaultValue = true)]
        public BcROIDETECT BcROIDETECT { get; set; }

        /// <summary>
        /// Gets or Sets BcTextDecoderTypes
        /// </summary>
        [DataMember(Name = "bcTextDecoderTypes", EmitDefaultValue = false)]
        public int? BcTextDecoderTypes { get; set; }

        /// <summary>
        /// Gets or Sets BcTypeDETECT
        /// </summary>
        [DataMember(Name = "bcType_DETECT", IsRequired = true, EmitDefaultValue = true)]
        public int BcTypeDETECT { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PArrayField {\n");
            sb.Append("  BcAngleDETECT: ").Append(BcAngleDETECT).Append("\n");
            sb.Append("  BcCodeResult: ").Append(BcCodeResult).Append("\n");
            sb.Append("  BcCountModule: ").Append(BcCountModule).Append("\n");
            sb.Append("  BcDataModule: ").Append(BcDataModule).Append("\n");
            sb.Append("  BcPDF417INFO: ").Append(BcPDF417INFO).Append("\n");
            sb.Append("  BcROIDETECT: ").Append(BcROIDETECT).Append("\n");
            sb.Append("  BcTextDecoderTypes: ").Append(BcTextDecoderTypes).Append("\n");
            sb.Append("  BcTextFieldType: ").Append(BcTextFieldType).Append("\n");
            sb.Append("  BcTypeDECODE: ").Append(BcTypeDECODE).Append("\n");
            sb.Append("  BcTypeDETECT: ").Append(BcTypeDETECT).Append("\n");
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
