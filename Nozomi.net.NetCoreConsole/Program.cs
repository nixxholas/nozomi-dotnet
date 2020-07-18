using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nozomi.net.Models;

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

            var componentAllResult = await apiClient.ComponentService.AllAsync(null);
            Console.WriteLine(componentAllResult);

            var connectValidateResult = await apiClient.ConnectService.ValidateAsync();
            Console.WriteLine(connectValidateResult.Response.IsSuccessStatusCode ? "Successfully executed Connect/Validate API." 
                : "There was an issue executing Connect/Validate API successfully.");
        }
    }
}