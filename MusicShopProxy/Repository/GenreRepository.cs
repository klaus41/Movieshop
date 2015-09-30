using MovieShopProxy.Context;
using MovieShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopProxy.Repository
{
    class GenreRepository
    {
        public List<Genre> ReadAll()
        {
            using (var ctx = new MovieShopDB())
            {
                return ctx.Genres.ToList();
            }
        }

    }
}
