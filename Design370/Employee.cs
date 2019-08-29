using MySql.Data.MySqlClient;

namespace Design370
{
    class Employee
    {
        public static short employeeID;

        public static short EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public static bool deleteEmployee()
        {
            DBConnection dB = DBConnection.Instance();
            if (dB.IsConnect())
            {
                string deleteEmp = "DELETE FROM `employee` WHERE `employee_idnumber` = '" + EmployeeID + "'";
                var command = new MySqlCommand(deleteEmp, dB.Connection);
                command.ExecuteReader();
                return true;
            }
            else
                return false;
        }
    }
}
