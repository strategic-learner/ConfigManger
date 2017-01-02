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
     public interface ParamDefinition : IEntityRW
        {
         Guid ParamVersionID { get; }
         int ParamSequence { get; }
         Guid ParamTypeID { get; }  //data type for validations
         string variableName { get; }
         string intendedUse { get; } //Specify intended usage of the ConfigParam's value
        }
    }