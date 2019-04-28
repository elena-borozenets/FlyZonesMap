using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FlyZonesMap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string googleUrl = "https://maps.googleapis.com/maps/api/place/textsearch/json?key=AIzaSyAtGhClpk9gDmflMhxPhwnNpZ0JyRdx6Lw&input=airport&region=ua";
            WebRequest request = WebRequest.Create(googleUrl);

            WebResponse response = request.GetResponse();

            Stream data = response.GetResponseStream();

            StreamReader reader = new StreamReader(data);

            // json-formatted string from maps api
            string responseFromServer = reader.ReadToEnd();
            ViewBag.Data = responseFromServer;
            response.Close();

            return View();
        }
    }
}