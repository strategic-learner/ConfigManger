using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class PrimaryFunction : EntityWrite, IPrimaryFunction
        {
        private PrimaryFunction() { }

        
        public string abbr { get; private set; }
        public string description { get; private set; }

		
        
        }
	}