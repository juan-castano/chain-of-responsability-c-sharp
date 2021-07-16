using chain_of_responsability.Services.Abstract;
using System;

namespace chain_of_responsability.Services.Implementation
{
    public class StopRegisterMigrationHandler : MigrationAbstractHandler
    {
        private readonly LoggerService _loggerService;
        public StopRegisterMigrationHandler(LoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public override void Migrate()
        {
            _loggerService.LogInfo("StopRegister migrating...");

            var dataService = DataService.GetInstance();

            dataService.Add("stop-register-1", "stop-register-value-1");
            dataService.Add("stop-register-2", "stop-register-value-2");
            dataService.Add("stop-register-3", "stop-register-value-3");
            dataService.Add("stop-register-4", "stop-register-value-4");
            dataService.Add("stop-register-5", "stop-register-value-5");

            if (this.Next != null)
            {
                this.Next.Migrate();
            }
        }
    }
}
