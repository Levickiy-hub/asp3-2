using _04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04.Controllers
{
    public class PhoneController : Controller
    {
        private PhoneService phoneService = new PhoneService();
        public ActionResult Index()
        {
            ViewBag.phones = phoneService.GetAll().ToList();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSave(Phone phone)
        {
            phoneService.Save(phone);
            ViewBag.phones = phoneService.GetAll().ToList();
            return Redirect("/");
        }

        public ActionResult Update()
        {
            ViewBag.update = phoneService.GetById(Convert.ToInt32(this.Request.QueryString.Get(0)));
            return View();
        }

        [HttpPost]
        public ActionResult UpdateSave(Phone phone)
        {
            phoneService.Update(phone);
            ViewBag.phones = phoneService.GetAll().ToList();
            return Redirect("/");
        }

        public ActionResult Delete()
        {
            ViewBag.delete = phoneService.GetById(Convert.ToInt32(this.Request.QueryString.Get(0)));
            return View();
        }
        [HttpPost]
        public ActionResult DeleteSave(int id)
        {
            phoneService.Delete(id);
            ViewBag.phones = phoneService.GetAll().ToList();
            return Redirect("/");
        }
    }
}