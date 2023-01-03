using Microsoft.AspNetCore.Mvc;
using ProjectCourse1.Models;
using ProjectCourse1.ViewModels;

namespace ProjectCourse1.Components
{
    public class ShoppingCartSummary:ViewComponent
    {
        private readonly IShoppingCart _shoppingCart;
        public ShoppingCartSummary(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        public IViewComponentResult Invoke()
        {
            var item = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = item;

            var shoppingcartViewModel =
                new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());
            return View(shoppingcartViewModel);

        }
    }
}
