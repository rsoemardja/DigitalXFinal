using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DigitalXData;

namespace DigitalXMVC.Models
{
    public class RowViewModels
    {
        public string Title { get; set; }
        public string SeeMore { get; set; }

        public List<ProductDTO> Products { get; set; }
    }
}