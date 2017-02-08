using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PathServerAudit : EntityAudit, IPathServerAudit
        {
        private PathServerAudit() { }

        
        
        
        


        

        [StringLength(256)]
        public string server { get; private set;}

        [StringLength(256)]
        public string path { get; private set;}


        
        
        }
    }