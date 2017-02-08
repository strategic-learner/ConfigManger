using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class Plan : EntityWrite, IPlanWrite
        {
        private Plan() { }

        
        public string abbr { get; private set; }
        public string descr { get; private set; }


        
        
        }

    }