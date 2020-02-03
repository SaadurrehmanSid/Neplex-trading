using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Neplex_trading.Data;
using Neplex_trading.Data.Interfaces;
using Neplex_trading.Models;
using Neplex_trading.ViewModels;

namespace Neplex_trading.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepo _productRepo;
        private readonly ICategoryRepo _categoryRepo;
        private readonly AppDbContext _context;

        public HomeController(IProductRepo productRepo,ICategoryRepo categoryRepo, AppDbContext context)
        {
        
            _productRepo = productRepo;
            _categoryRepo = categoryRepo;
            _context = context;
        }
        public IActionResult Index()
        {
            var model = new HomeVM
            {
                Product = _context.Products.Take(9).OrderBy(n=>n.ProductName),
                Category= _categoryRepo.GetCategories()

            };
           
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
