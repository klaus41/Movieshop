
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
            facade.GetMovieRepository().Delete(movie);
            return RedirectToAction("Index", "Movie");
            //return View(movieId);
        }

        /*
        [HttpPost]
        [ActionName("DeleteAccepted")]
        public ActionResult DeleteAccepted(Movie movie)
        {
            facade.GetMovieRepository().Delete(movie);
            return Redirect("Index");

        }

    */
        [HttpGet]
        public ActionResult Update(int movieId)
        {
            Movie movie = facade.GetMovieRepository().FindMovie(movieId);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Update(Movie movie)
        {
            facade.GetMovieRepository().Update(movie);
            return RedirectToAction("Index", "Movie");
        }

       
        
    }
}