// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Rest;
using Newtonsoft.Json;
using Nozomi.net.Models;

namespace Nozomi.net.Services
{
    /// <summary>
    /// ComponentHistoricItemService operations.
    /// </summary>
    public partial class ComponentHistoricItemService : IServiceOperations<NozomiApiClient>, IComponentHistoricItemService
    {
        /// <summary>
        /// Initializes a new instance of the ComponentHistoricItemService class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ComponentHistoricItemService(NozomiApiClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the NozomiApiClient
        /// </summary>
        public NozomiApiClient Client { get; private set; }

        /// <summary>
        /// Obtain all the component historical values created
        /// </summary>
        /// <param name='componentGuid'>
        /// The unique identifier of the component.
        /// </param>
        /// <param name='index'>
        /// The 'page' of the list of results in 100s.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<object>> All(string componentGuid, int? index = 0, 
            CancellationToken cancellationToken = default(CancellationToken))
        {
            if (componentGuid == null)
                throw new ValidationException(ValidationRules.CannotBeNull, "componentGuid");
            
            // Relative Url
            var relativeUrl = "ComponentHistoricItemService/All/{componentGuid}";
            relativeUrl = relativeUrl.Replace("{componentGuid}", 
                System.Uri.EscapeDataString(componentGuid));

            // Query Parameters
            var _queryParameters = new NameValueCollection();
            if (index != null)
                _queryParameters["index"] = System.Uri.EscapeDataString(
                    Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(index, Client.SerializationSettings)
                        .Trim('"'));
            
            // Tracing Parameters
            var tracingParameters = new Dictionary<string, object>();
            tracingParameters.Add("index", index);
            tracingParameters.Add("componentGuid", componentGuid);

            return await Client.Invoke<IList<ComponentHistoricItemViewModel>>(HttpMethod.Get, relativeUrl, 
                _queryParameters, tracingParameters, cancellationToken: cancellationToken);
        }

    }
}
