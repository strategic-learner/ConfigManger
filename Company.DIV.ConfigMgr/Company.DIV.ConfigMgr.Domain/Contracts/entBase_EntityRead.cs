using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Interface for all entities that Read
    /// </summary>
    public abstract class EntityRead
        {
        public Guid ID { get; private set; }

        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; set; }
        }
    }
