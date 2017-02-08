using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JExecutablePathServerAudit : EntityAudit, IJExecutablePathServerAudit
        {
        private JExecutablePathServerAudit() { }

        
        
        
        


        
        public Guid ExecutableID { get; private set;}
        public Guid PathServerID { get; private set;}


        
        
        }
    }