// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// The instance view of a virtual machine extension.
    /// </summary>
    public partial class VirtualMachineExtensionInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionInstanceView class.
        /// </summary>
        public VirtualMachineExtensionInstanceView() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionInstanceView class.
        /// </summary>
        /// <param name="name">the virtual machine extension name.</param>
        /// <param name="type">the full type of the extension handler which
        /// includes both publisher and type.</param>
        /// <param name="typeHandlerVersion">the type version of the extension
        /// handler.</param>
        /// <param name="substatuses">the resource status information.</param>
        /// <param name="statuses">the resource status information.</param>
        public VirtualMachineExtensionInstanceView(string name = default(string), string type = default(string), string typeHandlerVersion = default(string), System.Collections.Generic.IList<InstanceViewStatus> substatuses = default(System.Collections.Generic.IList<InstanceViewStatus>), System.Collections.Generic.IList<InstanceViewStatus> statuses = default(System.Collections.Generic.IList<InstanceViewStatus>))
        {
            Name = name;
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
            Substatuses = substatuses;
            Statuses = statuses;
        }

        /// <summary>
        /// Gets or sets the virtual machine extension name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the full type of the extension handler which includes
        /// both publisher and type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the type version of the extension handler.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "substatuses")]
        public System.Collections.Generic.IList<InstanceViewStatus> Substatuses { get; set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "statuses")]
        public System.Collections.Generic.IList<InstanceViewStatus> Statuses { get; set; }

    }
}
