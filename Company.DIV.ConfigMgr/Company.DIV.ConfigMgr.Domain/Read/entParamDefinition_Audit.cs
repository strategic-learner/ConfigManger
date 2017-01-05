using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ParamDefinitionAudit : IParamDefinition, IEntityAudit
        {
        private ParamDefinitionAudit() { }

        public int AuditID { get; private set;}
        public DateTime AuditDT { get; private set;}
        public byte AuditType { get; private set;}
        public string AuditSUserSName { get; private set;}

        public Guid ID_ { get; private set;}
        public Guid ParamVersionID { get; private set;}

        public int ParamSequence { get; private set;}
        public Guid ParamTypeID { get; private set;}

        [MaxLength(50)]
        public string variableName { get; private set;}

        [MaxLength(500)]
        public string intendedUse { get; private set;}


        public DateTime updateDT_ { get; private set;}
        public string updateUser_ { get; private set;}
        }
    }