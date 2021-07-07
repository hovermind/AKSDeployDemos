using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace ConsoleApp.KeyVaultAccess
{
    public class EntryPoint
    {
        private readonly IConfiguration _configuration;

        public EntryPoint(IConfiguration config)
        {
            _configuration = config;
        }

        public void Run(String[] args)
        {
            while (true)
            {
                WriteLine("");
                WriteLine("=====================================================================================\n");

                WriteLine("KeyVault Access from console app\n");

                var testSecretName = _configuration["TestSecretName"];
                var testSecret = _configuration[testSecretName];

                WriteLine($"Test secret (from Azure KeyVault): {testSecret}");

                WriteLine("\n=================================================================================");
                WriteLine("");

                Thread.Sleep(1000);
            }
        }
    }
}
