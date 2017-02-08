using System.Collections.Generic;
using System.Linq;
using Company.DIV.ConfigMgr.Domain;

namespace Company.DIV.ConfigMgr.Domain.DTO
    {
    public abstract class DAOConfigFull<TConfig, TParamVersion, TParamDefinition, TApp, TExecutable >
        where TConfig : IConfigBase
        where TParamVersion : IParamVersionBase
        where TParamDefinition : IParamDefinitionBase
        where TApp : IAppBase
        where TExecutable : IExecutableBase
        {
        public virtual List<TConfig> config { get; protected set; }
        public virtual List<TParamVersion> paramVersion { get; protected set; }
        public virtual List<TParamDefinition> paramDefinition { get; protected set; } 
        public virtual List<TApp> app { get; protected set; }
        public virtual List<DTOPlanLOB> planLOB { get; protected set; }
        public virtual List<TExecutable> executable { get; protected set; }
        }
    }
