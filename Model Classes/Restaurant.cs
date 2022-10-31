using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlue.Model_Classes
{
    public class Restaurant
    {
        public byte [] Restaurant_Image { get; set; }
        public string Restaurant_Name { get; set; }
        public string Address { get; set; }
        public string Address_OnMap { get; set; }
        public string PhoneNumber { get; set; }
        public string ServiceOptions { get; set; }
        public string WorkingHours { get; set; }

        public void save()
        {
            string query = "insert into restaurant(address,address_on_map,restaurant_name,restaurant_image,phone_number,opening_and_closing_time,service_options) " +
                           "values(@address,@address_on_map,@restaurant_name,@restaurant_image,@phone_number,@opening_and_closing_time,@service_options)";

            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@address", Address);
                    cmd.Parameters.AddWithValue("@address_on_map", Address_OnMap);
                    cmd.Parameters.AddWithValue("@restaurant_name", Restaurant_Name);
                    cmd.Parameters.AddWithValue("@restaurant_image", Restaurant_Image);
                    cmd.Parameters.AddWithValue("@phone_number", PhoneNumber);
                    cmd.Parameters.AddWithValue("@opening_and_closing_time", WorkingHours);
                    cmd.Parameters.AddWithValue("@service_options", ServiceOptions);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
