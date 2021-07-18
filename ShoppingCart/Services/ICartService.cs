using ShoppingCart.Models;
using System;
using System.Collections.Generic;

namespace ShoppingCart.Services
{
    public interface ICartService
    {
        IList<Product> Cart { get; }
        decimal Total { get; set; }

        event Action OnChange;

        void AddProduct(Product product);
        void DeleteProduct(Product product);
    }
}