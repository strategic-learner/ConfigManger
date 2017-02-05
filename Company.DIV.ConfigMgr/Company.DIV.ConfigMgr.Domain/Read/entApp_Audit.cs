using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class AppAudit : EntityAudit, IAppBase
        {
        private AppAudit() { }

        
        
        


        

		public int ITIL { get; private set;}

        [MaxLength(3)]
        public string abbr { get; private set;}

        [MaxLength(100)]
        public string description { get; private set;}


        
        

        }
}