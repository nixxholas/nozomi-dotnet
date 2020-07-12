using System;

namespace Nozomi.net.Exceptions
{
    public class ApiKeyConfigurationException : Exception
    {
        private static readonly string DefaultMessage = "Incorrect Api Key Configuration.";

        public string ApiKeyHeader { get; }
        public string ApiKey { get; }

        public ApiKeyConfigurationException() : base(DefaultMessage) { }
        public ApiKeyConfigurationException(string message) : base(message) { }
        public ApiKeyConfigurationException(string message, Exception innerException)
            : base(message, innerException) { }

        public ApiKeyConfigurationException(string apiKeyHeader, string apiKey)
            : base(DefaultMessage)
        {
            ApiKeyHeader = apiKeyHeader;
            ApiKey = apiKey;
        }

        public ApiKeyConfigurationException(string apiKeyHeader, string apiKey, System.Exception innerException)
            : base(DefaultMessage, innerException)
        {
            ApiKeyHeader = apiKeyHeader;
            ApiKey = apiKey;
        }

        protected ApiKeyConfigurationException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}