using Day44Concepts.Models;
using System.Collections.Generic;

namespace Day44Concepts.Repositories
{
    public class TestRepository : IProductRepository
    {
        public int AddProduct(ProductModel product)
        {
            throw new System.NotImplementedException();
        }

        public string GetName()
        {
            return "Name from Test Repository";
        }

        public List<ProductModel> GetProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
