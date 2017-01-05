using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JConfigJPlanLOB : IJConfigJPlanLOB, IEntityRead
        {
        public JConfigJPlanLOB() { }
        public JConfigJPlanLOB( string user)
            {
            ID = new Guid();
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        public Guid ID { get; private set; }

        [Required]
        [Index("NDX_UniqueKey" , 1 , IsUnique = true , IsClustered = false)]
        public Guid ConfigID { get; private set; }

        [Required]
        [Index("NDX_UniqueKey" , 2 , IsUnique = true , IsClustered = false)]
        public Guid JPlanLOBID { get; private set; }


        #region NavigationProperties

        public Config Config { get; private set; }
        public JPlanLOB JPlanLOB { get; private set; }

        #endregion


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }