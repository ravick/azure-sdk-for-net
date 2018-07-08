// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualWANsOperations.
    /// </summary>
    public static partial class VirtualWANsOperationsExtensions
    {
            /// <summary>
            /// Retrieves the details of a VirtualWAN.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being retrieved.
            /// </param>
            public static VirtualWAN Get(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName)
            {
                return operations.GetAsync(resourceGroupName, virtualWANName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the details of a VirtualWAN.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualWAN> GetAsync(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualWANName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a VirtualWAN resource if it doesn't exist else updates the existing
            /// VirtualWAN.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being created or updated.
            /// </param>
            /// <param name='wANParameters'>
            /// Parameters supplied to create or update VirtualWAN.
            /// </param>
            public static VirtualWAN CreateOrUpdate(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName, VirtualWAN wANParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, virtualWANName, wANParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a VirtualWAN resource if it doesn't exist else updates the existing
            /// VirtualWAN.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being created or updated.
            /// </param>
            /// <param name='wANParameters'>
            /// Parameters supplied to create or update VirtualWAN.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualWAN> CreateOrUpdateAsync(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName, VirtualWAN wANParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualWANName, wANParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a VirtualWAN tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being updated.
            /// </param>
            /// <param name='wANParameters'>
            /// Parameters supplied to Update VirtualWAN tags.
            /// </param>
            public static VirtualWAN UpdateTags(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName, TagsObject wANParameters)
            {
                return operations.UpdateTagsAsync(resourceGroupName, virtualWANName, wANParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a VirtualWAN tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being updated.
            /// </param>
            /// <param name='wANParameters'>
            /// Parameters supplied to Update VirtualWAN tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualWAN> UpdateTagsAsync(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName, TagsObject wANParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, virtualWANName, wANParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a VirtualWAN.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being deleted.
            /// </param>
            public static void Delete(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName)
            {
                operations.DeleteAsync(resourceGroupName, virtualWANName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a VirtualWAN.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualWANName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all the VirtualWANs in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            public static IPage<VirtualWAN> ListByResourceGroup(this IVirtualWANsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VirtualWANs in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualWAN>> ListByResourceGroupAsync(this IVirtualWANsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the VirtualWANs in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<VirtualWAN> List(this IVirtualWANsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VirtualWANs in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualWAN>> ListAsync(this IVirtualWANsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a VirtualWAN resource if it doesn't exist else updates the existing
            /// VirtualWAN.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being created or updated.
            /// </param>
            /// <param name='wANParameters'>
            /// Parameters supplied to create or update VirtualWAN.
            /// </param>
            public static VirtualWAN BeginCreateOrUpdate(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName, VirtualWAN wANParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, virtualWANName, wANParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a VirtualWAN resource if it doesn't exist else updates the existing
            /// VirtualWAN.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being created or updated.
            /// </param>
            /// <param name='wANParameters'>
            /// Parameters supplied to create or update VirtualWAN.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualWAN> BeginCreateOrUpdateAsync(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName, VirtualWAN wANParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualWANName, wANParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a VirtualWAN tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being updated.
            /// </param>
            /// <param name='wANParameters'>
            /// Parameters supplied to Update VirtualWAN tags.
            /// </param>
            public static VirtualWAN BeginUpdateTags(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName, TagsObject wANParameters)
            {
                return operations.BeginUpdateTagsAsync(resourceGroupName, virtualWANName, wANParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a VirtualWAN tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being updated.
            /// </param>
            /// <param name='wANParameters'>
            /// Parameters supplied to Update VirtualWAN tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualWAN> BeginUpdateTagsAsync(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName, TagsObject wANParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateTagsWithHttpMessagesAsync(resourceGroupName, virtualWANName, wANParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a VirtualWAN.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being deleted.
            /// </param>
            public static void BeginDelete(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName)
            {
                operations.BeginDeleteAsync(resourceGroupName, virtualWANName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a VirtualWAN.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN being deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualWANsOperations operations, string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualWANName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all the VirtualWANs in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualWAN> ListByResourceGroupNext(this IVirtualWANsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VirtualWANs in a resource group.
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
            public static async Task<IPage<VirtualWAN>> ListByResourceGroupNextAsync(this IVirtualWANsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the VirtualWANs in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualWAN> ListNext(this IVirtualWANsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VirtualWANs in a subscription.
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
            public static async Task<IPage<VirtualWAN>> ListNextAsync(this IVirtualWANsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}