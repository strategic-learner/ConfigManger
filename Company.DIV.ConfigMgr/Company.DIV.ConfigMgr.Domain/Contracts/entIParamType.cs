

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <DomainNotes>
    /// This could have been an Enum, but for the ability to build App-independant Sql queries
    /// </DomainNotes>
	public interface IParamType : IEntityBase
        {
        string type { get; }

        }
    }