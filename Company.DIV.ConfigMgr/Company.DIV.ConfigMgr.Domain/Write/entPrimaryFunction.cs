using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class PrimaryFunction : IPrimaryFunction, IEntityWrite
        {
        private PrimaryFunction() { }

        public Guid ID { get; private set; }
        public string abbr { get; private set; }
        public string description { get; private set; }

		public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
	}