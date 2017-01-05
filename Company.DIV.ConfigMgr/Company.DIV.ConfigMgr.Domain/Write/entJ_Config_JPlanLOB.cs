using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JConfigJPlanLOB : IJConfigJPlanLOB, IEntityWrite
        {
        public JConfigJPlanLOB() { }

        public Guid ID { get; private set; }

        public Guid ConfigID { get; private set; }
        public Guid JPlanLOBID { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }