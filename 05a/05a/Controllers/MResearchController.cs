using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05a.Controllers
{
    public class MResearchController : Controller
    {
        public string M01()
        {
            return "GET:M01";
        }

        public string M02()
        {
            return "GET:M02";
        }

        public string M03()
        {
            return "GET:M03";
        }

        public string MXX()
        {
            return "MXX --- Error, your URI is not allowed";
        }



    }
}