using System.Collections.Generic;
using System.Data.Entity;
using Company.DIV.ConfigMgr.Domain.Read;

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

            List<int> List = new List<int>
            //{5,6,7,8 };
            {5,6,7 };
            

            Domain.Business.UseCase.JobIDList jobIDList = new Domain.Business.UseCase.JobIDList(List);

            using ( ConfigMgrReadContext dbcontext = new ConfigMgrReadContext() )
                {

                var test = new Company.DIV.ConfigMgr.Data.Read.DAO.DROConfigFull(dbcontext , jobIDList);
                //test.LoadToFirstLevel();
                int test3 = 3;
                }

            int test2 = 2;

            }
        }
    }
