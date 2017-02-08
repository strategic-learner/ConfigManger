using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JExecutablePathServer : EntityWrite, IJExecutablePathServerWrite
        {
        private JExecutablePathServer() { }

        
        public Guid ExecutableID { get; private set; }
        public Guid PathServerID { get; private set; }


        
        
        }
    }