using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class PathServer : EntityWrite, IPathServer
        {
        private PathServer() { }

        
        public string server { get; private set; }
        public string path { get; private set; }


        
        
        }
    }