using System;

namespace Company.DIV.ConfigMgr.Domain
    {
	public interface IConfig
		{
         int jobID { get;  }
         Guid AppID { get; }
         Guid ParamVersionID { get; }
         bool Active { get; }
         string DescriptonShort { get; }
         string DescriptonFull { get; }
         DateTime effDT { get; }
         DateTime trmDT { get; }

        }
    }