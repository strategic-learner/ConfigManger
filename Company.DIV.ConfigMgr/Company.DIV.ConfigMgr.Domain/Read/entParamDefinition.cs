using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ParamDefinition : IParamDefinition, IEntityRead
        {
        private ParamDefinition() { }
        public ParamDefinition( string user )
            {
            this.ConfigParamPROD = new HashSet<ConfigParamPROD>();
            this.ConfigParamSTG1 = new HashSet<ConfigParamSTG1>();
            this.ConfigParamSTG2 = new HashSet<ConfigParamSTG2>();
            this.ConfigParamQA1 = new HashSet<ConfigParamQA1>();
            this.ConfigParamQA2 = new HashSet<ConfigParamQA2>();
            this.ConfigParamDEV1 = new HashSet<ConfigParamDEV1>();
            this.ConfigParamDEV2 = new HashSet<ConfigParamDEV2>();

            ID = new Guid();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        
        public Guid ID { get; private set; }

        [Required]
        [Index("NDX_PKey" , 1 , IsUnique = true, IsClustered =false)] 
        public Guid ParamVersionID { get; private set; }

        [Required]
        [Index("NDX_PKey" , 2 , IsUnique = true , IsClustered = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParamSequence { get; private set; }
        
        [Required]
        public Guid ParamTypeID { get; private set; }  //data type for validations

        [Required]
        [MaxLength(50)]
        public string variableName { get; private set; }

        [Required]
        [MaxLength(500)]
        public string intendedUse { get; private set; } //Specify intended usage of the ConfigParam's value


        #region NavigationProperties

        public ParamVersion ParamVersion { get; private set; }
        public ParamType ParamType { get; private set; }
        public ICollection<ConfigParamPROD> ConfigParamPROD { get; private set; }
        public ICollection<ConfigParamSTG1> ConfigParamSTG1 { get; private set; }
        public ICollection<ConfigParamSTG2> ConfigParamSTG2 { get; private set; }
        public ICollection<ConfigParamQA1> ConfigParamQA1 { get; private set; }
        public ICollection<ConfigParamQA2> ConfigParamQA2 { get; private set; }
        public ICollection<ConfigParamDEV1> ConfigParamDEV1 { get; private set; }
        public ICollection<ConfigParamDEV2> ConfigParamDEV2 { get; private set; }

        #endregion


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }