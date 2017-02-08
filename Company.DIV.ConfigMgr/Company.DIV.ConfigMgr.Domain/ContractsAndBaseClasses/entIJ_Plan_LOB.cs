using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IJPlanLOBRead : IEntityRead, IJPlanLOBBase { }
    public interface IJPlanLOBWrite : IEntityWrite, IJPlanLOBBase { }
    public interface IJPlanLOBAudit : IEntityAudit, IJPlanLOBBase { }



    public interface IJPlanLOBBase
        {
        Guid PlanID { get; }
        Guid LineOfBusinessID { get; }
        }
    }