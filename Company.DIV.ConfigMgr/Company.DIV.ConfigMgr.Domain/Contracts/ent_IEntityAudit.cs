using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Interface for all entities that read Audit tables
    /// </summary>
    public interface IEntityAudit
        {
        int AuditID { get; }
        DateTime AuditDT { get; }
        byte AuditType { get; }
        string AuditSUserSName { get; }


        Guid ID_ { get; }

        DateTime createDT_ { get; }
        string createUser_ { get; }

        DateTime updateDT_ { get; }
        string updateUser_ { get; }


        }
    }
