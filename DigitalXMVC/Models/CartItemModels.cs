using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DigitalXMVC.Models
{
    public class CartItemModels
    {
        [Key]
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}