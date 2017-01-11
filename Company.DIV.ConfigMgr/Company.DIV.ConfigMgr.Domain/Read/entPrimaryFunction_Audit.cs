using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PrimaryFunctionAudit : EntityAudit, IPrimaryFunction 
        {
        private PrimaryFunctionAudit() { }

        
        
        
        

        

        [MaxLength(3)]
        public string abbr { get; private set;}

        [MaxLength(50)]
        public string description { get; private set;}


        
        
        }
	}