using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JExecutablePathServer : IJExecutablePathServer, IEntityWrite
        {
        public JExecutablePathServer() { }

        public Guid ID { get; private set; }
        public Guid ExecutableID { get; private set; }
        public Guid PathServerID { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }