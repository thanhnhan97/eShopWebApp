using System;
using System.Collections.Generic;
using System.Text;

namespace eShopeSolution.Data.Entities
{
    public class ProductInCategory
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }

    }
}
