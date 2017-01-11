using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JPathServerPathShare : EntityWrite, IJPathServerPathShare
        {
        private JPathServerPathShare() { }

        
        public Guid PathServerID { get; private set; }
        public Guid PathShareID { get; private set; }


        
        
        }
    }