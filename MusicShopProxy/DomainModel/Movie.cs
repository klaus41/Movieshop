using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieShopProxy.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Title")]
        [StringLength(30)]
        public string Title { get; set; }
        [Range(1,9000)]
        [DataType("number")]
        public int Price { get; set; }
        [DataType("date")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }


    }
}