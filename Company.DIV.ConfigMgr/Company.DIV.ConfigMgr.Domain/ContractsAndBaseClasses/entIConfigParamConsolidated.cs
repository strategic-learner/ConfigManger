using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// this object is the base JPlanLOB entity plus PlanAbbr & LOBAbbr
    /// </summary>
    public interface IConfigParamConsolidated: IConfigParamBase, IEntityRead, IEntityWrite
        {
        }
    }
