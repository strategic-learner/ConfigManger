using System.Collections.Generic;
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

            List<int> List = new List<int>{1,2,3,4 };

            Domain.Business.UseCase.JobIDList jobIDList = new Domain.Business.UseCase.JobIDList(List);

            var test = new Company.DIV.ConfigMgr.Data.Read.DAO.DROConfigurationFull(new ConfigMgrReadContext() , jobIDList);

            }
        }
    }
