using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IConfigRead : IEntityRead, IConfigBase
        { }
    public interface IConfigWrite : IEntityWrite, IConfigBase
        { }
    public interface IConfigAudit : IEntityAudit, IConfigBase
        { }
    public interface IConfigBase
		{
         int jobID { get;  }
         Guid AppID { get; }
         Guid ParamVersionID { get; }
         bool Active { get; }
         string DescriptionShort { get; }
         string DescriptionFull { get; }
         DateTime effDT { get; }
         DateTime trmDT { get; }

        }
    }