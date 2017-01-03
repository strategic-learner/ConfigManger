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
    public class ParamDefinition : IParamDefinition
        {
        private ParamDefinition() { }
        public ParamDefinition( string user )
            {
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
        public ICollection<ConfigParamPROD> ConfigParamsPROD { get; private set; }
        public ICollection<ConfigParamSTG1> ConfigParamsSTG1 { get; private set; }
        public ICollection<ConfigParamSTG2> ConfigParamsSTG2 { get; private set; }
        public ICollection<ConfigParamQA1> ConfigParamsQA1 { get; private set; }
        public ICollection<ConfigParamQA2> ConfigParamsQA2 { get; private set; }
        public ICollection<ConfigParamDEV1> ConfigParamsDEV1 { get; private set; }
        public ICollection<ConfigParamDEV2> ConfigParamsDEV2 { get; private set; }
        
        #endregion


        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }