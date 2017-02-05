using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    //TODO: add same versions for all the other Entity classes...
    public interface IConfigParamAudit : IEntityAudit , IConfigParamBase
        {
        int AuditID { get; }
        DateTime AuditDT { get; }
        byte AuditType { get; }
        string AuditSUserSName { get; }
        Guid? ID { get; }
        DateTime? updateDT { get; }
        string updateUser { get; }



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
