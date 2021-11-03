using PhoneDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab6.Controllers
{
    public class DictController : Controller
    {
        IPhoneDictionary<Phone> phoneRepository;

        public DictController(IPhoneDictionary<Phone> rep)
        {
            phoneRepository = rep;
        }

        public ActionResult Index()
        {
            return View(phoneRepository.GetAll());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Phone phone)
        {
            phoneRepository.Add(phone);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(string id)
        {
            int ID;
            if (Int32.TryParse(id, out ID))
            {
                var phone = phoneRepository.Get(ID);
                if (phone == null)
                {
                    return HttpNotFound();
                }
                return View(phone);
            }
            else
                return HttpNotFound();
        }


        [HttpPost]
        public ActionResult Update(Phone phone)
        {
            phoneRepository.Update(phone);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Delete(string id)
        {
            int ID;
            if (Int32.TryParse(id, out ID))
            {
                var phone = phoneRepository.Get(ID);
                if (phone == null)
                {
                    return HttpNotFound();
                }
                return View(phone);
            }
            else
                return HttpNotFound();
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteSave(string id)
        {
            int ID;
            if (Int32.TryParse(id, out ID))
            {
                phoneRepository.Remove(phoneRepository.Get(ID));
                return RedirectToAction("Index");
            }
            else
                return HttpNotFound();
        }
    }
}