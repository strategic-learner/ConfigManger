using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class PathServer : IPathServer, IEntityWrite
        {
        private PathServer() { }

        public Guid ID { get; private set; }
        public string server { get; private set; }
        public string path { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }