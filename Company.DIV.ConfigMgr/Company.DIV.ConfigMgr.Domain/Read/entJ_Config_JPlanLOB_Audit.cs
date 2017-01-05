﻿using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JConfigJPlanLOBAudit : IJConfigJPlanLOB, IEntityAudit
        {
        public JConfigJPlanLOBAudit() { }

        public int AuditID { get; private set;}
        public DateTime AuditDT { get; private set;}
        public byte AuditType { get; private set;}
        public string AuditSUserSName { get; private set;}

        public Guid ID_ { get; private set;}
        public Guid ConfigID { get; private set;}
        public Guid JPlanLOBID { get; private set;}


        public DateTime updateDT_ { get; private set;}
        public string updateUser_ { get; private set;}
        }
    }