using System;

namespace Company.DIV.ConfigMgr.Domain.DTO
    {
    /// <summary>
    /// base JPlanLOB entity plus PlanAbbr & LOBAbbr
    /// </summary>
    public class DTOPlanLOB : IDTOPlanLOB
        {
        public Guid IDjPlanLOB { get; set; }
        public string PlanAbbr { get; set; }
        public string LobAbbr { get; set; }
        }
    }
