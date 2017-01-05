using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class Executable : IExecutable, IEntityWrite
        {
        private Executable() { }
        
		public Guid ID { get; private set; }
        public Guid ParamVersionID { get; private set; }
        public Guid AppID { get; private set; }
        public string nameWExtension { get; private set; }
        public string description { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
	}