

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IPathShareRead : IEntityRead, IPathShareBase { }
    public interface IPathShareWrite : IEntityWrite, IPathShareBase { }
    public interface IPathShareAudit : IEntityAudit, IPathShareBase { }

    public interface IPathShareBase
        {
        string share { get; }
        string path { get; }
        }
    }