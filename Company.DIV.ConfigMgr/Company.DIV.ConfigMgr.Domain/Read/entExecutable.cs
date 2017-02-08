using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class Executable : EntityRead, IExecutableRead
        {
        private Executable() { }
        //public Executable( MockUsers user )
        //    {
        //    this.JConfigExecutables = new HashSet<JConfigExecutable>();
        //    this.JExecutablePathServers = new HashSet<JExecutablePathServer>();
        //    this.JExecutablePrimaryFunctions = new HashSet<JExecutablePrimaryFunction>();

        //    ID = new Guid();
        //    updateDT = DateTime.Now;
        //    updateUser = user.defaultUser;
        //    }

        
		

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
        public Guid? ParamVersionID { get; private set; }


        #region NavigationProperties

        public ICollection<JConfigExecutable> JConfigExecutables { get; private set; }
        public ICollection<JExecutablePathServer> JExecutablePathServers { get; private set; }
        public ICollection<JExecutablePrimaryFunction> JExecutablePrimaryFunctions { get; private set; }
        //public ParamVersion ParamVersion { get; private set; }  //Trying OneWay Nav
        //public App App { get; private set; }  //Trying OneWay Nav

        #endregion






        }
	}