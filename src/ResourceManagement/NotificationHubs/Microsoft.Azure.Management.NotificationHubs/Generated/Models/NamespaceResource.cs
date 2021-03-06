// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.NotificationHubs;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description of a Namespace resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NamespaceResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the NamespaceResource class.
        /// </summary>
        public NamespaceResource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NamespaceResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">The sku of the created namespace</param>
        /// <param name="namespaceResourceName">The name of the
        /// namespace.</param>
        /// <param name="provisioningState">Provisioning state of the
        /// Namespace.</param>
        /// <param name="region">Specifies the targeted region in which the
        /// namespace should be created. It can be any of the following values:
        /// Australia EastAustralia SoutheastCentral USEast USEast US 2West
        /// USNorth Central USSouth Central USEast AsiaSoutheast AsiaBrazil
        /// SouthJapan EastJapan WestNorth EuropeWest Europe</param>
        /// <param name="status">Status of the namespace. It can be any of
        /// these values:1 = Created/Active2 = Creating3 = Suspended4 =
        /// Deleting</param>
        /// <param name="createdAt">The time the namespace was created.</param>
        /// <param name="serviceBusEndpoint">Endpoint you can use to perform
        /// NotificationHub operations.</param>
        /// <param name="subscriptionId">The Id of the Azure subscription
        /// associated with the namespace.</param>
        /// <param name="scaleUnit">ScaleUnit where the namespace gets
        /// created</param>
        /// <param name="enabled">Whether or not the namespace is currently
        /// enabled.</param>
        /// <param name="critical">Whether or not the namespace is set as
        /// Critical.</param>
        /// <param name="namespaceType">The namespace type. Possible values
        /// include: 'Messaging', 'NotificationHub'</param>
        public NamespaceResource(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), string namespaceResourceName = default(string), string provisioningState = default(string), string region = default(string), string status = default(string), System.DateTime? createdAt = default(System.DateTime?), string serviceBusEndpoint = default(string), string subscriptionId = default(string), string scaleUnit = default(string), bool? enabled = default(bool?), bool? critical = default(bool?), NamespaceType? namespaceType = default(NamespaceType?))
            : base(location, id, name, type, tags, sku)
        {
            NamespaceResourceName = namespaceResourceName;
            ProvisioningState = provisioningState;
            Region = region;
            Status = status;
            CreatedAt = createdAt;
            ServiceBusEndpoint = serviceBusEndpoint;
            SubscriptionId = subscriptionId;
            ScaleUnit = scaleUnit;
            Enabled = enabled;
            Critical = critical;
            NamespaceType = namespaceType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string NamespaceResourceName { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the Namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets specifies the targeted region in which the namespace
        /// should be created. It can be any of the following values: Australia
        /// EastAustralia SoutheastCentral USEast USEast US 2West USNorth
        /// Central USSouth Central USEast AsiaSoutheast AsiaBrazil SouthJapan
        /// EastJapan WestNorth EuropeWest Europe
        /// </summary>
        [JsonProperty(PropertyName = "properties.region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets status of the namespace. It can be any of these
        /// values:1 = Created/Active2 = Creating3 = Suspended4 = Deleting
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the time the namespace was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets endpoint you can use to perform NotificationHub
        /// operations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusEndpoint")]
        public string ServiceBusEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Azure subscription associated with the
        /// namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets scaleUnit where the namespace gets created
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleUnit")]
        public string ScaleUnit { get; set; }

        /// <summary>
        /// Gets or sets whether or not the namespace is currently enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets whether or not the namespace is set as Critical.
        /// </summary>
        [JsonProperty(PropertyName = "properties.critical")]
        public bool? Critical { get; set; }

        /// <summary>
        /// Gets or sets the namespace type. Possible values include:
        /// 'Messaging', 'NotificationHub'
        /// </summary>
        [JsonProperty(PropertyName = "properties.namespaceType")]
        public NamespaceType? NamespaceType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
