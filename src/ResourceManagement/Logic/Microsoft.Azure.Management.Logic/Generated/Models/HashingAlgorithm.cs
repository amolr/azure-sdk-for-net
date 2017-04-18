// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for HashingAlgorithm.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HashingAlgorithm
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "MD5")]
        MD5,
        [EnumMember(Value = "SHA1")]
        SHA1,
        [EnumMember(Value = "SHA2256")]
        SHA2256,
        [EnumMember(Value = "SHA2384")]
        SHA2384,
        [EnumMember(Value = "SHA2512")]
        SHA2512
    }
}

