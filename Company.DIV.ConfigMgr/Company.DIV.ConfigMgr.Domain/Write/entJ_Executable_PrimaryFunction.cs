using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JExecutablePrimaryFunction : IJExecutablePrimaryFunction, IEntityWrite
        {
        public JExecutablePrimaryFunction() { }

        public Guid ID { get; private set; }
        public Guid ExecutableID { get; private set; }
        public Guid PrimaryFunctionID { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }