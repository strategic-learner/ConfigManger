using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JConfigJPlanLOB : EntityWrite, IJConfigJPlanLOBWrite
        {
        private JConfigJPlanLOB() { }

        

        public Guid ConfigID { get; private set; }
        public Guid JPlanLOBID { get; private set; }


        
        
        }
    }