using System.Collections.Generic;
using System.Linq;
using Company.DIV.ConfigMgr.Domain;

namespace Company.DIV.ConfigMgr.Domain 
    {
    //https://lostechies.com/jimmybogard/2008/05/21/entities-value-objects-aggregates-and-roots/
    public abstract class DAOConfigFull<TConfig/*, TParamVersion, TParamDefinition, TApp,   TJConfigPlan, TJConfigExecutable, TConfigParam*/>
        where TConfig : IConfig
        //where TParamVersion : IParamVersion
        //where TParamDefinition : IParamDefinition
        //where TApp : IApp
        //where TJConfigPlan : IJConfigPlan
        //where TJConfigExecutable : IJConfigExecutable
        //where TConfigParam : IConfigParam
        {
        //public virtual List<TConfig> configList { get; protected set; }
        public virtual IQueryable<TConfig> config { get; protected set; }
        //public virtual IQueryable<TParamVersion> paramVersion { get; protected set; }
        //public virtual IQueryable<TParamDefinition> paramDefinition { get; protected set; }  //+EagerLoad( ParamType.ID, ParamType.Type)
        //public virtual IQueryable<TApp> app { get; protected set; }
        //public virtual IQueryable<TJConfigPlan> jConfigPlan { get; protected set; }  //+EagerLoad( Plan.ID, Plan.Abbr).SoftFilter( Valid JAppPlan )
        //public virtual IQueryable<TJConfigExecutable> jConfigExecutable { get; protected set; }  //+EagerLoad( Executable.nameWExtension, Executable.description)

        //public virtual IQueryable<TConfigParam> configParamPROD { get; protected set; }
        //public virtual IQueryable<TConfigParam> configParamSTG1 { get; protected set; }
        //public virtual IQueryable<TConfigParam> configParamSTG2 { get; protected set; }
        //public virtual IQueryable<TConfigParam> configParamQA1 { get; protected set; }
        //public virtual IQueryable<TConfigParam> configParamQA2 { get; protected set; }
        //public virtual IQueryable<TConfigParam> configParamDEV1 { get; protected set; }
        //public virtual IQueryable<TConfigParam> configParamDEV2 { get; protected set; }


        //__Do Later__
        //IJConfigJPlanLOB   { get; }+EagerLoad( Plan.Abbr, LineOfBusiness.Abbr)
        }
    }
