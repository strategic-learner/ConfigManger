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

        public Plan( string user )
            {
            this.Apps = new HashSet<App>();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;

            }

        
        public Guid ID { get; set; }


        [Required]
        [MaxLength(4)]
        public string abbr { get; set; }

        [Required]
        [MaxLength(50)]
        public string descr { get; set; }


        #region NavigationProperties

        public ICollection<App> Apps { get; set; }
        public ICollection<Config> Configs { get; set; }
        public ICollection<JPlanLOB> JPlanLOB { get; set; }

        #endregion


        [Required]
        public DateTime createDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string createUser { get; set; }

        [Required]
        public DateTime updateDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string updateUser { get; set; }

        public Plan() { }

    }

}