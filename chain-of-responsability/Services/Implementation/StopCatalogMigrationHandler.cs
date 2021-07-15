using chain_of_responsability.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsability.Services.Implementation
{
    public class StopCatalogMigrationHandler : MigrationAbstractHandler
    {
        public override void Migrate()
        {
            Console.WriteLine("StopCatalog migrating...");

            var dataService = DataService.GetInstance();
            dataService.Add("stop-catalog-1", "stop-catalog-value-1");
            dataService.Add("stop-catalog-2", "stop-catalog-value-2");
            dataService.Add("stop-catalog-3", "stop-catalog-value-3");
            dataService.Add("stop-catalog-4", "stop-catalog-value-4");
            dataService.Add("stop-catalog-5", "stop-catalog-value-5");
            if (this.Next != null)
            {
                this.Next.Migrate();
            }
        }
    }
}
