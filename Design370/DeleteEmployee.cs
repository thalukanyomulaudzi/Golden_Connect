using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Design370
{
    class DeleteEmployee
    {
        public long employeeID;
        DBConnection dB = DBConnection.Instance();
        public DeleteEmployee()
        {
            //employeeID = id;
        }

        public long getEmployeeID
        {
            get
            {
                return employeeID;
            }

            set
            {
                employeeID = value;
            }
        }

        public bool deleteEmployee()
        {
            if(dB.IsConnect())
            {
                string deleteEmp = "DELETE FROM `employee` WHERE `employee_idnumber` = '"+getEmployeeID+"'";
                var command = new MySqlCommand(deleteEmp, dB.Connection);
                command.ExecuteReader();
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
