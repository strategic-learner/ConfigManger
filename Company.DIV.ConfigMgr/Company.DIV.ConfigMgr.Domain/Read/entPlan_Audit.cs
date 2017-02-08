using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PlanAudit : EntityAudit, IPlanAudit
        {
        private PlanAudit() { }

        
        
        
        

        

        [MaxLength(4)]
        public string abbr { get; private set;}

        [MaxLength(50)]
        public string descr { get; private set;}


        
        
        }

    }