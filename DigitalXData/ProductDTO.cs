using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalXData
{
    public class ProductDTO
    {
        public ProductDTO()
        {

        }
        public int ProductID { get; set; }
        public int RetailerID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public byte[] Picture { get; set; }
        public int CategoryID { get; set; }
        public int Category { get; set; }
        public virtual CategoryDTO ProductCategory { get; set; }

    }
}