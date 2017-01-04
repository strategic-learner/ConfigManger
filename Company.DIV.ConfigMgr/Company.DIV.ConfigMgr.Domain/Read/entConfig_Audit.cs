using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
	public class ConfigAudit : IConfig, IEntityAudit
        {
        private ConfigAudit() { }

        public int AuditID { get; private set;}
        public DateTime AuditDT { get; private set;}
        public byte AuditType { get; private set;}
        public string AuditSUserSName { get; private set;}


		public Guid ID_ { get; private set;}
        public int jobID { get; private set;}
        public Guid AppID { get; private set;}
        public Guid ParamVersionID { get; private set;}
        public bool Active { get; private set;}

        [MaxLength(25)]
        public string DescriptonShort { get; private set;}

        [MaxLength(100)]
        public string DescriptonFull { get; private set;}
        public DateTime effDT { get; private set;}
        public DateTime trmDT { get; private set;}

        public DateTime createDT_ { get; private set;}
        public string createUser_ { get; private set;}
        public DateTime updateDT_ { get; private set;}
        public string updateUser_ { get; private set;}
        }
    }