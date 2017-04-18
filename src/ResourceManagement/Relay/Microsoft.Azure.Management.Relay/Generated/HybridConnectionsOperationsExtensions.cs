// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Relay
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HybridConnectionsOperations.
    /// </summary>
    public static partial class HybridConnectionsOperationsExtensions
    {
            /// <summary>
            /// Lists the HybridConnection within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            public static IPage<HybridConnection> ListByNamespace(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListByNamespaceAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the HybridConnection within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<HybridConnection>> ListByNamespaceAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates a service HybridConnection. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a HybridConnection.
            /// </param>
            public static HybridConnection CreateOrUpdate(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, HybridConnection parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, hybridConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates a service HybridConnection. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a HybridConnection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HybridConnection> CreateOrUpdateAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, HybridConnection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a HybridConnection .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            public static void Delete(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, hybridConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a HybridConnection .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns the description for the specified HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            public static HybridConnection Get(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, hybridConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the description for the specified HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HybridConnection> GetAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Authorization rules for a HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            public static IPage<AuthorizationRule> ListAuthorizationRules(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName)
            {
                return operations.ListAuthorizationRulesAsync(resourceGroupName, namespaceName, hybridConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Authorization rules for a HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AuthorizationRule>> ListAuthorizationRulesAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates an authorization rule for a HybridConnection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='parameters'>
            /// The authorization rule parameters
            /// </param>
            public static AuthorizationRule CreateOrUpdateAuthorizationRule(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, AuthorizationRule parameters)
            {
                return operations.CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates an authorization rule for a HybridConnection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='parameters'>
            /// The authorization rule parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthorizationRule> CreateOrUpdateAuthorizationRuleAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, AuthorizationRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a HybridConnection authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            public static void DeleteAuthorizationRule(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName)
            {
                operations.DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a HybridConnection authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// HybridConnection authorizationRule for a HybridConnection by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            public static AuthorizationRule GetAuthorizationRule(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// HybridConnection authorizationRule for a HybridConnection by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthorizationRule> GetAuthorizationRuleAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Primary and Secondary ConnectionStrings to the HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            public static AuthorizationRuleKeys ListKeys(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Primary and Secondary ConnectionStrings to the HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthorizationRuleKeys> ListKeysAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the Primary or Secondary ConnectionStrings to the
            /// HybridConnection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate Auth Rule.
            /// </param>
            public static AuthorizationRuleKeys RegenerateKeys(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, RegenerateKeysParameters parameters)
            {
                return operations.RegenerateKeysAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the Primary or Secondary ConnectionStrings to the
            /// HybridConnection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate Auth Rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthorizationRuleKeys> RegenerateKeysAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, RegenerateKeysParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the HybridConnection within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<HybridConnection> ListByNamespaceNext(this IHybridConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListByNamespaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the HybridConnection within the namespace.
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
            public static async Task<IPage<HybridConnection>> ListByNamespaceNextAsync(this IHybridConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Authorization rules for a HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AuthorizationRule> ListAuthorizationRulesNext(this IHybridConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListAuthorizationRulesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Authorization rules for a HybridConnection.
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
            public static async Task<IPage<AuthorizationRule>> ListAuthorizationRulesNextAsync(this IHybridConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

