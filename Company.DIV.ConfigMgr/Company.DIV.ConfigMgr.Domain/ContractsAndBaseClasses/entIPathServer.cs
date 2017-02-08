

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IPathServerRead : IEntityRead, IPathServerBase { }
    public interface IPathServerWrite : IEntityWrite, IPathServerBase { }
    public interface IPathServerAudit : IEntityAudit, IPathServerBase { }

    public interface IPathServerBase
        {
        string server { get; }
        string path { get; }
        }
    }