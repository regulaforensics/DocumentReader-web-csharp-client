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
    /// Defines BarCodeModuleType
    /// </summary>
    public enum BarCodeModuleType
    {
        /// <summary>
        /// Enum TEXT for value: 0
        /// </summary>
        TEXT = 0,

        /// <summary>
        /// Enum BYTE for value: 1
        /// </summary>
        BYTE = 1,

        /// <summary>
        /// Enum NUM for value: 2
        /// </summary>
        NUM = 2,

        /// <summary>
        /// Enum SHIFT for value: 3
        /// </summary>
        SHIFT = 3,

        /// <summary>
        /// Enum ALL for value: 4
        /// </summary>
        ALL = 4
    }

}
