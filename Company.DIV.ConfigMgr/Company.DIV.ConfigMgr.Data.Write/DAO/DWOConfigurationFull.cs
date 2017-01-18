using System;
using System.Collections.Generic;
using Company.DIV.ConfigMgr.Domain;
using Company.DIV.ConfigMgr.Domain.Write;

namespace Company.DIV.ConfigMgr.Data.Write.DAO
    {
    public class DWOConfigurationFull : DAOConfigurationFull<Config , ParamVersion , ParamDefinition , App , JConfigPlan , JConfigExecutable , ConfigParam>
        {

        private IConfigMgrWriteContext db;

        public DWOConfigurationFull( IConfigMgrWriteContext _db )
            {
            db = _db;
            }
        //public DWOAggConfiguration( IConfigMgrReadContext _db , string _query )
        //    {
        //    db = _db;
        //    }







        }
    }
