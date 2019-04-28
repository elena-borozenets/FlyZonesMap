using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using FlyZonesMap.Service;
using Autofac.Integration.Mvc;
using FlyZonesMap.Infrastructure.Repositories;

namespace FlyZonesMap.Utils
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            // получаем экземпляр контейнера
            var builder = new ContainerBuilder();

            // регистрируем контроллер в текущей сборке
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // регистрируем споставление типов
            builder.RegisterType<PlaceRepository>().As<IPlaceRepository>();

            builder.RegisterType<PlaceService>().As<IPlaceService>();

            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}