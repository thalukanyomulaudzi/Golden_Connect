using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Design370
{
    class DBConnection
    {
        private DBConnection()
        {
        }

        public string DatabaseName { get; set; } = string.Empty;

        public string Password { get; set; }
        public MySqlConnection Connection { get; private set; } = null;

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(DatabaseName))
                    return false;
                string connstring = string.Format("Server=localhost; database={0}; UID=UserName; password=your password", DatabaseName);
                Connection = new MySqlConnection(connstring);
                Connection.Open();
            }

            return true;
        }

    }
}
