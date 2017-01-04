using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJPathServerPathShare : IEntityBase
        {
        Guid PathServerID { get; }
        Guid PathShareID { get; }
        }
    }