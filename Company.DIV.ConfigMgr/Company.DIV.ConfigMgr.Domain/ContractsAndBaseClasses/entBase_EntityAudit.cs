using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Abstract class for all entities that read Audit tables
    /// </summary>
    public abstract class EntityAudit : IEntityAudit
        {
        public int AuditID { get; private set; }
        public DateTime AuditDT { get; private set; }
        public byte AuditType { get; private set; }
        public string AuditSUserSName { get; private set; }


        public Guid? ID { get; private set; }

        public DateTime? updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }
