// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Azure;
    using KeyVault;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The deleted secret item containing metadata about the deleted secret.
    /// </summary>
    public partial class DeletedSecretItem : SecretItem
    {
        /// <summary>
        /// Initializes a new instance of the DeletedSecretItem class.
        /// </summary>
        public DeletedSecretItem() { }

        /// <summary>
        /// Initializes a new instance of the DeletedSecretItem class.
        /// </summary>
        /// <param name="id">Secret identifier.</param>
        /// <param name="attributes">The secret management attributes.</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs.</param>
        /// <param name="contentType">Type of the secret value such as a
        /// password.</param>
        /// <param name="managed">True if the secret's lifetime is managed by
        /// key vault. If this is a key backing a certificate, then managed
        /// will be true.</param>
        /// <param name="recoveryId">The url of the recovery object, used to
        /// identify and recover the deleted secret.</param>
        /// <param name="scheduledPurgeDate">The time when the secret is
        /// scheduled to be purged, in UTC</param>
        /// <param name="deletedDate">The time when the secret was deleted, in
        /// UTC</param>
        public DeletedSecretItem(string id = default(string), SecretAttributes attributes = default(SecretAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>), string contentType = default(string), bool? managed = default(bool?), string recoveryId = default(string), System.DateTime? scheduledPurgeDate = default(System.DateTime?), System.DateTime? deletedDate = default(System.DateTime?))
            : base(id, attributes, tags, contentType, managed)
        {
            RecoveryId = recoveryId;
            ScheduledPurgeDate = scheduledPurgeDate;
            DeletedDate = deletedDate;
        }

        /// <summary>
        /// Gets or sets the url of the recovery object, used to identify and
        /// recover the deleted secret.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryId")]
        public string RecoveryId { get; set; }

        /// <summary>
        /// Gets the time when the secret is scheduled to be purged, in UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "scheduledPurgeDate")]
        public System.DateTime? ScheduledPurgeDate { get; protected set; }

        /// <summary>
        /// Gets the time when the secret was deleted, in UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "deletedDate")]
        public System.DateTime? DeletedDate { get; protected set; }

    }
}

