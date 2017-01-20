using System.Collections.Generic;
using System.Linq;
using Company.DIV.ConfigMgr.Domain;

namespace Company.DIV.ConfigMgr.Domain 
    {
    //https://lostechies.com/jimmybogard/2008/05/21/entities-value-objects-aggregates-and-roots/
    public abstract class DAOConfigFull<TConfig, TParamVersion, TParamDefinition, TApp,   TJConfigPlan, TJConfigExecutable, TConfigParam>
        where TConfig : IConfig
        where TParamVersion : IParamVersion
        where TParamDefinition : IParamDefinition
        where TApp : IApp
        where TJConfigPlan : IJConfigPlan
        where TJConfigExecutable : IJConfigExecutable
        where TConfigParam : IConfigParam
        {
        public virtual List<TConfig> config { get; protected set; }
        //public virtual List<TConfig> config { get; protected set; }

        public virtual List<TParamVersion> paramVersion { get; protected set; }
        public virtual List<TParamDefinition> paramDefinition { get; protected set; }  //+EagerLoad( ParamType.ID, ParamType.Type)
        public virtual List<TApp> app { get; protected set; }

        //public virtual List<TJConfigPlan> jConfigPlan { get; protected set; }  //Depricate in favor of jConfigJPlanLOB
        public virtual List<IJConfigJPlanLOB> jConfigJPlanLOB { get; } //+EagerLoad( Plan.Abbr, LineOfBusiness.Abbr)

        public virtual List<TJConfigExecutable> jConfigExecutable { get; protected set; }  //+EagerLoad( Executable.nameWExtension, Executable.description)

        public virtual List<TConfigParam> configParamPROD { get; protected set; }
        public virtual List<TConfigParam> configParamSTG1 { get; protected set; }
        public virtual List<TConfigParam> configParamSTG2 { get; protected set; }
        public virtual List<TConfigParam> configParamQA1 { get; protected set; }
        public virtual List<TConfigParam> configParamQA2 { get; protected set; }
        public virtual List<TConfigParam> configParamDEV1 { get; protected set; }
        public virtual List<TConfigParam> configParamDEV2 { get; protected set; }


        }
    }
