// Code generated by Microsoft (R) AutoRest Code Generator 1.2.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RouteFiltersOperations.
    /// </summary>
    public static partial class RouteFiltersOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            public static void Delete(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName)
            {
                operations.DeleteAsync(resourceGroupName, routeFilterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, routeFilterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced express route bgp peering resources.
            /// </param>
            public static RouteFilter Get(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, routeFilterName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced express route bgp peering resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RouteFilter> GetAsync(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, routeFilterName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a route filter in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='routeFilterParameters'>
            /// Parameters supplied to the create or update route filter operation.
            /// </param>
            public static RouteFilter CreateOrUpdate(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, RouteFilter routeFilterParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, routeFilterName, routeFilterParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a route filter in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='routeFilterParameters'>
            /// Parameters supplied to the create or update route filter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RouteFilter> CreateOrUpdateAsync(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, RouteFilter routeFilterParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, routeFilterName, routeFilterParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a route filter in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='routeFilterParameters'>
            /// Parameters supplied to the update route filter operation.
            /// </param>
            public static RouteFilter Update(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, PatchRouteFilter routeFilterParameters)
            {
                return operations.UpdateAsync(resourceGroupName, routeFilterName, routeFilterParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a route filter in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='routeFilterParameters'>
            /// Parameters supplied to the update route filter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RouteFilter> UpdateAsync(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, PatchRouteFilter routeFilterParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, routeFilterName, routeFilterParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all route filters in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<RouteFilter> ListByResourceGroup(this IRouteFiltersOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all route filters in a resource group.
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
            public static async Task<IPage<RouteFilter>> ListByResourceGroupAsync(this IRouteFiltersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all route filters in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<RouteFilter> List(this IRouteFiltersOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all route filters in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RouteFilter>> ListAsync(this IRouteFiltersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            public static void BeginDelete(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName)
            {
                operations.BeginDeleteAsync(resourceGroupName, routeFilterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, routeFilterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a route filter in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='routeFilterParameters'>
            /// Parameters supplied to the create or update route filter operation.
            /// </param>
            public static RouteFilter BeginCreateOrUpdate(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, RouteFilter routeFilterParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, routeFilterName, routeFilterParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a route filter in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='routeFilterParameters'>
            /// Parameters supplied to the create or update route filter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RouteFilter> BeginCreateOrUpdateAsync(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, RouteFilter routeFilterParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, routeFilterName, routeFilterParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a route filter in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='routeFilterParameters'>
            /// Parameters supplied to the update route filter operation.
            /// </param>
            public static RouteFilter BeginUpdate(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, PatchRouteFilter routeFilterParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, routeFilterName, routeFilterParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a route filter in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='routeFilterParameters'>
            /// Parameters supplied to the update route filter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RouteFilter> BeginUpdateAsync(this IRouteFiltersOperations operations, string resourceGroupName, string routeFilterName, PatchRouteFilter routeFilterParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, routeFilterName, routeFilterParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all route filters in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RouteFilter> ListByResourceGroupNext(this IRouteFiltersOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all route filters in a resource group.
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
            public static async Task<IPage<RouteFilter>> ListByResourceGroupNextAsync(this IRouteFiltersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all route filters in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RouteFilter> ListNext(this IRouteFiltersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all route filters in a subscription.
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
            public static async Task<IPage<RouteFilter>> ListNextAsync(this IRouteFiltersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
