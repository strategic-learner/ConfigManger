using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Interface for all entities that Read
    /// </summary>
    public class EntityRead
        {
        public Guid ID { get; protected set; }

        public DateTime updateDT { get; protected set; }
        public string updateUser { get; protected set; }

        public EntityStateDisconnected entityStateDisconnected { get; set; }
        }
    }
