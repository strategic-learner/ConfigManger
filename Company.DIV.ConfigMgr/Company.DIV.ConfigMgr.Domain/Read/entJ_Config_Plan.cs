using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;


namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class JConfigPlan : EntityRead, IJConfigPlan
        {
        private JConfigPlan() { }
        public JConfigPlan( MockUsers user )
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
        public Guid PlanID { get; private set; }


        #region NavigationProperties

        public Config Config { get; private set; }
        public Plan Plan { get; private set; }
        
        #endregion


        
        

        
        }
    }