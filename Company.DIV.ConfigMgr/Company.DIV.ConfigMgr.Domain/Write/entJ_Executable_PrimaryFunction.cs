using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JExecutablePrimaryFunction : EntityWrite, IJExecutablePrimaryFunction
        {
        private JExecutablePrimaryFunction() { }

        
        public Guid ExecutableID { get; private set; }
        public Guid PrimaryFunctionID { get; private set; }


        
        
        }
    }