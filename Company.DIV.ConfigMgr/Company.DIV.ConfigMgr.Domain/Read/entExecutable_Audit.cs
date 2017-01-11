using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ExecutableAudit : EntityAudit, IExecutable
        {
        private ExecutableAudit() { }

        
        
        
        

        
        public Guid ParamVersionID { get; private set;}
        public Guid AppID { get; private set;}

        [MaxLength(256)]
        public string nameWExtension { get; private set;}

        [MaxLength(100)]
        public string description { get; private set;}


        
        
        }
	}