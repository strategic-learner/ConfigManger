using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class ParamType : IParamType, IEntityWrite
        {
        private ParamType() { }
        
		public Guid ID { get; private set; }
        public string type { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }