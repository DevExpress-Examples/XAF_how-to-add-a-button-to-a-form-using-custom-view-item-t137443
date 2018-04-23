using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MySolution.Mobile
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            CorsSupport.HandlePreflightRequest(HttpContext.Current);
        }
    }
}
