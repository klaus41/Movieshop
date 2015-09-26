using Movieshop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopProxy.Repository
{
    public class Facade
    {
        private MovieRepository movieRepo;

        public MovieRepository GetMovieRepository()
        {
            if (movieRepo == null)
            {
                movieRepo = new MovieRepository();
            }
            return movieRepo;
        }
    }
}