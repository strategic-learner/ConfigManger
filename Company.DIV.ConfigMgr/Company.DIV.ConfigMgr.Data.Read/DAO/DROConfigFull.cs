using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

//using System.Data.Entity.Core;
//using System.Data.Entity.Infrastructure;
//using System.Data.Entity.Spatial;
//using System.Data.Entity.SqlServer;
////using System.Data.Entity.Utilities;
//using System.Data.Entity.Validation;

using Company.DIV.ConfigMgr.Domain;
using Company.DIV.ConfigMgr.Domain.Read;
using Company.DIV.ConfigMgr.Domain.Business.UseCase;


namespace Company.DIV.ConfigMgr.Data.Read.DAO
    {
    public class DROConfigFull : DAOConfigFull<Config /*, ParamVersion , ParamDefinition , App , JConfigPlan , JConfigExecutable , ConfigParam*/>
        {
        private ConfigMgrReadContext db;
        private Config ConfigSingle;

        public DROConfigFull( ConfigMgrReadContext _db , JobIDList JobIDList )
            {
            db = _db as ConfigMgrReadContext;
            //db.Configuration.AutoDetectChangesEnabled=false;
            //db.Configuration.LazyLoadingEnabled = false;
            //var jobIDs = JobIDList.IDs.ToArray();

            //this.configList = db.config
            //    .AsNoTracking()
            //    .Where(cfg=> jobIDs.Contains(cfg.jobID))
            //    .ToList();

            //this.configQrybl = db.config
            //    .AsNoTracking()
            //    .Where(cfg => jobIDs.Contains(cfg.jobID))
            //    .ToList().AsQueryable();

            //this.ConfigSingle = db.config
            //    .AsNoTracking()
            //    .FirstOrDefault();

            //foreach ( Config cfg in this.configList )
            //    {
            //    db.config.Attach(cfg);
            //    }
            }

        public void LoadToFirstLevel()
            {
            foreach ( Config cfg in this.configList )
                {

                //db.Entry(cfg).Reference(x => x.App).Load();
                //db.Entry(cfg).Reference(x => x.ParamVersion).Load();

                //db.Entry(cfg).Collection(x => x.JConfigExecutables).Load();
                //db.Entry(cfg).Collection(x => x.JConfigJPlanLOBs).Load();
                //db.Entry(cfg).Collection(x => x.JConfigPlans).Load();

                //db.Entry(cfg).Collection(x => x.ConfigParamPROD).Load();
                //db.Entry(cfg).Collection(x => x.ConfigParamSTG1).Load();
                //db.Entry(cfg).Collection(x => x.ConfigParamSTG2).Load();
                //db.Entry(cfg).Collection(x => x.ConfigParamQA1).Load();
                //db.Entry(cfg).Collection(x => x.ConfigParamQA2).Load();
                //db.Entry(cfg).Collection(x => x.ConfigParamDEV1).Load();
                //db.Entry(cfg).Collection(x => x.ConfigParamDEV2).Load();
                }

            }


        }
    }
