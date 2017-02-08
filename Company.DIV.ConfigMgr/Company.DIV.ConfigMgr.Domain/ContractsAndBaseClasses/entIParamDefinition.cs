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
         Guid ParamTypeID { get; }  //data type for validations
         string variableName { get; }
         string intendedUse { get; } //Specify intended usage of the ConfigParam's value
        }
    }