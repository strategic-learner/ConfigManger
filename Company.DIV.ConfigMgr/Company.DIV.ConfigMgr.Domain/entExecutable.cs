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
	public class Executable
		{
        public Executable( string user )
            {
            //this.PROPERTY = new HashSet<ENTITYCLASS>();
            createDT = DateTime.Now;
            createUser = user;
            updateDT = DateTime.Now;
            updateUser = user;
            }

        [Key]
		public Guid ID { get; set; }

        [Required] //wanted this to be Optional for early phase, but EF (or maybe just EF PowerTools?) was fighting me
        public Guid ParamVersionID { get; set; }

        [Required]
        [Index("NDX_AppID_NameWExtension" , 1 , IsUnique = true)] 
        public Guid AppID { get; set; }

        [Required]
        [Index("NDX_AppID_NameWExtension" , 2 , IsUnique = true)]
        [MaxLength(256)]
        public string nameWExtension { get; set; }

        [Required]
        [MaxLength(100)]
        public string description { get; set; }

        //[Required]
        //public  { get; set; }

        #region NavigationProperties
        public ICollection<PrimaryFunction> PrimaryFunctions { get; set; }
        public ICollection<PathServer> PathServers { get; set; }
        public ICollection<Config> Configs { get; set; }
        public ParamVersion ParamVersion { get; set; }
        public App App { get; set; }
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



        private Executable() { }
        }
	}