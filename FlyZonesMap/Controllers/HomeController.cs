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
        private readonly IPlaceService _placeService;
        public HomeController(IPlaceService placeService)
        {
            _placeService = placeService;
        }

        private List<string> searchWords = new List<string>
        {
            //"airstrip",
            //"industrial%20zone",
            //"railway%20station",
            //"main%20street",
            "prison",
            "Міністерство%20внутрішніх%20справ",
            "Служба%20безпеки%20України",
            "Міністерство%20оборони%20України",
            "Національна%20поліція%20України",
            "Національна%20гвардія%20України",
            "Державна%20прикордонна%20служба",
            "Управління%20державної%20охорони",
            "site"
            //,
            //"",
            //"",
            //"",

        };

        public ActionResult Index()
        {
            //string json;
            //using (StreamReader r = new StreamReader("C:\\Users\\PC\\source\\repos\\FlyZonesMap\\FlyZonesMap\\Controllers\\example.json"))
            //{
            //    json = r.ReadToEnd();
            //}

            //string googleUrl;
            //foreach (var w in searchWords)
            //{
            //    googleUrl = String.Format("https://maps.googleapis.com/maps/api/place/textsearch/json?key=AIzaSyAtGhClpk9gDmflMhxPhwnNpZ0JyRdx6Lw&input={0}&region=ua", w);

            //    var json = _placeService.GetRequest(googleUrl);
            //    var places = _placeService.DeserializeData(json);
            //    _placeService.SavePlaces(places);
            //}

            var pl = _placeService.GetPlaces();

            return View(pl);
        }
    }
}