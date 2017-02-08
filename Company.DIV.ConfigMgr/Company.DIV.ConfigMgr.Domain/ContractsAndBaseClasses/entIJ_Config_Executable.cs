using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IJConfigExecutableRead : IEntityRead, IJConfigExecutableBase { }
    public interface IJConfigExecutableWrite : IEntityWrite, IJConfigExecutableBase { }
    public interface IJConfigExecutableAudit : IEntityAudit, IJConfigExecutableBase { }

    public interface IJConfigExecutableBase
        {
        Guid ConfigID { get; }
        Guid ExecutableID { get; }
        }
    }