using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using sit.Models;
using sit.Services;

namespace sit.Controllers
{
    public class CartController : Controller
    {
        private readonly CartService _cartService;

        public CartController()
        {
            _cartService = new CartService();
        }

        public ActionResult Index()
        {
            var cartItems = _cartService.GetCartItems();
            return View(cartItems);
        }

        [HttpPost]
        public ActionResult AddToCart(int productId, int quantity)
        {
            var product = GetProductById(productId); // Implementa este método para obtener el producto desde tu base de datos.
            if (product != null)
            {
                _cartService.AddToCart(product, quantity);
            }
            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(int productId)
        {
            _cartService.RemoveFromCart(productId);
            return RedirectToAction("Index");
        }

        private Product GetProductById(int productId)
        {
            // Simula la obtención del producto desde la base de datos.
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Buso y Calentador Nike", Description = "Description 1", Price = 120.0m, ImageUrl = "~/images/busonike.jpg" },
                new Product { Id = 2, Name = "Tennis Nike V2 Runn", Description = "Description 2", Price = 110.0m, ImageUrl = "~/images/deportivo.png" },
                // Agrega más productos según sea necesario
            };
            return products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
