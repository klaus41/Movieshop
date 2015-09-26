using Movieshop.Models;
using MovieShopProxy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Movieshop.Repository
{
    public class MovieRepository
    {
        public List<Movie> ReadAll()
        {
            using (var ctx = new MovieShopDB())
            {
                return ctx.Movies.ToList();
            }
        }


        public void Add(Movie movie)
        {
            using (var ctx = new MovieShopDB())
            {
                
                //Create the queries
                ctx.Movies.Add(movie);
                //Execute the queries
                ctx.SaveChanges();
            }
        }

    }
}