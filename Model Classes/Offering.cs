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
    public class Offering
    {
        public int restaurant_id { get; set; }
        public byte[] Offering_image { get; set; }
        public string Offering_name { get; set; }
        public float Price { get; set; }
        public string ServiceOptions { get; set; }
        public string EWT { get; set; } // EWT - Estimated Waiting Time (dine-in & takeaway)
        public string ETA { get; set; } // ETA - Estimated Time of Arrival (delivery)
        public string offering_type { get; set; }
        public string CourseOfMeal { get; set; }
        public string Cuisine { get; set; }

        public void save()
        {
            string query = "insert into offerings(rid, offering_name, offering_image, price, offering_type, cuisine, course_of_meal, EWT, ETA, service_options) " +
                           "values(@rid, @offering_name, @offering_image, @price, @offering_type, @cuisine, @course_of_meal, @EWT, @ETA, @service_options)";
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rid", restaurant_id);
                    cmd.Parameters.AddWithValue("@offering_name", Offering_name);
                    cmd.Parameters.AddWithValue("@offering_image", Offering_image);
                    cmd.Parameters.AddWithValue("@price", Price);
                    cmd.Parameters.AddWithValue("@offering_type", offering_type);
                    cmd.Parameters.AddWithValue("@cuisine", Cuisine);
                    cmd.Parameters.AddWithValue("@course_of_meal", CourseOfMeal);
                    cmd.Parameters.AddWithValue("@EWT", EWT);
                    cmd.Parameters.AddWithValue("@ETA", ETA);
                    cmd.Parameters.AddWithValue("@service_options", ServiceOptions);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
