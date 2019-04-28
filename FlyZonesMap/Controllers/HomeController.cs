using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlyZonesMap.Service;
using Microsoft.Ajax.Utilities;

namespace FlyZonesMap.Controllers
{
    public class HomeController : Controller
    {
        private readonly PlaceService _placeService;
        public HomeController()
        {
            _placeService = new PlaceService();
        }

        
        
        public ActionResult Index()
        {
            string json;
            using (StreamReader r = new StreamReader("C:\\Users\\PC\\source\\repos\\FlyZonesMap\\FlyZonesMap\\Controllers\\example.json"))
            {
                json = r.ReadToEnd();
            }

            _placeService.DeserializeData(json);
            return View();
        }
    }
}