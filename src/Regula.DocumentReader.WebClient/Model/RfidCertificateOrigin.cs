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
    /// Enumeration contains a set of constants that define the source of certificate used in the procedure of document security object digital signature verification
    /// </summary>
    /// <value>Enumeration contains a set of constants that define the source of certificate used in the procedure of document security object digital signature verification</value>
    public enum RfidCertificateOrigin
    {
        /// <summary>
        /// Enum UNDEFINED for value: 0
        /// </summary>
        UNDEFINED = 0,

        /// <summary>
        /// Enum PKD for value: 1
        /// </summary>
        PKD = 1,

        /// <summary>
        /// Enum SECURITY_OBJECT for value: 2
        /// </summary>
        SECURITY_OBJECT = 2,

        /// <summary>
        /// Enum USER_DEFINED for value: 3
        /// </summary>
        USER_DEFINED = 3,

        /// <summary>
        /// Enum MASTER_LIST_PKD for value: 4
        /// </summary>
        MASTER_LIST_PKD = 4,

        /// <summary>
        /// Enum MASTER_LIST_SO for value: 5
        /// </summary>
        MASTER_LIST_SO = 5,

        /// <summary>
        /// Enum DEFECT_LIST_SO for value: 6
        /// </summary>
        DEFECT_LIST_SO = 6,

        /// <summary>
        /// Enum DEVIATION_LIST_SO for value: 7
        /// </summary>
        DEVIATION_LIST_SO = 7,

        /// <summary>
        /// Enum BLACK_LIST_SO for value: 8
        /// </summary>
        BLACK_LIST_SO = 8
    }

}
