using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJConfigJPlanLOB : IEntityBase
        {
        Guid ConfigID { get; }
        Guid JPlanLOBID { get; }
        }
    }