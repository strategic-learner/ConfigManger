using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Abstract class for all entities that Read
    /// </summary>
    public abstract class EntityRead : IEntityRead
        {
        public Guid ID { get; private set; }

        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; set; }
        }
    }
