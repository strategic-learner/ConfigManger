using System.Collections.Generic;
using System.Linq;
using Company.DIV.ConfigMgr.Domain;

namespace Company.DIV.ConfigMgr.Domain.DTO
    {
    public abstract class DAOConfigFull<TConfig, TParamVersion, TParamDefinition, TApp, TExecutable, TConfigParam >
        where TConfig : IConfig
        where TParamVersion : IParamVersion
        where TParamDefinition : IParamDefinition
        where TApp : IAppBase
        where TExecutable : IExecutable
        where TConfigParam : IConfigParamBase
        {
        public virtual List<TConfig> config { get; protected set; }
        //public virtual List<TConfig> config { get; protected set; }

        public virtual List<TParamVersion> paramVersion { get; protected set; }
        public virtual List<TParamDefinition> paramDefinition { get; protected set; }  //+EagerLoad( ParamType.ID, ParamType.Type)
        public virtual List<TApp> app { get; protected set; }

        public virtual List<DTOPlanLOB> planLOB { get; protected set; }
        //public virtual List<TJConfigJPlanLOB> jConfigJPlanLOB { get; protected set; } //+EagerLoad( Plan.Abbr, LineOfBusiness.Abbr)
        //public virtual List<TPlan> plan { get; protected set; }
        //public virtual List<TLineOfBusiness> lob { get; protected set; }
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
