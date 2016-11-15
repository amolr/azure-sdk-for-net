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
    /// Describes a Virtual Machine Extension.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineExtension : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineExtension class.
        /// </summary>
        public VirtualMachineExtension() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineExtension class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="forceUpdateTag">how the extension handler should be
        /// forced to update even if the extension configuration has not
        /// changed.</param>
        /// <param name="publisher">the name of the extension handler
        /// publisher.</param>
        /// <param name="virtualMachineExtensionType">the type of the
        /// extension handler.</param>
        /// <param name="typeHandlerVersion">the type version of the extension
        /// handler.</param>
        /// <param name="autoUpgradeMinorVersion">whether the extension
        /// handler should be automatically upgraded across minor
        /// versions.</param>
        /// <param name="settings">Json formatted public settings for the
        /// extension.</param>
        /// <param name="protectedSettings">Json formatted protected settings
        /// for the extension.</param>
        /// <param name="provisioningState">the provisioning state, which only
        /// appears in the response.</param>
        /// <param name="instanceView">the virtual machine extension instance
        /// view.</param>
        public VirtualMachineExtension(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string forceUpdateTag = default(string), string publisher = default(string), string virtualMachineExtensionType = default(string), string typeHandlerVersion = default(string), bool? autoUpgradeMinorVersion = default(bool?), object settings = default(object), object protectedSettings = default(object), string provisioningState = default(string), VirtualMachineExtensionInstanceView instanceView = default(VirtualMachineExtensionInstanceView))
            : base(location, id, name, type, tags)
        {
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            VirtualMachineExtensionType = virtualMachineExtensionType;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
        }

        /// <summary>
        /// Gets or sets how the extension handler should be forced to update
        /// even if the extension configuration has not changed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.forceUpdateTag")]
        public string ForceUpdateTag { get; set; }

        /// <summary>
        /// Gets or sets the name of the extension handler publisher.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the type of the extension handler.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.type")]
        public string VirtualMachineExtensionType { get; set; }

        /// <summary>
        /// Gets or sets the type version of the extension handler.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets whether the extension handler should be automatically
        /// upgraded across minor versions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.autoUpgradeMinorVersion")]
        public bool? AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// Gets or sets json formatted public settings for the extension.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.settings")]
        public object Settings { get; set; }

        /// <summary>
        /// Gets or sets json formatted protected settings for the extension.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.protectedSettings")]
        public object ProtectedSettings { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the virtual machine extension instance view.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.instanceView")]
        public VirtualMachineExtensionInstanceView InstanceView { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
