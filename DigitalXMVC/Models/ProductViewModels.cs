using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DigitalXData;

namespace DigitalXMVC.Models
{
    public class ProductViewModels
    {
        public int RetailerID { get; set; }
        public int SubCategoryID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        public int UnitsInStock { get; set; }
        public string IsDiscontinued { get; set; }

        public List<Product> Products { get; set; }
    }
}