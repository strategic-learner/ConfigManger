

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IParamTypeRead : IEntityRead, IParamTypeBase { }
    public interface IParamTypeWrite : IEntityWrite, IParamTypeBase { }
    public interface IParamTypeAudit : IEntityAudit, IParamTypeBase { }

    /// <DomainNotes>
    /// This could have been an Enum, but prefer to allow the building of Sql queries independant of this app
    /// </DomainNotes>
	public interface IParamTypeBase
        {
        string type { get; }

        }
    }