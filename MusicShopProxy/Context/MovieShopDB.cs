﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieShopProxy.Models;

namespace MovieShopProxy.Context
{
    public class MovieShopDB : DbContext
    {
        public MovieShopDB(): base("MovieShopDB")
        {
            Database.SetInitializer(new MovieShopDBInitializer());
        }
        
    
        public DbSet<Movie> Movies { get; set; }

    }
}

