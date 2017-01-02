using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;


namespace Company.DIV.ConfigMgr.Domain
    {
	public interface IConfig : IEntityRW
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