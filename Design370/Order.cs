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
        private int productID;
        private long orderID;

        public Order() { }

        public Order(string name, int qty, string[] imgs, int productID, long orderID)
        {
            OrderName = name;
            OrderQuantity = qty;
            OrderImages = imgs;
            this.productID = productID;
            this.orderID = orderID;
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

        public int getProductID
        {
            get
            {
                return productID;
            }

            set
            {
                productID = value;
            }
        }

        public long getOrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                orderID = value;
            }
        }
    }
}
