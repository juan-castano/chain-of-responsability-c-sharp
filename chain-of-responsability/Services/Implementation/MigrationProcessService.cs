using chain_of_responsability.Services.Abstract;
using System;

namespace chain_of_responsability.Services.Implementation
{
    public class MigrationProcessService
    {
        private readonly LoggerService _loggerService;
        public MigrationProcessService(LoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public void StartMigration()
        {
            var stopCatalog = new StopCatalogMigrationHandler(_loggerService);
            var stopMigration = new StopMigrationHandler(_loggerService);
            var stopRegisterMigration = new StopRegisterMigrationHandler(_loggerService);
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
    }
}
