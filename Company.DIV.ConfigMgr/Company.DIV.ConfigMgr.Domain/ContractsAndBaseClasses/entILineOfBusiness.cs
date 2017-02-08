

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface ILineOfBusinessRead : IEntityRead, ILineOfBusinessBase { }
    public interface ILineOfBusinessWrite : IEntityWrite, ILineOfBusinessBase { }
    public interface ILineOfBusinessAudit : IEntityAudit, ILineOfBusinessBase { }


    public interface ILineOfBusinessBase
        {
        string abbr { get; }
        string descr { get; }
        }
    }