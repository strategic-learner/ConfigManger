using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJConfigPlan
        {
        Guid ConfigID { get; }
        Guid PlanID { get; }
        }
    }