﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JPathServerPathShare : EntityRead, IJPathServerPathShareRead
        {
        private JPathServerPathShare() { }
        //public JPathServerPathShare( MockUsers user )
        //    {
        //    ID = new Guid();
        //    updateDT = DateTime.Now;
        //    updateUser = user.defaultUser;
        //    }

        

        [Required]
        [Index("NDX_UniqueKey" , 1 , IsUnique = true , IsClustered = false)]
        public Guid PathServerID { get; private set; }

        [Required]
        [Index("NDX_UniqueKey" , 2 , IsUnique = true , IsClustered = false)]
        public Guid PathShareID { get; private set; }


        #region NavigationProperties

        #endregion
        }
    }