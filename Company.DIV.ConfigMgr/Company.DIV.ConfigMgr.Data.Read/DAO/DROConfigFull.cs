using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

using Company.DIV.ConfigMgr.Domain;
using Company.DIV.ConfigMgr.Domain.Read;
using Company.DIV.ConfigMgr.Domain.Business.UseCase;
using Company.DIV.ConfigMgr.Domain.DTO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Company.DIV.ConfigMgr.Data.Read.DAO
    {
    public class DROConfigFull : DAOConfigFull<Config , ParamVersion , ParamDefinition , App , Executable>
        {
        private IConfigFullReadContext _db;
        public List<Guid> _ConfigIDsAll;
        public List<int> _JobIDsInput;
        public List<int> _JobIDsAll;

        public DROConfigFull( IConfigFullReadContext db , JobIDList jobIDsToAddList )
            {
            if ( db == null )
                {
                Debug.Print("input parameter db cannot be null");
                throw new NullReferenceException("input parameter db cannot be null");
                }
            if ( jobIDsToAddList == null )
                {
                Debug.Print("input parameter jobIDList cannot be null");
                throw new NullReferenceException("input parameter jobIDList cannot be null");
                }
            if ( jobIDsToAddList.IDs.Count<=0 )
                {
                Debug.Print("input parameter jobIDList.IDs.Count must be GT 0");
                throw new Exception("input parameter jobIDList.IDs.Count must be GT 0");
                }

            this._db = db;
            _JobIDsInput = jobIDsToAddList.IDs;
            }

        public DROConfigFull( IConfigFullReadContext db , JobIDList jobIDsToAddList , DROConfigFull _DROConfigFull )
            {
            if ( db == null )
                {
                Debug.Print("input parameter db cannot be null");
                throw new NullReferenceException("input parameter db cannot be null");
                }
            if ( jobIDsToAddList.IDs == null )
                {
                Debug.Print("input parameter jobIDList cannot be null");
                throw new NullReferenceException("input parameter jobIDList cannot be null");
                }
            if ( jobIDsToAddList.IDs.Count <= 0 )
                {
                Debug.Print("input parameter jobIDList.IDs.Count must be GT 0");
                throw new Exception("input parameter jobIDList.IDs.Count must be GT 0");
                }
            if ( _DROConfigFull == null )
                {
                Debug.Print("input parameter _DROConfigFull cannot be null");
                throw new NullReferenceException("input parameter _DROConfigFull cannot be null");
                }

            this._db = db as ConfigMgrReadContext;
            _JobIDsInput = jobIDsToAddList.IDs;
            InitializeFromExisting(_DROConfigFull);
            }

        public async Task<bool> LoadAllAsync()
            {
            await ConfigsLoadAllAsync();
            await AppsLoadAllAsync();
            await ParamVersionAndDefinitionsLoadAllAsync();
            await ExecutablesLoadAllAsync();
            await PlanLOBsLoadAll();
            await ConfigParamLoadAll();

            return true;
            }

        private async Task<bool> ConfigsLoadAllAsync()
            {
            List<int> existingJobIDs =
                this.config?
                .Select(x => x.jobID)
                .ToList()
                ??
                EmptyListTint();

            List<int> JobIDsToAdd =
                _JobIDsInput.Except(existingJobIDs).ToList();

            try
                {
                var configsToAdd =
                await _db.config
                            .AsNoTracking()
                            .Where(cfg => JobIDsToAdd.Contains(cfg.jobID))
                            .ToListAsync();

                this.config =
                    this.config?.AsEnumerable()
                    .Union(configsToAdd).ToList()
                    ??
                    configsToAdd;
                }
            catch ( Exception ex )
                {
                }
            finally
                {
                }


            try
                {
                _ConfigIDsAll = this.config.Select(c => c.ID).ToList();
                }
            catch ( Exception ex )
                {
                }
            finally
                {
                }

            try
                {
                _JobIDsAll = this.config.Select(c => c.jobID).ToList();
                }
            catch(Exception ex)
                {
                }
            finally
                {
                }
            return true;
            }

        private async Task<bool> AppsLoadAllAsync()
            {
            List<Guid> appIDsAll = 
                this.config.Select(c => c.AppID).Distinct().ToList();

            List<Guid> appIDsExisting =
                this.app?.AsEnumerable().Select(x => x.ID)
                .Union(
                    EmptyListTGuid()
                    ).ToList()
                    ??
                    EmptyListTGuid();

            List<Guid> appIDsToAdd = appIDsAll.Except(appIDsExisting).ToList();

            var appsAll = await _db.app
                .AsNoTracking()
                .Where(x => appIDsToAdd.Contains(x.ID))
                .ToListAsync();

            this.app =
                this.app?.AsEnumerable()
                .Union(appsAll).ToList()
                ??
                appsAll;

            return true;
            }

        private async Task<bool> ParamVersionAndDefinitionsLoadAllAsync()
            {
            List<Guid> paramVersionIDsAll = 
                this.config.Select(c => c.ParamVersionID).Distinct().ToList();

            List<Guid> paramVersionIDsExisting =
                this.paramVersion?
                .Select(x => x.ID)
                .Distinct()
                .ToList()
                ??
                EmptyListTGuid();

            List<Guid> paramVersionIDsToAdd =
                paramVersionIDsAll.Except(paramVersionIDsExisting).ToList();

            var paramVersionsToAdd =
                await _db.paramVersion
                            .AsNoTracking()
                            .Where(x => paramVersionIDsToAdd.Contains(x.ID))
                            .ToListAsync();

            this.paramVersion =
                this.paramVersion?.AsEnumerable()
                .Union(
                    paramVersionsToAdd
                    ).ToList()
                    ??
                    paramVersionsToAdd;

            var paramDefinitionsToAdd =
                await _db.paramDefinition
                .AsNoTracking()
                .Where(pd => paramVersionIDsToAdd.Contains(pd.ParamVersionID))
                .OrderBy(pd => pd.ParamVersionID)
                .ThenBy(pd => pd.ParamSequence)
                .ToListAsync();

            this.paramDefinition =
                this.paramDefinition?.AsEnumerable()
                .Union(
                    paramDefinitionsToAdd
                    ).ToList()
                    ??
                    paramDefinitionsToAdd;

            return true;
            }

        private async Task<bool> ExecutablesLoadAllAsync()
            {
            List<Guid> executableIDsAll = new List<Guid>();
            List<Guid> executableIDsExisting = new List<Guid>();
            List<Guid> executableIDsToAdd = new List<Guid>();

            ///Attach the M2M NavProps
            try
                {
                var jConfigExecutableAll =
                    await _db.jConfigExecutable
                    .AsNoTracking()
                    .Where(x => _ConfigIDsAll.Contains(x.ConfigID))
                    .Distinct()
                    .ToListAsync();


                foreach ( Config cfg in this.config )
                    {
                    List<Guid> jConfigExecutableIDsExisting =
                        cfg.JConfigExecutables?.Select(x => x.ID)
                        .Distinct()
                        .ToList()
                        ??
                        EmptyListTGuid();

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

                executableIDsAll =
                    jConfigExecutableAll
                    .Select(jcea => jcea.ExecutableID)
                    .ToList();

                }
            catch ( Exception ex )
                {
                }
            finally
                {
                }

            //Get the Executables
            executableIDsExisting =
                this.executable?.Select(e => e.ID)
                .Distinct()
                .ToList()
                ??
                EmptyListTGuid();

            executableIDsToAdd = 
                executableIDsAll.Except(executableIDsExisting).ToList();

            try
                {
                var executablesToAdd =
                    await _db.executable
                    .AsNoTracking()
                    .Where(e => executableIDsToAdd.Contains(e.ID))
                    .ToListAsync();

                this.executable =
                    this.executable?.AsEnumerable()
                    .Union(
                        executablesToAdd
                        ).ToList()
                        ??
                        executablesToAdd;
                }
            catch(Exception ex)
                {
                }
            finally
                {
                }

            return true;
            }
        
        private async Task<bool> JConfigJPlanLOBsLoadAll()
            {

            ///Attach the M2M NavProps
            try
                {
                var jConfigJPlanLOBAll =
                    await _db.jConfigJPlanLOB
                    .AsNoTracking()
                    .Where(x => _ConfigIDsAll.Contains(x.ConfigID))
                    .Distinct()
                    .ToListAsync();


                foreach ( Config cfg in this.config )
                    {
                    List<Guid> jConfigJPlanLOBIDsExisting =
                        cfg.JConfigJPlanLOBs?.Select(x => x.ID)
                        .Distinct()
                        .ToList()
                        ??
                        EmptyListTGuid();

                    cfg.JConfigJPlanLOBs =
                        cfg.JConfigJPlanLOBs?.AsEnumerable()
                        .Union(
                            jConfigJPlanLOBAll
                            .Where(j => j.ConfigID == cfg.ID && !jConfigJPlanLOBIDsExisting.Contains(j.ID))
                            .ToList()
                            ).ToList()
                        ??
                        jConfigJPlanLOBAll
                        .Where(j => j.ConfigID == cfg.ID)
                        .ToList();
                    }

                }
            catch ( Exception ex )
                {
                }
            finally
                {
                }

            return true;
            }

        private async Task<bool> PlanLOBsLoadAll()
            {
            this.planLOB = 
            await _db.jPlanLOB
                .Join(_db.plan, 
                    jpl=>jpl.PlanID , p=>p.ID
                    ,( jpl , p )=> new {
                        IDjPlanLOB = jpl.ID
                        ,PlanAbbr = p.abbr
                        ,jpl.LineOfBusinessID}
                    )
                .Join(_db.lineOfBusiness ,
                    x => x.LineOfBusinessID , lob => lob.ID 
                    ,( x , lob ) => new {
                         x.IDjPlanLOB
                        ,x.PlanAbbr
                        ,LobAbbr = lob.abbr }
                    )
                .Select(x2 => new DTOPlanLOB {
                     IDjPlanLOB = x2.IDjPlanLOB
                    ,PlanAbbr = x2.PlanAbbr
                    ,LobAbbr = x2.LobAbbr } )
                .ToListAsync();

            return true;
            }
        
        private async Task<bool> ConfigParamLoadAll()
            {
            IEnumerable<ConfigParamConsolidated> AllParams = await ConfigParamGetAll();

            foreach ( Config cfg in this.config )
                {
                //0 initialize config.ConfigParamXXX
                if ( cfg.ConfigParamPROD == null )
                    { cfg.ConfigParamPROD = Enumerable.Empty<ConfigParamPROD>().ToList(); }

                if ( cfg.ConfigParamSTG1 == null )
                    { cfg.ConfigParamSTG1 = Enumerable.Empty<ConfigParamSTG1>().ToList(); }
                if ( cfg.ConfigParamSTG2 == null )
                    { cfg.ConfigParamSTG2 = Enumerable.Empty<ConfigParamSTG2>().ToList(); }

                if ( cfg.ConfigParamQA1 == null )
                    { cfg.ConfigParamQA1 = Enumerable.Empty<ConfigParamQA1>().ToList(); }
                if ( cfg.ConfigParamQA2 == null )
                    { cfg.ConfigParamQA2 = Enumerable.Empty<ConfigParamQA2>().ToList(); }

                if ( cfg.ConfigParamDEV1 == null )
                    { cfg.ConfigParamDEV1 = Enumerable.Empty<ConfigParamDEV1>().ToList(); }
                if ( cfg.ConfigParamDEV2 == null )
                    { cfg.ConfigParamDEV2 = Enumerable.Empty<ConfigParamDEV2>().ToList(); }


                //1 find existing in Config
                IEnumerable<Guid> paramIDsExistingPROD =
                    cfg.ConfigParamPROD.Select(x => x.ID);

                IEnumerable<Guid> paramIDsExistingSTG1 =
                    cfg.ConfigParamSTG1.Select(x => x.ID);

                IEnumerable<Guid> paramIDsExistingSTG2 =
                    cfg.ConfigParamSTG2.Select(x => x.ID);

                IEnumerable<Guid> paramIDsExistingQA1 =
                    cfg.ConfigParamQA1.Select(x => x.ID);

                IEnumerable<Guid> paramIDsExistingQA2 =
                    cfg.ConfigParamQA2.Select(x => x.ID);

                IEnumerable<Guid> paramIDsExistingDEV1 =
                    cfg.ConfigParamDEV1.Select(x => x.ID);

                IEnumerable<Guid> paramIDsExistingDEV2 =
                    cfg.ConfigParamDEV2.Select(x => x.ID);


                //2 Divide Consolidated by env & select new to add for this Config
                IEnumerable<ConfigParamConsolidated> paramsToAddPROD =
                    AllParams.Where(x => x.ConfigID == cfg.ID && x.Environ == "PROD" && !paramIDsExistingPROD.Contains(x.ID));

                IEnumerable<ConfigParamConsolidated> paramsToAddSTG1 =
                    AllParams.Where(x => x.ConfigID == cfg.ID && x.Environ == "STG1" && !paramIDsExistingSTG1.Contains(x.ID));

                IEnumerable<ConfigParamConsolidated> paramsToAddSTG2 =
                    AllParams.Where(x => x.ConfigID == cfg.ID && x.Environ == "STG2" && !paramIDsExistingSTG2.Contains(x.ID));

                IEnumerable<ConfigParamConsolidated> paramsToAddQA1 =
                    AllParams.Where(x => x.ConfigID == cfg.ID && x.Environ == "QA1" && !paramIDsExistingQA1.Contains(x.ID));

                IEnumerable<ConfigParamConsolidated> paramsToAddQA2 =
                    AllParams.Where(x => x.ConfigID == cfg.ID && x.Environ == "QA2" && !paramIDsExistingQA2.Contains(x.ID));

                IEnumerable<ConfigParamConsolidated> paramsToAddDEV1 =
                    AllParams.Where(x => x.ConfigID == cfg.ID && x.Environ == "DEV1" && !paramIDsExistingDEV1.Contains(x.ID));

                IEnumerable<ConfigParamConsolidated> paramsToAddDEV2 =
                    AllParams.Where(x => x.ConfigID == cfg.ID && x.Environ == "DEV2" && !paramIDsExistingDEV2.Contains(x.ID));

                //4 add to Config
                foreach ( ConfigParamConsolidated x in paramsToAddPROD )
                    { cfg.ConfigParamPROD.Add(new ConfigParamPROD(x));}

                foreach ( ConfigParamConsolidated x in paramsToAddSTG1 )
                    { cfg.ConfigParamSTG1.Add(new ConfigParamSTG1(x)); }
                foreach ( ConfigParamConsolidated x in paramsToAddSTG2 )
                    { cfg.ConfigParamSTG2.Add(new ConfigParamSTG2(x)); }

                foreach ( ConfigParamConsolidated x in paramsToAddQA1 )
                    { cfg.ConfigParamQA1.Add(new ConfigParamQA1(x)); }
                foreach ( ConfigParamConsolidated x in paramsToAddQA2 )
                    { cfg.ConfigParamQA2.Add(new ConfigParamQA2(x)); }

                foreach ( ConfigParamConsolidated x in paramsToAddDEV1 )
                    { cfg.ConfigParamDEV1.Add(new ConfigParamDEV1(x)); }
                foreach ( ConfigParamConsolidated x in paramsToAddDEV2 )
                    { cfg.ConfigParamDEV2.Add(new ConfigParamDEV2(x)); }
                }

            return true;
            }

        private async Task<IEnumerable<ConfigParamConsolidated>> ConfigParamGetAll()
            {
            IEnumerable<ConfigParamConsolidated> ConfigParamsAll =
                await
                _db.configParamPROD
                .Where(cpX => _ConfigIDsAll.Contains(cpX.ConfigID))
                .Select(cp => new ConfigParamConsolidated { Environ = "PROD" , ID = cp.ID , ConfigID = cp.ConfigID , effDT = cp.effDT , trmDT = cp.trmDT , ParamDefinitionID = cp.ParamDefinitionID , isRefOnly = cp.isRefOnly , value = cp.value , valueUseageComments = cp.valueUseageComments })
                .Union(_db.configParamSTG1
                    .Where(cpX => _ConfigIDsAll.Contains(cpX.ConfigID))
                    .Select(cp => new ConfigParamConsolidated { Environ = "STG1" , ID = cp.ID , ConfigID = cp.ConfigID , effDT = cp.effDT , trmDT = cp.trmDT , ParamDefinitionID = cp.ParamDefinitionID , isRefOnly = cp.isRefOnly , value = cp.value , valueUseageComments = cp.valueUseageComments })
                    )
                .Union(_db.configParamSTG2
                    .Where(cpX => _ConfigIDsAll.Contains(cpX.ConfigID))
                    .Select(cp => new ConfigParamConsolidated { Environ = "STG2" , ID = cp.ID , ConfigID = cp.ConfigID , effDT = cp.effDT , trmDT = cp.trmDT , ParamDefinitionID = cp.ParamDefinitionID , isRefOnly = cp.isRefOnly , value = cp.value , valueUseageComments = cp.valueUseageComments })
                    )
                .Union(_db.configParamQA1
                    .Where(cpX => _ConfigIDsAll.Contains(cpX.ConfigID))
                    .Select(cp => new ConfigParamConsolidated { Environ = "QA1" , ID = cp.ID , ConfigID = cp.ConfigID , effDT = cp.effDT , trmDT = cp.trmDT , ParamDefinitionID = cp.ParamDefinitionID , isRefOnly = cp.isRefOnly , value = cp.value , valueUseageComments = cp.valueUseageComments })
                    )
                .Union(_db.configParamQA2
                    .Where(cpX => _ConfigIDsAll.Contains(cpX.ConfigID))
                    .Select(cp => new ConfigParamConsolidated { Environ = "QA2" , ID = cp.ID , ConfigID = cp.ConfigID , effDT = cp.effDT , trmDT = cp.trmDT , ParamDefinitionID = cp.ParamDefinitionID , isRefOnly = cp.isRefOnly , value = cp.value , valueUseageComments = cp.valueUseageComments })
                    )
                .Union(_db.configParamDEV1
                    .Where(cpX => _ConfigIDsAll.Contains(cpX.ConfigID))
                    .Select(cp => new ConfigParamConsolidated { Environ = "DEV1" , ID = cp.ID , ConfigID = cp.ConfigID , effDT = cp.effDT , trmDT = cp.trmDT , ParamDefinitionID = cp.ParamDefinitionID , isRefOnly = cp.isRefOnly , value = cp.value , valueUseageComments = cp.valueUseageComments })
                    )
                .Union(_db.configParamDEV2
                    .Where(cpX => _ConfigIDsAll.Contains(cpX.ConfigID))
                    .Select(cp => new ConfigParamConsolidated { Environ = "DEV2" , ID = cp.ID , ConfigID = cp.ConfigID , effDT = cp.effDT , trmDT = cp.trmDT , ParamDefinitionID = cp.ParamDefinitionID , isRefOnly = cp.isRefOnly , value = cp.value , valueUseageComments = cp.valueUseageComments })
                    )
                    .ToListAsync();

            return ConfigParamsAll;
            }


        private static List<Guid> GuidDotEmptyListOf()
            {return new List<Guid> { Guid.Empty };}

        private static List<Guid> EmptyListTGuid()
            {return Enumerable.Empty<Guid>().ToList();}

        private static List<int> EmptyListTint()
            { return Enumerable.Empty<int>().ToList(); }

        private void InitializeFromExisting( DROConfigFull _DROConfigFull )
            {
            this.config = _DROConfigFull.config;
            this.app = _DROConfigFull.app;
            this.executable = _DROConfigFull.executable;
            this.paramDefinition = _DROConfigFull.paramDefinition;
            this.paramVersion = _DROConfigFull.paramVersion;
            this.planLOB = _DROConfigFull.planLOB;
            }

        public void dbDispose()
            {
            _db.Dispose();
            }

        }
    }
