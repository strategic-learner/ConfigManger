using System;
using System.Linq;
using Company.DIV.ConfigMgr.Domain;
using Company.DIV.ConfigMgr.Domain.Read;
using Company.DIV.ConfigMgr.Data.Read;

namespace Company.DIV.ConfigMgr.Data.Read.DAO
    {
    public class AppRead : IDataRead<App>
        {

        public IQueryable<App> GetAll()
            {
            //IQueryable<App> iqApp;
            using ( ConfigMgrReadContext db = new ConfigMgrReadContext() )
                {
                //iqApp = db.app.AsNoTracking().ToList().AsQueryable();
                return db.app.AsNoTracking().ToList().AsQueryable();
                }
            }


        public App findByID( Guid? id )
            {
            using ( ConfigMgrReadContext db = new ConfigMgrReadContext() )
                {
                App app = db.app.Find(id);
                return app;
                }
            }

        }
    }
