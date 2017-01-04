

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IApp : IEntityBase
        { 

        /// <summary>
        ///an external value; defined by the business
        /// </summary>
		int ITIL { get; }
        string abbr { get; }
        string description { get; }

    }
}