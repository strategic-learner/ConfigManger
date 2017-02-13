using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ParamDefinition : EntityRead, IParamDefinitionRead
        {
        private ParamDefinition() { }
        //public ParamDefinition( MockUsers user )
        //    {
        //    this.ConfigParamPROD = new HashSet<ConfigParamPROD>();
        //    this.ConfigParamSTG1 = new HashSet<ConfigParamSTG1>();
        //    this.ConfigParamSTG2 = new HashSet<ConfigParamSTG2>();
        //    this.ConfigParamQA1 = new HashSet<ConfigParamQA1>();
        //    this.ConfigParamQA2 = new HashSet<ConfigParamQA2>();
        //    this.ConfigParamDEV1 = new HashSet<ConfigParamDEV1>();
        //    this.ConfigParamDEV2 = new HashSet<ConfigParamDEV2>();

        //    ID = new Guid();
        //    updateDT = DateTime.Now;
        //    updateUser = user.defaultUser;
        //    }


        [Required]
        [Index("NDX_UNIQUE_ParamVersionID_ParamSequence" , 1 , IsUnique = true, IsClustered =false)] 
        public Guid ParamVersionID { get; private set; }

        [Required]
        [Index("NDX_UNIQUE_ParamVersionID_ParamSequence" , 2 , IsUnique = true , IsClustered = false)]
        public int ParamSequence { get; private set; }

        ///data type for validations
        [Required]
        public Guid ParamTypeID { get; private set; }  

        [Required]
        [MaxLength(50)]
        public string variableName { get; private set; }

        ///Specify intended usage of the ConfigParam's value
        [Required]
        [MaxLength(500)]
        public string intendedUse { get; private set; } 


        #region NavigationProperties

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