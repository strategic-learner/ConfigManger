using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DIV.ConfigMgr.Domain;

namespace Company.DIV.ConfigMgr.Data
    {
    public class AppDAO : IDAO<App>
        {

        public IQueryable<App> GetAll()
            {
            //IQueryable<App> iqApp;
            using ( ConfigMgrContext db = new ConfigMgrContext() )
                {
                //iqApp = db.app.AsNoTracking().ToList().AsQueryable();
                return db.app.AsNoTracking().ToList().AsQueryable();
                }
            }


        public App findByID( Guid? id )
            {
            using ( ConfigMgrContext db = new ConfigMgrContext() )
                {
                App app = db.app.Find(id);
                return app;
                }
            }

        public void Insert( App _app )
            {
            using ( ConfigMgrContext db = new ConfigMgrContext() )
                {
                db.app.Add(_app);
                db.SaveChanges();
                }
            }

        public void Update( App _app )
            {
            using ( ConfigMgrContext db = new ConfigMgrContext() )
                {
                db.app.Attach(_app);
                db.Entry(_app).State = EntityState.Modified;
                db.SaveChanges();
                }
            }

        public void Delete( Guid? id )
            {
            using ( ConfigMgrContext db = new ConfigMgrContext() )
                {
                var _app = db.app.Find(id);
                db.app.Remove(_app);
                db.SaveChanges();
                }
            }

        public void Dispose()
            {
            }

        }
    }
