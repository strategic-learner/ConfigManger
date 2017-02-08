using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IConfigParamRead : IEntityRead, IConfigParamBase
        { }
    public interface IConfigParamWrite : IEntityWrite, IConfigParamBase
        { }
    public interface IConfigParamAudit : IEntityAudit, IConfigParamBase
        { }


    public interface IConfigParamBase
        {
        string Environ { get; }
        Guid ConfigID { get; }
        DateTime effDT { get; }
        DateTime trmDT { get; }
        Guid ParamDefinitionID { get; }
        bool isRefOnly { get; }
        string value { get; }
        string valueUseageComments { get; }
        }

    }