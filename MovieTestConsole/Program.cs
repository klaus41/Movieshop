using MovieShopProxy;
using MovieShopProxy.Context;
using MovieShopProxy.Models;
using MovieShopProxy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie() { Id = 2, Price = 200, Title = "Lego movie 2", ReleaseDate = DateTime.Now.AddYears(-1) };
            Facade facade = new Facade();
            facade.GetMovieRepository().Add(movie);
        }
    }
}
