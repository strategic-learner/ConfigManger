using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJAppPlan : IEntityBase
        {
        Guid AppID { get; }
        Guid PlanID { get; }
        }
    }