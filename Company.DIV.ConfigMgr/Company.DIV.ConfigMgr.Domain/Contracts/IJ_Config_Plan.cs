using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public interface IJConfigPlan : IEntityRW
        {
        Guid ConfigID { get; }
        Guid PlanID { get; }
        }
    }