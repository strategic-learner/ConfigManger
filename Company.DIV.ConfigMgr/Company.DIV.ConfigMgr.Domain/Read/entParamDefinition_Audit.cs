using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ParamDefinitionAudit : EntityAudit, IParamDefinitionAudit
        {
        private ParamDefinitionAudit() { }

        
        
        
        

        
        public Guid ParamVersionID { get; private set;}

        public int ParamSequence { get; private set;}
        public Guid ParamTypeID { get; private set;}

        [MaxLength(50)]
        public string variableName { get; private set;}

        [MaxLength(500)]
        public string intendedUse { get; private set;}


        
        
        }
    }