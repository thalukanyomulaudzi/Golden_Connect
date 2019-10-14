using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design370
{
    public class Customer_Order_Receipts
    {
        public Customer_Order_Receipts(string p, string unit, string q)
        {
            product_name = p;
            product_price = unit;
            order_line_quantity = q;
        }

        public string product_name { get; set; }
        public string product_price { get; set; }
        public string order_line_quantity { get; set; }
    }
}
