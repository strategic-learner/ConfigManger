using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJExecutablePrimaryFunction : IEntityBase
        {
        Guid ExecutableID { get; }
        Guid PrimaryFunctionID { get; }
        }
    }