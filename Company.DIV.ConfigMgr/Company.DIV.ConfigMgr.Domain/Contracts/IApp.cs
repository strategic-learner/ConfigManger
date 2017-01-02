using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IApp : IEntityRW
        { 

        /// <summary>
        /// value predefined by business
        /// </summary>
		int ITIL { get; }
        string abbr { get; }
        string description { get; }

    }
}