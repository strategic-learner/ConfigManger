using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JConfigPlanAudit : EntityAudit, IJConfigPlan
        {
        private JConfigPlanAudit() { }

        
        
        
        

        
        public Guid ConfigID { get; private set;}
        public Guid PlanID { get; private set;}


        
        
        }
    }