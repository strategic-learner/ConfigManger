using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJPlanLOB : IEntityBase
        {
        Guid planID { get; }
        Guid LineOfBusinessID { get; }
        }
    }