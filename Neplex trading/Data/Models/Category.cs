using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Neplex_trading.Models
{
    public class Category
    {
        [Required]
        [Key]
        public int CartegoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImagePath { get; set; }

        
    }
}
