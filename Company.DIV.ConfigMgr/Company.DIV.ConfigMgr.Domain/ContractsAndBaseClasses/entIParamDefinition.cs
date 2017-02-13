using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IParamDefinitionRead : IEntityRead, IParamDefinitionBase { }
    public interface IParamDefinitionWrite : IEntityWrite, IParamDefinitionBase { }
    public interface IParamDefinitionAudit : IEntityAudit, IParamDefinitionBase { }


    public interface IParamDefinitionBase
        {
         Guid ParamVersionID { get; }
         int ParamSequence { get; }
        ///data type for validations
        Guid ParamTypeID { get; }  
         string variableName { get; }
        ///Specify intended usage of the ConfigParam's value
        string intendedUse { get; } 
        }
    }