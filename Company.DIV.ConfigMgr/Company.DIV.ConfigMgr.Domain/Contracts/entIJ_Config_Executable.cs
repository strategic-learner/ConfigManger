using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IJConfigExecutable
        {
        Guid ConfigID { get; }
        Guid ExecutableID { get; }
        }
    }