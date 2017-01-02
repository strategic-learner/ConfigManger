using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public interface IApp { }


    public class App : IApp
        {
		public App() {
            ID = new Guid();
			this.Plans = new HashSet<Plan>();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
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
        public string description { get; set; }


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