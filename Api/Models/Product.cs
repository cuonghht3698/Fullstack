using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]

        public decimal price { get; set; }
        [Required]

        public string color { get; set; }

    }
}
