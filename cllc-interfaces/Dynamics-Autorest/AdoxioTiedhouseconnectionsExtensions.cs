// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AdoxioTiedhouseconnections.
    /// </summary>
    public static partial class AdoxioTiedhouseconnectionsExtensions
    {
            /// <summary>
            /// Get entities from adoxio_tiedhouseconnections
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Show only the first n items
            /// </param>
            /// <param name='skip'>
            /// Skip only the first n items
            /// </param>
            /// <param name='search'>
            /// Search items by search phrases
            /// </param>
            /// <param name='filter'>
            /// Filter items by property values
            /// </param>
            /// <param name='count'>
            /// Include count of items
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static GetOKResponseModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModel Get(this IAdoxioTiedhouseconnections operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from adoxio_tiedhouseconnections
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Show only the first n items
            /// </param>
            /// <param name='skip'>
            /// Skip only the first n items
            /// </param>
            /// <param name='search'>
            /// Search items by search phrases
            /// </param>
            /// <param name='filter'>
            /// Filter items by property values
            /// </param>
            /// <param name='count'>
            /// Include count of items
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetOKResponseModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModel> GetAsync(this IAdoxioTiedhouseconnections operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to adoxio_tiedhouseconnections
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            public static MicrosoftDynamicsCRMadoxioTiedhouseconnection Create(this IAdoxioTiedhouseconnections operations, MicrosoftDynamicsCRMadoxioTiedhouseconnection body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_tiedhouseconnections
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioTiedhouseconnection> CreateAsync(this IAdoxioTiedhouseconnections operations, MicrosoftDynamicsCRMadoxioTiedhouseconnection body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete entity from adoxio_tiedhouseconnections
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseconnectionid'>
            /// key: adoxio_tiedhouseconnectionid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this IAdoxioTiedhouseconnections operations, string adoxioTiedhouseconnectionid, string ifMatch = default(string))
            {
                operations.DeleteAsync(adoxioTiedhouseconnectionid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_tiedhouseconnections
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseconnectionid'>
            /// key: adoxio_tiedhouseconnectionid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAdoxioTiedhouseconnections operations, string adoxioTiedhouseconnectionid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(adoxioTiedhouseconnectionid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get entity from adoxio_tiedhouseconnections by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseconnectionid'>
            /// key: adoxio_tiedhouseconnectionid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioTiedhouseconnection GetByKey(this IAdoxioTiedhouseconnections operations, string adoxioTiedhouseconnectionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(adoxioTiedhouseconnectionid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_tiedhouseconnections by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseconnectionid'>
            /// key: adoxio_tiedhouseconnectionid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioTiedhouseconnection> GetByKeyAsync(this IAdoxioTiedhouseconnections operations, string adoxioTiedhouseconnectionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(adoxioTiedhouseconnectionid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update entity in adoxio_tiedhouseconnections
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseconnectionid'>
            /// key: adoxio_tiedhouseconnectionid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this IAdoxioTiedhouseconnections operations, string adoxioTiedhouseconnectionid, MicrosoftDynamicsCRMadoxioTiedhouseconnection body)
            {
                operations.UpdateAsync(adoxioTiedhouseconnectionid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_tiedhouseconnections
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseconnectionid'>
            /// key: adoxio_tiedhouseconnectionid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IAdoxioTiedhouseconnections operations, string adoxioTiedhouseconnectionid, MicrosoftDynamicsCRMadoxioTiedhouseconnection body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(adoxioTiedhouseconnectionid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
