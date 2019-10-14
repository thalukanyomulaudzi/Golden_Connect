using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design370
{
    public class ProductsOnHand
    {
        public ProductsOnHand(string n, int q)
        {
            product_name = n;
            product_stock_quantity = q;
        }
        public string product_name { get; set; }
        public int product_stock_quantity { get; set; }
    }
}
