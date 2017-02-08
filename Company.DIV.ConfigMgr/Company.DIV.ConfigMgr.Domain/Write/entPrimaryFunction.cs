using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class PrimaryFunction : EntityWrite, IPrimaryFunctionWrite
        {
        private PrimaryFunction() { }

        
        public string abbr { get; private set; }
        public string description { get; private set; }

		
        
        }
	}