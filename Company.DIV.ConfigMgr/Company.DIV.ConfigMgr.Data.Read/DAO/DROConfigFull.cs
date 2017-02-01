﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

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
        List<Guid> _ConfigIDsAll;
        List<int> _JobIDsInput;
        List<int> _JobIDsAll;

        public DROConfigFull( ConfigMgrReadContext db , JobIDList jobIDList )
            {
            if ( db == null )
                {
                Debug.Print("input parameter db cannot be null");
                throw new NullReferenceException("input parameter db cannot be null");
                }
            if ( jobIDList == null )
                {
                Debug.Print("input parameter jobIDList cannot be null");
                throw new NullReferenceException("input parameter jobIDList cannot be null");
                }
            if ( jobIDList.IDs.Count<=0 )
                {
                Debug.Print("input parameter jobIDList.IDs.Count must be GT 0");
                throw new Exception("input parameter jobIDList.IDs.Count must be GT 0");
                }

            Debug.Print("__________ctor new start");
            db.Configuration.AutoDetectChangesEnabled = false;
            this._db = db as ConfigMgrReadContext;
            _JobIDsInput = jobIDList.IDs;
            Debug.Print("__________ctor new end");
            }

        public DROConfigFull( ConfigMgrReadContext db , JobIDList jobIDList , DROConfigFull _DROConfigFull )
            {
            if ( db == null )
                {
                Debug.Print("input parameter db cannot be null");
                throw new NullReferenceException("input parameter db cannot be null");
                }
            if ( jobIDList == null )
                {
                Debug.Print("input parameter jobIDList cannot be null");
                throw new NullReferenceException("input parameter jobIDList cannot be null");
                }
            if ( jobIDList.IDs.Count <= 0 )
                {
                Debug.Print("input parameter jobIDList.IDs.Count must be GT 0");
                throw new Exception("input parameter jobIDList.IDs.Count must be GT 0");
                }
            if ( _DROConfigFull == null )
                {
                Debug.Print("input parameter _DROConfigFull cannot be null");
                throw new NullReferenceException("input parameter _DROConfigFull cannot be null");
                }



            Debug.Print("__________ctor from existing start");
            db.Configuration.AutoDetectChangesEnabled = false;
            this._db = db as ConfigMgrReadContext;
            _JobIDsInput = jobIDList.IDs;
            InitializeFromExisting(_DROConfigFull);
            Debug.Print("__________ctor from existing end");
            }


        public async Task<bool> LoadAllAsync()
            {
            //Debug.Print("__________LoadAllAsync() start");
            //Debug.Print("__________bf await ConfigsLoadAllAsync()");
            await ConfigsLoadAllAsync();
            await AppsLoadAllAsync();
            await ParamVersionAndDefinitionsLoadAllAsync();
            await ExecutablesLoadAllAsync();

            //Debug.Print("__________bf Task[] LoadAll");

            //Cant do this using shared DbContext, not thread safe - would have to create new instance of DbContext per parallel Task.
            //parallel might be worth object size if using mini-fied IDbContext per load operation IConfigContext, IAppContext...
            //Task<bool>[] LoadAll = new Task<bool>[] // have to get used to this... The Tasks start firing here...
            //{
            //AppsLoadAllAsync()
            //,ParamVersionAndDefinitionsLoadAllAsync()
            //,ExecutablesLoadAllAsync()
            //};
            //await Task.WhenAll(LoadAll);  
            //Task.WaitAll(LoadAll);  // can't await this   //this may deadlock!? which might explain some things... (PluralSight: Getting Started with Asynchronous Programming in .NET  by Filip Ekberg)


            //Debug.Print("__________LoadAllAsync() END");
            return true;
            }


        private async Task<bool> ConfigsLoadAllAsync()
            {
            //Debug.Print("__________ConfigsLoadAllAsync() Start");
            List<int> existingJobIDs =
                this.config?
                .Select(x => x.jobID)
                .ToList()
                ??
                EmptyListTint();

            //Debug.Print("__________ConfigsLoadAllAsync() 1");
            List<int> JobIDsToAdd =
                _JobIDsInput.Except(existingJobIDs).ToList();

            //Debug.Print("__________ConfigsLoadAllAsync() 2");
            try
                {
                //Debug.Print("__________ConfigsLoadAllAsync() 3"); 
                //when calling this via "await DROConfigInstance.LoadAllAsync();" instead of via "DROConfigFull1.LoadAllAsync().Wait();" the MainReal() Method exits, and no exeptions are Caught!?
                var configsToAdd =
                await _db.config
                            .AsNoTracking()
                            .Where(cfg => JobIDsToAdd.Contains(cfg.jobID))
                            .ToListAsync();

                //Debug.Print("__________ConfigsLoadAllAsync() 4");
                this.config =
                    this.config?.AsEnumerable()
                    .Union(configsToAdd).ToList()
                    ??
                    configsToAdd;
                }
            catch ( Exception ex )
                {
                //Debug.Print("________________Source");
                //Debug.Print(ex.Source.ToString());
                //Debug.Print("________________Message");
                //Debug.Print(ex.Message.ToString());
                //Debug.Print("________________StackTrace");
                //Debug.Print(ex.StackTrace.ToString());
                //Debug.Print("________________InnerException");
                //Debug.Print(ex.InnerException.ToString());
                //Debug.Print("________________HResult");
                //Debug.Print(ex.HResult.ToString());
                //Debug.Print("________________Data");
                //Debug.Print(ex.Data.ToString());
                //Debug.Print("________________entireException");
                //Debug.Print(ex.ToString());
                }
            finally
                {
                }


            try
                {
                //Debug.Print("__________ConfigsLoadAllAsync() 5");
                _ConfigIDsAll = this.config.Select(c => c.ID).ToList();
                }
            catch ( Exception ex )
                {
                //Debug.Print("________________Source");
                //Debug.Print(ex.Source.ToString());
                //Debug.Print("________________Message");
                //Debug.Print(ex.Message.ToString());
                //Debug.Print("________________StackTrace");
                //Debug.Print(ex.StackTrace.ToString());
                //Debug.Print("________________InnerException");
                //Debug.Print(ex.InnerException.ToString());
                //Debug.Print("________________HResult");
                //Debug.Print(ex.HResult.ToString());
                //Debug.Print("________________Data");
                //Debug.Print(ex.Data.ToString());
                //Debug.Print("________________entireException");
                //Debug.Print(ex.ToString());
                }
            finally
                {
                }

            try
                {
                //Debug.Print("__________ConfigsLoadAllAsync() 6");
                _JobIDsAll = this.config.Select(c => c.jobID).ToList();
                }
            catch(Exception ex)
                {
                //Debug.Print("________________Source");
                //Debug.Print(ex.Source.ToString());
                //Debug.Print("________________Message");
                //Debug.Print(ex.Message.ToString());
                //Debug.Print("________________StackTrace");
                //Debug.Print(ex.StackTrace.ToString());
                //Debug.Print("________________InnerException");
                //Debug.Print(ex.InnerException.ToString());
                //Debug.Print("________________HResult");
                //Debug.Print(ex.HResult.ToString());
                //Debug.Print("________________Data");
                //Debug.Print(ex.Data.ToString());
                //Debug.Print("________________entireException");
                //Debug.Print(ex.ToString());
                }
            finally
                {
                }
            //Debug.Print("__________ConfigsLoadAllAsync() END");
            return true;
            }

        private async Task<bool> AppsLoadAllAsync()
            {
            //Debug.Print("__________AppsLoadAllAsync() Start");
            List<Guid> appIDsAll = 
                this.config.Select(c => c.AppID).Distinct().ToList();

            //Debug.Print("__________AppsLoadAllAsync() 1");
            List<Guid> appIDsExisting =
                this.app?.AsEnumerable().Select(x => x.ID)
                .Union(
                    EmptyListTGuid()
                    ).ToList()
                    ??
                    EmptyListTGuid();

            //Debug.Print("__________AppsLoadAllAsync() 2");
            List<Guid> appIDsToAdd = appIDsAll.Except(appIDsExisting).ToList();

            //Debug.Print("__________AppsLoadAllAsync() 3");
            var appsAll = await _db.app
                .AsNoTracking()
                .Where(x => appIDsToAdd.Contains(x.ID))
                .ToListAsync();

            //Debug.Print("__________AppsLoadAllAsync() 4");
            this.app =
                this.app?.AsEnumerable()
                .Union(appsAll).ToList()
                ??
                appsAll;

            //Debug.Print("__________AppsLoadAllAsync() END");
            return true;
            }

        private async Task<bool> ParamVersionAndDefinitionsLoadAllAsync()
            {
            //Debug.Print("__________ParamVersionAndDefinitionsLoadAllAsync() Start");
            List<Guid> paramVersionIDsAll = 
                this.config.Select(c => c.ParamVersionID).Distinct().ToList();

            //Debug.Print("__________ParamVersionAndDefinitionsLoadAllAsync() 1");
            List<Guid> paramVersionIDsExisting =
                this.paramVersion?
                .Select(x => x.ID)
                .Distinct()
                .ToList()
                ??
                EmptyListTGuid();

            //Debug.Print("__________ParamVersionAndDefinitionsLoadAllAsync() 2");
            List<Guid> paramVersionIDsToAdd =
                paramVersionIDsAll.Except(paramVersionIDsExisting).ToList();

            //Debug.Print("__________ParamVersionAndDefinitionsLoadAllAsync() 3");
            var paramVersionsToAdd =
                await _db.paramVersion
                            .AsNoTracking()
                            .Where(x => paramVersionIDsToAdd.Contains(x.ID))
                            .ToListAsync();

            //Debug.Print("__________ParamVersionAndDefinitionsLoadAllAsync() 4");
            this.paramVersion =
                this.paramVersion?.AsEnumerable()
                .Union(
                    paramVersionsToAdd
                    ).ToList()
                    ??
                    paramVersionsToAdd;

            //Debug.Print("__________ParamVersionAndDefinitionsLoadAllAsync() 5");
            var paramDefinitionsToAdd =
                await _db.paramDefinition
                .AsNoTracking()
                .Where(pd => paramVersionIDsToAdd.Contains(pd.ParamVersionID))
                .OrderBy(pd => pd.ParamVersionID)
                .ThenBy(pd => pd.ParamSequence)
                .ToListAsync();

            //Debug.Print("__________ParamVersionAndDefinitionsLoadAllAsync() 6");
            this.paramDefinition =
                this.paramDefinition?.AsEnumerable()
                .Union(
                    paramDefinitionsToAdd
                    ).ToList()
                    ??
                    paramDefinitionsToAdd;

            //Debug.Print("__________ParamVersionAndDefinitionsLoadAllAsync() END");
            return true;
            }

        private async Task<bool> ExecutablesLoadAllAsync()
            {
            //List<Guid> executableIDJoinsExisting =
            //    this.config
            //    .Where(c => c.JConfigExecutables != null)
            //    .SelectMany(c => c.JConfigExecutables.Select(jce => jce.ExecutableID))
            //    .Distinct()
            //    .ToList();
            Debug.Print("__________ExecutablesLoadAllAsync() start");
            List<Guid> executableIDsAll = new List<Guid>();
            List<Guid> executableIDsExisting = new List<Guid>();
            List<Guid> executableIDsToAdd = new List<Guid>();
            Debug.Print("__________ExecutablesLoadAllAsync() End fields");

            ///Attach the M2M NavProps
            try
                {
                Debug.Print("__________ExecutablesLoadAllAsync() var jConfigExecutableAll");
                var jConfigExecutableAll =
                    await _db.jConfigExecutable
                    .AsNoTracking()
                    .Where(x => _ConfigIDsAll.Contains(x.ConfigID))
                    .Distinct()
                    .ToListAsync();


                foreach ( Config cfg in this.config )
                    {
                    Debug.Print("__________ExecutablesLoadAllAsync() forEach Start");
                    List<Guid> jConfigExecutableIDsExisting =
                        cfg.JConfigExecutables?.Select(x => x.ID)
                        .Distinct()
                        .ToList()
                        ??
                        EmptyListTGuid();

                    Debug.Print("__________ExecutablesLoadAllAsync() forEach Mid");
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
                    Debug.Print("__________ExecutablesLoadAllAsync() forEach End");
                    }

                Debug.Print("__________ExecutablesLoadAllAsync() executableIDsAll");
                executableIDsAll =
                    jConfigExecutableAll
                    .Select(jcea => jcea.ExecutableID)
                    .ToList();

                //Debug.Print("__________ExecutablesLoadAllAsync() ");
                //if ( !executableIDsAll.Any() )
                //    { executableIDsAll = EmptyListTGuid(); }
                }
            catch ( Exception ex )
                {
                Debug.Print("__________ExecutablesLoadAllAsync() Catch 1");
                //Exception thrown: 'System.NotSupportedException' in EntityFramework.dll
                }
            finally
                {
                Debug.Print("__________ExecutablesLoadAllAsync() Finally 1");
                }


            Debug.Print("__________ExecutablesLoadAllAsync() executableIDsExisting");
            //Get the Executables
            executableIDsExisting =
                this.executable?.Select(e => e.ID)
                .Distinct()
                .ToList()
                ??
                EmptyListTGuid();

            Debug.Print("__________ExecutablesLoadAllAsync() executableIDsToAdd");
            executableIDsToAdd = 
                executableIDsAll.Except(executableIDsExisting).ToList();

            try
                {
                Debug.Print("__________ExecutablesLoadAllAsync() executablesToAdd");
                var executablesToAdd =
                    await _db.executable
                    .AsNoTracking()
                    .Where(e => executableIDsToAdd.Contains(e.ID))
                    .ToListAsync();

                Debug.Print("__________ExecutablesLoadAllAsync() this.executable");
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
                Debug.Print("__________ExecutablesLoadAllAsync() catch 2");
                }
            finally
                {
                Debug.Print("__________ExecutablesLoadAllAsync() finally 2");
                }

            return true;
            }


        //private Task PlansLoadAll()
        //    {

        //    }

        //private Task LineOfBusinessLoadAll()
        //    {

        //    }

        //private Task ConfigParamsLoadAll()
        //    {

        //    }

        //private Task ConfigParamsLoadAll<TConfigParam>() where TConfigParam : IConfigParam
        //    {
        //    //TConfigParam

        //    }


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
            this.configParamPROD = _DROConfigFull.configParamPROD;
            this.configParamSTG1 = _DROConfigFull.configParamSTG1;
            this.configParamSTG2 = _DROConfigFull.configParamSTG2;
            this.configParamQA1 = _DROConfigFull.configParamQA1;
            this.configParamQA2 = _DROConfigFull.configParamQA2;
            this.configParamDEV1 = _DROConfigFull.configParamDEV1;
            this.configParamDEV2 = _DROConfigFull.configParamDEV2;
            this.executable = _DROConfigFull.executable;
            this.lob = _DROConfigFull.lob;
            this.paramDefinition = _DROConfigFull.paramDefinition;
            this.paramVersion = _DROConfigFull.paramVersion;
            this.plan = _DROConfigFull.plan;
            }


        }
    }
