using System;
using Company.DIV.ConfigMgr.Users;


namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class App : EntityWrite, IAppBase
        {
        private App() { }
        //public App( /*Read.App don't think this will come direct from Read.App, but rather from a ViewModel */ read, MockUsers user )
        //    {
        //    this.ID= read.ID;
        //    this.ITIL = read.ITIL;
        //    this.abbr = read.abbr;
        //    this.description = read.description;
        //    this.updateDT = DateTime.Now;
        //    this.updateUser = user.defaultUser;
        //    }

        public int ITIL { get; private set; }

        public string abbr { get; private set; }

        public string description { get; private set; }

        }
    }