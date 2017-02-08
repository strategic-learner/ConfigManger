using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class ParamVersion : EntityWrite, IParamVersionWrite
        {
        private ParamVersion() { }

        
        public float version { get; private set; }
        public string description { get; private set; }


        
        
        }
    }