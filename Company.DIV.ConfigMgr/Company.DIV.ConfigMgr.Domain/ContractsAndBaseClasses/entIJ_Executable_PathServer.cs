using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IJExecutablePathServerRead : IEntityRead, IJExecutablePathServerBase { }
    public interface IJExecutablePathServerWrite : IEntityWrite, IJExecutablePathServerBase { }
    public interface IJExecutablePathServerAudit : IEntityAudit, IJExecutablePathServerBase { }

    public interface IJExecutablePathServerBase
        {
        Guid ExecutableID { get; }
        Guid PathServerID { get; }
        }
    }