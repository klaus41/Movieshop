
using MovieShopProxy.Models;
using MovieShopProxy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movieshop.Controllers
{
    public class MovieController : Controller
    {
        private Facade facade = new Facade();

        public ActionResult Index()
        {
            List<Movie> movies = facade.GetMovieRepository().ReadAll();
            return View(movies);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            facade.GetMovieRepository().Add(movie);
            return Redirect("Index");
        }

        public ActionResult Delete(Movie movie)
        {
            return View(movie);
        }

        public ActionResult DeleteAccepted(Movie movie)
        {
            facade.GetMovieRepository().Delete(movie);
            return Redirect("Index");

        }
    }
}