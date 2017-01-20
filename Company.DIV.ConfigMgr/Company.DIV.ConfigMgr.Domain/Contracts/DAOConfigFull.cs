using System.Collections.Generic;
using System.Linq;
using Company.DIV.ConfigMgr.Domain;

namespace Company.DIV.ConfigMgr.Domain 
    {
    //https://lostechies.com/jimmybogard/2008/05/21/entities-value-objects-aggregates-and-roots/
    public abstract class DAOConfigFull<TConfig, TParamVersion, TParamDefinition, TApp, /*TJConfigJPlanLOB,*/ TPlan,TLineOfBusiness, /*TJConfigExecutable,*/ TExecutable, TConfigParam>
        where TConfig : IConfig
        where TParamVersion : IParamVersion
        where TParamDefinition : IParamDefinition
        where TApp : IApp
        //where TJConfigJPlanLOB : IJConfigJPlanLOB
        where TPlan : IPlan
        where TLineOfBusiness : ILineOfBusiness
        //where TJConfigExecutable : IJConfigExecutable
        where TExecutable : IExecutable
        where TConfigParam : IConfigParam
        {
        public virtual List<TConfig> config { get; protected set; }
        //public virtual List<TConfig> config { get; protected set; }

        public virtual List<TParamVersion> paramVersion { get; protected set; }
        public virtual List<TParamDefinition> paramDefinition { get; protected set; }  //+EagerLoad( ParamType.ID, ParamType.Type)
        public virtual List<TApp> app { get; protected set; }

        //public virtual List<IJConfigJPlanLOB> jConfigJPlanLOB { get; } //+EagerLoad( Plan.Abbr, LineOfBusiness.Abbr)
        public virtual List<TPlan> plan { get; protected set; }
        public virtual List<TLineOfBusiness> lob { get; protected set; }

        //public virtual List<TJConfigExecutable> jConfigExecutable { get; protected set; }  //+EagerLoad( Executable.nameWExtension, Executable.description)
        public virtual List<TExecutable> executable { get; protected set; }


        public virtual List<TConfigParam> configParamPROD { get; protected set; }
        public virtual List<TConfigParam> configParamSTG1 { get; protected set; }
        public virtual List<TConfigParam> configParamSTG2 { get; protected set; }
        public virtual List<TConfigParam> configParamQA1 { get; protected set; }
        public virtual List<TConfigParam> configParamQA2 { get; protected set; }
        public virtual List<TConfigParam> configParamDEV1 { get; protected set; }
        public virtual List<TConfigParam> configParamDEV2 { get; protected set; }


        }
    }
