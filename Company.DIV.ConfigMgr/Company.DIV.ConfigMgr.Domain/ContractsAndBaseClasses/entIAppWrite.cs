using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IAppWrite : IEntityWrite , IAppBase
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