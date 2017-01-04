using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Interface for all entities that Read
    /// </summary>
    public interface IEntityRead
        {
        Guid ID { get; }

        DateTime createDT { get; }
        string createUser { get; }

        DateTime updateDT { get; }
        string updateUser { get; }

        EntityStateDisconnected entityStateDisconnected { get; }
        }
    }
