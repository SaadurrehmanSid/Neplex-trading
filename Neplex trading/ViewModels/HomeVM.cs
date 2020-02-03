using Neplex_trading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neplex_trading.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Product>  Product { get; set; }
        public IEnumerable<Category> Category { get; set; }

    }
}
