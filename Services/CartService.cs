using System.Collections.Generic;
using System.Linq;
using sit.Models;

namespace sit.Services
{
    public class CartService
    {
        private readonly List<CartItem> _cartItems = new List<CartItem>();

        public void AddToCart(Product product, int quantity)
        {
            var cartItem = _cartItems.FirstOrDefault(ci => ci.Product.Id == product.Id);
            if (cartItem == null)
            {
                _cartItems.Add(new CartItem { Product = product, Quantity = quantity });
            }
            else
            {
                cartItem.Quantity += quantity;
            }
        }

        public void RemoveFromCart(int productId)
        {
            var cartItem = _cartItems.FirstOrDefault(ci => ci.Product.Id == productId);
            if (cartItem != null)
            {
                _cartItems.Remove(cartItem);
            }
        }

        public List<CartItem> GetCartItems()
        {
            return _cartItems;
        }

        public decimal GetTotalPrice()
        {
            return _cartItems.Sum(ci => ci.Product.Price * ci.Quantity);
        }
    }
}
