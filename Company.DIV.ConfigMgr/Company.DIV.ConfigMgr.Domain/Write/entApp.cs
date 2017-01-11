using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class App : EntityWrite, IApp
        {
        private App() { }

		

		public int ITIL { get; private set; }

        public string abbr { get; private set; }

        public string description { get; private set; }


        
        
        }
}