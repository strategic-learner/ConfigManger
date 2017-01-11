using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Interface for all entities that Write
    /// </summary>
    public class EntityWrite
        {
        public Guid ID { get; private set; }

        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }
