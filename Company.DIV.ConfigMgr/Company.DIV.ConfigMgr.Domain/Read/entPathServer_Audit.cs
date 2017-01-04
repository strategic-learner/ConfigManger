using System;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
	public class PathServerAudit : IPathServer, IEntityAudit
        {
        private PathServerAudit() { }

        public int AuditID { get; private set;}
        public DateTime AuditDT { get; private set;}
        public byte AuditType { get; private set;}
        public string AuditSUserSName { get; private set;}


        public Guid ID_ { get; private set;}

        [StringLength(256)]
        public string server { get; private set;}

        [StringLength(256)]
        public string path { get; private set;}


        public DateTime createDT_ { get; private set;}
        public string createUser_ { get; private set;}
        public DateTime updateDT_ { get; private set;}
        public string updateUser_ { get; private set;}
        }
    }