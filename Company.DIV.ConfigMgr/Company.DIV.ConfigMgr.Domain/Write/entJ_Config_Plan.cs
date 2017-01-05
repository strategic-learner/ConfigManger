using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JConfigPlan : IJConfigPlan, IEntityWrite
        {
        public JConfigPlan() { }

        public Guid ID { get; private set; }
        public Guid ConfigID { get; private set; }
        public Guid PlanID { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }