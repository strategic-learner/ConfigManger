using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DIV.ConfigMgr.Data
    {
    public static class Program
        {
        public static void Main()
            {
#if DEBUG
            Database.SetInitializer<ConfigMgrContext>(new ConfigMgrDropCreateAlwaysInitializer());
            //Database.SetInitializer(new ConfigMgrInitializer());
#else
            Database.SetInitializer<ConfigMgrContext>(new ConfigMgrDropCreateAlwaysInitialize());
#endif

            }
        }
    }
