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
    public class DROConfigFull : DAOConfigFull<Config , ParamVersion , ParamDefinition , App , /*JConfigJPlanLOB ,*/ Plan , LineOfBusiness , /*JConfigExecutable ,*/ Executable , ConfigParam>
        {
        private ConfigMgrReadContext _db;
        List<Guid> ConfigIDsAll = new List<Guid>();
        
        public DROConfigFull( ConfigMgrReadContext db , JobIDList JobIDList )
            {
            if ( db == null ) { throw new NullReferenceException("db cannot be null"); }
            if ( JobIDList == null ) { throw new NullReferenceException("JobIDList cannot be null"); }
            if ( JobIDList.IDs.Count<=0 ){ throw new Exception("JobIDList.IDs.Count must be GT 0"); }

            this._db = db as ConfigMgrReadContext;
            List<int> jobIDs = JobIDList.IDs;

            this.config = db.config
                .AsNoTracking()
                .Where(cfg => jobIDs.Contains(cfg.jobID))
                .ToList();

            ConfigIDsAll = this.config.Select(c => c.ID).ToList();

            //this.app = new App();


            LoadToFirstLevel();
            }

        public DROConfigFull( ConfigMgrReadContext db , JobIDList JobIDList , DROConfigFull ConfigFull)
            {
            if ( db == null ){ throw new NullReferenceException("db cannot be null"); }
            if ( JobIDList == null ){ throw new NullReferenceException("JobIDList cannot be null"); }
            if ( JobIDList.IDs.Count <= 0 ){ throw new Exception("JobIDList.IDs.Count must be GT 0"); }

            this._db = db as ConfigMgrReadContext;
            this.config = ConfigFull.config;

            List<int> existingJobIDs = this.config.Select(x => x.jobID).ToList();
            List<int> JobIDsToAdd = new List<int>();
            foreach ( int jobID in JobIDList.IDs )
                {
                if ( !existingJobIDs.Contains(jobID) )
                    { JobIDsToAdd.Add(jobID); }
                }

            this.config = this.config.AsEnumerable().Union(db.config
                .AsNoTracking()
                .Where(cfg => JobIDsToAdd.Contains(cfg.jobID))
                .ToList()
                ).ToList();

            ConfigIDsAll = this.config.Select(c => c.ID).ToList();
            }




        private void LoadToFirstLevel()
            {

            AppsLoadAll();
            ParamVersionsLoadAll();
            ExecutablesLoadAll();
            //Task<bool> appsLoadAll = Task.Factory.StartNew(AppsLoadAll);
            //Task<bool> paramVersionsLoadAll = Task.Factory.StartNew(ParamVersionsLoadAll);
            //Task<bool> executablesLoadAlll = Task.Factory.StartNew(ExecutablesLoadAll);

            //Task.WaitAll();
            
            //foreach ( Config cfg in this.config )
            //    {
            //    //db.Entry(cfg).Reference(x => x.App).Load();  //loads endless loop of App<=>config references
            //    //db.Entry(cfg).Reference(x => x.ParamVersion).Load();  //Loading for the first cfg, seems to load for all the other cfg`s in the loop?

            //    _db.Entry(cfg).Collection(x => x.JConfigExecutables).Load();
            //    _db.Entry(cfg).Collection(x => x.JConfigJPlanLOBs).Load();
            //    _db.Entry(cfg).Collection(x => x.JConfigPlans).Load();

            //    _db.Entry(cfg).Collection(x => x.ConfigParamPROD).Load();
            //    _db.Entry(cfg).Collection(x => x.ConfigParamSTG1).Load();
            //    _db.Entry(cfg).Collection(x => x.ConfigParamSTG2).Load();
            //    _db.Entry(cfg).Collection(x => x.ConfigParamQA1).Load();
            //    _db.Entry(cfg).Collection(x => x.ConfigParamQA2).Load();
            //    _db.Entry(cfg).Collection(x => x.ConfigParamDEV1).Load();
            //    _db.Entry(cfg).Collection(x => x.ConfigParamDEV2).Load();
                //}

            }



        private bool AppsLoadAll()
            {
            List<Guid> appIDsAll = this.config.Select(c => c.AppID).Distinct().ToList();
            List<Guid> appIDsExisting = 
                this.app?.AsEnumerable().Select(x => x.ID)
                .Union(
                    GuidEmptyList()
                    ).ToList()
                    ??
                    GuidEmptyList()
                    ;
            
            this.app = 
                this.app?.AsEnumerable()
                .Union(
                    _db.app
                    .AsNoTracking()
                    .Where(x => appIDsAll.Contains(x.ID) && !appIDsExisting.Contains(x.ID))
                    .ToList()
                    ).ToList()
                    ??
                    _db.app
                    .AsNoTracking()
                    .Where(x => appIDsAll.Contains(x.ID))
                    .ToList()
                    ;

            return true;
            }

        private bool ParamVersionsLoadAll()
            {
            List<Guid> paramVersionIDsAll = this.config.Select(c => c.ParamVersionID).Distinct().ToList();
            List<Guid> paramVersionIDsExisting =
                this.paramVersion?.AsEnumerable().Select(x => x.ID).Distinct()
                .Union(
                    GuidEmptyList()
                    ).ToList()
                    ??
                    GuidEmptyList()
                    ;

            this.paramVersion = 
                this.paramVersion?.AsEnumerable()
                .Union(
                    _db.paramVersion
                    .AsNoTracking()
                    .Where(x => paramVersionIDsAll.Contains(x.ID) && !paramVersionIDsExisting.Contains(x.ID))
                    .ToList()
                    ).ToList()
                    ??
                    _db.paramVersion
                    .AsNoTracking()
                    .Where(x => paramVersionIDsAll.Contains(x.ID))
                    .ToList()
                    ;

            return true;
            }

        private bool ExecutablesLoadAll()
            {
            List<Guid> executableIDsExistingJoins = 
                this.config
                .SelectMany(c => c.JConfigExecutables?.Select(jce => jce.ExecutableID))
                .Distinct()
                .ToList()
                ??
                GuidEmptyList();
                        
            var jConfigExecutableAll = _db.jConfigExecutable
                .Where(x => ConfigIDsAll.Contains(x.ConfigID) && !executableIDsExistingJoins.Contains(x.ID))
                .Distinct()
                .ToList();

            foreach (Config cfg in this.config)
                {
                List<Guid> jConfigExecutableIDsExisting = 
                    cfg.JConfigExecutables?.AsEnumerable().Select(x => x.ID).Distinct()
                    .Union(
                        GuidEmptyList()
                        ).ToList()
                    ??
                    GuidEmptyList();

                cfg.JConfigExecutables = 
                    cfg.JConfigExecutables?.AsEnumerable()
                    .Union(
                        jConfigExecutableAll
                        .Where(j => j.ConfigID == cfg.ID && !jConfigExecutableIDsExisting.Contains(j.ID))
                        .ToList()
                        ).ToList()
                    ??
                    jConfigExecutableAll
                    .Where(j => j.ConfigID == cfg.ID)
                    .ToList();
                }

            List<Guid> executableIDsAll =
                jConfigExecutableAll
                .Select(jcea =>jcea.ExecutableID)
                .ToList();

            if ( !executableIDsAll.Any())
                { executableIDsAll = GuidEmptyList(); }


            List<Guid> executableIDsExisting =
                this.executable.Select(e=>e.ID)
                .Distinct()
                .ToList()
                ??
                GuidEmptyList();

            this.executable = 
                this.executable?.AsEnumerable()
                .Union(
                    _db.executable
                    .Where(e => executableIDsAll.Contains(e.ID) && !executableIDsExisting.Contains(e.ID))
                    .ToList()
                    ).ToList()
                ??
                _db.executable
                .Where(e => executableIDsAll.Contains(e.ID))
                .ToList();

            return true;
            }


        private bool ParamDefinitionLoadAll()
            {

            return true;
            }

        private bool PlanLoadAll()
            {

            return true;
            }

        private bool LineOfBusinessLoadAll()
            {

            return true;
            }

        private bool ConfigParamLoadAll()
            {

            return true;
            }




        private bool ConfigParamLoadAll<TConfigParam>() where TConfigParam : IConfigParam
            {
            //TConfigParam

            return true;
            }
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





        private List<Guid> GuidEmptyList()
            {
            List<Guid> g = new List<Guid> { Guid.Empty };
            return g;
            }


        public void DisposeDBContext()
            {this._db.Dispose();}

        }
    }
