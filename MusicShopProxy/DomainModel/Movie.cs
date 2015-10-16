using MovieShopProxy.DomainModel;
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
        public Movie() { }
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Title")]
        [StringLength(50)]
        public string Title { get; set; }
        [Range(1, 9000)]
        [DataType("number")]
        public int Price { get; set; }
        [DataType("date")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Trailer Link")]
        public string TrailerURL { get; set; }
        [Display(Name = "Picture Link")]
        public string PictureURL { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }

    }
}
