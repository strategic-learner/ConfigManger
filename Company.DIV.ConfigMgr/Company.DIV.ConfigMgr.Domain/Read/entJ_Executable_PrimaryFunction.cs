using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JExecutablePrimaryFunction : IJExecutablePrimaryFunction, IEntityRead
        {
        public JExecutablePrimaryFunction() { }
        public JExecutablePrimaryFunction( MockUsers user )
            {
            ID = new Guid();
            updateDT = DateTime.Now;
            updateUser = user.defaultUser;
            }

        public Guid ID { get; private set; }

        [Required]
        [Index("NDX_UniqueKey" , 1 , IsUnique = true , IsClustered = false)]
        public Guid ExecutableID { get; private set; }

        [Required]
        [Index("NDX_UniqueKey" , 2 , IsUnique = true , IsClustered = false)]
        public Guid PrimaryFunctionID { get; private set; }


        #region NavigationProperties

        public Executable Executable { get; private set; }
        public PrimaryFunction PrimaryFunction { get; private set; }

        #endregion


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }