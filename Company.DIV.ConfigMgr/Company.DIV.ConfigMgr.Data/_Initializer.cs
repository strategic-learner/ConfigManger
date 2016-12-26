using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DIV.ConfigMgr.Data
    {
    internal class ConfigMgrDropCreateAlwaysInitializer :
        DropCreateDatabaseAlways<ConfigMgrContext>
    //DropCreateDatabaseIfModelChanges<ConfigMgrContext>
        {

        public ConfigMgrDropCreateAlwaysInitializer()
            {

            }

        }
    }
