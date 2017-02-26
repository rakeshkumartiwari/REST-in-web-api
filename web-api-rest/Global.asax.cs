using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using web_api_rest.Infrastructure;

namespace web_api_rest
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            
            GlobalConfiguration.Configure(WebApiConfig.Register);
           
        }
    }
}
