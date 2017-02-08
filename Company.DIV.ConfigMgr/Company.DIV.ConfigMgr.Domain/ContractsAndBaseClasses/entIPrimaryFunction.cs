

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IPrimaryFunctionRead : IEntityRead, IPrimaryFunctionBase { }
    public interface IPrimaryFunctionWrite : IEntityWrite, IPrimaryFunctionBase { }
    public interface IPrimaryFunctionAudit : IEntityAudit, IPrimaryFunctionBase { }

    public interface IPrimaryFunctionBase
        {
        string abbr { get; }
        string description { get; }
        }
	}