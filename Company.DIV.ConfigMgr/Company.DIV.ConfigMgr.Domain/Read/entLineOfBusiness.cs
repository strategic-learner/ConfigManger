using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class LineOfBusiness : EntityRead, ILineOfBusiness
        {
        private LineOfBusiness() { }
        public LineOfBusiness( MockUsers user )
            {
            this.JPlanLOB = new HashSet<JPlanLOB>();

            ID = new Guid();
            updateDT = DateTime.Now;
            updateUser = user.defaultUser;
            }

        
        

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


        
        

        
        }
    }