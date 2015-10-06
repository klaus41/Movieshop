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
    public class MovieShopContextInitializer : DropCreateDatabaseAlways<MovieShopContext>
    {
        protected override void Seed(MovieShopContext context)
        {
            IList<Movie> movies = new List<Movie>();
           

            Genre genre1 = context.Genres.Add(new Genre() { Id = 1, Name = "Action" });
            Genre genre2 = context.Genres.Add(new Genre() { Id = 2, Name = "Science Fiction" });
            
                
            movies.Add(new Movie() {
                Title = "The Dark Knight",
                ReleaseDate = new DateTime(2008, 07, 22),
                Price = 200,
                PictureURL = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-the_dark_knight_movie_poster.jpg",
                TrailerURL = "https://www.youtube.com/embed/EXeTwQWrcwY",
                Genres = new List<Genre>() { genre1, genre2 },
            });
            movies.Add(new Movie() { Title = "The Martian",
                ReleaseDate = new DateTime(2015, 10, 19),
                Price = 250,
                PictureURL = "http://www.movienewz.com/img/gallery/martian/posters/martian_movie_poster_1.jpg",
                TrailerURL = "https://www.youtube.com/embed/ej3ioOneTy8",
                Genres = new List<Genre>() { genre1 },
            });
            movies.Add(new Movie() { Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });

            foreach (Movie mov in movies)
                context.Movies.Add(mov);

            

            base.Seed(context);
        }
    }
}
