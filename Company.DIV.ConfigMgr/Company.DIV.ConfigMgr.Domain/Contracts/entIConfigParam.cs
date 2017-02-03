using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IConfigParam
        {
        string Environ { get; }
        Guid ConfigID { get; }
         DateTime effDT { get; }
         DateTime trmDT { get; }
         Guid ParamDefinitionID { get; }
         bool isRefOnly { get; }
         string value { get; }
         string valueUseageComments { get; }
        }





    }