using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJExecutablePrimaryFunction
        {
        Guid ExecutableID { get; }
        Guid PrimaryFunctionID { get; }
        }
    }