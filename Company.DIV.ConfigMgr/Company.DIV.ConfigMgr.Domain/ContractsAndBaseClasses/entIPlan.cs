

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IPlanRead : IEntityRead, IPlanBase { }
    public interface IPlanWrite : IEntityWrite, IPlanBase { }
    public interface IPlanAudit : IEntityAudit, IPlanBase { }

    public interface IPlanBase
        {
        string abbr { get; }
        string descr { get; }
	}
}