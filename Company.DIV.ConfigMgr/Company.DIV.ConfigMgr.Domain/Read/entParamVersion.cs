using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ParamVersion : IParamVersion, IEntityRead
        {
        private ParamVersion() { }
        public ParamVersion(string user)
            {
            this.Executables = new HashSet<Executable>();
            this.Configs = new HashSet<Config>();
            this.ParamDefinitions = new HashSet<ParamDefinition>();

            ID = new Guid();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        
		public Guid ID { get; private set; }

        [Required]
        [Index("NDX_PKey" , 1 , IsUnique = true , IsClustered = false)] 
        public float version { get; private set; }

        [Required]
        [MaxLength(100)]
        public string description { get; private set; }


        #region NavigationProperties

        public ICollection<Executable> Executables { get; private set; }
        public ICollection<Config> Configs { get; private set; }
        public ICollection<ParamDefinition> ParamDefinitions { get; private set; }

        #endregion


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }