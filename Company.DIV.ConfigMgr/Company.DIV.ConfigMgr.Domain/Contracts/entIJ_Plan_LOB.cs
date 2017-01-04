using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJPlanLOB
        {
        Guid planID { get; }
        Guid LineOfBusinessID { get; }
        }
    }