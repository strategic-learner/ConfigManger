using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class LineOfBusiness : ILineOfBusiness, IEntityWrite
        {
        private LineOfBusiness() { }

        public Guid ID { get; private set; }
        public string abbr { get; private set; }
        public string descr { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }