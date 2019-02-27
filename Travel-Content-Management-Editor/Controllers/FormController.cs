using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Content_Management_Editor.Models;

namespace Travel_Content_Management_Editor.Controllers
{
    public class FormController : Controller
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
                IS_DEFAULT_PLACE = true,
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
            return RedirectToAction("Places", "Home");
        }
        [HttpPost]
        public ActionResult TourForm(decimal tourId, string tourName, string summary, string tourDescription, string url, string bookNowUrl, string duration, string cost, string groupSize, string additionalInfo)
        {
            var context = new TravelContentManagerEntities();
            var tour = new TOUR()
            {
                TOUR_ID = tourId,
                TOUR_GUID = System.Guid.NewGuid(),
                TOUR_NAME = tourName,
                TOUR_SUMMARY = summary,
                TOUR_DESC = tourDescription,
                URL = url,
                BOOK_NOW_URL = bookNowUrl,
                DURATION = duration,
                COST = cost,
                GROUP_SIZE = groupSize,
                ADDITIONAL_INFO = additionalInfo,
                ENTERED_BY = System.Guid.NewGuid(),
                ENTERED_DATE_TIME = DateTime.Now

            };
            context.TOURs.Add(tour);
            context.SaveChanges();
            return RedirectToAction("Index", "Home", "Places");
        }
    }
}