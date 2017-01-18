using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

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

        public DROConfigurationFull( ConfigMgrReadContext _db , JobIDList JobIDList )
            {
            db = _db as ConfigMgrReadContext;
            var jobIDs = JobIDList.IDs.ToArray();

            this.config = db.config
                .AsNoTracking()
                .Where(cfg=> jobIDs.Contains(cfg.jobID))
                .ToList().AsQueryable();
            }

        public void LoadToFirstLevel()
            {
            db.Entry(config).Reference(cfg => cfg.app).Load();

            }


        }
    }
