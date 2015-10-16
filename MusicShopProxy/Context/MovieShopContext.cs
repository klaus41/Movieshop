﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieShopProxy.Models;
using MovieShopProxy.DomainModel;
using System.Diagnostics;

namespace MovieShopProxy.Context
{
    public class MovieShopContext : DbContext
    {
        public MovieShopContext(): base("MovieShopDB")
        {
            Debug.WriteLine("Making a database!");
            Database.SetInitializer(new MovieShopContextInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasMany(g => g.Genres).WithMany();
        }
        //OnModelCreating States exactly which lists the tables are connected as many-to-many through

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        


    }
}

