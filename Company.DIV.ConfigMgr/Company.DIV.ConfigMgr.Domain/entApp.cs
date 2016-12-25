﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain
    {
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
        [MaxLength(3)]
        public string abbr { get; set; }

		[Required]
        [MaxLength(100)]
        public string descr { get; set; }


        #region Navigation Properties

        [Required]
		public ICollection<Plan> Plans  { get; set; }
        public ICollection<Config> Configs { get; set; }
        public ICollection<Executable> Executables { get; set; }

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

}
}