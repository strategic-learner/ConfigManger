

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface ILineOfBusiness : IEntityBase
        {
        string abbr { get; }
        string descr { get; }
        }
    }