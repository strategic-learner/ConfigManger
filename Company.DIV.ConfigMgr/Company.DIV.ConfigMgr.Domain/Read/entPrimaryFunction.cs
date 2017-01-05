using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PrimaryFunction : IPrimaryFunction, IEntityRead
        {
        private PrimaryFunction() { }
        public PrimaryFunction( string user )
            {
            this.JExecutablePrimaryFunctions = new HashSet<JExecutablePrimaryFunction>();

            ID = new Guid();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        
		public Guid ID { get; private set; }
        
        [Required]
        [MaxLength(3)]
        public string abbr { get; private set; }

        [Required]
        [MaxLength(50)]
        public string description { get; private set; }


        #region NavigationProperties

        public ICollection<JExecutablePrimaryFunction> JExecutablePrimaryFunctions { get; private set; }

        #endregion


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
	}