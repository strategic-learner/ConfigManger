using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVC02.Users;

namespace MVC02.Models {
	public class Plan {

		public Plan() {
			this.Apps = new HashSet<App>();
            createDT = DateTime.Now;
            createUser = MockUsers.Mock1();
            updateDT = DateTime.Now;
            updateUser = MockUsers.Mock1();

            }

        [Key]
		public Guid ID { get; set; }


		[Required]
		public string abbr { get; set; }

		[Required]
		public string descr { get; set; }


        #region NavigationProperties
        public virtual ICollection<App> Apps { get; set; }
        public virtual ICollection<Config> Configs { get; set; }
        #endregion


        [Required]
		public DateTime createDT { get; set; }

		[Required]
		public string createUser { get; set; }

		[Required]
		public DateTime updateDT { get; set; }

		[Required]
		public string updateUser { get; set; }

		
	}
}