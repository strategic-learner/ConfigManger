﻿using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JPlanLOBAudit : EntityAudit, IJPlanLOBAudit
        {
        private JPlanLOBAudit() { }

        
        
        
        


        
        public Guid PlanID { get; private set;}
        public Guid LineOfBusinessID { get; private set;}


        
        
        }
    }