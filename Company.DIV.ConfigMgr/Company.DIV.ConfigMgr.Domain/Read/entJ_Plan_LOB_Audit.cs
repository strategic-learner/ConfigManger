using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JPlanLOBAudit : IJPlanLOB, IEntityAudit
        {
        public JPlanLOBAudit() { }

        public int AuditID { get; private set;}
        public DateTime AuditDT { get; private set;}
        public byte AuditType { get; private set;}
        public string AuditSUserSName { get; private set;}


        public Guid ID_ { get; private set;}
        public Guid planID { get; private set;}
        public Guid LineOfBusinessID { get; private set;}

        public DateTime createDT_ { get; private set;}
        public string createUser_ { get; private set;}
        public DateTime updateDT_ { get; private set;}
        public string updateUser_ { get; private set;}
        }
    }