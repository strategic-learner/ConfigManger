using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;


namespace Company.DIV.ConfigMgr.Domain.Read
    {
	public class Config : IConfig
		{
        private Config() { }
        public Config(string user)
			{
            effDT = DateTime.Now;
            trmDT = DataConstants.defaultEndDate;

            ID = new Guid();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }


        [Key]
		public Guid ID { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int jobID { get; private set; }

        [Required]
        public Guid AppID { get; private set; }

        [Required]
        public Guid ParamVersionID { get; private set; }
        
        [Required]
        public bool Active { get; private set; }

        [Required]
        [MinLength(8)]
        [MaxLength(25)]
        public string DescriptonShort { get; private set; }

        [Required]
        [MaxLength(100)]
        public string DescriptonFull { get; private set; }

        [Required]
        public DateTime effDT { get; private set; }

        [Required]
        public DateTime trmDT { get; private set; }


        #region NavigationProperties

        [Required]
        public ICollection<Plan> Plans { get; private set; }
        public ICollection<ConfigParamPROD> ConfigParamsPROD { get; private set; }
        public ICollection<ConfigParamSTG1> ConfigParamsSTG1 { get; private set; }
        public ICollection<ConfigParamSTG2> ConfigParamsSTG2 { get; private set; }
        public ICollection<ConfigParamQA1> ConfigParamsQA1 { get; private set; }
        public ICollection<ConfigParamQA2> ConfigParamsQA2 { get; private set; }
        public ICollection<ConfigParamDEV1> ConfigParamsDEV1 { get; private set; }
        public ICollection<ConfigParamDEV2> ConfigParamsDEV2 { get; private set; }
        public ICollection<Executable> Executables { get; private set; }
        public ICollection<JPlanLOB> JPlanLOBs { get; private set; }
        public App App { get; private set; }
        public ParamVersion ParamVersion { get; private set; }

        #endregion


        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }