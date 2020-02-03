using Neplex_trading.Data.Interfaces;
using Neplex_trading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neplex_trading.Data.Repositories
{
   
    public class SqlProductsRepo : IProductRepo
    {
        private readonly AppDbContext _context;

        public SqlProductsRepo(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }
    }
}
