using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05a.Controllers
{
    public class CResearchController : Controller
    {
        public string C01()
        {
            string result = "";
            result += "Method -----> " + Request.HttpMethod+ "<br>";
            result += "Url -----> " + Request.Url + "<br>";
            result += "Headers -----> ";
            for(int i = 0; i < Request.Headers.Count; i++)
            {
                result += $"{Request.Headers.GetKey(i)}: {Request.Headers.Get(Request.Headers.GetKey(i))}<br>";
            }
            result += "Query -----> ";
            for (int i = 0; i < Request.QueryString.Count; i++)
            {
                result += $"{Request.QueryString.GetKey(i)}: {Request.QueryString.Get(Request.QueryString.GetKey(i))}<br>";
            }

            Stream req = Request.InputStream;
            req.Seek(0, SeekOrigin.Begin);
            string body = new StreamReader(req).ReadToEnd();
            result += "Body -----> <br>" + body;
            Response.ContentType = "text/html";
            return result;
        }

        public string C02()
        {
            string result = "";
            result += "Status -----> " + Response.StatusCode +Response.StatusDescription+ "<br>";
            result += "Headers -----> ";
            for (int i = 0; i < Response.Headers.Count; i++)
            {
                result += $"{Response.Headers.GetKey(i)}: {Response.Headers.Get(Response.Headers.GetKey(i))}<br>";
            }

            Stream req = Request.InputStream;
            req.Seek(0, SeekOrigin.Begin);
            string body = new StreamReader(req).ReadToEnd();
            result += " -----> <br>" + body;
            Response.ContentType = "text/html";

            return result;
        }
    }
}