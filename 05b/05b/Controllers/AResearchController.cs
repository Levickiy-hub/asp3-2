using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05b.Controllers
{
    public class AResearchController : Controller
    {
        // GET: AResearch
        public string Index()
        {
            return "";
        }

        [ActionFilter]
        public string AA()
        {
            Response.Write("AA<br>");
            return "ARR</br>";
        }

        [ResultFilter]
        public string AR()
        {
            return "AR<br>";
        }
        [ExceptionFilter]
        public string AE()
        {
            throw new Exception();
            //return "AE";
        }

    }

    public class ActionFilter : FilterAttribute, IActionFilter, IResultFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("After action calling<br>");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("Before action calling<br>");
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("After result calling<br>");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("Before result calling<br>");
        }
    }

    public class ResultFilter : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("After result calling<br>");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("Before result calling<br>");
        }
    }

    public class ExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.HttpContext.Response.Write("Oops. I caught exception<br>");
            filterContext.ExceptionHandled = true;

        }
    }

}