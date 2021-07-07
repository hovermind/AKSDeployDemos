using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp.KeyVaultAccess
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var services = Startup.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<EntryPoint>().Run(args);
        }
    }
}
