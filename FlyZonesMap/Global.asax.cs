using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FlyZonesMap.Service;
using FlyZonesMap.Utils;
using FlyZonesMap.Infrastructure.Context;

namespace FlyZonesMap
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            FlyZonesMapDbContextInitializer db = new FlyZonesMapDbContextInitializer();
            System.Data.Entity.Database.SetInitializer(db);

            AutofacConfig.ConfigureContainer();

            AutoMapper.Mapper.Initialize(cfg =>
                cfg.AddProfile<MappingProfile>());
        }
    }
}
