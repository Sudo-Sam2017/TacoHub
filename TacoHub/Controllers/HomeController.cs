﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TacoHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your Tacos.Delivered";

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.Message = "Menu";
            return View();
        }
    }
}