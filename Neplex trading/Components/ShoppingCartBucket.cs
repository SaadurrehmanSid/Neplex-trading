using Microsoft.AspNetCore.Mvc;
using Neplex_trading.Data.Models;
using Neplex_trading.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neplex_trading.Components
{
    public class ShoppingCartBucket :ViewComponent
    {
        private ShoppingCart _cart;

        public ShoppingCartBucket(ShoppingCart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _cart.GetShoppingCartItems();
            _cart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartVM
            {
                ShoppingCart = _cart,
                ShoppingCartTotal = _cart.GetShoppingCartTotal()

            };
            return View(shoppingCartViewModel);
        }
    }
}
