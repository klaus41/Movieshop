using MovieShopProxy.Models;
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

            movies.Add(new Movie() { Title = "Star Wars", ReleaseDate = DateTime.Today.AddYears(-30), Price = 200 });
            movies.Add(new Movie() { Title = "Primer", ReleaseDate = DateTime.Today.AddYears(-10), Price = 100});
            movies.Add(new Movie() { Title = "National Security", ReleaseDate = DateTime.Today.AddYears(-12), Price = 150 });

            foreach (Movie mov in movies)
                context.Movies.Add(mov);

            base.Seed(context);
        }
    }
}
