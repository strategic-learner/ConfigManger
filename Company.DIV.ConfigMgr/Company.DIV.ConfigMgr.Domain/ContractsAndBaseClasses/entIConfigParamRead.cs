using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    //TODO: add same versions for all the other Entity classes...
    public interface IConfigParamRead : IEntityRead, IConfigParamBase
        {
        Guid ID { get; }
        DateTime updateDT { get; }
        string updateUser { get; }
        EntityStateDisconnected entityStateDisconnected { get; }


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
