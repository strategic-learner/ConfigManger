

namespace Company.DIV.ConfigMgr.Domain
    {
	public interface IPathServer : IEntityBase
        {
        string server { get; }
        string path { get; }
        }
    }