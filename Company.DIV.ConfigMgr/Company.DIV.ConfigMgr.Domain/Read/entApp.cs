using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class App : IApp, IEntityRead
        {
        private App() { }
        public App( string user )
            {
			this.JAppPlans = new HashSet<JAppPlan>();
            this.Configs = new HashSet<Config>();
            this.Executables = new HashSet<Executable>();

            ID = new Guid();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        
		public Guid ID { get; private set; }

		[Required]
		public int ITIL { get; private set; }

		[Required]
        [MaxLength(3)]
        public string abbr { get; private set; }

		[Required]
        [MaxLength(100)]
        public string description { get; private set; }


        #region Navigation Properties

		public ICollection<JAppPlan> JAppPlans { get; private set; }
        public ICollection<Config> Configs { get; private set; }
        public ICollection<Executable> Executables { get; private set; }

        #endregion


        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
}