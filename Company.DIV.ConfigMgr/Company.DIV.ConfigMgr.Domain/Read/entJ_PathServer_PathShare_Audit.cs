using System;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JPathServerPathShareAudit : EntityAudit, IJPathServerPathShare
        {
        private JPathServerPathShareAudit() { }

        
        
        
        

        
        public Guid PathServerID { get; private set;}
        public Guid PathShareID { get; private set;}


        
        
        }
    }