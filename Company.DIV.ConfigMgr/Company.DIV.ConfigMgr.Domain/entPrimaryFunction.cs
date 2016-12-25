using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain
    {
	public class PrimaryFunction
		{
		public PrimaryFunction( string user )
            {
            //this.PROPERTY = new HashSet<ENTITYCLASS>();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        [Key]
		public Guid ID { get; set; }
        
        [Required]
        [MaxLength(3)]
        public string abbr { get; set; }

        [Required]
        [MaxLength(50)]
        public string description { get; set; }

        //[Required]
        //public  { get; set; }

        #region NavigationProperties

        public ICollection<Executable> Executables { get; set; }

        #endregion


        [Required]
		public DateTime createDT { get; set; }

		[Required]
        [MaxLength(20)]
        public string createUser { get; set; }

		[Required]
		public DateTime updateDT { get; set; }

		[Required]
        [MaxLength(20)]
        public string updateUser { get; set; }



        private PrimaryFunction() { }
        }
	}