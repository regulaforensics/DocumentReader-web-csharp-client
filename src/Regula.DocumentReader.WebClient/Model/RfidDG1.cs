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
    /// Structure used to store the contents of EF.DG1 informational data group of ePassport application – document MRZ data
    /// </summary>
    [DataContract]
    public partial class RfidDG1 :  IEquatable<RfidDG1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RfidDG1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RfidDG1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RfidDG1" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="documentID">documentID (required).</param>
        /// <param name="documentType">Symbolic code of document type (required).</param>
        /// <param name="state">Symbolic code of document issuing state (required).</param>
        /// <param name="holder">DO’s name and surname (required).</param>
        /// <param name="documentNumber">Document number (required).</param>
        /// <param name="checkDigitDocumentNumber">Check digit of document number (required).</param>
        /// <param name="nationality">Symbolic code of DO’s nationality (required).</param>
        /// <param name="birthday">DO’s date of birth (required).</param>
        /// <param name="checkDigitBirthday">Check digit of DO’s date of birth (required).</param>
        /// <param name="sex">DO’s sex (required).</param>
        /// <param name="expiryDate">Term of validity of the document (required).</param>
        /// <param name="checkDigitExpiryDate">Check digit of term of validity of the document (required).</param>
        /// <param name="optionalData">DO’s personal number or other additional data (required).</param>
        /// <param name="checkDigitOptionalData">Check digit of additional data (required).</param>
        /// <param name="checkDigitComposite">General check digit (required).</param>
        public RfidDG1(Integer type = default(Integer), Integer documentID = default(Integer), string documentType = default(string), string state = default(string), string holder = default(string), string documentNumber = default(string), decimal checkDigitDocumentNumber = default(decimal), string nationality = default(string), string birthday = default(string), decimal checkDigitBirthday = default(decimal), string sex = default(string), string expiryDate = default(string), decimal checkDigitExpiryDate = default(decimal), string optionalData = default(string), decimal checkDigitOptionalData = default(decimal), decimal checkDigitComposite = default(decimal))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "documentID" is required (not null)
            if (documentID == null)
            {
                throw new InvalidDataException("documentID is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.DocumentID = documentID;
            }
            
            // to ensure "documentType" is required (not null)
            if (documentType == null)
            {
                throw new InvalidDataException("documentType is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.DocumentType = documentType;
            }
            
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.State = state;
            }
            
            // to ensure "holder" is required (not null)
            if (holder == null)
            {
                throw new InvalidDataException("holder is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.Holder = holder;
            }
            
            // to ensure "documentNumber" is required (not null)
            if (documentNumber == null)
            {
                throw new InvalidDataException("documentNumber is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.DocumentNumber = documentNumber;
            }
            
            // to ensure "checkDigitDocumentNumber" is required (not null)
            if (checkDigitDocumentNumber == null)
            {
                throw new InvalidDataException("checkDigitDocumentNumber is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.CheckDigitDocumentNumber = checkDigitDocumentNumber;
            }
            
            // to ensure "nationality" is required (not null)
            if (nationality == null)
            {
                throw new InvalidDataException("nationality is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.Nationality = nationality;
            }
            
            // to ensure "birthday" is required (not null)
            if (birthday == null)
            {
                throw new InvalidDataException("birthday is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.Birthday = birthday;
            }
            
            // to ensure "checkDigitBirthday" is required (not null)
            if (checkDigitBirthday == null)
            {
                throw new InvalidDataException("checkDigitBirthday is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.CheckDigitBirthday = checkDigitBirthday;
            }
            
            // to ensure "sex" is required (not null)
            if (sex == null)
            {
                throw new InvalidDataException("sex is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.Sex = sex;
            }
            
            // to ensure "expiryDate" is required (not null)
            if (expiryDate == null)
            {
                throw new InvalidDataException("expiryDate is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.ExpiryDate = expiryDate;
            }
            
            // to ensure "checkDigitExpiryDate" is required (not null)
            if (checkDigitExpiryDate == null)
            {
                throw new InvalidDataException("checkDigitExpiryDate is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.CheckDigitExpiryDate = checkDigitExpiryDate;
            }
            
            // to ensure "optionalData" is required (not null)
            if (optionalData == null)
            {
                throw new InvalidDataException("optionalData is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.OptionalData = optionalData;
            }
            
            // to ensure "checkDigitOptionalData" is required (not null)
            if (checkDigitOptionalData == null)
            {
                throw new InvalidDataException("checkDigitOptionalData is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.CheckDigitOptionalData = checkDigitOptionalData;
            }
            
            // to ensure "checkDigitComposite" is required (not null)
            if (checkDigitComposite == null)
            {
                throw new InvalidDataException("checkDigitComposite is a required property for RfidDG1 and cannot be null");
            }
            else
            {
                this.CheckDigitComposite = checkDigitComposite;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=true)]
        public Integer Type { get; set; }

        /// <summary>
        /// Gets or Sets DocumentID
        /// </summary>
        [DataMember(Name="DocumentID", EmitDefaultValue=true)]
        public Integer DocumentID { get; set; }

        /// <summary>
        /// Symbolic code of document type
        /// </summary>
        /// <value>Symbolic code of document type</value>
        [DataMember(Name="DocumentType", EmitDefaultValue=true)]
        public string DocumentType { get; set; }

        /// <summary>
        /// Symbolic code of document issuing state
        /// </summary>
        /// <value>Symbolic code of document issuing state</value>
        [DataMember(Name="State", EmitDefaultValue=true)]
        public string State { get; set; }

        /// <summary>
        /// DO’s name and surname
        /// </summary>
        /// <value>DO’s name and surname</value>
        [DataMember(Name="Holder", EmitDefaultValue=true)]
        public string Holder { get; set; }

        /// <summary>
        /// Document number
        /// </summary>
        /// <value>Document number</value>
        [DataMember(Name="DocumentNumber", EmitDefaultValue=true)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Check digit of document number
        /// </summary>
        /// <value>Check digit of document number</value>
        [DataMember(Name="CheckDigitDocumentNumber", EmitDefaultValue=true)]
        public decimal CheckDigitDocumentNumber { get; set; }

        /// <summary>
        /// Symbolic code of DO’s nationality
        /// </summary>
        /// <value>Symbolic code of DO’s nationality</value>
        [DataMember(Name="Nationality", EmitDefaultValue=true)]
        public string Nationality { get; set; }

        /// <summary>
        /// DO’s date of birth
        /// </summary>
        /// <value>DO’s date of birth</value>
        [DataMember(Name="Birthday", EmitDefaultValue=true)]
        public string Birthday { get; set; }

        /// <summary>
        /// Check digit of DO’s date of birth
        /// </summary>
        /// <value>Check digit of DO’s date of birth</value>
        [DataMember(Name="CheckDigitBirthday", EmitDefaultValue=true)]
        public decimal CheckDigitBirthday { get; set; }

        /// <summary>
        /// DO’s sex
        /// </summary>
        /// <value>DO’s sex</value>
        [DataMember(Name="Sex", EmitDefaultValue=true)]
        public string Sex { get; set; }

        /// <summary>
        /// Term of validity of the document
        /// </summary>
        /// <value>Term of validity of the document</value>
        [DataMember(Name="ExpiryDate", EmitDefaultValue=true)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// Check digit of term of validity of the document
        /// </summary>
        /// <value>Check digit of term of validity of the document</value>
        [DataMember(Name="CheckDigitExpiryDate", EmitDefaultValue=true)]
        public decimal CheckDigitExpiryDate { get; set; }

        /// <summary>
        /// DO’s personal number or other additional data
        /// </summary>
        /// <value>DO’s personal number or other additional data</value>
        [DataMember(Name="OptionalData", EmitDefaultValue=true)]
        public string OptionalData { get; set; }

        /// <summary>
        /// Check digit of additional data
        /// </summary>
        /// <value>Check digit of additional data</value>
        [DataMember(Name="CheckDigitOptionalData", EmitDefaultValue=true)]
        public decimal CheckDigitOptionalData { get; set; }

        /// <summary>
        /// General check digit
        /// </summary>
        /// <value>General check digit</value>
        [DataMember(Name="CheckDigitComposite", EmitDefaultValue=true)]
        public decimal CheckDigitComposite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RfidDG1 {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DocumentID: ").Append(DocumentID).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Holder: ").Append(Holder).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  CheckDigitDocumentNumber: ").Append(CheckDigitDocumentNumber).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  CheckDigitBirthday: ").Append(CheckDigitBirthday).Append("\n");
            sb.Append("  Sex: ").Append(Sex).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  CheckDigitExpiryDate: ").Append(CheckDigitExpiryDate).Append("\n");
            sb.Append("  OptionalData: ").Append(OptionalData).Append("\n");
            sb.Append("  CheckDigitOptionalData: ").Append(CheckDigitOptionalData).Append("\n");
            sb.Append("  CheckDigitComposite: ").Append(CheckDigitComposite).Append("\n");
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
            return this.Equals(input as RfidDG1);
        }

        /// <summary>
        /// Returns true if RfidDG1 instances are equal
        /// </summary>
        /// <param name="input">Instance of RfidDG1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RfidDG1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DocumentID == input.DocumentID ||
                    (this.DocumentID != null &&
                    this.DocumentID.Equals(input.DocumentID))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Holder == input.Holder ||
                    (this.Holder != null &&
                    this.Holder.Equals(input.Holder))
                ) && 
                (
                    this.DocumentNumber == input.DocumentNumber ||
                    (this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(input.DocumentNumber))
                ) && 
                (
                    this.CheckDigitDocumentNumber == input.CheckDigitDocumentNumber ||
                    (this.CheckDigitDocumentNumber != null &&
                    this.CheckDigitDocumentNumber.Equals(input.CheckDigitDocumentNumber))
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
                ) && 
                (
                    this.Birthday == input.Birthday ||
                    (this.Birthday != null &&
                    this.Birthday.Equals(input.Birthday))
                ) && 
                (
                    this.CheckDigitBirthday == input.CheckDigitBirthday ||
                    (this.CheckDigitBirthday != null &&
                    this.CheckDigitBirthday.Equals(input.CheckDigitBirthday))
                ) && 
                (
                    this.Sex == input.Sex ||
                    (this.Sex != null &&
                    this.Sex.Equals(input.Sex))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.CheckDigitExpiryDate == input.CheckDigitExpiryDate ||
                    (this.CheckDigitExpiryDate != null &&
                    this.CheckDigitExpiryDate.Equals(input.CheckDigitExpiryDate))
                ) && 
                (
                    this.OptionalData == input.OptionalData ||
                    (this.OptionalData != null &&
                    this.OptionalData.Equals(input.OptionalData))
                ) && 
                (
                    this.CheckDigitOptionalData == input.CheckDigitOptionalData ||
                    (this.CheckDigitOptionalData != null &&
                    this.CheckDigitOptionalData.Equals(input.CheckDigitOptionalData))
                ) && 
                (
                    this.CheckDigitComposite == input.CheckDigitComposite ||
                    (this.CheckDigitComposite != null &&
                    this.CheckDigitComposite.Equals(input.CheckDigitComposite))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DocumentID != null)
                    hashCode = hashCode * 59 + this.DocumentID.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Holder != null)
                    hashCode = hashCode * 59 + this.Holder.GetHashCode();
                if (this.DocumentNumber != null)
                    hashCode = hashCode * 59 + this.DocumentNumber.GetHashCode();
                if (this.CheckDigitDocumentNumber != null)
                    hashCode = hashCode * 59 + this.CheckDigitDocumentNumber.GetHashCode();
                if (this.Nationality != null)
                    hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.Birthday != null)
                    hashCode = hashCode * 59 + this.Birthday.GetHashCode();
                if (this.CheckDigitBirthday != null)
                    hashCode = hashCode * 59 + this.CheckDigitBirthday.GetHashCode();
                if (this.Sex != null)
                    hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.CheckDigitExpiryDate != null)
                    hashCode = hashCode * 59 + this.CheckDigitExpiryDate.GetHashCode();
                if (this.OptionalData != null)
                    hashCode = hashCode * 59 + this.OptionalData.GetHashCode();
                if (this.CheckDigitOptionalData != null)
                    hashCode = hashCode * 59 + this.CheckDigitOptionalData.GetHashCode();
                if (this.CheckDigitComposite != null)
                    hashCode = hashCode * 59 + this.CheckDigitComposite.GetHashCode();
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