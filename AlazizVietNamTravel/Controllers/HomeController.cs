using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlazizVietNamTravel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "Giới thiệu";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Title = "Blog";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Liên hệ";

            return View();
        }

        public ActionResult Places()
        {
            ViewBag.Title = "Địa điểm";

            return View();
        }
    }
}