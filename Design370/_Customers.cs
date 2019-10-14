using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design370
{
    public class _Customers
    {
        //public _Customers() { }

        public _Customers(string fn, string ln, string em, string pn, string id)
        {
            customer_first = fn;
            customer_last = ln;
            customer_email = em;
            customer_phone = pn;
            customer_id_number = id;
        }

        public string customer_first { get; set; }
        public string customer_last { get; set; }
        public string customer_email { get; set; }
        public string customer_phone { get; set; }
        public string customer_id_number { get; set; }
    }
}
