using Neplex_trading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neplex_trading.ViewModels
{
    public class ProductByCategoryVM
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Product> SingleProductList { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public string CategoryName { get; set; }
    }
}
