using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neplex_trading.ViewModels
{
    public class EditCategoryVM  
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ExsistingPhoto { get; set; }

        public  IFormFile Photo { get; set; }
    }
}
