﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JConfigExecutable : EntityRead, IJConfigExecutable
        {
        private JConfigExecutable() { }
        public JConfigExecutable( MockUsers user )
            {
            ID = new Guid();
            updateDT = DateTime.Now;
            updateUser = user.defaultUser;
            }

        

        [Required]
        [Index("NDX_UniqueKey" , 1 , IsUnique = true , IsClustered = false)]
        public Guid ConfigID { get; private set; }

        [Required]
        [Index("NDX_UniqueKey" , 2 , IsUnique = true , IsClustered = false)]
        public Guid ExecutableID { get; private set; }


        #region NavigationProperties

        public Config Config { get; private set; }
        public Executable Executable { get; private set; }

        #endregion


        
        

        
        }
    }