using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JConfigJPlanLOB : EntityRead, IJConfigJPlanLOBRead
        {
        private JConfigJPlanLOB() { }
        //public JConfigJPlanLOB( MockUsers user )
        //    {
        //    ID = new Guid();
        //    updateDT = DateTime.Now;
        //    updateUser = user.defaultUser;
        //    }

        

        [Required]
        [Index("NDX_UniqueKey" , 1 , IsUnique = true , IsClustered = false)]
        public Guid ConfigID { get; private set; }

        [Required]
        [Index("NDX_UniqueKey" , 2 , IsUnique = true , IsClustered = false)]
        public Guid JPlanLOBID { get; private set; }


        #region NavigationProperties

        //public Config Config { get; private set; }  //Trying OneWay Nav
        //public JPlanLOB JPlanLOB { get; private set; }  //Trying OneWay Nav

        #endregion






        }
    }