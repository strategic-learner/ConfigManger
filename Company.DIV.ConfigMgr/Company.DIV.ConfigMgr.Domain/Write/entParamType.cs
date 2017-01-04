using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
	public class ParamType : IParamType, IEntityWrite
        {
        private ParamType() { }
        
		public Guid ID { get; private set; }
        public string type { get; private set; }

        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }