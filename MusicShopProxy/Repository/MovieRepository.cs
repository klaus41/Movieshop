using MovieShopProxy.Models;
using MovieShopProxy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Infrastructure;

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
        /* delete through  id:
            
            Movie movie = null;
            foreach (var item in ReadAll())
            {
                if (movieId == item.Id)
                {
                    movie = item;
                }
            }
            */

        public void Delete(Movie movie)
        {
           
            try { 
            using (var ctx = new MovieShopDB())
            {
                ctx.Movies.Attach(movie);
                ctx.Movies.Remove(movie);
                ctx.SaveChanges();
            }
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }
        }

        public Movie FindMovie(int movieId)
        {
            foreach (var item in ReadAll())
            {
                if (item.Id == movieId)
                {
                    return item;
                }

            }
            return null;
        }

        public void Update(Movie movie)
        {
            using (var ctx = new MovieShopDB())
            {
                foreach (var movieDB in ctx.Movies.ToList())
                {
                    if (movie.Id == movieDB.Id)
                    {
                        movieDB.Title = movie.Title;
                        movieDB.ReleaseDate = movie.ReleaseDate;
                        movieDB.Price = movie.Price;
                        ctx.SaveChanges();

                    }
                }
            }


        }
    }
}