using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class App : EntityRead, IApp
        {
        private App() { }

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
        }
}