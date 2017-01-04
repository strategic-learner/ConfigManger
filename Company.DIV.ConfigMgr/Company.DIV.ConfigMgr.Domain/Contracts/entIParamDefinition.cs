using System;


namespace Company.DIV.ConfigMgr.Domain
    {
     public interface IParamDefinition : IEntityBase
        {
         Guid ParamVersionID { get; }
         int ParamSequence { get; }
         Guid ParamTypeID { get; }  //data type for validations
         string variableName { get; }
         string intendedUse { get; } //Specify intended usage of the ConfigParam's value
        }
    }