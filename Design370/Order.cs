using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design370
{
    class Order
    {
        private string OrderName;
        private int OrderQuantity;
        private string[] OrderImages;

        public Order() { }

        public Order(string name, int qty, string[] imgs)
        {
            OrderName = name;
            OrderQuantity = qty;
            OrderImages = imgs;
        }

        public string getOrderName
        {
            get
            {
                return OrderName;
            }

            set
            {
                OrderName = value;
            }
        }

        public int getOrderQuanity
        {
            get
            {
                return OrderQuantity;
            }

            set
            {
                OrderQuantity = value;
            }
        }

        public string[] getOrderImages
        {
            get
            {
                return OrderImages;
            }

            set
            {
                OrderImages = value;
            }
        }
    }
}
