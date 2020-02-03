using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Neplex_trading.Data;
using Neplex_trading.Data.Models;
using Neplex_trading.ViewModels;

namespace Neplex_trading.Controllers
{
    public class ShoppingCartController : Controller
    {
        private AppDbContext _context;
        private ShoppingCart _cart;

        public ShoppingCartController(AppDbContext context, ShoppingCart cart)
        {
            _context = context;
            _cart = cart;
        }
        public IActionResult Index()
        {
            var items = _cart.GetShoppingCartItems();
            _cart.ShoppingCartItems = items;

            var shoppingCartVM = new ShoppingCartVM {
                    ShoppingCart = _cart,
                    ShoppingCartTotal = _cart.GetShoppingCartTotal()
            };
            return View(shoppingCartVM);
        }

       [HttpGet]
        public IActionResult UpdateCart(int id,int amount) {

            var item = _context.ShoppingCartItems.Find(id);
            if (item != null)
            {
                
                item.Amount = amount;
            }
            else
            {
                return View("NotFount");
            }
            _context.ShoppingCartItems.Update(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }



        public IActionResult AddToShoppingCart(int id)
        {

            var selectedItem = _context.Products.Find(id);
            if (selectedItem != null)
            {
                _cart.AddToCart(selectedItem, 1);
            }
            return RedirectToAction("Index");
        }




        public IActionResult RemoveFromShoppingCart(int id)
        {
            var selectedItem = _context.Products.Find(id);
            if (selectedItem != null)
            {
                _cart.RemoveFromCart(selectedItem);
            }
            return RedirectToAction("Index");
        }
















    }
}