using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PathServer : IPathServer, IEntityRead
        {
        private PathServer() { }
        public PathServer( string user )
            {
            this.JExecutablePathServers = new HashSet<JExecutablePathServer>();
            this.JPathServerPathShares = new HashSet<JPathServerPathShare>();

            ID = new Guid();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        
		public Guid ID { get; private set; }

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


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }