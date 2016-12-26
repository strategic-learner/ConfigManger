using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DIV.ConfigMgr.Data
    {
    internal class ConfigMgrDropCreateAlwaysInitializer : DropCreateDatabaseAlways<ConfigMgrContext>
        {
        protected override void Seed( ConfigMgrContext context )
            {
            SeedData seedData = new SeedData();
            seedData.data(context);
            }
        }

    internal class ConfigMgrDropCreateIfModelChangesInitializer : DropCreateDatabaseIfModelChanges<ConfigMgrContext>
        {
        protected override void Seed( ConfigMgrContext context )
            {
            SeedData seedData = new SeedData();
            seedData.data(context);
            }
        }
    internal class ConfigMgrCreateDatabaseIfNotExistsInitializer :  CreateDatabaseIfNotExists<ConfigMgrContext>
        {
        protected override void Seed( ConfigMgrContext context )
            {
            SeedData seedData = new SeedData();
            seedData.data(context);
            }
        }
    }
