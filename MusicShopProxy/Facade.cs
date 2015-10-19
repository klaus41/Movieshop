using Movieshop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopProxy.Repository
{
    public class Facade
    {
        private MovieRepository movieRepo;
        private GenreRepository genreRepo;
        private CustomerRepository customerRepo;

        public MovieRepository GetMovieRepository()
        {
            if (movieRepo == null)
            {
                movieRepo = new MovieRepository();
            }
            return movieRepo;
        }
        public GenreRepository GetGenresRepository()
        {
            if (genreRepo == null)
            {
                genreRepo = new GenreRepository();
            }
            return genreRepo;
        }

        public CustomerRepository GetCustomerRepository()
        {
            if (customerRepo == null)
            {
                customerRepo = new CustomerRepository();
            }
            return customerRepo;
        }
    }
}