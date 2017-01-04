using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJExecutablePathServer : IEntityBase
        {
        Guid ExecutableID { get; }
        Guid PathServerID { get; }
        }
    }