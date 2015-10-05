using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieShopProxy.Models;
using MovieShopProxy.DomainModel;
using System.Diagnostics;

namespace MovieShopProxy.Context
{
    public class MovieShopDB : DbContext
    {
        public MovieShopDB(): base("MovieShopDB")
        {
            Debug.WriteLine("Making a database!");
            Database.SetInitializer(new MovieShopDBInitializer());
        }
        
    
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        


    }
}

