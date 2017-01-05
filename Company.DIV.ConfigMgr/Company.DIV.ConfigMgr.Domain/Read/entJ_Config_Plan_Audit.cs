using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JConfigPlanAudit : IJConfigPlan, IEntityAudit
        {
        public JConfigPlanAudit() { }

        public int AuditID { get; private set;}
        public DateTime AuditDT { get; private set;}
        public byte AuditType { get; private set;}
        public string AuditSUserSName { get; private set;}

        public Guid ID_ { get; private set;}
        public Guid ConfigID { get; private set;}
        public Guid PlanID { get; private set;}


        public DateTime updateDT_ { get; private set;}
        public string updateUser_ { get; private set;}
        }
    }