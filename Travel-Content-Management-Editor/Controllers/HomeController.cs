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

        public ActionResult Places(Guid id)
        {
            ViewData["selectedGUID"] = id;
            var entities = new Models.TravelContentManagerEntities();
            var mod = new Models.ViewModel();
            mod.tour = entities.TOURs;
            mod.orgToItem = entities.TOUR_ORGANIZATION_TO_ITEM;
            mod.place = entities.TOUR_PLACE;
            return View(mod);
        }

        public ActionResult Tours(Guid id)
        {
            ViewData["selectedGUID"] = id;
            var entities = new Models.TravelContentManagerEntities();
            var mod = new Models.ViewModel();
            mod.tour = entities.TOURs;
            mod.orgToItem = entities.TOUR_ORGANIZATION_TO_ITEM;
            mod.place = entities.TOUR_PLACE;
            mod.placeToTours = entities.TOUR_PLACE_TO_TOUR;
            return View(mod);
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

        public ActionResult createPlace(Guid id)
        {
            ViewData["selectedGUID"] = id;
            return View();
        }
        public ActionResult placeToTour()
        {
            
            return View();
        }

        public ActionResult createOrganization()
        {
            return View();
        }

        public ActionResult createTour(Guid id)
        {
            ViewData["selectedGUID"] = id;
            return View();
        }

        public ActionResult createEvent()
        {
            return View();
        }

        public ActionResult MapView()
        {
            return View();
        }
        public ActionResult editTour(Guid id, string tourName)
        {
            ViewData["selectedGUID"] = id;
            ViewData["selectedTour"] = tourName;
            var entities = new Models.TravelContentManagerEntities();
            var mod = new Models.ViewModel();
            mod.tour = entities.TOURs;
            mod.orgToItem = entities.TOUR_ORGANIZATION_TO_ITEM;
            mod.place = entities.TOUR_PLACE;
            mod.placeToTours = entities.TOUR_PLACE_TO_TOUR;
            return View(mod);
        }

    }
}