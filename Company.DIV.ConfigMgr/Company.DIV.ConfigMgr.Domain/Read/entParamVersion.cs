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
	public class ParamVersion : IParamVersion
		{
        private ParamVersion() { }
        public ParamVersion(string user)
            {
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

        //[Required]
        //public  { get; private set; }

        #region NavigationProperties
        public ICollection<Executable> Executables { get; private set; }
        public ICollection<Config> Configs { get; private set; }
        public ICollection<ParamDefinition> ParamDefinitions { get; private set; }
        #endregion


        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }