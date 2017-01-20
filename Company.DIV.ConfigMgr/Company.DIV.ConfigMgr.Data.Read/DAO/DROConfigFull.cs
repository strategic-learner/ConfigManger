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
using System.Threading.Tasks;

namespace Company.DIV.ConfigMgr.Data.Read.DAO
    {
    public class DROConfigFull : DAOConfigFull<Config , ParamVersion , ParamDefinition , App , JConfigPlan , JConfigExecutable , ConfigParam>
        {
        private ConfigMgrReadContext _db;

        public DROConfigFull( ConfigMgrReadContext db , JobIDList JobIDList )
            {
            this._db = db as ConfigMgrReadContext;
            List<int> jobIDs = JobIDList.IDs;

            this.config = db.config
                .AsNoTracking()
                .Where(cfg => jobIDs.Contains(cfg.jobID))
                .ToList();
            
            }

        public DROConfigFull( ConfigMgrReadContext _db , JobIDList JobIDList , DROConfigFull ConfigFull)
            {
            this._db = _db as ConfigMgrReadContext;
            this.config = ConfigFull.config;

            List<int> existingJobIDs = this.config.Select(x => x.jobID).ToList();
            List<int> JobIDsToAdd = new List<int>();
            foreach ( int jobID in JobIDList.IDs )
                {
                if ( !existingJobIDs.Contains(jobID) )
                    { JobIDsToAdd.Add(jobID); }
                }

            this.config = this.config.AsEnumerable().Union(_db.config
                .AsNoTracking()
                .Where(cfg => JobIDsToAdd.Contains(cfg.jobID))
                .ToList()
                ).ToList();
            }




        public void LoadToFirstLevel()
            {
            Task<bool> appsLoadAll = Task.Factory.StartNew(AppsLoadAll);
            Task<bool> paramVersionsLoadAll = Task.Factory.StartNew(ParamVersionsLoadAll);
            

            Task.WaitAll();
            
            foreach ( Config cfg in this.config )
                {
                //db.Entry(cfg).Reference(x => x.App).Load();  //loads endless loop of App<=>config references
                //db.Entry(cfg).Reference(x => x.ParamVersion).Load();  //Loading for the first cfg, seems to load for all the other cfg`s in the loop?

                _db.Entry(cfg).Collection(x => x.JConfigExecutables).Load();
                _db.Entry(cfg).Collection(x => x.JConfigJPlanLOBs).Load();
                _db.Entry(cfg).Collection(x => x.JConfigPlans).Load();

                _db.Entry(cfg).Collection(x => x.ConfigParamPROD).Load();
                _db.Entry(cfg).Collection(x => x.ConfigParamSTG1).Load();
                _db.Entry(cfg).Collection(x => x.ConfigParamSTG2).Load();
                _db.Entry(cfg).Collection(x => x.ConfigParamQA1).Load();
                _db.Entry(cfg).Collection(x => x.ConfigParamQA2).Load();
                _db.Entry(cfg).Collection(x => x.ConfigParamDEV1).Load();
                _db.Entry(cfg).Collection(x => x.ConfigParamDEV2).Load();
                }

            }


        private bool AppsLoadAll()
            {
            List<Guid> appIDsAll = this.config.Select(c => c.AppID).Distinct().ToList();
            List<Guid> existingAppIDs = this.app.Select(x => x.ID).ToList();
            List<Guid> AppIDsToAdd = new List<Guid>();
            foreach ( Guid id in appIDsAll )
                {
                if ( !existingAppIDs.Contains(id) )
                    { AppIDsToAdd.Add(id); }
                }

            this.app = this.app.AsEnumerable().Union(
                _db.app
                .AsNoTracking()
                .Where(x => AppIDsToAdd.Contains(x.ID))
                .ToList()
                ).ToList();

            return true;
            }


        private bool ParamVersionsLoadAll()
            {
            List<Guid> paramVersionIDsAll = this.config.Select(c => c.ParamVersionID).Distinct().ToList();
            List<Guid> existingParamVersionIDs = this.paramVersion.Select(x => x.ID).ToList();
            List<Guid> paramVersionIDsToAdd = new List<Guid>();
            foreach ( Guid id in paramVersionIDsAll )
                {
                if ( !existingParamVersionIDs.Contains(id) )
                    { paramVersionIDsToAdd.Add(id); }
                }

            this.paramVersion = this.paramVersion.AsEnumerable().Union(
                _db.paramVersion
                .AsNoTracking()
                .Where(x => paramVersionIDsToAdd.Contains(x.ID))
                .ToList()
                ).ToList();

            return true;
            }



        

        private bool ExecutablesLoadAll()
            {
            
            List<Guid> JConfigExecutablesAll = this.config.Select(c => _db.executable.Where( == c.ParamVersionID)).Distinct().ToList();
            List<Guid> existingParamVersionIDs = this.paramVersion.Select(x => x.ID).ToList();
            List<Guid> paramVersionIDsToAdd = new List<Guid>();
            foreach ( Guid id in paramVersionIDsAll )
                {
                if ( !existingParamVersionIDs.Contains(id) )
                    { paramVersionIDsToAdd.Add(id); }
                }

            this.paramVersion = this.paramVersion.AsEnumerable().Union(
                _db.paramVersion
                .AsNoTracking()
                .Where(x => paramVersionIDsToAdd.Contains(x.ID))
                .ToList()
                ).ToList();

            return true;
            }







        //private bool ConfigParamLoadAll<T>() where T : IConfigParam
        //    {
        //    List<Guid> paramVersionIDsAll = this.config.Select(c => c.ParamVersionID).Distinct().ToList();
        //    List<Guid> existingParamVersionIDs = this.paramVersion.Select(x => x.ID).ToList();
        //    List<Guid> paramVersionIDsToAdd = new List<Guid>();
        //    foreach ( Guid id in paramVersionIDsAll )
        //        {
        //        if ( !existingParamVersionIDs.Contains(id) )
        //            { paramVersionIDsToAdd.Add(id); }
        //        }

        //    this.paramVersion = this.paramVersion.AsEnumerable().Union(
        //        _db.paramVersion
        //        .AsNoTracking()
        //        .Where(x => paramVersionIDsToAdd.Contains(x.ID))
        //        .ToList()
        //        ).ToList();

        //    return true;
        //    }




        public void DisposeDBContext()
            {this._db.Dispose();}

        }
    }
