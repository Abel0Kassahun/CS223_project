using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;
using System.Data;

namespace ProjectBlue.Model_Classes
{
    public class User
    {
        static List<User> user = new List<User>();
        public string AccountType { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; } // should uniquely identify a user
        public string Email { get; set; }
        public string Password { get; set; }

        public void save()
        {
            string query = "insert into user_info(account_type,full_name,email,username,_password) " +
                           "values(@account_type,@fullname,@email,@username,@password)";
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@account_type", AccountType);
                    cmd.Parameters.AddWithValue("@fullname", FullName);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@password", Password);//this might be done by a a loop since its a char array
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<User> GetALLUserInfo()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "SELECT * FROM user_info";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User usr = new User();
                            usr.FullName = reader.GetString(reader.GetOrdinal("full_name"));
                            usr.AccountType = reader.GetString(reader.GetOrdinal("account_type"));
                            usr.Username = reader.GetString(reader.GetOrdinal("username"));
                            usr.Password = reader.GetString(reader.GetOrdinal("_password"));
                            usr.Email = reader.GetString(reader.GetOrdinal("email"));
                            user.Add(usr);     
                        }
                    }
                }
            }
            return user;
        }
    }
}
