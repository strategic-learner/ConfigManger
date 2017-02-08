using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ParamVersion : EntityRead, IParamVersionRead
        {
        private ParamVersion() { }
        //public ParamVersion( MockUsers user )
        //    {
        //    this.Executables = new HashSet<Executable>();
        //    this.Configs = new HashSet<Config>();
        //    this.ParamDefinitions = new HashSet<ParamDefinition>();

        //    ID = new Guid();
        //    updateDT = DateTime.Now;
        //    updateUser = user.defaultUser;
        //    }

        
		

        [Required]
        [Index("NDX_UNIQUE_version" , 1 , IsUnique = true , IsClustered = false)] 
        public float version { get; private set; }

        [Required]
        [MaxLength(100)]
        public string description { get; private set; }


        #region NavigationProperties

        public ICollection<Executable> Executables { get; private set; }
        public ICollection<Config> Configs { get; private set; }
        public ICollection<ParamDefinition> ParamDefinitions { get; private set; }

        #endregion
        }
    }