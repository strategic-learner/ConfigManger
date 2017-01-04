

namespace Company.DIV.ConfigMgr.Domain
    {
	public interface IPlan : IEntityBase
        {
        string abbr { get; }
        string descr { get; }
	}
}