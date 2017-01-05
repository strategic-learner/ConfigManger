using System.Data.Entity;

namespace Company.DIV.ConfigMgr.Data.Read
    {
    internal class ConfigMgrDropCreateAlwaysInitializer : DropCreateDatabaseAlways<ConfigMgrReadContext>
        {
        protected override void Seed( ConfigMgrReadContext context )
            {
            SeedData seedData = new SeedData();
            seedData.data(context);
            }
        }

    internal class ConfigMgrDropCreateIfModelChangesInitializer : DropCreateDatabaseIfModelChanges<ConfigMgrReadContext>
        {
        protected override void Seed( ConfigMgrReadContext context )
            {
            SeedData seedData = new SeedData();
            seedData.data(context);
            }
        }
    internal class ConfigMgrCreateDatabaseIfNotExistsInitializer :  CreateDatabaseIfNotExists<ConfigMgrReadContext>
        {
        protected override void Seed( ConfigMgrReadContext context )
            {
            SeedData seedData = new SeedData();
            seedData.data(context);
            }
        }
    }
