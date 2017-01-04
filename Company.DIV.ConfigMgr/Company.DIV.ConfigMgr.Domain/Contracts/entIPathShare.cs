

namespace Company.DIV.ConfigMgr.Domain
    {
	public interface IPathShare : IEntityBase
        {
        string share { get; }
        string path { get; }
        }
    }