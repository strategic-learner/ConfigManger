using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public interface IJAppPlan : IEntityRW
        {
        Guid AppID { get; }
        Guid PlanID { get; }
        }
    }