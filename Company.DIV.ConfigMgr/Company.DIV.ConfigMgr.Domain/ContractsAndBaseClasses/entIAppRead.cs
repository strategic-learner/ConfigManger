using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IAppRead : IEntityRead, IAppBase
        {
        Guid ID { get; }
        DateTime updateDT { get; }
        string updateUser { get; }
        EntityStateDisconnected entityStateDisconnected { get; }

        int ITIL { get; }
        string abbr { get; }
        string description { get; }

    }
}