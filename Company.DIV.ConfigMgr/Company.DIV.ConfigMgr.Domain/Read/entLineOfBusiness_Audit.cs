using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class LineOfBusinessAudit : EntityAudit, ILineOfBusiness
        {
        private LineOfBusinessAudit() { }

        
        
        
        

        

        [MaxLength(10)]
        public string abbr { get; private set;}

        [MaxLength(50)]
        public string descr { get; private set;}


        
        
        }
    }