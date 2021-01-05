using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZenBD_API.Models;

namespace ZenBD_API.Repositories
{
    public class ProductRepository:Repository<Product>
    {
        public List<Product> GetAllLatest()
        {
            return this.GetAll().OrderByDescending(x => x.ProductId).ToList();
        }

        public List<Product> SearchByName(string SearchValue)
        {
            return this.context.Products.Where(x => x.ProductName.Contains(SearchValue) || SearchValue == null).ToList();
        }
        public List<Product> SearchByCategory(string SearchValue)
        {
            return this.context.Products.Where(x => x.Category.CategoryName.Contains(SearchValue) || SearchValue == null).ToList();
        }
        
    }
}