using System.Data.Entity;

namespace Company.DIV.ConfigMgr.Data.Read
    {
    public static class Program
        {
        public static void Main()
            {
            #if DEBUG
            ///designtime helper for Migrations - use whichever is needed, and set this project as the startup project 
            Database.SetInitializer<ConfigMgrReadContext>(new ConfigMgrCreateDatabaseIfNotExistsInitializer());
            //Database.SetInitializer<ConfigMgrContext>(new ConfigMgrDropCreateAlwaysInitializer());
            //Database.SetInitializer<ConfigMgrContext>(new ConfigMgrDropCreateIfModelChangesInitializer());
            #endif
            }
        }
    }
