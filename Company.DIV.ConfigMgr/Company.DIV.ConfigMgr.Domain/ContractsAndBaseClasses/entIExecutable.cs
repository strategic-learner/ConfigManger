using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IExecutableRead : IEntityRead, IExecutableBase
        { }
    public interface IExecutableWrite : IEntityWrite, IExecutableBase
        { }
    public interface IExecutableAudit : IEntityAudit, IExecutableBase
        { }


    public interface IExecutableBase
        {
         Guid AppID { get; }
         string nameWExtension { get; }
         string description { get; }
        Guid? ParamVersionID { get; }
        }
    }