

namespace Company.DIV.ConfigMgr.Domain
    {
	public interface IPrimaryFunction : IEntityBase
		{
        string abbr { get; }
        string description { get; }
        }
	}