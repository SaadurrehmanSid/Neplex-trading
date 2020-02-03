using Neplex_trading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neplex_trading.Data.Interfaces
{
     public interface ICategoryRepo
    {
        IEnumerable<Category> GetCategories();
    }
}
