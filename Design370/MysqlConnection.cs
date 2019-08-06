using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Design370
{
    class MysqlConnection
    {
        public static string conn = "datasource=127.0.0.1;username=root;password=;database=golden_connect";
        MySqlConnection mysqlCon = new MySqlConnection(conn);
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
    }
}
