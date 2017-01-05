using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class PathShare : IPathShare, IEntityWrite
        {
        private PathShare() { }

        public Guid ID { get; private set; }
        public string share { get; private set; }
        public string path { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }