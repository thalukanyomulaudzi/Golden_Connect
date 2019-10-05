using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Design370
{
    class User
    {
        public static int AccessLevel { get; set; } = -1;
        public static int ID { get; set; } = -1;
        public static string Name { get; set; } = "";

        public static void login(string user, string pass)
        {
            //string newsalt = generateSalt();
            //MessageBox.Show(byteArrayToString(hash(pass + newsalt)) + "," + newsalt);
            //File.WriteAllText("hash.txt", byteArrayToString(hash(pass + newsalt)) + "," + newsalt);
            //return;
            try
            {
                string username = "", password = "", salt = "", name = "";
                int access = 0, id = -1;

                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT u.username, u.password, u.salt, et.access_level, e.employee_id, e.employee_first, e.employee_last " +
                    "FROM user u JOIN employee e ON u.employee_id = e.employee_id " +
                    "JOIN employee_type et ON e.employee_type = et.employee_type_id " +
                    "WHERE u.username = '" + user + "'";
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
                    id = reader.GetInt32(4);
                    name += reader.GetString(6) + ", " + reader.GetString(5);
                }
                reader.Close();
                byte[] hashed = hash(pass + salt);
                if (byteArrayToString(hashed) == password)
                {
                    //login
                    AccessLevel = access;
                    ID = id;
                    Name = name;
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

        public static void logout()
        {
            ID = -1;
            AccessLevel = -1;
        }

        public static uint lastInputTime()
        {
            return GetLastInputTime();
        }



        [DllImport("user32.dll")]
        public static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
        public static uint GetLastInputTime()
        {
            uint idleTime = 0;
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo);
            lastInputInfo.dwTime = 0;

            uint envTicks = (uint)Environment.TickCount;

            if (GetLastInputInfo(ref lastInputInfo))
            {
                uint lastInputTick = lastInputInfo.dwTime;
                idleTime = envTicks - lastInputTick;
            }
            return ((idleTime > 0) ? (idleTime / 1000) : 0);
        }
    }
    struct LASTINPUTINFO
    {
        public static readonly int SizeOf = Marshal.SizeOf(typeof(LASTINPUTINFO));

        public uint cbSize;
        public uint dwTime;
    }
}
