using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Design370
{
    class User
    {
        public static int AccessLevel { get; set; }
        public static string ID { get; set; }

        public static void login(string id, string pass)
        {
            //string newsalt = generateSalt();
            //MessageBox.Show(newsalt);
            //txtID.Text = byteArrayToString(hash(txtPassword.Text + newsalt));
            //return;
            try
            {
                string username = "", password = "", salt = "";
                int access = 0;

                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT u.username, u.password, u.salt, et.access_level " +
                    "FROM user u JOIN employee e ON u.employee_id = e.employee_id " +
                    "JOIN employee_type et ON e.employee_type = et.employee_type_id " +
                    "WHERE u.username = '" + id + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("That user ID is not valid");
                    reader.Close();
                    return;
                }
                while (reader.Read())
                {
                    username = reader.GetString(0);
                    password = reader.GetString(1);
                    salt = reader.GetString(2);
                    access = reader.GetInt32(3);
                }
                reader.Close();
                byte[] hashed = hash(pass + salt);
                if (byteArrayToString(hashed) == password)
                {
                    //login
                    AccessLevel = access;
                }
                else
                {
                    //dont login
                    MessageBox.Show("The password is incorrect");
                    return;
                }
                Login.ActiveForm.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static string generateSalt()
        {
            Random random = new Random();
            string salt = "";
            string hex = "0123456789abcdef";

            for (int i = 0; i < 10; i++)
                salt += hex.ElementAt(random.Next() % hex.Length);
            return salt;
        }

        public static byte[] hash(string input)
        {
            HashAlgorithm algorithm = SHA256.Create();
            //MessageBox.Show(byteArrayToString(algorithm.ComputeHash(Encoding.UTF8.GetBytes(input))));
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
        }

        public static string byteArrayToString(byte[] array)
        {
            StringBuilder hex = new StringBuilder(array.Length * 2);
            foreach (byte b in array)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public static void addUser(string user, string pass)
        {
            try
            {
                int id = 0;

                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT LAST_INSERT_ID()";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();

                string salt = generateSalt();
                byte[] passHash = hash(pass + salt);

                query = "INSERT INTO user (user_id, employee_id, username, password, salt) " +
                    "VALUES (NULL, '" + id + "', '" + user + "', '" + byteArrayToString(passHash) + "', '" + salt + "')";
                //MessageBox.Show(query);
                command = new MySqlCommand(query, dBCon.Connection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
