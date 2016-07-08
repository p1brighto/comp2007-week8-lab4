﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comp2007_week8_lab4.Controllers
{
    public class HomeController : Controller
    {
        //GER://Home
        public ActionResult Index()
        {
            return View();
        }
        //GER://Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //GER://Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}