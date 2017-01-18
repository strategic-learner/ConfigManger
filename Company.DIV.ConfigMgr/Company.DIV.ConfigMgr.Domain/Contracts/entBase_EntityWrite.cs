using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Interface for all entities that Write
    /// </summary>
    public abstract class EntityWrite
        {
        public Guid ID { get; protected set; }

        public DateTime updateDT { get; protected set; }
        public string updateUser { get; protected set; }
        }
    }
