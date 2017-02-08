using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IJPathServerPathShareRead : IEntityRead, IJPathServerPathShareBase { }
    public interface IJPathServerPathShareWrite : IEntityWrite, IJPathServerPathShareBase { }
    public interface IJPathServerPathShareAudit : IEntityAudit, IJPathServerPathShareBase { }

    public interface IJPathServerPathShareBase
        {
        Guid PathServerID { get; }
        Guid PathShareID { get; }
        }
    }