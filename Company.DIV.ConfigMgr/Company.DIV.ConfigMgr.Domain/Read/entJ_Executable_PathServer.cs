﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JExecutablePathServer : EntityRead, IJExecutablePathServer
        {
        private JExecutablePathServer() { }
        //public JExecutablePathServer( MockUsers user )
        //    {
        //    ID = new Guid();
        //    updateDT = DateTime.Now;
        //    updateUser = user.defaultUser;
        //    }

        

        [Required]
        [Index("NDX_UniqueKey" , 1 , IsUnique = true , IsClustered = false)]
        public Guid ExecutableID { get; private set; }

        [Required]
        [Index("NDX_UniqueKey" , 2 , IsUnique = true , IsClustered = false)]
        public Guid PathServerID { get; private set; }


        #region NavigationProperties

        //public Executable Executable { get; private set; }  //Trying OneWay Nav
        //public PathServer PathServer { get; private set; }  //Trying OneWay Nav

        #endregion






        }
    }