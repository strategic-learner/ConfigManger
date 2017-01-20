using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJPlanLOB
        {
        Guid PlanID { get; }
        Guid LineOfBusinessID { get; }
        }
    }