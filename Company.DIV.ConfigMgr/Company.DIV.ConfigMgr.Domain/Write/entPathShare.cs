using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class PathShare : EntityWrite, IPathShareWrite
        {
        private PathShare() { }

        
        public string share { get; private set; }
        public string path { get; private set; }


        
        
        }
    }