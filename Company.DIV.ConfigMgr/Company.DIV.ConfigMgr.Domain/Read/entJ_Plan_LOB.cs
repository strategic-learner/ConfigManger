using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JPlanLOB : IJPlanLOB, IEntityRead
        {
        public JPlanLOB() { }
        public JPlanLOB(string user)
            {
            this.JConfigJPlanLOBs = new HashSet<JConfigJPlanLOB>();

            ID = new Guid();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        public Guid ID { get; private set; }

        [Required]
        [Index("NDX_UniqueKey" , 1 , IsUnique = true , IsClustered = false)]
        public Guid planID { get; private set; }

        [Required]
        [Index("NDX_UniqueKey" , 2 , IsUnique = true , IsClustered = false)]
        public Guid LineOfBusinessID { get; private set; }


        #region NavigationProperties

        public Plan Plans { get; private set; }
        public LineOfBusiness LineOfBusiness { get; private set; }
        public ICollection<JConfigJPlanLOB> JConfigJPlanLOBs { get; private set; }
        
        #endregion


        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }