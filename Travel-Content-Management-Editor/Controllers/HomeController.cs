using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Content_Management_Editor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Places()
        {
            var entities = new Models.TravelContentManagerEntities();
            return View(entities.TOUR_PLACE.ToList());
        }

        public ActionResult Tours()
        {
            var entities = new Models.TravelContentManagerEntities();
            return View(entities.TOURs.ToList());
        }

        public ActionResult Events()
        {
            var entities = new Models.TravelContentManagerEntities();
            return View(entities.TOUR_EVENT.ToList());
        }

        public ActionResult Organizations()
        {
            var entities = new Models.TravelContentManagerEntities();
            return View(entities.TOUR_ORGANIZATION.ToList());
        }

        public ActionResult createPlace()
        {
            return View();
        }

        public ActionResult createOrganization()
        {
            return View();
        }

        public ActionResult createTour()
        {
            return View();
        }

        public ActionResult createEvent()
        {
            return View();
        }

    }
}