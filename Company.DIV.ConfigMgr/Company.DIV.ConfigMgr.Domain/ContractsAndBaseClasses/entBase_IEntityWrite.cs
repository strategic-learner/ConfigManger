using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Interface for all entities that Write
    /// </summary>
    public interface IEntityWrite
        {
        Guid ID { get; }

        DateTime updateDT { get; }
        string updateUser { get; }
        EntityStateDisconnected entityStateDisconnected { get; }
        }
    }
