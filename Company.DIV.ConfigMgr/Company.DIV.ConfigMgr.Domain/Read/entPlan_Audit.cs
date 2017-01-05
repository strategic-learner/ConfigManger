using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PlanAudit : IPlan, IEntityAudit
        {
        public PlanAudit() { }

        public int AuditID { get; private set;}
        public DateTime AuditDT { get; private set;}
        public byte AuditType { get; private set;}
        public string AuditSUserSName { get; private set;}

        public Guid ID_ { get; private set;}

        [MaxLength(4)]
        public string abbr { get; private set;}

        [MaxLength(50)]
        public string descr { get; private set;}


        public DateTime updateDT_ { get; private set;}
        public string updateUser_ { get; private set;}
        }

    }