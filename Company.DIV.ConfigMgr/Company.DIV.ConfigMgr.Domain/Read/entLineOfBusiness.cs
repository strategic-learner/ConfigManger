using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class LineOfBusiness : ILineOfBusiness, IEntityRead
        {
        private LineOfBusiness() { }
        public LineOfBusiness( MockUsers user )
            {
            this.JPlanLOB = new HashSet<JPlanLOB>();

            ID = new Guid();
            updateDT = DateTime.Now;
            updateUser = user.defaultUser;
            }

        
        public Guid ID { get; private set; }

        [Required]
        [MaxLength(10)]
        public string abbr { get; private set; }

        [Required]
        [MaxLength(50)]
        public string descr { get; private set; }


        #region NavigationProperties

        [Required]
        public ICollection<JPlanLOB> JPlanLOB { get; private set; }

        #endregion


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }