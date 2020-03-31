using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MyAPI.DTO;

namespace MyAPI.Controllers
{
    public class ProductsController : ApiController
    {
        List<ProductEntity> products = new List<ProductEntity>();
        public ProductsController()
        {
            GetSampleProducts();
        }
        public IEnumerable<ProductEntity>Get()
        {
            return products;
        }
        public ProductEntity Get(int id)
        {
            var product = products.FirstOrDefault(c=>c.ProductId == id);
            return product;
        }

        private void GetSampleProducts()
        {
            products.Add(new ProductEntity() { ProductId = 1, Name = "History", Description = "Sach Lich Su", Price = "23000" });
            products.Add(new ProductEntity() { ProductId = 2, Name = "English", Description = "Sach Anh Van", Price = "22000" });
            products.Add(new ProductEntity() { ProductId = 3, Name = "Science", Description = "Sach Khoa Hoc", Price = "21000" });
            products.Add(new ProductEntity() { ProductId = 4, Name = "Geography", Description = "Sach Dia Ly", Price = "20000" });
        }
    }
}