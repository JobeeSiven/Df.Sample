﻿using CourseManager.Filters;
using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManager.Controllers
{
    [RequireAuthentication]
    [ActionResultExceptionFilter]
    public class HomeController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult Navbar()
        {
            var site = new WebsiteInfo();
            ViewBag.site = site;
            site.ActionLinks = db.ActionLinks.ToList();
            return PartialView("~/Views/Shared/Navbar.cshtml");
        }

        [ChildActionOnly]
        public ActionResult Sidebar()
        {
            var sidebars = db.Sidebars.ToList();
            ViewBag.Sidebars = sidebars;

            return PartialView("~/Views/Shared/Sidebar.cshtml");
        }

        
    }
}