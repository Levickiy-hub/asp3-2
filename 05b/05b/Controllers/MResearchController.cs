using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace _05b.Controllers
{
    [RoutePrefix("it")]
    public class MResearchController : Controller
    {
        // GET: MResearch
        public string Index()
        {
            return "";
        }

        [HttpGet]
        [Route("{n:int}/{str}")]
        public string M01B(int n, string str)
        {
            return $"GET:M01:/{n}/{str}";
        }

        [Route("{b:bool}/{letters:alpha}")]
        [AcceptVerbs("GET", "POST")]
        public string M02(bool b, string letters)
        {  
            return $"{Request.HttpMethod}:M02:/{b}/{letters}";
        }

        [Route("{f:float}/{str:length(2,5)}")]
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Delete)]
        public string M03(float f, string str)
        {
            return $"{Request.HttpMethod}:M03:/{f}/{str}";
        }

        [Route("{letters:length(3, 4)}/{n:range(100, 200)}")]
        //[HttpGet]
        [AcceptVerbs("PUT")]
        public string M04(string letters, int n)
        {
            return $"PUT:M04/{letters}/{n}";
        }

        [Route("{mail:regex(^\\w+@\\w+\\.\\w+$)}")]
        [HttpPost]
        public string M05(string mail)
        {
            return $"POST:M05/{mail}";
        }
    }
}