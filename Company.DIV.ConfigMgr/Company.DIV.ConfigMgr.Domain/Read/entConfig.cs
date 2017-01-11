using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;


namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class Config : EntityRead, IConfig
        {
        private Config() { }
        public Config( MockUsers user ) 
			{
            this.JConfigPlans = new HashSet<JConfigPlan>();
            this.JConfigJPlanLOBs = new HashSet<JConfigJPlanLOB>();
            this.JConfigExecutables = new HashSet<JConfigExecutable>();
            this.ConfigParamPROD = new HashSet<ConfigParamPROD>();
            this.ConfigParamSTG1 = new HashSet<ConfigParamSTG1>();
            this.ConfigParamSTG2 = new HashSet<ConfigParamSTG2>();
            this.ConfigParamQA1 = new HashSet<ConfigParamQA1>();
            this.ConfigParamQA2 = new HashSet<ConfigParamQA2>();
            this.ConfigParamDEV1 = new HashSet<ConfigParamDEV1>();
            this.ConfigParamDEV2 = new HashSet<ConfigParamDEV2>();
            effDT = DateTime.Now;
            trmDT = DataConstants.defaultEndDate;

            ID = new Guid();
            updateDT = DateTime.Now;
            updateUser = user.defaultUser;
            }


		

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
        public ICollection<JConfigPlan> JConfigPlans { get; private set; }
        public ICollection<JConfigJPlanLOB> JConfigJPlanLOBs { get; private set; }
        public ICollection<JConfigExecutable> JConfigExecutables { get; private set; }

        public App App { get; private set; }
        public ParamVersion ParamVersion { get; private set; }

        public ICollection<ConfigParamPROD> ConfigParamPROD { get; private set; }
        public ICollection<ConfigParamSTG1> ConfigParamSTG1 { get; private set; }
        public ICollection<ConfigParamSTG2> ConfigParamSTG2 { get; private set; }
        public ICollection<ConfigParamQA1> ConfigParamQA1 { get; private set; }
        public ICollection<ConfigParamQA2> ConfigParamQA2 { get; private set; }
        public ICollection<ConfigParamDEV1> ConfigParamDEV1 { get; private set; }
        public ICollection<ConfigParamDEV2> ConfigParamDEV2 { get; private set; }

        #endregion


        
        

        
        }
    }