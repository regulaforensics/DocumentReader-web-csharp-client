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
    /// Enumeration contains visibility status of the security element
    /// </summary>
    /// <value>Enumeration contains visibility status of the security element</value>
    public enum Visibility
    {
        /// <summary>
        /// Enum INVISIBLE for value: 0
        /// </summary>
        INVISIBLE = 0,

        /// <summary>
        /// Enum VISIBLE for value: 1
        /// </summary>
        VISIBLE = 1,

        /// <summary>
        /// Enum COLORED for value: 2
        /// </summary>
        COLORED = 2,

        /// <summary>
        /// Enum GRAYSCALE for value: 4
        /// </summary>
        GRAYSCALE = 4,

        /// <summary>
        /// Enum WHITE_IR_MATCHING for value: 8
        /// </summary>
        WHITE_IR_MATCHING = 8
    }

}
