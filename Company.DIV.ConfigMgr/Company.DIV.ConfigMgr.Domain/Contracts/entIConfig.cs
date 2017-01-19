using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IConfig
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