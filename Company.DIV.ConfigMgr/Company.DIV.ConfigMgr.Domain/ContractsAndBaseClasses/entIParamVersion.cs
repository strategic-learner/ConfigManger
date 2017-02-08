

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IParamVersionRead : IEntityRead, IParamVersionBase { }
    public interface IParamVersionWrite : IEntityWrite, IParamVersionBase { }
    public interface IParamVersionAudit : IEntityAudit, IParamVersionBase { }

    public interface IParamVersionBase
        {
        float version { get; }
        string description { get; }

        }
    }