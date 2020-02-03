using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neplex_trading.ViewModels
{
    public class ProductsVM
    {
        [Required]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name ="Art#")]
        public string ProductArtNumber { get; set; }
        [Required]
        [Display(Name ="Description")]
        public string ProductDescription { get; set; }
        [Required]
        [Display(Name ="Select Image")]
        public IFormFile Photo { get; set; }
        [Display(Name ="Choose Category")]

        public int CategoryId { get; set; }

    }
}
