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
    /// Enumeration contains a set of constants that define the type of application within the context of the communication session with electronic document
    /// </summary>
    /// <value>Enumeration contains a set of constants that define the type of application within the context of the communication session with electronic document</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RfidApplicationType
    {
        /// <summary>
        /// Enum UNSPECIFIED for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        UNSPECIFIED = 1,

        /// <summary>
        /// Enum E_PASSPORT for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        E_PASSPORT = 2,

        /// <summary>
        /// Enum E_ID for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        E_ID = 3,

        /// <summary>
        /// Enum E_SIGN for value: 3
        /// </summary>
        [EnumMember(Value = "3")]
        E_SIGN = 4,

        /// <summary>
        /// Enum E_DL for value: 4
        /// </summary>
        [EnumMember(Value = "4")]
        E_DL = 5,

        /// <summary>
        /// Enum ROOT_FILES for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        ROOT_FILES = 6

    }

}