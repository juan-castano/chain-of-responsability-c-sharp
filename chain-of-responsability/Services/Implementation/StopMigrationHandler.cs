using chain_of_responsability.Services.Abstract;
using System;

namespace chain_of_responsability.Services.Implementation
{
    public class StopMigrationHandler : MigrationAbstractHandler
    {
        private readonly LoggerService _loggerService;
        public StopMigrationHandler(LoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public override void Migrate()
        {
            _loggerService.LogInfo("StopMigration migrating...");

            var dataService = DataService.GetInstance();

            dataService.Add("stop-1", "stop-value-1");
            dataService.Add("stop-2", "stop-value-2");
            dataService.Add("stop-3", "stop-value-3");
            dataService.Add("stop-4", "stop-value-4");
            dataService.Add("stop-5", "stop-value-5");

            if (this.Next != null)
            {
                this.Next.Migrate();
            }
        }
    }
}
