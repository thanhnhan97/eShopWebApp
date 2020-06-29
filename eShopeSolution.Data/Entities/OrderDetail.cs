using System;
using System.Collections.Generic;
using System.Text;

namespace eShopeSolution.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        //Quan hệ 1 - many
        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
