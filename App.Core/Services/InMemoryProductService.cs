using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace App.Core.Services
{
    public class InMemoryProductService : IProductServices

    {
        private List<Product> _products;
        public InMemoryProductService()
        {
            _products = new List<Product>();
            GenerateFakeProducts();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();

        }
        public bool Update(Product product)
        {
            return false;
        }
        public bool Delete(String id)
        {
            return false;
        }
        public Product GetById(String id)
        {
            throw new NotImplementedException();

        }
        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }
        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            throw new NotImplementedException();

        }
        public bool Exists(string id)
        {
            throw new NotImplementedException();
        }

        private void GenerateFakeProducts()
        {
            _products.Clear();
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Laptop",
                Category = ProductCategoryEnum.Electronics,
                Price = 150000.00m,
                Stock = 20,
                Status = ProductStatusEnum.Active
            });
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "USB-C Cable",
                Category = ProductCategoryEnum.Electronics,
                Price = 1200m,
                Stock = 18,
                Status = ProductStatusEnum.Active
            });
        }
        private string GenerateId()
        {
            // e.g., P-1A2B3C
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }

    }
}
