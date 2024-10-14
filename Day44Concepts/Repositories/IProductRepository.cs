using Day44Concepts.Models;
using System.Collections.Generic;

namespace Day44Concepts.Repositories
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetProducts();
        string GetName();
    }
}