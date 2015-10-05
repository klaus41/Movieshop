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
<<<<<<< HEAD
        { 
                List<Movie> movies = new List<Movie>();
                movies.Add(new Movie()
                {
                    Title = "The Dark Knight",
                    ReleaseDate = new DateTime(2008, 07, 22),
                    Price = 200,
                    PictureURL = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-the_dark_knight_movie_poster.jpg",
                    TrailerURL = "https://www.youtube.com/embed/EXeTwQWrcwY",
                });
                movies.Add(new Movie()
                {
                    Title = "The Martian",
                    ReleaseDate = new DateTime(2015, 10, 19),
                    Price = 250,
                    PictureURL = "http://www.movienewz.com/img/gallery/martian/posters/martian_movie_poster_1.jpg",
                    TrailerURL = "https://www.youtube.com/embed/ej3ioOneTy8",
                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",

                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",

                });
                movies.Add(new Movie()
                {
                    Title = "The Dark Knight",
                    ReleaseDate = new DateTime(2008, 07, 22),
                    Price = 200,
                    PictureURL = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-the_dark_knight_movie_poster.jpg",
                    TrailerURL = "https://www.youtube.com/embed/EXeTwQWrcwY",
                });
                movies.Add(new Movie()
                {
                    Title = "The Martian",
                    ReleaseDate = new DateTime(2015, 10, 19),
                    Price = 250,
                    PictureURL = "http://www.movienewz.com/img/gallery/martian/posters/martian_movie_poster_1.jpg",
                    TrailerURL = "https://www.youtube.com/embed/ej3ioOneTy8",
                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",

                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",

                });
                movies.Add(new Movie()
                {
                    Title = "The Dark Knight",
                    ReleaseDate = new DateTime(2008, 07, 22),
                    Price = 200,
                    PictureURL = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-the_dark_knight_movie_poster.jpg",
                    TrailerURL = "https://www.youtube.com/embed/EXeTwQWrcwY",
                });
                movies.Add(new Movie()
                {
                    Title = "The Martian",
                    ReleaseDate = new DateTime(2015, 10, 19),
                    Price = 250,
                    PictureURL = "http://www.movienewz.com/img/gallery/martian/posters/martian_movie_poster_1.jpg",
                    TrailerURL = "https://www.youtube.com/embed/ej3ioOneTy8",
                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",

                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",

                });
                movies.Add(new Movie()
                {
                    Title = "The Dark Knight",
                    ReleaseDate = new DateTime(2008, 07, 22),
                    Price = 200,
                    PictureURL = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-the_dark_knight_movie_poster.jpg",
                    TrailerURL = "https://www.youtube.com/embed/EXeTwQWrcwY",
                });
                movies.Add(new Movie()
                {
                    Title = "The Martian",
                    ReleaseDate = new DateTime(2015, 10, 19),
                    Price = 250,
                    PictureURL = "http://www.movienewz.com/img/gallery/martian/posters/martian_movie_poster_1.jpg",
                    TrailerURL = "https://www.youtube.com/embed/ej3ioOneTy8",
                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",

                });
                movies.Add(new Movie()
                {
                    Title = "Insurgent",
                    ReleaseDate = new DateTime(2015, 03, 11),
                    Price = 150,
                    PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                    TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",

                });
                return movies;
                //return ctx.Movies.ToList();
=======
        {
            using (var ctx = new MovieShopDB())
            {
                return ctx.Movies.Include("Genres").ToList();
                    
            }
>>>>>>> 1e85fe630e0a05ddc8326367f98bfa08604b7688
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
                        //movieDB.Genres = movie.Genres;
                        ctx.SaveChanges();

                    }
                }
            }


        }
    }
}