using SklepSportowy.App_Start;
using SklepSportowy.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SklepSportowy
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer(new ProduktyInitializer());
            ProduktyContext db = new ProduktyContext();
            db.Database.Initialize(true);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
