// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ApplicationGatewaysOperations.
    /// </summary>
    public static partial class ApplicationGatewaysOperationsExtensions
    {
            /// <summary>
            /// The delete ApplicationGateway operation deletes the specified application
            /// gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void Delete(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).DeleteAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete ApplicationGateway operation deletes the specified application
            /// gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The delete ApplicationGateway operation deletes the specified application
            /// gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void BeginDelete(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginDeleteAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete ApplicationGateway operation deletes the specified application
            /// gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get ApplicationGateway operation retrieves information about the
            /// specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static ApplicationGateway Get(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).GetAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get ApplicationGateway operation retrieves information about the
            /// specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGateway> GetAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            public static ApplicationGateway CreateOrUpdate(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).CreateOrUpdateAsync(resourceGroupName, applicationGatewayName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGateway> CreateOrUpdateAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            public static ApplicationGateway BeginCreateOrUpdate(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, applicationGatewayName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGateway> BeginCreateOrUpdateAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List ApplicationGateway operation retrieves all the application
            /// gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<ApplicationGateway> List(this IApplicationGatewaysOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ApplicationGateway operation retrieves all the application
            /// gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationGateway>> ListAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List ApplicationGateway operation retrieves all the application
            /// gateways in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ApplicationGateway> ListAll(this IApplicationGatewaysOperations operations)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ApplicationGateway operation retrieves all the application
            /// gateways in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationGateway>> ListAllAsync(this IApplicationGatewaysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gateway in the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void Start(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).StartAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gateway in the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StartAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StartWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gateway in the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void BeginStart(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginStartAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gateway in the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStartAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gateway in the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void Stop(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).StopAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gateway in the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StopWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gateway in the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void BeginStop(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginStopAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gateway in the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStopAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginStopWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The BackendHealth operation gets the backend health of application gateway
            /// in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='expand'>
            /// Expands BackendAddressPool and BackendHttpSettings referenced in backend
            /// health.
            /// </param>
            public static ApplicationGatewayBackendHealth BackendHealth(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, string expand = default(string))
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BackendHealthAsync(resourceGroupName, applicationGatewayName, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The BackendHealth operation gets the backend health of application gateway
            /// in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='expand'>
            /// Expands BackendAddressPool and BackendHttpSettings referenced in backend
            /// health.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGatewayBackendHealth> BackendHealthAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BackendHealthWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The BackendHealth operation gets the backend health of application gateway
            /// in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='expand'>
            /// Expands BackendAddressPool and BackendHttpSettings referenced in backend
            /// health.
            /// </param>
            public static ApplicationGatewayBackendHealth BeginBackendHealth(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, string expand = default(string))
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginBackendHealthAsync(resourceGroupName, applicationGatewayName, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The BackendHealth operation gets the backend health of application gateway
            /// in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='expand'>
            /// Expands BackendAddressPool and BackendHttpSettings referenced in backend
            /// health.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGatewayBackendHealth> BeginBackendHealthAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginBackendHealthWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List ApplicationGateway operation retrieves all the application
            /// gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApplicationGateway> ListNext(this IApplicationGatewaysOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ApplicationGateway operation retrieves all the application
            /// gateways in a resource group.
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
            public static async Task<IPage<ApplicationGateway>> ListNextAsync(this IApplicationGatewaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List ApplicationGateway operation retrieves all the application
            /// gateways in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApplicationGateway> ListAllNext(this IApplicationGatewaysOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListAllNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ApplicationGateway operation retrieves all the application
            /// gateways in a subscription.
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
            public static async Task<IPage<ApplicationGateway>> ListAllNextAsync(this IApplicationGatewaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
