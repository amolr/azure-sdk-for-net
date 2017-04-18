// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Base class for backup items.
    /// </summary>
    public partial class ProtectedItem
    {
        /// <summary>
        /// Initializes a new instance of the ProtectedItem class.
        /// </summary>
        public ProtectedItem() { }

        /// <summary>
        /// Initializes a new instance of the ProtectedItem class.
        /// </summary>
        /// <param name="backupManagementType">Type of backup managemenent for
        /// the backed up item. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer',
        /// 'AzureSql'</param>
        /// <param name="workloadType">Type of workload this item represents.
        /// Possible values include: 'Invalid', 'VM', 'FileFolder',
        /// 'AzureSqlDb', 'SQLDB', 'Exchange', 'Sharepoint',
        /// 'DPMUnknown'</param>
        /// <param name="sourceResourceId">ARM ID of the resource to be backed
        /// up.</param>
        /// <param name="policyId">ID of the backup policy with which this
        /// item is backed up.</param>
        /// <param name="lastRecoveryPoint">Timestamp when the last (latest)
        /// backup copy was created for this backup item.</param>
        public ProtectedItem(BackupManagementType? backupManagementType = default(BackupManagementType?), DataSourceType? workloadType = default(DataSourceType?), string sourceResourceId = default(string), string policyId = default(string), System.DateTime? lastRecoveryPoint = default(System.DateTime?))
        {
            BackupManagementType = backupManagementType;
            WorkloadType = workloadType;
            SourceResourceId = sourceResourceId;
            PolicyId = policyId;
            LastRecoveryPoint = lastRecoveryPoint;
        }

        /// <summary>
        /// Gets or sets type of backup managemenent for the backed up item.
        /// Possible values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "backupManagementType")]
        public BackupManagementType? BackupManagementType { get; set; }

        /// <summary>
        /// Gets or sets type of workload this item represents. Possible
        /// values include: 'Invalid', 'VM', 'FileFolder', 'AzureSqlDb',
        /// 'SQLDB', 'Exchange', 'Sharepoint', 'DPMUnknown'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "workloadType")]
        public DataSourceType? WorkloadType { get; set; }

        /// <summary>
        /// Gets or sets ARM ID of the resource to be backed up.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceResourceId")]
        public string SourceResourceId { get; set; }

        /// <summary>
        /// Gets or sets ID of the backup policy with which this item is
        /// backed up.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }

        /// <summary>
        /// Gets or sets timestamp when the last (latest) backup copy was
        /// created for this backup item.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastRecoveryPoint")]
        public System.DateTime? LastRecoveryPoint { get; set; }

    }
}
