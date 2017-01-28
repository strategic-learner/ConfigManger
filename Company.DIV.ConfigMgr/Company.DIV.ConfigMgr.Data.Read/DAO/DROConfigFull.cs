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
using System.Diagnostics;

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

            ExecutablesLoadAllAsync();
            //LoadAllAsync()
            //Task.WaitAll(LoadAllAsync());
            //_db.Dispose();
            int test5 = 5;
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




        private async Task LoadAllAsync()
            {
            //AppsLoadAll();
            //ParamVersionAndDefinitionsLoadAll();
            //ExecutablesLoadAll();
            //Task<bool> appsLoadAll = Task.Factory.StartNew(AppsLoadAll);
            //Task<bool> paramVersionAndDefinitionsLoadAll = Task.Factory.StartNew(ParamVersionAndDefinitionsLoadAll);
            //Task<bool> executablesLoadAll = Task.Factory.StartNew(ExecutablesLoadAll);


            //List<Task> updates = new List<Task>();
            ////updates.Add(AppsLoadAllAsync());
            ////updates.Add(ParamVersionAndDefinitionsLoadAllAsync());
            //updates.Add(ExecutablesLoadAllAsync());

            //Task.WaitAll(updates.ToArray());  //!!! is this getting converted to void???
            //var TEST = await Task.FromResult(updates);
            var TEST = await Task.FromResult(ExecutablesLoadAllAsync());

            int test4 = 4;
            }



        private async Task<bool> AppsLoadAllAsync()
            {
            Debug.Print("_______________Start AppsLoadAllAsync");
            await Task.Delay(100);

            List<Guid> appIDsAll = this.config.Select(c => c.AppID).Distinct().ToList();
            List<Guid> appIDsExisting = 
                this.app?.AsEnumerable().Select(x => x.ID)
                .Union(
                    GuidEmptyList()
                    ).ToList()
                    ??
                    GuidEmptyList();
            Debug.Print("_______________preQuery AppsLoadAllAsync");

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
                    .ToList();

            Debug.Print("_______________End AppsLoadAllAsync");

            return true;
            }

        private async Task<bool> ParamVersionAndDefinitionsLoadAllAsync()
            {
            Debug.Print("_______________Start ParamVersionAndDefinitionsLoadAllAsync");
            await Task.Delay(75);

            List<Guid> paramVersionIDsAll = this.config.Select(c => c.ParamVersionID).Distinct().ToList();
            List<Guid> paramVersionIDsExisting =
                this.paramVersion?.AsEnumerable().Select(x => x.ID).Distinct()
                .Union(
                    GuidEmptyList()
                    ).ToList()
                    ??
                    GuidEmptyList();

            List<Guid> paramVersionIDsToAdd =
                paramVersionIDsAll.Except(paramVersionIDsExisting).ToList();

            Debug.Print("_______________prequery1 ParamVersionAndDefinitionsLoadAllAsync");
            this.paramVersion = 
                this.paramVersion?.AsEnumerable()
                .Union(
                    _db.paramVersion
                    .AsNoTracking()
                    .Where(x => paramVersionIDsToAdd.Contains(x.ID))
                    .ToList()
                    ).ToList()
                    ??
                    _db.paramVersion
                    .AsNoTracking()
                    .Where(x => paramVersionIDsToAdd.Contains(x.ID))
                    .ToList();
            Debug.Print("_______________PreQuery2 ParamVersionAndDefinitionsLoadAllAsync");
            this.paramDefinition =
                this.paramDefinition?.AsEnumerable()
                .Union(
                    _db.paramDefinition
                    .AsNoTracking()
                    .Where(pd => paramVersionIDsToAdd.Contains(pd.ParamVersionID))
                    .OrderBy(pd => pd.ParamVersionID)
                    .ThenBy(pd => pd.ParamSequence)
                    ).ToList()
                    ??
                    _db.paramDefinition
                    .AsNoTracking()
                    .Where(pd => paramVersionIDsToAdd.Contains(pd.ParamVersionID))
                    .OrderBy(pd => pd.ParamVersionID)
                    .ThenBy(pd => pd.ParamSequence)
                    .ToList();
            Debug.Print("_______________end ParamVersionAndDefinitionsLoadAllAsync");
            return true;
            }

        private bool ExecutablesLoadAllAsync()
        //private async Task<bool> ExecutablesLoadAllAsync()
            {
            Debug.Print("_______________Start ExecutablesLoadAllAsync");
            //await Task.Delay(50);

            List<Guid> executableIDJoinsExisting =
                this.config
                .Where(c => c.JConfigExecutables != null)
                .SelectMany(c => c.JConfigExecutables.Select(jce => jce.ExecutableID) )
                .Distinct()
                .ToList();

            Debug.Print("_______________PreQuery1 ExecutablesLoadAllAsync");
            var jConfigExecutableAll = _db.jConfigExecutable
                .AsNoTracking()
                .Where(x => ConfigIDsAll.Contains(x.ConfigID) && !executableIDJoinsExisting.Contains(x.ID))
                .Distinct()
                .ToList();

            foreach ( Config cfg in this.config)
                {
                List<Guid> jConfigExecutableIDsExisting = 
                    cfg.JConfigExecutables?.AsEnumerable().Select(x => x.ID)
                    .Distinct()
                    .ToList()
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
                this.executable?.Select(e=>e.ID)
                .Distinct()
                .ToList()
                ??
                GuidEmptyList();

            Debug.Print("_______________PreQuery2 ExecutablesLoadAllAsync");
            this.executable = 
                this.executable?.AsEnumerable()
                .Union(
                    _db.executable
                    .AsNoTracking()
                    .Where(e => executableIDsAll.Contains(e.ID) && !executableIDsExisting.Contains(e.ID))
                    .ToList()
                    ).ToList()
                ??
                _db.executable
                .AsNoTracking()
                .Where(e => executableIDsAll.Contains(e.ID))
                .ToList();

            Debug.Print("_______________End ExecutablesLoadAllAsync");
            return true;
            }

        private bool PlansLoadAll()
            {

            return true;
            }

        private bool LineOfBusinessLoadAll()
            {

            return true;
            }

        private bool ConfigParamsLoadAll()
            {

            return true;
            }

        private bool ConfigParamsLoadAll<TConfigParam>() where TConfigParam : IConfigParam
            {
            //TConfigParam

            return true;
            }



        private List<Guid> GuidEmptyList()
            {
            List<Guid> g = new List<Guid> { Guid.Empty };
            return g;
            }


        public void DisposeDBContext()
            {this._db.Dispose();}



        //private bool ParamDefinitionsLoadAll()
        //    {
        //this was unfinished somewhere halfway down
        //    IList<Guid> paramVersionIDsExisting =
        //        this.paramVersion?
        //        .Select(pv => pv.ID).Distinct()
        //        .ToList()
        //        ??
        //        GuidEmptyList();

        //    IList<Guid> paramVersionIDsAll = 
        //        this.config.Select(x=>x.ParamVersionID)
        //        .Distinct()
        //        .ToList();

        //    IList<Guid> paramVersionIDsToAdd = 
        //        paramVersionIDsAll.Except(paramVersionIDsExisting).ToList();


        //    IList<Guid> paramDefinitionIDsExisting =
        //        this.paramDefinition?
        //        .Select(pd => pd.ID).Distinct()
        //        .ToList()
        //        ??
        //        GuidEmptyList();

        //    var paramDefinitionIDsAll =
        //        _db.paramDefinition
        //        .Where(x=> paramVersionIDsAll.Contains(x.ParamVersionID))
        //        .AsNoTracking()
        //        .ToList();


        //    //IList<Guid> paramDefinitionIDsToAdd =
        //    //    paramVersionIDsAll
        //    //    .Except(paramVersionIDsExisting)
        //    //    .ToList();


        //    List<Guid> paramDefinitionIDsAll =
        //        ParamDefinitionAll
        //        .Select(jcea => jcea.ParamDefinitionID)
        //        .ToList();

        //    if ( !paramDefinitionIDsAll.Any() )
        //        { paramDefinitionIDsAll = GuidEmptyList(); }

        //    List<Guid> paramDefinitionIDsExisting =
        //        this.paramDefinition.Select(e => e.ID)
        //        .Distinct()
        //        .ToList()
        //        ??
        //        GuidEmptyList();

        //    this.paramDefinition =
        //        this.paramDefinition?.AsEnumerable()
        //        .Union(
        //            _db.paramDefinition
        //            .Where(e => paramDefinitionIDsAll.Contains(e.ID) && !paramDefinitionIDsExisting.Contains(e.ID))
        //            .ToList()
        //            ).ToList()
        //        ??
        //        _db.paramDefinition
        //        .Where(e => paramDefinitionIDsAll.Contains(e.ID))
        //        .ToList();

        //    return true;
        //    }



        }
    }
