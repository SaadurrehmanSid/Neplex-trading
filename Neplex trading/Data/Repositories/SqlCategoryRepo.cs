using Neplex_trading.Data.Interfaces;
using Neplex_trading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neplex_trading.Data.Repositories
{
    public class SqlCategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext _context;

        public SqlCategoryRepo(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories;
        }
    }
}
