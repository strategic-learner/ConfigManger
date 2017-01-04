

namespace Company.DIV.ConfigMgr.Domain
    {
	public interface IParamVersion : IEntityBase
        {
        float version { get; }
        string description { get; }

        }
    }