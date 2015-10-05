﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopProxy.DomainModel
{
    [Table("Order")]
    class Order
    {
        [Key]
        public int Id { get; set; }
        public virtual OrderLine OrderLine { get; set; }

    }
}
