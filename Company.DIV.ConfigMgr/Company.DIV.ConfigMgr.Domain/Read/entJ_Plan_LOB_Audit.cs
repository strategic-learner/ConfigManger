using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JPlanLOBAudit : EntityAudit, IJPlanLOB
        {
        private JPlanLOBAudit() { }

        
        
        
        


        
        public Guid planID { get; private set;}
        public Guid LineOfBusinessID { get; private set;}


        
        
        }
    }