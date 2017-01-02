using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.Entity;  //Removed with EF reference
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Company.DIV.ConfigMgr.DataRead;
using Company.DIV.ConfigMgr.Domain.Read;


namespace Company.DIV.ConfigMgr.Web.Controllers
{
    public class AppsController : Controller
    {
        private AppDAO dao;
        
        public AppsController( AppDAO appDAO )
            {
            dao = appDAO;
            }


        // GET: Apps
        public ActionResult Index()
        {
            ICollection<App> apps = dao.GetAll().ToList();
            return View(apps);
        }

        // GET: Apps/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            App app = dao.findByID(id);
            if (app == null)
            {
                return HttpNotFound();
            }
            return View(app);
        }

        // GET: Apps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Apps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ITIL,abbr,description,createDT,createUser,updateDT,updateUser")] App app)
        {
            if (ModelState.IsValid)
            {
                app.ID = Guid.NewGuid();
                dao.Insert(app);
                return RedirectToAction("Index");
            }

            return View(app);
        }

        // GET: Apps/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            App app = dao.findByID(id);
            if (app == null)
            {
                return HttpNotFound();
            }
            return View(app);
        }

        // POST: Apps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ITIL,abbr,description,createDT,createUser,updateDT,updateUser")] App app)
        {
            if (ModelState.IsValid)
            {
                dao.Update(app);
                return RedirectToAction("Index");
            }
            return View(app);
        }

        // GET: Apps/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            App app = dao.findByID(id);
            if (app == null)
            {
                return HttpNotFound();
            }
            return View(app);
        }

        // POST: Apps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            dao.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dao.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
