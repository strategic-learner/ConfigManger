using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PathShare : IPathShare, IEntityRead
        {
        private PathShare() { }
        public PathShare( string user )
            {
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
        public string share { get; private set; }

        [Index("NDX_PKey" , 2 , IsUnique = true , IsClustered = false)]
        [StringLength(256)]
        public string path { get; private set; }


        #region Navigation Properties

        public ICollection<JPathServerPathShare> JPathServerPathShares { get; private set; }

        #endregion


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }