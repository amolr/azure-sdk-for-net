// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LogProfilesOperations.
    /// </summary>
    public static partial class LogProfilesOperationsExtensions
    {
            /// <summary>
            /// Deletes the log profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            public static void Delete(this ILogProfilesOperations operations, string logProfileName)
            {
                operations.DeleteAsync(logProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the log profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ILogProfilesOperations operations, string logProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(logProfileName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the log profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            public static LogProfileResource Get(this ILogProfilesOperations operations, string logProfileName)
            {
                return operations.GetAsync(logProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the log profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogProfileResource> GetAsync(this ILogProfilesOperations operations, string logProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(logProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a log profile in Azure Monitoring REST API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            public static LogProfileResource CreateOrUpdate(this ILogProfilesOperations operations, string logProfileName, LogProfileResource parameters)
            {
                return operations.CreateOrUpdateAsync(logProfileName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a log profile in Azure Monitoring REST API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogProfileResource> CreateOrUpdateAsync(this ILogProfilesOperations operations, string logProfileName, LogProfileResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(logProfileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the log profiles.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<LogProfileResource> List(this ILogProfilesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the log profiles.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<LogProfileResource>> ListAsync(this ILogProfilesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

