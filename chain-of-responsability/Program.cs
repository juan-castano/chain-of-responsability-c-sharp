using chain_of_responsability.Services.Abstract;
using chain_of_responsability.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace chain_of_responsability
{
    class Program
    {
        static void Main(string[] args)
        {

            using IHost host = CreateHostBuilder(args).Build();
            Console.WriteLine("Chain of responsability pattern used for migrating data as a flow");
            var stopCatalog = new StopCatalogMigrationHandler();
            var stopMigration = new StopMigrationHandler();
            var stopRegisterMigration = new StopRegisterMigrationHandler();
            stopMigration
                .SetHandler(stopCatalog)
                .SetHandler(stopRegisterMigration);
            stopMigration.Migrate();

            Console.WriteLine("After make migrations");
            foreach (var item in DataService.GetInstance().Map)
            {
                Console.WriteLine(item);
            }            
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddTransient<IMigrateHandler, StopCatalogMigrationHandler>();
                });
        }
    }
}
