using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JConfigExecutableAudit : EntityAudit, IJConfigExecutableAudit
        {
        private JConfigExecutableAudit() { }
        
        
        
        
        
        
        
        public Guid ConfigID { get; private set;}
        public Guid ExecutableID { get; private set;}


        
        
        }
    }