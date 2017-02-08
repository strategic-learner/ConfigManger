using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JConfigJPlanLOBAudit : EntityAudit, IJConfigJPlanLOBAudit
        {
        private JConfigJPlanLOBAudit() { }

        
        
        
        

        
        public Guid ConfigID { get; private set;}
        public Guid JPlanLOBID { get; private set;}


        
        
        }
    }