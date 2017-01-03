﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public interface IJPathServerPathShare : IEntityRW
        {
        Guid PathServerID { get; }
        Guid PathShareID { get; }
        }
    }