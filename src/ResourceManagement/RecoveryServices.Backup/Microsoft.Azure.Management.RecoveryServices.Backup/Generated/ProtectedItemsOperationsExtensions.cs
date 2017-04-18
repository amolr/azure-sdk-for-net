// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ProtectedItemsOperations.
    /// </summary>
    public static partial class ProtectedItemsOperationsExtensions
    {
            /// <summary>
            /// Provides a pageable list of all items that can be backed up within a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// skipToken Filter.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ProtectedItemResource> List(this IProtectedItemsOperations operations, string vaultName, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<ProtectedItemQueryObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ProtectedItemQueryObject>), string skipToken = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectedItemsOperations)s).ListAsync(vaultName, resourceGroupName, odataQuery, skipToken), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides a pageable list of all items that can be backed up within a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// skipToken Filter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ProtectedItemResource>> ListAsync(this IProtectedItemsOperations operations, string vaultName, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<ProtectedItemQueryObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ProtectedItemQueryObject>), string skipToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(vaultName, resourceGroupName, odataQuery, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Provides the details of the backed up item. This is an asynchronous
            /// operation. To know the status of the operation, call the
            /// GetItemOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backed up item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backed up item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backed up item name whose details are to be fetched.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static ProtectedItemResource Get(this IProtectedItemsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, Microsoft.Rest.Azure.OData.ODataQuery<GetProtectedItemQueryObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<GetProtectedItemQueryObject>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectedItemsOperations)s).GetAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides the details of the backed up item. This is an asynchronous
            /// operation. To know the status of the operation, call the
            /// GetItemOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backed up item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backed up item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backed up item name whose details are to be fetched.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ProtectedItemResource> GetAsync(this IProtectedItemsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, Microsoft.Rest.Azure.OData.ODataQuery<GetProtectedItemQueryObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<GetProtectedItemQueryObject>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Enables backup of an item or to modifies the backup policy information of
            /// an already backed up item. This is an asynchronous operation. To know the
            /// status of the operation, call the GetItemOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backup item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backup item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Item name to be backed up.
            /// </param>
            /// <param name='resourceProtectedItem'>
            /// resource backed up item
            /// </param>
            public static void CreateOrUpdate(this IProtectedItemsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, ProtectedItemResource resourceProtectedItem)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectedItemsOperations)s).CreateOrUpdateAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, resourceProtectedItem), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables backup of an item or to modifies the backup policy information of
            /// an already backed up item. This is an asynchronous operation. To know the
            /// status of the operation, call the GetItemOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backup item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backup item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Item name to be backed up.
            /// </param>
            /// <param name='resourceProtectedItem'>
            /// resource backed up item
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task CreateOrUpdateAsync(this IProtectedItemsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, ProtectedItemResource resourceProtectedItem, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.CreateOrUpdateWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, resourceProtectedItem, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Used to disable backup of an item within a container. This is an
            /// asynchronous operation. To know the status of the request, call the
            /// GetItemOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backed up item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backed up item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backed up item to be deleted.
            /// </param>
            public static void Delete(this IProtectedItemsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectedItemsOperations)s).DeleteAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Used to disable backup of an item within a container. This is an
            /// asynchronous operation. To know the status of the request, call the
            /// GetItemOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backed up item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backed up item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backed up item to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IProtectedItemsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Provides a pageable list of all items that can be backed up within a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ProtectedItemResource> ListNext(this IProtectedItemsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectedItemsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides a pageable list of all items that can be backed up within a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ProtectedItemResource>> ListNextAsync(this IProtectedItemsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
