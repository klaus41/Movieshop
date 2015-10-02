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
        

        public void Delete(int movieId)
        {
            Movie movie = FindMovie(movieId);
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
                        movieDB.TrailerURL = movie.TrailerURL;
                        movieDB.PictureURL = movie.PictureURL;
                        ctx.SaveChanges();

                    }
                }
            }


        }
    }
}