﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FileValidation.ViewModels;

namespace FileValidation.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult ImageUpload()
        {
            var upload = new ImageViewModel();
            return View(upload);
        }

        [HttpPost]
        public ActionResult ImageUpload(ImageViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return Content("Success");
        }
    }
}