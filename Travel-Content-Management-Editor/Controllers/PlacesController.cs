using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Content_Management_Editor.Controllers
{
    public class PlacesController : Controller
    {
        // GET: TOUR_PLACE
        public ActionResult Places()
        {
            var entities = new Models.TravelContentManagerEntities();
            return View(entities.TOUR_PLACE.ToList());
        }
    }
       
}