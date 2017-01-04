using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJPathServerPathShare
        {
        Guid PathServerID { get; }
        Guid PathShareID { get; }
        }
    }