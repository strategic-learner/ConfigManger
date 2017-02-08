using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PathShareAudit : EntityAudit, IPathShareAudit
        {
        private PathShareAudit() { }

        
        
        
        
        
        
        
        [StringLength(256)]
        public string share { get; private set;}

        [StringLength(256)]
        public string path { get; private set;}


        
        
        }
    }