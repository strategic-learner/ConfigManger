using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJConfigJPlanLOB
        {
        Guid ConfigID { get; }
        Guid JPlanLOBID { get; }
        }
    }