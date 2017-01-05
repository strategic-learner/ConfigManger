using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class LineOfBusinessAudit : ILineOfBusiness, IEntityAudit
        {
        private LineOfBusinessAudit() { }

        public int AuditID { get; private set;}
        public DateTime AuditDT { get; private set;}
        public byte AuditType { get; private set;}
        public string AuditSUserSName { get; private set;}

        public Guid ID_ { get; private set;}

        [MaxLength(10)]
        public string abbr { get; private set;}

        [MaxLength(50)]
        public string descr { get; private set;}


        public DateTime updateDT_ { get; private set;}
        public string updateUser_ { get; private set;}
        }
    }