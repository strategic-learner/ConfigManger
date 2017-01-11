using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PrimaryFunction : EntityRead, IPrimaryFunction
        {
        private PrimaryFunction() { }
        public PrimaryFunction( MockUsers user )
            {
            this.JExecutablePrimaryFunctions = new HashSet<JExecutablePrimaryFunction>();

            ID = new Guid();
            updateDT = DateTime.Now;
            updateUser = user.defaultUser;
            }

        
		
        
        [Required]
        [MaxLength(3)]
        public string abbr { get; private set; }

        [Required]
        [MaxLength(50)]
        public string description { get; private set; }


        #region NavigationProperties

        public ICollection<JExecutablePrimaryFunction> JExecutablePrimaryFunctions { get; private set; }

        #endregion


        
        

        
        }
	}