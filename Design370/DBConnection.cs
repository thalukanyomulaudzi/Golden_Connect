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
                string connstring = string.Format("Server=remotemysql.com; database={0}; UID=4d3dGYntTO; password=1nluzUaqm6", DatabaseName);
                //string connstring = string.Format("Server=localhost; database={0}; UID=root; password=", DatabaseName);
                Connection = new MySqlConnection(connstring);
                try
                {
                    Connection.Open();
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                }
            }

            return true;
        }
        public void Close()
        {
            Connection.Close();
        }

        public void Open()
        {
            Connection.Open();
        }

    }
}
