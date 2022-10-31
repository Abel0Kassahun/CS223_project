using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBlue
{
    public partial class AddItemsForm : Form
    {
        string full_name;
        public AddItemsForm(string full_name)
        {
            InitializeComponent();
            this.full_name = full_name;

            bool Continue = true;
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query1 = " select full_name from restaurant_manager";
                using (MySqlCommand com = new MySqlCommand(query1, conn))
                {
                    using (MySqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read() && Continue)
                        {
                            if (full_name == reader.GetString("full_name"))
                            {
                                cardAddRestaurant.Hide();
                                Continue = false;
                            }
                            else
                            {
                                cardAddRestaurant.Show();
                            }
                        }
                    }
                }
            }
        }

        private void cardAddRestaurant_Click(object sender, EventArgs e)
        { 
            AddRestaurantForm addRestaurantForm1 = new AddRestaurantForm(full_name);
            addRestaurantForm1.ShowDialog();
        }

        private void cardAddOffering_Click(object sender, EventArgs e)
        {
            bool Continue = true;
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query1 = " select full_name from restaurant_manager";
                using (MySqlCommand com = new MySqlCommand(query1, conn))
                {
                    using(MySqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read() && Continue)
                        {
                            if(full_name == reader.GetString("full_name"))
                            {
                                AddOfferingForm addOfferingForm1 = new AddOfferingForm(full_name);
                                addOfferingForm1.Show();
                                Continue = false;
                            }
                        }
                    }
                }
            }
            if(Continue)
            {
                MessageBox.Show("Before you add an offering you must first add information about your restaurant");
            }
        }
    }
}
