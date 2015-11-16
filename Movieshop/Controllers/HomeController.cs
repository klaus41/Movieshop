using MovieShopProxy.Models;
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
<<<<<<< HEAD

=======
>>>>>>> 96fa5b2e309412419fd60a1dbed81171f7b8fe76
        private Facade facade = new Facade();

        public ActionResult Index()
        {
            List<Movie> movies = facade.GetMovieRepository().ReadAll();
            return View(movies);
        }

        [HttpPost]
<<<<<<< HEAD
        public ActionResult Index(string movieSearched)
        {
            List<Movie> movies = facade.GetMovieRepository().TitleFilter(movieSearched);
            return View(movies);
        }

        [HttpPost]
        public ActionResult OrderReceived(string trailerURL)
        {
            Movie movieFound = facade.GetMovieRepository().GetMovieByTrailerURL(trailerURL);
            return View(movieFound);
        }

        [HttpPost]
        public ActionResult OrderConfirmed(string customerEmail)
        {
            return View();
=======
        public ActionResult OrderReceived(string trailerURL)
        {
            Movie movieFound = facade.GetMovieRepository().GetMovieByTrailerURL(trailerURL);
            return View(movieFound);
        }

        [HttpPost]
        public ActionResult OrderConfirmed(string customerEmail)
        {
            
>>>>>>> 96fa5b2e309412419fd60a1dbed81171f7b8fe76
        }
    }
}