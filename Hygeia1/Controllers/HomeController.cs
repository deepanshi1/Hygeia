using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hygeia1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Message = "The Team.";
            return View();
        }

        public ActionResult Technology()
        {
            return View();
        }

        public ActionResult WhatWeDo()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }
}
