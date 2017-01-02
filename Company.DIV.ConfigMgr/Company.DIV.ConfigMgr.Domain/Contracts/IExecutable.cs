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
	public interface IExecutable : IEntityRW
        {
         Guid ParamVersionID { get; }
         Guid AppID { get; }
         string nameWExtension { get; }
         string description { get; }
        }
	}