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
            return RedirectToAction("Tours", "Home");
        }
        [HttpPost]
        public ActionResult PlaceToTourForm(string tour, string place)
        {
            using (var context = new TravelContentManagerEntities())
            {
                var targetTourRecord = context.TOURs
                    .Where(b => b.TOUR_NAME == tour)
                    .FirstOrDefault();
                var targetPlaceRecord = context.TOUR_PLACE
                    .Where(b => b.PLACE_NAME == place)
                    .FirstOrDefault();
                var placeToTour = new TOUR_PLACE_TO_TOUR()
                {
                    PLACE_TO_TOUR_ID = targetPlaceRecord.PLACE_ID,
                    PLACE_TO_TOUR_GUID = System.Guid.NewGuid(),
                    TOUR_GUID = targetTourRecord.TOUR_GUID,
                    PLACE_GUID = targetPlaceRecord.PLACE_GUID,
                    ENTERED_BY = System.Guid.NewGuid(),
                    ENTERED_DATE_TIME = DateTime.Now,
                    PLACE_SUMMARY_OVERRIDE = targetPlaceRecord.PLACE_SUMMARY,
                    PLACE_DESC_OVERRIDE = targetPlaceRecord.PLACE_DESC

                };
                context.TOUR_PLACE_TO_TOUR.Add(placeToTour);
                context.SaveChanges();
            }
            
            return RedirectToAction("Index", "Home", "Places");
        }
        [HttpPost]
        public ActionResult OrganizationForm(string organizationName, string description, string location, string url, string joinCode, string contactName, string contactEmail, string contactPhone, string groupSize, string additionalInfo)
        {
            var context = new TravelContentManagerEntities();
            var organization = new TOUR_ORGANIZATION()
            {
                ORGANIZATION_ID = 1,
                ORGANIZATION_GUID = System.Guid.NewGuid(),
                ORGANIZATION_NAME = organizationName,
                ORGANIZATION_DESC = description,
                LOCATION = location,
                URL = url,
                JOIN_CODE = joinCode,
                CONTACT_NAME = contactName,
                CONTACT_EMAIL = contactEmail,
                CONTACT_PHONE = contactPhone,
                ENTERED_BY = System.Guid.NewGuid(),
                ENTERED_DATE_TIME = DateTime.Now

            };
            context.TOUR_ORGANIZATION.Add(organization);
            context.SaveChanges();
            return RedirectToAction("Organizations", "home");
        }
    }
}