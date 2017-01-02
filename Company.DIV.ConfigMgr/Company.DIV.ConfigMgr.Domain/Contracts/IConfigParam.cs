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
    public interface IConfigParam : IEntityRW
        {
         Guid ConfigID { get; }
         DateTime effDT { get; }
         DateTime trmDT { get; }
         Guid ParamDefinitionsID { get; }
         bool isRefOnly { get; }
         string value { get; }
         string valueUseageComments { get; }
        }





    }