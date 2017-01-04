﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JAppPlan : IJAppPlan, IEntityWrite
        {
        public JAppPlan() { }
        public Guid ID { get; private set; }
        public Guid AppID { get; private set; }
        public Guid PlanID { get; private set; }

        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }