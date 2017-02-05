using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IAppAudit : IEntityAudit, IAppBase
        {
        int AuditID { get; }
        DateTime AuditDT { get; }
        byte AuditType { get; }
        string AuditSUserSName { get; }
        Guid? ID { get; }
        DateTime? updateDT { get; }
        string updateUser { get; }

        int ITIL { get; }
        string abbr { get; }
        string description { get; }

    }
}