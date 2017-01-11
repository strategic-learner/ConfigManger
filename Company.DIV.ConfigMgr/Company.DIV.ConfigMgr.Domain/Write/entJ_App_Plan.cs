using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JAppPlan : EntityWrite, IJAppPlan
        {
        private JAppPlan() { }
        
        public Guid AppID { get; private set; }
        public Guid PlanID { get; private set; }


        
        
        }
    }