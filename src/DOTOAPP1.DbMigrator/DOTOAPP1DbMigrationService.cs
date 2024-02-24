using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace DOTOAPP1.DbMigrator
{
    public class DOTOAPP1DbMigrationService : ITransientDependency
    {
        private readonly IDataSeedContributor _dataSeeder;

        public DOTOAPP1DbMigrationService(IDataSeedContributor dataSeeder)
        {
            _dataSeeder = dataSeeder;
        }

        public void Initialize()
        {
            var context = new DataSeedContext();
            _dataSeeder.SeedAsync(context);
        }
    }
}
