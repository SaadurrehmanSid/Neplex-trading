using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neplex_trading.ViewModels
{
    public class EditProductVM
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name ="Product Art Number")]
        public string ProductArtNumber { get; set; }
        [Required]
        [Display(Name ="Product Description")]
        public string ProductDescription { get; set; }
        [Required]
        public double Price { get; set; }
        [Display(Name ="Add to feature product")]
        public bool IsFeatured { get; set; }
        [Display(Name = "Is product is available in stock")]
        public bool InStock { get; set; }

        public IFormFile Photo { get; set; }
        public string ExistingPhoto { get; set; }

        public int CategoryId { get; set; }
    }
}
