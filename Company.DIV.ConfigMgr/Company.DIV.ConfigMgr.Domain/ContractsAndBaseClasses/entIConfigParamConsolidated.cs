using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// this is a quasi-DTO.  Initially useful for creating Union query of all Environments for single ping to db
    /// </summary>
    public interface IConfigParamConsolidated: IConfigParamBase, IEntityRead, IEntityWrite
        {
        }
    }
