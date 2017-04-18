// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes Windows Configuration of the OS Profile.
    /// </summary>
    public partial class WindowsConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the WindowsConfiguration class.
        /// </summary>
        public WindowsConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the WindowsConfiguration class.
        /// </summary>
        /// <param name="provisionVMAgent">Indicates whether the virtual
        /// machine agent should be provisioned on the Virtual Machine. If not
        /// specified, then the default behavior is to set it to true.</param>
        /// <param name="enableAutomaticUpdates">Indicates whether Windows
        /// updates are automatically installed on the VM.</param>
        /// <param name="timeZone">The time zone of the VM</param>
        /// <param name="additionalUnattendContent">Additional base-64 encoded
        /// XML formatted information that can be included in the Unattend.xml
        /// file.</param>
        /// <param name="winRM">The Windows Remote Management configuration of
        /// the VM</param>
        public WindowsConfiguration(bool? provisionVMAgent = default(bool?), bool? enableAutomaticUpdates = default(bool?), string timeZone = default(string), IList<AdditionalUnattendContent> additionalUnattendContent = default(IList<AdditionalUnattendContent>), WinRMConfiguration winRM = default(WinRMConfiguration))
        {
            ProvisionVMAgent = provisionVMAgent;
            EnableAutomaticUpdates = enableAutomaticUpdates;
            TimeZone = timeZone;
            AdditionalUnattendContent = additionalUnattendContent;
            WinRM = winRM;
        }

        /// <summary>
        /// Gets or sets indicates whether the virtual machine agent should be
        /// provisioned on the Virtual Machine. If not specified, then the
        /// default behavior is to set it to true.
        /// </summary>
        [JsonProperty(PropertyName = "provisionVMAgent")]
        public bool? ProvisionVMAgent { get; set; }

        /// <summary>
        /// Gets or sets indicates whether Windows updates are automatically
        /// installed on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "enableAutomaticUpdates")]
        public bool? EnableAutomaticUpdates { get; set; }

        /// <summary>
        /// Gets or sets the time zone of the VM
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets additional base-64 encoded XML formatted information
        /// that can be included in the Unattend.xml file.
        /// </summary>
        [JsonProperty(PropertyName = "additionalUnattendContent")]
        public IList<AdditionalUnattendContent> AdditionalUnattendContent { get; set; }

        /// <summary>
        /// Gets or sets the Windows Remote Management configuration of the VM
        /// </summary>
        [JsonProperty(PropertyName = "winRM")]
        public WinRMConfiguration WinRM { get; set; }

    }
}

