// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response of the List NotificationHub operation.
    /// </summary>
    public partial class NotificationHubListResult
    {
        /// <summary>
        /// Initializes a new instance of the NotificationHubListResult class.
        /// </summary>
        public NotificationHubListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationHubListResult class.
        /// </summary>
        /// <param name="value">Result of the List NotificationHub
        /// operation.</param>
        /// <param name="nextLink">Link to the next set of results. Not empty
        /// if Value contains incomplete list of NotificationHub</param>
        public NotificationHubListResult(IList<NotificationHub> value = default(IList<NotificationHub>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets result of the List NotificationHub operation.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<NotificationHub> Value { get; set; }

        /// <summary>
        /// Gets or sets link to the next set of results. Not empty if Value
        /// contains incomplete list of NotificationHub
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
