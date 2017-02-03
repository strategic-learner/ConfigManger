using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// this object is the base JPlanLOB entity plus PlanAbbr & LOBAbbr
    /// </summary>
    public interface IDTOConfigParam
        {
        string Environ { get; }
        Guid ID { get; }
        Guid ConfigID { get; }

        DateTime effDT { get; }

        DateTime trmDT { get; }

        Guid ParamDefinitionID { get; }

        bool isRefOnly { get; }

        string value { get; }

        string valueUseageComments { get; }

        }
    }
