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
    /// <DomainNotes>
    /// This could have been an Enum, but for the ability to build App-independant Sql queries
    /// </DomainNotes>
	public interface IParamType : IEntityRW
        {
        string type { get; }

        }
    }