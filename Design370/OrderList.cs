using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design370
{
    public class OrderList
    {
        public OrderList(int order_id, string name, DateTime orderDate, decimal orderToT, string oS)
        {
            getOrderID = order_id;
            getCustomerName = name;
            getOrderDate = orderDate;
            getOrderTotal = orderToT;
            getOrderStatus = oS;
        }

        public int getOrderID { get; set; }
        public string getCustomerName { get; set; }
        public DateTime getOrderDate { get; set; }
        public decimal getOrderTotal { get; set; }
        public string getOrderStatus { get; set; }
    }
}
