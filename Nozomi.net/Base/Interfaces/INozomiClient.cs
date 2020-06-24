using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Nozomi.net.Base.Interfaces
{
    /// <summary>
    /// Interface for a Nozomi client.
    /// </summary>
    public interface INozomiClient
    {
        /// <summary>Gets the base URL for Nozomi's API.</summary>
        /// <value>The base URL for Nozomi's API.</value>
        string ApiBase { get; }

        /// <summary>Gets the API key used by the client to send requests.</summary>
        /// <value>The API key used by the client to send requests.</value>
        string ApiKey { get; }

        /// <summary>Gets the base URL for Nozomi's OAuth API.</summary>
        /// <value>The base URL for Nozomi's OAuth API.</value>
        string ConnectBase { get; }

        /// <summary>Sends a request to Nozomi's API as an asynchronous operation.</summary>
        /// <typeparam name="T">Type of the Nozomi entity returned by the API.</typeparam>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="options">The parameters of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="NozomiException">Thrown if the request fails.</exception>
        Task<T> RequestAsync<T>(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
            where T : INozomiEntity;
    }
}