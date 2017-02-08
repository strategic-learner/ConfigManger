using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IJAppPlanRead : IEntityRead, IJAppPlanBase { }
    public interface IJAppPlanWrite : IEntityWrite, IJAppPlanBase { }
    public interface IJAppPlanAudit : IEntityAudit, IJAppPlanBase { }
    public interface IJAppPlanBase
        {
        Guid AppID { get; }
        Guid PlanID { get; }
        }
    }