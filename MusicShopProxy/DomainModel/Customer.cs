using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopProxy.DomainModel
{
    [Table("Customer")]
    class Customer
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }


    }
}
