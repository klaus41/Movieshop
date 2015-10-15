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
            Genre genre3 = context.Genres.Add(new Genre() { Id = 3, Name = "Thriller" });
            
                
            movies.Add(new Movie() {
                Title = "The Dark Knight",
                ReleaseDate = new DateTime(2008, 07, 22),
                Price = 200,
                PictureURL = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-the_dark_knight_movie_poster.jpg",
                TrailerURL = "https://www.youtube.com/embed/EXeTwQWrcwY",
                Genres = new List<Genre>() { genre1, genre2 },
            });
            movies.Add(new Movie() {
                Title = "The Martian",
                ReleaseDate = new DateTime(2015, 10, 19),
                Price = 250,
                PictureURL = "http://www.movienewz.com/img/gallery/martian/posters/martian_movie_poster_1.jpg",
                TrailerURL = "https://www.youtube.com/embed/ej3ioOneTy8",
                Genres = new List<Genre>() { genre1 },
            });
            movies.Add(new Movie() {
                Title = "Insurgent",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                TrailerURL = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "The Grey",
                ReleaseDate = new DateTime(2012, 01, 12),
                Price = 150,
                PictureURL = "http://gdj.gdj.netdna-cdn.com/wp-content/uploads/2011/12/grey-movie-poster.jpg",
                TrailerURL = "https://www.youtube.com/embed/Hfb0-U0ydj8",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Real Steel",
                ReleaseDate = new DateTime(2012, 01, 12),
                Price = 150,
                PictureURL = "http://images5.fanpop.com/image/photos/26200000/Real-Steel-movie-posters-26233237-1079-1600.jpg",
                TrailerURL = "https://www.youtube.com/embed/3S8a180uYBM",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "The Expendables",
                ReleaseDate = new DateTime(2010, 08, 20),
                Price = 150,
                PictureURL = "https://bandbent.files.wordpress.com/2012/08/expendables-2-movie-poster-comic-con-high-quality.jpg",
                TrailerURL = "https://www.youtube.com/embed/C6RU5y2fU6s",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Harry Potter and The Order of the Phoenix",
                ReleaseDate = new DateTime(2007, 07, 11),
                Price = 150,
                PictureURL = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-harry-potter-phoenix.jpg",
                TrailerURL = "https://www.youtube.com/embed/CQAX-YwX6iM",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Thor",
                ReleaseDate = new DateTime(2011, 03, 28),
                Price = 150,
                PictureURL = "http://blog.moviepostershop.com/wp-content/uploads/2011/03/Thor-movie-poster.jpg",
                TrailerURL = "https://www.youtube.com/embed/JOddp-nlNvQ",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "James Bond - Skyfall",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.printmag.com/wp-content/uploads/skyfall_xlg.jpg",
                TrailerURL = "https://www.youtube.com/embed/6kw1UVovByw",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "James Bond - Quantum of Solace",
                ReleaseDate = new DateTime(2008, 11, 14),
                Price = 150,
                PictureURL = "http://images2.fanpop.com/images/photos/8400000/Movie-Posters-movies-8405072-1723-2560.jpg",
                TrailerURL = "https://www.youtube.com/embed/f6acw690AqQ",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "The Dark Knight",
                ReleaseDate = new DateTime(2008, 07, 22),
                Price = 200,
                PictureURL = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-the_dark_knight_movie_poster.jpg",
                TrailerURL = "https://www.youtube.com/embed/EXeTwQWrcwY",
                Genres = new List<Genre>() { genre1, genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "The Martian",
                ReleaseDate = new DateTime(2015, 10, 19),
                Price = 250,
                PictureURL = "http://www.movienewz.com/img/gallery/martian/posters/martian_movie_poster_1.jpg",
                TrailerURL = "https://www.youtube.com/embed/ej3ioOneTy8",
                Genres = new List<Genre>() { genre1 },
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
                Title = "The Grey",
                ReleaseDate = new DateTime(2012, 01, 12),
                Price = 150,
                PictureURL = "http://gdj.gdj.netdna-cdn.com/wp-content/uploads/2011/12/grey-movie-poster.jpg",
                TrailerURL = "https://www.youtube.com/embed/Hfb0-U0ydj8",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Real Steel",
                ReleaseDate = new DateTime(2012, 01, 12),
                Price = 150,
                PictureURL = "http://images5.fanpop.com/image/photos/26200000/Real-Steel-movie-posters-26233237-1079-1600.jpg",
                TrailerURL = "https://www.youtube.com/embed/3S8a180uYBM",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "The Expendables",
                ReleaseDate = new DateTime(2010, 08, 20),
                Price = 150,
                PictureURL = "https://bandbent.files.wordpress.com/2012/08/expendables-2-movie-poster-comic-con-high-quality.jpg",
                TrailerURL = "https://www.youtube.com/embed/C6RU5y2fU6s",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Harry Potter and The Order of the Phoenix",
                ReleaseDate = new DateTime(2007, 07, 11),
                Price = 150,
                PictureURL = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-harry-potter-phoenix.jpg",
                TrailerURL = "https://www.youtube.com/embed/CQAX-YwX6iM",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "Thor",
                ReleaseDate = new DateTime(2011, 03, 28),
                Price = 150,
                PictureURL = "http://blog.moviepostershop.com/wp-content/uploads/2011/03/Thor-movie-poster.jpg",
                TrailerURL = "https://www.youtube.com/embed/JOddp-nlNvQ",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "James Bond - Skyfall",
                ReleaseDate = new DateTime(2015, 03, 11),
                Price = 150,
                PictureURL = "http://www.printmag.com/wp-content/uploads/skyfall_xlg.jpg",
                TrailerURL = "https://www.youtube.com/embed/6kw1UVovByw",
                Genres = new List<Genre>() { genre2 },
            });
            movies.Add(new Movie()
            {
                Title = "James Bond - Quantum of Solace",
                ReleaseDate = new DateTime(2008, 11, 14),
                Price = 150,
                PictureURL = "http://images2.fanpop.com/images/photos/8400000/Movie-Posters-movies-8405072-1723-2560.jpg",
                TrailerURL = "https://www.youtube.com/embed/f6acw690AqQ",
                Genres = new List<Genre>() { genre2 },
            });

            foreach (Movie mov in movies)
                context.Movies.Add(mov);

            

            base.Seed(context);
        }
    }
}
