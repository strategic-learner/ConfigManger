using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JAppPlanAudit : EntityAudit, IJAppPlan
        {
        private JAppPlanAudit() { }

        
        
        
        

        
        public Guid AppID { get; private set;}
        public Guid PlanID { get; private set;}


        
        
        }
    }