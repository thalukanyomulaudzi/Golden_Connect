using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design370
{
    public class Globals
    {
        //Supplier
        private static string mSupplierID = "";
        private static string mSupplierName="";
        private static string mSupplierEmail="";
        private static string mSupplierPhone="";

        //Product
        private static string mProductID = "";
        private static string mProductName = "";
        private static int mProductQuantity = 0;
        private static string mProductTypeName = "";

        //Supplier
        public static string SupplierID
        {
            get { return mSupplierID; }
            set { mSupplierID = value; }
        }
        public static string SupplierName
        {
            get { return mSupplierName;}
            set { mSupplierName = value; }
        }
    
        public static string SupplierEmail
        {
            get { return mSupplierEmail; }
            set { mSupplierEmail = value; }
        }
       
        public static string SupplierPhone
        {
            get { return mSupplierPhone; }
            set { mSupplierPhone = value; }
        }

        //Product
        public static string ProductID
        {
            get { return mProductID; }
            set { mProductID = value; }
        }

        public static string ProductName
        {
            get { return mProductName; }
            set { mProductName = value; }
        }

        public static int ProductQuantity
        {
            get { return mProductQuantity; }
            set { mProductQuantity = value; }
        }
        public static string ProductTypeName
        {
            get { return mProductTypeName; }
            set { mProductTypeName = value; }
        }

    }
}
