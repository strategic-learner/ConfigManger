using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Abstract class for all entities that Read
    /// </summary>
    public abstract class EntityRead : IEntityRead
        {
        public Guid ID { get; protected set; }

        public DateTime updateDT { get; protected set; }
        public string updateUser { get; protected set; }

        public EntityStateDisconnected entityStateDisconnected { get; set; }
        }
    }
