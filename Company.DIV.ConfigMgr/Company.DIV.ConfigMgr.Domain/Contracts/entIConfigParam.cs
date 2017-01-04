using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IConfigParam : IEntityBase
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