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
    /// Enumeration contains a set of constants that define the type of certificate used in the procedure of document security object digital signature verification
    /// </summary>
    /// <value>Enumeration contains a set of constants that define the type of certificate used in the procedure of document security object digital signature verification</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RfidCertificateType
    {
        /// <summary>
        /// Enum UNDEFINED for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        UNDEFINED = 1,

        /// <summary>
        /// Enum CSCA for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        CSCA = 2,

        /// <summary>
        /// Enum CSCA_LINK for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        CSCA_LINK = 3,

        /// <summary>
        /// Enum DS for value: 3
        /// </summary>
        [EnumMember(Value = "3")]
        DS = 4,

        /// <summary>
        /// Enum MLS for value: 4
        /// </summary>
        [EnumMember(Value = "4")]
        MLS = 5,

        /// <summary>
        /// Enum DEV_LS for value: 5
        /// </summary>
        [EnumMember(Value = "5")]
        DEV_LS = 6,

        /// <summary>
        /// Enum DEF_LS for value: 6
        /// </summary>
        [EnumMember(Value = "6")]
        DEF_LS = 7,

        /// <summary>
        /// Enum BLS for value: 7
        /// </summary>
        [EnumMember(Value = "7")]
        BLS = 8

    }

}