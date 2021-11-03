using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace _05b.Controllers
{
    public class CHResearchController : Controller
    {
        // GET: CHResearch
        public string Index()
        {
            return "";
        }

        static int x = 9;
        [OutputCache(Duration = 30, Location = OutputCacheLocation.ServerAndClient, NoStore = false)]
        [HttpGet]
        public ActionResult AD()
        {
            x++;
            return Content($"GET:/AD:{x}");
        }

        [OutputCache(Duration = 30, VaryByParam = "x;y")]
        [HttpPost]
        public ActionResult AP(string x, string y, string z)
        {
            return Content($"POST:/AP:{x}:{y}:{z}");
        }
    }
}