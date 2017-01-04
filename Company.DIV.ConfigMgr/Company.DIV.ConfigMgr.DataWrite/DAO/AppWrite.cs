using System;
using System.Data.Entity;
using Company.DIV.ConfigMgr.Domain;
using Company.DIV.ConfigMgr.Domain.Write;
using Company.DIV.ConfigMgr.Data.Write;

namespace Company.DIV.ConfigMgr.Data.Write.DAO
    {
    public class AppWrite : IDataWrite<App>
        {
        
        public void Insert( App _app )
            {
            using ( ConfigMgrWriteContext db = new ConfigMgrWriteContext() )
                {
                db.app.Add(_app);
                db.SaveChanges();
                }
            }

        public void Update( App _app )
            {
            using ( ConfigMgrWriteContext db = new ConfigMgrWriteContext() )
                {
                db.app.Attach(_app);
                db.Entry(_app).State = EntityState.Modified;
                db.SaveChanges();
                }
            }

        public void Delete( Guid? id )
            {
            using ( ConfigMgrWriteContext db = new ConfigMgrWriteContext() )
                {
                var _app = db.app.Find(id);
                db.app.Remove(_app);
                db.SaveChanges();
                }
            }

        }
    }
