using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class Executable : EntityWrite, IExecutable
        {
        private Executable() { }
        
		
        public Guid ParamVersionID { get; private set; }
        public Guid AppID { get; private set; }
        public string nameWExtension { get; private set; }
        public string description { get; private set; }


        
        
        }
	}