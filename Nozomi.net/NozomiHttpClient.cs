using System;
using System.Net.Http;

namespace Nozomi.net
{
    public class NozomiHttpClient : HttpClient
    {
        private string ApiKey { get; set; }
        
        public NozomiHttpClient(string apiKey)
        {
            SetApiKey(apiKey);
        }

        public NozomiHttpClient(string apiKey, HttpMessageHandler handler) : base(handler)
        {
            SetApiKey(apiKey);
        }

        public NozomiHttpClient(string apiKey, HttpMessageHandler handler, bool disposeHandler) 
            : base(handler, disposeHandler)
        {
            SetApiKey(apiKey);
        }

        private void SetApiKey(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
                throw new NullReferenceException("Invalid API Key");
            ApiKey = apiKey;
        }
    }
}