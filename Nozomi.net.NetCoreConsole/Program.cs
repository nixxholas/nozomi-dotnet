using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nozomi.net.NetCoreConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var envVars = Environment.GetEnvironmentVariables();
            if (envVars["key"] == null && string.IsNullOrEmpty((string) envVars["key"]))
                throw new KeyNotFoundException("Please provide an API Key.");
            
            var apiClient = new NozomiApiClient((string) envVars["key"]);

            var result = await apiClient.ConnectService.ValidateAsync();
            Console.WriteLine(result);
        }
    }
}