namespace Nozomi.net.Base
{
    public class RequestOptions
    {
        /// <summary>
        /// Gets or sets the API key to use for the request.
        /// </summary>
        public string ApiKey { get; set; }

        // TODO: Support idempotent requests
        // /// <summary>
        // /// Get or sets the idempotency
        // /// key</a> to use for the request.
        // /// </summary>
        // public string IdempotencyKey { get; set; }

        /// <summary>Gets or sets the base URL for the request.</summary>
        /// <remarks>
        /// This is an internal property. It is set by services or individual request methods when
        /// they need to send a request to a non-standard destination, e.g. <c>docs.nozomi.one</c>
        /// for file creation requests or <c>docs.nozomi.one</c> for OAuth requests.
        /// </remarks>
        internal string BaseUrl { get; set; }

        /// <summary>Gets or sets the API version for the request.</summary>
        /// <remarks>
        /// This is an internal property. For most requests, the API version is always set to the
        /// library's pinned version (<see cref="NozomiConfiguration.ApiVersion"/>). This property
        /// is only used for creating ephemeral keys, which require a specific API version.
        /// </remarks>
        internal string NozomiVersion { get; set; }
    }
}