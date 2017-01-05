using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ExecutableAudit : IExecutable, IEntityAudit
        {
        private ExecutableAudit() { }

        public int AuditID { get; private set;}
        public DateTime AuditDT { get; private set;}
        public byte AuditType { get; private set;}
        public string AuditSUserSName { get; private set;}

        public Guid ID_ { get; private set;}
        public Guid ParamVersionID { get; private set;}
        public Guid AppID { get; private set;}

        [MaxLength(256)]
        public string nameWExtension { get; private set;}

        [MaxLength(100)]
        public string description { get; private set;}


        public DateTime updateDT_ { get; private set;}
        public string updateUser_ { get; private set;}
        }
	}