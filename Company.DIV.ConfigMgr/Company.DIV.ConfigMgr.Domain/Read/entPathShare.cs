using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class PathShare : EntityRead, IPathShare
        {
        private PathShare() { }
        //public PathShare( MockUsers user )
        //    {
        //    this.JPathServerPathShares = new HashSet<JPathServerPathShare>();

        //    ID = new Guid();
        //    updateDT = DateTime.Now;
        //    updateUser = user.defaultUser;
        //    }

        
		
        
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


        
        

        
        }
    }