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
    /// Structure is used to describe the certificate contents used for the digital signature verification of the document security object within the context of the communication session with electronic document.
    /// </summary>
    [DataContract(Name = "RfidCertificateEx")]
    public partial class RfidCertificateEx : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name = "Origin", IsRequired = true, EmitDefaultValue = true)]
        public RfidCertificateOrigin Origin { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", IsRequired = true, EmitDefaultValue = true)]
        public RfidCertificateType Type { get; set; }

        /// <summary>
        /// Gets or Sets PAStatus
        /// </summary>
        [DataMember(Name = "PA_Status", IsRequired = true, EmitDefaultValue = true)]
        public RFIDErrorCodes PAStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RfidCertificateEx" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RfidCertificateEx() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RfidCertificateEx" /> class.
        /// </summary>
        /// <param name="varVersion">Version of Certificate ASN.1 structure (required).</param>
        /// <param name="serialNumber">Certificate serial number. Base64 encoded. (required).</param>
        /// <param name="signatureAlgorithm">Certificate digital signature algorithm identifier (OID); String in the format S1 (S2), where S1 – algorithm name, S2 – identifier (OID string). (required).</param>
        /// <param name="issuer">issuer (required).</param>
        /// <param name="validity">validity (required).</param>
        /// <param name="subject">subject (required).</param>
        /// <param name="subjectPKAlgorithm">Certificate public key algorithm identifier (OID); String in the format S1 (S2), where S1 – algorithm name, S2 – identifier (OID string). (required).</param>
        /// <param name="extensions">List of the certificate extensions (required).</param>
        /// <param name="notifications">List of remarks arisen during the analysis of the certificate data structure and its validity verification. (required).</param>
        /// <param name="origin">origin (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="fileName">fileName (required).</param>
        /// <param name="pAStatus">pAStatus (required).</param>
        public RfidCertificateEx(decimal varVersion = default(decimal), string serialNumber = default(string), string signatureAlgorithm = default(string), RfidDistinguishedName issuer = default(RfidDistinguishedName), RfidValidity validity = default(RfidValidity), RfidDistinguishedName subject = default(RfidDistinguishedName), string subjectPKAlgorithm = default(string), List<RfidPkiExtension> extensions = default(List<RfidPkiExtension>), List<ParsingNotificationCodes> notifications = default(List<ParsingNotificationCodes>), RfidCertificateOrigin origin = default(RfidCertificateOrigin), RfidCertificateType type = default(RfidCertificateType), TrfFtString fileName = default(TrfFtString), RFIDErrorCodes pAStatus = default(RFIDErrorCodes))
        {
            this.VarVersion = varVersion;
            // to ensure "serialNumber" is required (not null)
            if (serialNumber == null)
            {
                throw new ArgumentNullException("serialNumber is a required property for RfidCertificateEx and cannot be null");
            }
            this.SerialNumber = serialNumber;
            // to ensure "signatureAlgorithm" is required (not null)
            if (signatureAlgorithm == null)
            {
                throw new ArgumentNullException("signatureAlgorithm is a required property for RfidCertificateEx and cannot be null");
            }
            this.SignatureAlgorithm = signatureAlgorithm;
            // to ensure "issuer" is required (not null)
            if (issuer == null)
            {
                throw new ArgumentNullException("issuer is a required property for RfidCertificateEx and cannot be null");
            }
            this.Issuer = issuer;
            // to ensure "validity" is required (not null)
            if (validity == null)
            {
                throw new ArgumentNullException("validity is a required property for RfidCertificateEx and cannot be null");
            }
            this.Validity = validity;
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new ArgumentNullException("subject is a required property for RfidCertificateEx and cannot be null");
            }
            this.Subject = subject;
            // to ensure "subjectPKAlgorithm" is required (not null)
            if (subjectPKAlgorithm == null)
            {
                throw new ArgumentNullException("subjectPKAlgorithm is a required property for RfidCertificateEx and cannot be null");
            }
            this.SubjectPKAlgorithm = subjectPKAlgorithm;
            // to ensure "extensions" is required (not null)
            if (extensions == null)
            {
                throw new ArgumentNullException("extensions is a required property for RfidCertificateEx and cannot be null");
            }
            this.Extensions = extensions;
            // to ensure "notifications" is required (not null)
            if (notifications == null)
            {
                throw new ArgumentNullException("notifications is a required property for RfidCertificateEx and cannot be null");
            }
            this.Notifications = notifications;
            this.Origin = origin;
            this.Type = type;
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName is a required property for RfidCertificateEx and cannot be null");
            }
            this.FileName = fileName;
            this.PAStatus = pAStatus;
        }

        /// <summary>
        /// Version of Certificate ASN.1 structure
        /// </summary>
        /// <value>Version of Certificate ASN.1 structure</value>
        [DataMember(Name = "Version", IsRequired = true, EmitDefaultValue = true)]
        public decimal VarVersion { get; set; }

        /// <summary>
        /// Certificate serial number. Base64 encoded.
        /// </summary>
        /// <value>Certificate serial number. Base64 encoded.</value>
        [DataMember(Name = "SerialNumber", IsRequired = true, EmitDefaultValue = true)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Certificate digital signature algorithm identifier (OID); String in the format S1 (S2), where S1 – algorithm name, S2 – identifier (OID string).
        /// </summary>
        /// <value>Certificate digital signature algorithm identifier (OID); String in the format S1 (S2), where S1 – algorithm name, S2 – identifier (OID string).</value>
        [DataMember(Name = "SignatureAlgorithm", IsRequired = true, EmitDefaultValue = true)]
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name = "Issuer", IsRequired = true, EmitDefaultValue = true)]
        public RfidDistinguishedName Issuer { get; set; }

        /// <summary>
        /// Gets or Sets Validity
        /// </summary>
        [DataMember(Name = "Validity", IsRequired = true, EmitDefaultValue = true)]
        public RfidValidity Validity { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "Subject", IsRequired = true, EmitDefaultValue = true)]
        public RfidDistinguishedName Subject { get; set; }

        /// <summary>
        /// Certificate public key algorithm identifier (OID); String in the format S1 (S2), where S1 – algorithm name, S2 – identifier (OID string).
        /// </summary>
        /// <value>Certificate public key algorithm identifier (OID); String in the format S1 (S2), where S1 – algorithm name, S2 – identifier (OID string).</value>
        [DataMember(Name = "SubjectPKAlgorithm", IsRequired = true, EmitDefaultValue = true)]
        public string SubjectPKAlgorithm { get; set; }

        /// <summary>
        /// List of the certificate extensions
        /// </summary>
        /// <value>List of the certificate extensions</value>
        [DataMember(Name = "Extensions", IsRequired = true, EmitDefaultValue = true)]
        public List<RfidPkiExtension> Extensions { get; set; }

        /// <summary>
        /// List of remarks arisen during the analysis of the certificate data structure and its validity verification.
        /// </summary>
        /// <value>List of remarks arisen during the analysis of the certificate data structure and its validity verification.</value>
        [DataMember(Name = "Notifications", IsRequired = true, EmitDefaultValue = true)]
        public List<ParsingNotificationCodes> Notifications { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name = "FileName", IsRequired = true, EmitDefaultValue = true)]
        public TrfFtString FileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RfidCertificateEx {\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  SignatureAlgorithm: ").Append(SignatureAlgorithm).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  SubjectPKAlgorithm: ").Append(SubjectPKAlgorithm).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  PAStatus: ").Append(PAStatus).Append("\n");
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
