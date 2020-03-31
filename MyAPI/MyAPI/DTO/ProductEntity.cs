using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.DTO
{
    public class ProductEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}