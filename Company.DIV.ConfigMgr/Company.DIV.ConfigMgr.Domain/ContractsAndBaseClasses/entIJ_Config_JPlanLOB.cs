using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IJConfigJPlanLOBRead : IEntityRead, IJConfigJPlanLOBBase { }
    public interface IJConfigJPlanLOBWrite : IEntityWrite, IJConfigJPlanLOBBase { }
    public interface IJConfigJPlanLOBAudit : IEntityAudit, IJConfigJPlanLOBBase { }

    public interface IJConfigJPlanLOBBase
        {
        Guid ConfigID { get; }
        Guid JPlanLOBID { get; }
        }
    }