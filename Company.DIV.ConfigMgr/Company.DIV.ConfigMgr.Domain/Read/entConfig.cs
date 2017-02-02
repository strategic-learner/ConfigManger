using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class Config : EntityRead, IConfig
        {
        private Config() { }
   //     public Config( MockUsers user ) 
			//{
   //         this.JConfigPlans = new HashSet<JConfigPlan>();
   //         this.JConfigJPlanLOBs = new HashSet<JConfigJPlanLOB>();
   //         this.JConfigExecutables = new HashSet<JConfigExecutable>();
   //         this.ConfigParamPROD = new HashSet<ConfigParamPROD>();
   //         this.ConfigParamSTG1 = new HashSet<ConfigParamSTG1>();
   //         this.ConfigParamSTG2 = new HashSet<ConfigParamSTG2>();
   //         this.ConfigParamQA1 = new HashSet<ConfigParamQA1>();
   //         this.ConfigParamQA2 = new HashSet<ConfigParamQA2>();
   //         this.ConfigParamDEV1 = new HashSet<ConfigParamDEV1>();
   //         this.ConfigParamDEV2 = new HashSet<ConfigParamDEV2>();
   //         effDT = DateTime.Now;
   //         trmDT = DataConstants.defaultEndDate;

   //         ID = new Guid();
   //         updateDT = DateTime.Now;
   //         updateUser = user.defaultUser;
   //         }


		

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
        public string DescriptionShort { get; private set; }

        [Required]
        [MaxLength(100)]
        public string DescriptionFull { get; private set; }

        [Required]
        public DateTime effDT { get; private set; }

        [Required]
        public DateTime trmDT { get; private set; }


        #region NavigationProperties

        //[Required]
        //public ICollection<JConfigPlan> JConfigPlans { get; set; }  //Depricate this in favor of a [Required] JConfigJPlanLOB
        public ICollection<JConfigJPlanLOB> JConfigJPlanLOBs { get; set; }
        public ICollection<JConfigExecutable> JConfigExecutables { get; set; }

        //public App App { get; private set; }  //Trying OneWay Nav
        //public ParamVersion ParamVersion { get; private set; }  //Trying OneWay Nav

        public ICollection<ConfigParamPROD> ConfigParamPROD { get; set; }
        public ICollection<ConfigParamSTG1> ConfigParamSTG1 { get; set; }
        public ICollection<ConfigParamSTG2> ConfigParamSTG2 { get; set; }
        public ICollection<ConfigParamQA1> ConfigParamQA1 { get; set; }
        public ICollection<ConfigParamQA2> ConfigParamQA2 { get; set; }
        public ICollection<ConfigParamDEV1> ConfigParamDEV1 { get; set; }
        public ICollection<ConfigParamDEV2> ConfigParamDEV2 { get; set; }

        #endregion
        }
    }