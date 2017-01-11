using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ParamTypeAudit : EntityAudit, IParamType
        {
        private ParamTypeAudit() { }

        
        
        
        

        

        [MaxLength(15)]
        public string type { get; private set;}


        
        
        }
    }