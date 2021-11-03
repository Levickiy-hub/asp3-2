using _03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.Controllers
{
    public class DictController : Controller
    {
        Models.Database db = new Models.Database();
        // GET: Dict
        public ActionResult Index()
        {

            ViewBag.getall = this.db.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSave(string name, long phone)
        {
            Data data = new Data(1, name, phone);
            db.Save(data);
            ViewBag.getall = this.db.GetAll();
            return View("Index");
        }

        public ActionResult Update()
        {
            ViewBag.update = this.db.FindById(Convert.ToInt32(this.Request.QueryString.Get(0)));
            return View();
        }

        [HttpPost]
        public ActionResult UpdateSave(Data data)
        {
            db.Update(data);
            ViewBag.getall = this.db.GetAll();
            return View("Index");
        }

        public ActionResult Delete()
        {
            ViewBag.delete = this.db.FindById(Convert.ToInt32(this.Request.QueryString.Get(0)));
            return View();
        }
        [HttpPost]
        public ActionResult DeleteSave(int id)
        {
            db.Delete(id);
            ViewBag.getall = this.db.GetAll();
            return View("Index");
        }

    }
}