﻿using System;

namespace Company.DIV.ConfigMgr.Domain.DTO
    {
    /// <summary>
    /// this object is the base JPlanLOB entity plus PlanAbbr & LOBAbbr
    /// </summary>
    public interface IDTOPlanLOB
        {
        Guid IDjPlanLOB { get; set; }
        string PlanAbbr { get; }
        string LobAbbr { get; set; }
        }
    }
