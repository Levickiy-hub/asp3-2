using System.Web;

namespace lab1
{
    public class Lab1Task1 : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            string parmA = context.Request.QueryString["parmA"];
            string parmB = context.Request.QueryString["parmB"];
            res.ContentType = "text/plain";
            res.Write($"Get-Http-{context.Request.Url.AbsolutePath} :ParmA = {parmA},ParmB = {parmB}");
        }
    }
    public class Lab1Task2 : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            string parmA = context.Request.Params["parmA"];
            string parmB = context.Request.Params["parmB"];
            res.ContentType = "text/plain";
            res.Write($"Post-Http-{context.Request.Url.AbsolutePath} :ParmA = {parmA},ParmB = {parmB}");
        }
    }
    public class Lab1Task3 : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            string parmA = context.Request.Params["parmA"];
            string parmB = context.Request.Params["parmB"];
            res.ContentType = "text/plain";
            res.Write($"Put-Http-{context.Request.Url.AbsolutePath} :ParmA = {parmA},ParmB = {parmB}");
        }
    }
    public class Lab1Task4 : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            string parmA = context.Request.Params["parmA"];
            string parmB = context.Request.Params["parmB"];
            int sum = int.Parse(parmA) + int.Parse(parmB);
            res.ContentType = "text/plain";
            res.Write($"{sum}");
        }
    }  
    public class Lab1Task5 : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            if (context.Request.HttpMethod == "GET")
            {
                res.WriteFile("./task5.html");
            }
            else if(context.Request.HttpMethod == "POST")
            {
                string x = context.Request.Params["x"];
                string y = context.Request.Params["y"];
                int mul = int.Parse(x) * int.Parse(y);
                res.ContentType = "text/plain";
                res.Write($"{mul}");
            }
            else
            {
                res.StatusCode = 404;
                res.End();
            }

        }
    }
    public class Lab1Task6 : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            if (context.Request.HttpMethod == "GET")
            {
                res.WriteFile("./task6.html");
            }
            else if(context.Request.HttpMethod == "POST")
            {
                string x = context.Request.Params["x"];
                string y = context.Request.Params["y"];
                int mul = int.Parse(x) * int.Parse(y);
                res.ContentType = "text/plain";
                res.Write($"{mul}");
            }
            else
            {
                res.StatusCode = 404;
                res.End();
            }

        }
    }
}