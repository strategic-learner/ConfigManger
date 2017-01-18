using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Spatial;
using System.Data.Entity.SqlServer;
using System.Data.Entity.Utilities;
using System.Data.Entity.Validation;
using Company.DIV.ConfigMgr.Domain;
using Company.DIV.ConfigMgr.Domain.Read;
using Company.DIV.ConfigMgr.Domain.Business.UseCase;

namespace Company.DIV.ConfigMgr.Data.Read.DAO
    {
    public class DROConfigurationFull : DAOConfigurationFull<Config , ParamVersion , ParamDefinition , App , JConfigPlan , JConfigExecutable , ConfigParam>
        {
        private ConfigMgrReadContext db;
        private ConfigMgrReadContext db2 = new ConfigMgrReadContext();
        //private string query;

        private DROConfigurationFull( IConfigMgrReadContext _db )
            {
            db = _db as ConfigMgrReadContext;
            }
        public DROConfigurationFull( ConfigMgrReadContext _db , QryGetAggConfigurationByJobIDList _query )
            {
            db = _db as ConfigMgrReadContext;
            var JobIDList = _query.JobIDList.ToArray();

            this.config = db.config
                .AsNoTracking()
                .Where(x=> JobIDList.Contains(x.jobID))
                .ToList().AsQueryable();
            }

        //public void test()
        //    {
        //    var test = db.config.AsNoTracking().ToList();
        //    //IQueryable = db2.config.AsNoTracking().Include(x=>x.);

        //    }


        //return db.app.AsNoTracking().ToList().AsQueryable();





        }
    }
