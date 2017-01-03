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
	public class Executable : IExecutable
		{
        private Executable() { }
        public Executable( string user )
            {
            this.JConfigExecutables = new HashSet<JConfigExecutable>();
            this.JExecutablePathServers = new HashSet<JExecutablePathServer>();
            this.JExecutablePrimaryFunctions = new HashSet<JExecutablePrimaryFunction>();

            ID = new Guid();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        
		public Guid ID { get; private set; }

        [Required] //wanted this to be Optional for early phase, but EF (or maybe just EF PowerTools?) was fighting me
        public Guid ParamVersionID { get; private set; }

        [Required]
        [Index("NDX_AppID_NameWExtension" , 1 , IsUnique = true , IsClustered = false)] 
        public Guid AppID { get; private set; }

        [Required]
        [Index("NDX_AppID_NameWExtension" , 2 , IsUnique = true , IsClustered = false)]
        [MaxLength(256)]
        public string nameWExtension { get; private set; }

        [Required]
        [MaxLength(100)]
        public string description { get; private set; }


        #region NavigationProperties

        public ICollection<JConfigExecutable> JConfigExecutables { get; private set; }
        public ICollection<JExecutablePathServer> JExecutablePathServers { get; private set; }
        public ICollection<JExecutablePrimaryFunction> JExecutablePrimaryFunctions { get; private set; }
        public ParamVersion ParamVersion { get; private set; }
        public App App { get; private set; }

        #endregion


        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
	}