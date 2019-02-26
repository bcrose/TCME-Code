using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Content_Management_Editor.Models;

namespace Travel_Content_Management_Editor.Controllers
{
    public class Places : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();

        }
        [HttpPost]
        public ActionResult FormOne(decimal placeId, string googlePlaceId, string placeName, string summary, string placeDescription, string address, string phoneNumber, string website, double lattitude, double longitude)
        {
            var context = new TravelContentManagerEntities();
            var place = new TOUR_PLACE()
            {
                PLACE_ID = placeId,
                PLACE_GUID = System.Guid.NewGuid(),
                GOOGLE_PLACE_ID = googlePlaceId,
                IS_DEFAULT_PLACE = false,
                PLACE_NAME = placeName,
                PLACE_SUMMARY = summary,
                PLACE_DESC = placeDescription,
                ADDRESS = address,
                PHONE = phoneNumber,
                WEBSITE = website,
                LATITUDE = lattitude,
                LONGITUDE = longitude,
                ENTERED_BY = System.Guid.NewGuid(),
                ENTERED_DATE_TIME = DateTime.Now

            };
            context.TOUR_PLACE.Add(place);
            context.SaveChanges();
            return RedirectToAction("Index", "Home", "Places");
        }
    }
}