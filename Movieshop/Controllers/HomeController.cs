﻿using MovieShopProxy.Models;
using MovieShopProxy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movieshop.Controllers
{
    public class HomeController : Controller
    {
        //hi ivan
        private Facade facade = new Facade();
        public ActionResult Index()
        {
            List<Movie> movies = facade.GetMovieRepository().ReadAll();
            return View(movies);
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
    }
}