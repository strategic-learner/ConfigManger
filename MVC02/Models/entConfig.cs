using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVC02.Users;
using static MVC02.AppConstants.AppConstants;

namespace MVC02.Models
	{
	public class Config
		{
		public Config(string user)
			{
            //this.PROPERTY = new HashSet<ENTITYCLASS>();

            effDT = DateTime.Now;
            trmDT = defaultEndDate();

            createDT = DateTime.Now;
            createUser = user;
            updateDT = DateTime.Now;
            updateUser = user;
            }


        [Key]
		public Guid ID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int jobID { get; private set; }

        [Required]
        public Guid AppID { get; set; }

        [Required]
        public Guid ParamVersionID { get; set; }
        
        [Required]
        public bool Active { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(25)]
        public string DescriptonShort { get; set; }

        [Required]
        [MaxLength(100)]
        public string DescriptonFull { get; set; }

        [Required]
        public DateTime effDT { get; set; }

        [Required]
        public DateTime trmDT { get; set; }


        #region NavigationProperties

        [Required]
        public virtual ICollection<Plan> Plans { get; set; }
        public virtual ICollection<ConfigParam> ConfigParams { get; set; }
        public virtual ICollection<Executable> Executables { get; set; }
        public virtual ICollection<JPlanLOB> JPlanLOBs { get; set; }
        public virtual App App { get; set; }
        public virtual ParamVersion ParamVersion { get; set; }

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


        private Config() { }

        }
    }