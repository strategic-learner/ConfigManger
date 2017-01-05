using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JPlanLOB : IJPlanLOB, IEntityWrite
        {
        public JPlanLOB() { }

        public Guid ID { get; private set; }
        public Guid planID { get; private set; }
        public Guid LineOfBusinessID { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }