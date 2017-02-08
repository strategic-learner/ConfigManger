using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class LineOfBusiness : EntityWrite, ILineOfBusinessWrite
        {
        private LineOfBusiness() { }

        
        public string abbr { get; private set; }
        public string descr { get; private set; }


        
        
        }
    }