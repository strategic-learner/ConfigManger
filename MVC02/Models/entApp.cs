using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVC02.Users;

namespace MVC02.Models {
	public class App {
		public App() {
			this.Plans = new HashSet<Plan>();
            createDT = DateTime.Now;
            createUser = MockUsers.Mock1();
            updateDT = DateTime.Now;
            updateUser = MockUsers.Mock1();
            }

        [Key]
		public Guid ID { get; set; }

        /// <summary>
        /// value predefined by business
        /// </summary>
		[Required]
		public int ITIL { get; set; }

		[Required]
		public string abbr { get; set; }

		[Required]
		public string descr { get; set; }


        #region Navigation Properties

        [Required]
		public virtual ICollection<Plan> Plans  { get; set; }
        public virtual ICollection<Config> Configs { get; set; }
        public virtual ICollection<Executable> Executables { get; set; }

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