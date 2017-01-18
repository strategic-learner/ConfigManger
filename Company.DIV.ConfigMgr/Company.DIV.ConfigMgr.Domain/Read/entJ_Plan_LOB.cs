using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JPlanLOB : EntityRead, IJPlanLOB
        {
        private JPlanLOB() { }
        //public JPlanLOB( MockUsers user )
        //    {
        //    this.JConfigJPlanLOBs = new HashSet<JConfigJPlanLOB>();

        //    ID = new Guid();
        //    updateDT = DateTime.Now;
        //    updateUser = user.defaultUser;
        //    }

        

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


        
        

        
        }
    }