using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJAppPlan
        {
        Guid AppID { get; }
        Guid PlanID { get; }
        }
    }