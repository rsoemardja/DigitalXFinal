using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalXData
{
    public class CategoryDTO
    {

        public int CategoryID { get; set; }
        public string Category { get; set; }
        public int ParentCategory { get; set; }

    }
}
