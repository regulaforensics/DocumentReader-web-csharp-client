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
    /// Enumeration contains a set of constants specifying the rate of data exchange between the reader and the RFID-chip
    /// </summary>
    /// <value>Enumeration contains a set of constants specifying the rate of data exchange between the reader and the RFID-chip</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RfidBaudRate
    {
        /// <summary>
        /// Enum UNKNOWN for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        UNKNOWN = 1,

        /// <summary>
        /// Enum RFBR_106 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        RFBR_106 = 2,

        /// <summary>
        /// Enum RFBR_212 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        RFBR_212 = 3,

        /// <summary>
        /// Enum RFBR_424 for value: 4
        /// </summary>
        [EnumMember(Value = "4")]
        RFBR_424 = 4,

        /// <summary>
        /// Enum RFBR_848 for value: 8
        /// </summary>
        [EnumMember(Value = "8")]
        RFBR_848 = 5

    }

}