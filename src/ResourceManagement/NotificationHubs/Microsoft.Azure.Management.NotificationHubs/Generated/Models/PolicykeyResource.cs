// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.NotificationHubs;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Namespace/NotificationHub Regenerate Keys
    /// </summary>
    public partial class PolicykeyResource
    {
        /// <summary>
        /// Initializes a new instance of the PolicykeyResource class.
        /// </summary>
        public PolicykeyResource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicykeyResource class.
        /// </summary>
        /// <param name="policyKey">Name of the key that has to be regenerated
        /// for the Namespace/Notification Hub Authorization Rule. The value
        /// can be Primary Key/Secondary Key.</param>
        public PolicykeyResource(string policyKey = default(string))
        {
            PolicyKey = policyKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the key that has to be regenerated for the
        /// Namespace/Notification Hub Authorization Rule. The value can be
        /// Primary Key/Secondary Key.
        /// </summary>
        [JsonProperty(PropertyName = "policyKey")]
        public string PolicyKey { get; set; }

    }
}
