using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class ParamVersion : IParamVersion, IEntityWrite
        {
        private ParamVersion() { }

        public Guid ID { get; private set; }
        public float version { get; private set; }
        public string description { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }