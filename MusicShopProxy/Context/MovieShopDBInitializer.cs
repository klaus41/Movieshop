using MovieShopProxy.DomainModel;
using MovieShopProxy.Models;
using MovieShopProxy.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopProxy.Context
{
    public class MovieShopDBInitializer : DropCreateDatabaseAlways<MovieShopDB>
    {
        protected override void Seed(MovieShopDB context)
        {
            IList<Movie> movies = new List<Movie>();
            IList<Genre> genres = new List<Genre>();
            movies.Add(new Movie() {
                Title = "The Dark Knight",
                ReleaseDate = new DateTime(2008, 07, 22),
                Price = 200,
                PictureURL = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-the_dark_knight_movie_poster.jpg",
                TrailerURL = "https://www.youtube.com/embed/EXeTwQWrcwY",
            });
            movies.Add(new Movie() { Title = "The Martian",
                ReleaseDate = new DateTime(2015, 10, 19),
                Price = 250,
                PictureURL = "http://www.movienewz.com/img/gallery/martian/posters/martian_movie_poster_1.jpg",
                TrailerURL = "https://www.youtube.com/embed/ej3ioOneTy8"});
            movies.Add(new Movie() { Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo" });

            foreach (Movie mov in movies)
                context.Movies.Add(mov);

            genres.Add(new Genre() { Name = "Action" });
            genres.Add(new Genre() { Name = "Science Fiction" });

            foreach (Genre genre in genres)
                context.Genres.Add(genre);

            base.Seed(context);
        }
    }
}
