using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PrimaryFunctionAudit : IPrimaryFunction, IEntityAudit 
        {
        private PrimaryFunctionAudit() { }

        public int AuditID { get; private set;}
        public DateTime AuditDT { get; private set;}
        public byte AuditType { get; private set;}
        public string AuditSUserSName { get; private set;}

        public Guid ID_ { get; private set;}

        [MaxLength(3)]
        public string abbr { get; private set;}

        [MaxLength(50)]
        public string description { get; private set;}


        public DateTime updateDT_ { get; private set;}
        public string updateUser_ { get; private set;}
        }
	}