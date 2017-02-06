using System;
using System.Collections.Generic;
using Company.DIV.ConfigMgr.Domain;
using Company.DIV.ConfigMgr.Domain.Write;
using Company.DIV.ConfigMgr.Domain.DTO;

namespace Company.DIV.ConfigMgr.Data.Write.DAO
    {
    public class DWOConfigFull : DAOConfigFull<Config , ParamVersion , ParamDefinition , App , Executable , ConfigParam>
        {

        private IConfigMgrWriteContext db;

        public DWOConfigFull( IConfigMgrWriteContext _db )
            {
            db = _db;
            }
        //public DWOConfigFull( IConfigMgrReadContext _db , string _query )
        //    {
        //    db = _db;
        //    }







        }
    }
