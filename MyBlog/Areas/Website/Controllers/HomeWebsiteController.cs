using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Controllers;


namespace MyBlog.Areas.Website.Controllers
{
    public class HomeWebsiteController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Project description page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Blog implementation page";

            return View();
        }

        public ActionResult Game()
        {
            ViewBag.Message = "Game";

            return View();
        }
    }
}
