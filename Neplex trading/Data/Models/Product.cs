using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neplex_trading.Models
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductArtNumber { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public double Price { get; set; }

        public bool IsFeatured { get; set; }
        
        public bool InStock { get; set; }

        public string ProductImage { get; set; }

        public int CategoryId{ get; set; }

        public  Category Category{ get; set; }

    }
}
