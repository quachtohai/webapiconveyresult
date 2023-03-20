using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace eSolution.BackendApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();           
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var context = System.Web.HttpContext.Current;

            context.Response.AddHeader("Access-Control-Allow-Origin", "*");

            if (context.Request.HttpMethod == "OPTIONS")
            {
                //These headers are handling the "pre-flight" OPTIONS call sent by the browser
                context.Response.AddHeader("Access-Control-Allow-Headers", "*");
                context.Response.AddHeader("Access-Control-Allow-credentials", "true");
                context.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, PATCH, POST, DELETE, OPTIONS");
                context.Response.AddHeader("Access-Control-Allow-Headers", "x-requested-with, Content-Type, origin, authorization, Accepts, accept, client-security-token, access-control-allow-headers");
                context.Response.AddHeader("Access-Control-Max-Age", "86400");
                context.Response.End();
            }
        }
    }
}
