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
        public ICollection<Plan> Plans { get; set; }
        public ICollection<ConfigParamPROD> ConfigParamsPROD { get; set; }
        public ICollection<ConfigParamSTG1> ConfigParamsSTG1 { get; set; }
        public ICollection<ConfigParamSTG2> ConfigParamsSTG2 { get; set; }
        public ICollection<ConfigParamQA1> ConfigParamsQA1 { get; set; }
        public ICollection<ConfigParamQA2> ConfigParamsQA2 { get; set; }
        public ICollection<ConfigParamDEV1> ConfigParamsDEV1 { get; set; }
        public ICollection<ConfigParamDEV2> ConfigParamsDEV2 { get; set; }
        public ICollection<Executable> Executables { get; set; }
        public ICollection<JPlanLOB> JPlanLOBs { get; set; }
        public App App { get; set; }
        public ParamVersion ParamVersion { get; set; }

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