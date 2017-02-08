

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IAppRead : IEntityRead, IAppBase
        { }
    public interface IAppWrite : IEntityWrite, IAppBase
        { }
    public interface IAppAudit : IEntityAudit, IAppBase
        { }

    public interface IAppBase
        { 
        /// <summary>
        ///an external value; defined by the business
        /// </summary>
		int ITIL { get; }
        string abbr { get; }
        string description { get; }
    }
}