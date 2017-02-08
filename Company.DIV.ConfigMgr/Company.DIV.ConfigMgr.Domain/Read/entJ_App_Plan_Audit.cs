using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JAppPlanAudit : EntityAudit, IJAppPlanAudit
        {
        private JAppPlanAudit() { }

        
        
        
        

        
        public Guid AppID { get; private set;}
        public Guid PlanID { get; private set;}


        
        
        }
    }