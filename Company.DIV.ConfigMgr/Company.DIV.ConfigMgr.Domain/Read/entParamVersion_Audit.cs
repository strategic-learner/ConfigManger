using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ParamVersionAudit : EntityAudit, IParamVersion
        {
        private ParamVersionAudit() { }

        
        
        
        

        

        public float version { get; private set;}

        [MaxLength(100)]
        public string description { get; private set;}


        
        
        }
    }