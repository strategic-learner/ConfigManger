using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JExecutablePrimaryFunctionAudit : EntityAudit, IJExecutablePrimaryFunctionAudit
        {
        private JExecutablePrimaryFunctionAudit() { }

        
        
        
        

        
        public Guid ExecutableID { get; private set;}
        public Guid PrimaryFunctionID { get; private set;}


        
        
        }
    }