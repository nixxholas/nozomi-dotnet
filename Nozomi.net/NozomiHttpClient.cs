using System;
using System.Net.Http;

namespace Nozomi.net
{
    public class NozomiHttpClient : HttpClient
    {
        private string ApiKey { get; set; }
        
        public NozomiHttpClient(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
                throw new NullReferenceException("Invalid API Key");
            ApiKey = apiKey;
        }
    }
}