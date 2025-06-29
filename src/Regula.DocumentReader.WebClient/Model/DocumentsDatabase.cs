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
    /// Document database information
    /// </summary>
    [DataContract(Name = "DocumentsDatabase")]
    public partial class DocumentsDatabase : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsDatabase" /> class.
        /// </summary>
        /// <param name="description">Document database description.</param>
        /// <param name="exportDate">Date the document database was created.</param>
        /// <param name="iD">Document database identifier.</param>
        /// <param name="varVersion">Document database version.</param>
        public DocumentsDatabase(string description = default(string), string exportDate = default(string), string iD = default(string), string varVersion = default(string))
        {
            this.Description = description;
            this.ExportDate = exportDate;
            this.ID = iD;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Document database description
        /// </summary>
        /// <value>Document database description</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string? Description { get; set; }

        /// <summary>
        /// Date the document database was created
        /// </summary>
        /// <value>Date the document database was created</value>
        [DataMember(Name = "ExportDate", EmitDefaultValue = false)]
        public string? ExportDate { get; set; }

        /// <summary>
        /// Document database identifier
        /// </summary>
        /// <value>Document database identifier</value>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string? ID { get; set; }

        /// <summary>
        /// Document database version
        /// </summary>
        /// <value>Document database version</value>
        [DataMember(Name = "Version", EmitDefaultValue = false)]
        public string? VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentsDatabase {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExportDate: ").Append(ExportDate).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
