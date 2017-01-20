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
        //List<EntityState> entryState = new List<EntityState>();
        //private Config ConfigSingle;

        public DROConfigFull( ConfigMgrReadContext _db , JobIDList JobIDList )
            {
            db = _db as ConfigMgrReadContext;
            db.Configuration.AutoDetectChangesEnabled=false;
            //db.Configuration.LazyLoadingEnabled = false;
            var jobIDs = JobIDList.IDs.ToArray();

            this.config = db.config
                .AsNoTracking()
                .Where(cfg => jobIDs.Contains(cfg.jobID))
                .ToList().AsQueryable();

            foreach ( Config cfg in this.config )
                {
                db.config.Attach(cfg);
                //EntityState es = db.Entry(config).State;
                //entryState.Add(es);
                }
            
            }

        public void LoadToFirstLevel()
            {
            List<Guid> appIDs = this.config.Select(c => c.AppID).Distinct().ToList();
            foreach ( Guid id in appIDs )
                {
                db.app
                    .AsNoTracking()
                    .Where(a => a.ID == id)
                    .Load();
                }

            List<Guid> paramVersionIDs = this.config.Select(c => c.ParamVersionID).Distinct().ToList();
            foreach ( Guid pvID in paramVersionIDs )
                {
                db.paramVersion
                    .AsNoTracking()
                    .Where(pv => pv.ID == pvID)
                    .Load();

                db.paramDefinition
                    .AsNoTracking()
                    .Where(pd => pd.ParamVersionID == pvID)
                    .Load();
                }


            foreach ( Config cfg in this.config )
                {
                //db.Entry(cfg).Reference(x => x.App).Load();  //loads endless loop of App<=>config references
                //db.Entry(cfg).Reference(x => x.ParamVersion).Load();  //Loading for the first cfg, seems to load for all the other cfg`s in the loop?

                db.Entry(cfg).Collection(x => x.JConfigExecutables).Load();
                db.Entry(cfg).Collection(x => x.JConfigJPlanLOBs).Load();
                db.Entry(cfg).Collection(x => x.JConfigPlans).Load();

                db.Entry(cfg).Collection(x => x.ConfigParamPROD).Load();
                db.Entry(cfg).Collection(x => x.ConfigParamSTG1).Load();
                db.Entry(cfg).Collection(x => x.ConfigParamSTG2).Load();
                db.Entry(cfg).Collection(x => x.ConfigParamQA1).Load();
                db.Entry(cfg).Collection(x => x.ConfigParamQA2).Load();
                db.Entry(cfg).Collection(x => x.ConfigParamDEV1).Load();
                db.Entry(cfg).Collection(x => x.ConfigParamDEV2).Load();
                }

            }


        }
    }
