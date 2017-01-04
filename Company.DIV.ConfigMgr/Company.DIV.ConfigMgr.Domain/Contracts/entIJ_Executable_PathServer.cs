using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJExecutablePathServer
        {
        Guid ExecutableID { get; }
        Guid PathServerID { get; }
        }
    }