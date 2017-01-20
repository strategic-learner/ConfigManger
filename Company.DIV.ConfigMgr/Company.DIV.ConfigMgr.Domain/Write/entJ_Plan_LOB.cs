using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JPlanLOB : EntityWrite, IJPlanLOB
        {
        private JPlanLOB() { }

        
        public Guid PlanID { get; private set; }
        public Guid LineOfBusinessID { get; private set; }


        
        
        }
    }