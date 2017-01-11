﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PathServer : EntityRead, IPathServer
        {
        private PathServer() { }
        public PathServer( MockUsers user )
            {
            this.JExecutablePathServers = new HashSet<JExecutablePathServer>();
            this.JPathServerPathShares = new HashSet<JPathServerPathShare>();

            ID = new Guid();
            updateDT = DateTime.Now;
            updateUser = user.defaultUser;
            }

        
		

        [Required]
        [Index("NDX_PKey" , 1 , IsUnique = true , IsClustered = false)]
        [StringLength(256)]
        public string server { get; private set; }

        [Index("NDX_PKey" , 2 , IsUnique = true , IsClustered = false)]
        [StringLength(256)]
        public string path { get; private set; }


        #region Navigation Properties

        public ICollection<JExecutablePathServer> JExecutablePathServers { get; private set; }
        public ICollection<JPathServerPathShare> JPathServerPathShares { get; private set; }

        #endregion


        
        

        
        }
    }