using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Interface for all entities Read and Write
    /// </summary>
    public interface IEntityBase
        {
        Guid ID { get; }

        DateTime createDT { get; }
        string createUser { get; }

        DateTime updateDT { get; }
        string updateUser { get; }
        }
    }
