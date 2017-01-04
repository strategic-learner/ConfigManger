using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJConfigPlan : IEntityBase
        {
        Guid ConfigID { get; }
        Guid PlanID { get; }
        }
    }