using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class Plan : IPlan
        {
        public Plan() { }
        public Plan( string user )
            {
            this.JAppPlans = new HashSet<JAppPlan>();
            this.JConfigPlans = new HashSet<JConfigPlan>();
            this.JPlanLOB = new HashSet<JPlanLOB>();

            ID = new Guid();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
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


        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }

    }