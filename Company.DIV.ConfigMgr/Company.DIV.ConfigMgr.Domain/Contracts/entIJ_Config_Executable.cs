using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJConfigExecutable : IEntityBase
        {
        Guid ConfigID { get; }
        Guid ExecutableID { get; }
        }
    }