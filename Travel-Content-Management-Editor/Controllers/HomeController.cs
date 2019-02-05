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
            return View();
        }

        public ActionResult Tours()
        { 
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }
    }
}