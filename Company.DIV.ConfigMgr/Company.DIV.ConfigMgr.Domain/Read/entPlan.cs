using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class Plan : EntityRead, IPlanRead
        {
        private Plan() { }
        //public Plan( MockUsers user ) 
        //    {
        //    this.JAppPlans = new HashSet<JAppPlan>();
        //    this.JConfigPlans = new HashSet<JConfigPlan>();
        //    this.JPlanLOB = new HashSet<JPlanLOB>();

        //    ID = new Guid();
        //    updateDT = DateTime.Now;
        //    updateUser = user.defaultUser;
        //    }

        
        


        [Required]
        [MaxLength(4)]
        public string abbr { get; private set; }

        [Required]
        [MaxLength(50)]
        public string descr { get; private set; }


        #region NavigationProperties

        public ICollection<JAppPlan> JAppPlans { get; private set; }
        public ICollection<JPlanLOB> JPlanLOB { get; private set; }

        #endregion


        
        

        
        }

    }