using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class Plan : IPlan, IEntityRead
        {
        public Plan() { }
        public Plan( MockUsers user ) 
            {
            this.JAppPlans = new HashSet<JAppPlan>();
            this.JConfigPlans = new HashSet<JConfigPlan>();
            this.JPlanLOB = new HashSet<JPlanLOB>();

            ID = new Guid();
            updateDT = DateTime.Now;
            updateUser = user.defaultUser;
            }

        
        public Guid ID { get; private set; }


        [Required]
        [MaxLength(4)]
        public string abbr { get; private set; }

        [Required]
        [MaxLength(50)]
        public string descr { get; private set; }


        #region NavigationProperties

        public ICollection<JAppPlan> JAppPlans { get; private set; }
        public ICollection<JConfigPlan> JConfigPlans { get; private set; }
        public ICollection<JPlanLOB> JPlanLOB { get; private set; }

        #endregion


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }

    }