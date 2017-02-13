using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ConfigAudit : EntityAudit, IConfigAudit
        {
        private ConfigAudit() { }
        public int jobID { get; private set;}
        public Guid AppID { get; private set;}
        public Guid ParamVersionID { get; private set;}
        public bool Active { get; private set;}

        [MaxLength(25)]
        public string DescriptionShort { get; private set;}

        [MaxLength(100)]
        public string DescriptionFull { get; private set;}
        public DateTime effDT { get; private set;}
        public DateTime trmDT { get; private set;}
        }
    }