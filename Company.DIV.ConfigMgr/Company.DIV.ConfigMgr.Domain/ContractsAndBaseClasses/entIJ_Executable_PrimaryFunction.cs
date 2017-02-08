using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IJExecutablePrimaryFunctionRead : IEntityRead, IJExecutablePrimaryFunctionBase { }
    public interface IJExecutablePrimaryFunctionWrite : IEntityWrite, IJExecutablePrimaryFunctionBase { }
    public interface IJExecutablePrimaryFunctionAudit : IEntityAudit, IJExecutablePrimaryFunctionBase { }

    public interface IJExecutablePrimaryFunctionBase
        {
        Guid ExecutableID { get; }
        Guid PrimaryFunctionID { get; }
        }
    }