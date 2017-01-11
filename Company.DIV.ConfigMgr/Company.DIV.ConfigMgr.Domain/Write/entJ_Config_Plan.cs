using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JConfigPlan : EntityWrite, IJConfigPlan
        {
        private JConfigPlan() { }

        
        public Guid ConfigID { get; private set; }
        public Guid PlanID { get; private set; }


        
        
        }
    }