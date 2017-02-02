using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// this object is the base JPlanLOB entity plus PlanAbbr & LOBAbbr
    /// </summary>
    public interface IDTOPlanLOB
        {
        Guid IDjPlanLOB { get; set; }
        //Guid IDplan { get; set; }
        //Guid IDlob { get; set; }
        string PlanAbbr { get; }
        string LobAbbr { get; set; }
        }
    }
