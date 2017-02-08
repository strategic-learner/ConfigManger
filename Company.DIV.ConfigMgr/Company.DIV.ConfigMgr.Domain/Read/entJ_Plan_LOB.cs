using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JPlanLOB : EntityRead, IJPlanLOBRead
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
        public Guid PlanID { get; private set; }

        [Required]
        [Index("NDX_UniqueKey" , 2 , IsUnique = true , IsClustered = false)]
        public Guid LineOfBusinessID { get; private set; }


        #region NavigationProperties

        //public Plan Plans { get; private set; }  //Trying OneWay Nav
        //public LineOfBusiness LineOfBusiness { get; private set; }  //Trying OneWay Nav
        public ICollection<JConfigJPlanLOB> JConfigJPlanLOBs { get; private set; }

        #endregion


        
        

        
        }
    }