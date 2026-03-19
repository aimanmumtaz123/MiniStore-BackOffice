using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Contracts

{
    public interface IProductServices
    {
        public Product Add(Product product)
        {
            return product ;
        }
        

        public bool Update(Product product)
        {
            return true;
        }
       
        public bool Delete(String id)
        {
            return true;
        }

        public Product GetById(String id)
        {
            return null;
        }
       
        
        
        
        public List<Product> GetAll()
        {
            return new List<Product>();
        }
       
        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            return new List<Product>();
        }
        public bool Exists(string id)
        {
            return false;
        }


    }
    
}
