using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Abstract class for all entities that read Audit tables
    /// Audit Tables are populated directly by the database via Triggers
    /// DbContext will have no Setters
    /// </summary>
    public abstract class EntityAudit : IEntityAudit
        {
        public int AuditID { get; protected set; }
        public DateTime AuditDT { get; protected set; }
        public byte AuditType { get; protected set; }
        public string AuditSUserSName { get; protected set; }

        public Guid? ID { get; protected set; }
        public DateTime? updateDT { get; protected set; }
        public string updateUser { get; protected set; }
        }
    }
