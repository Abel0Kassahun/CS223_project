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
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace ProjectBlue
{
    public partial class CustomerMainForm : MaterialForm
    {
        public CustomerMainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
            
        }
        private void CustomerMainForm_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "select * from test";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OfferingCardMedium ocm = new OfferingCardMedium();
                            ocm.OfferingName = reader.GetString("food_name");
                            ocm.OfferingPrice = reader.GetInt32("price");
                            ocm.RestaurantName = reader.GetString("restaurant");
                            flpMealOfTheDay.Controls.Add(ocm);
                        }
                    }
                }
            }
        }
        private void offeringCardMedium1_Click(object sender, EventArgs e)
        {
            OfferingCardMedium ocm = new OfferingCardMedium();
            materialLabel5.Text = ocm.OfferingName;
        }

        private void offeringCardMedium2_Click(object sender, EventArgs e)
        {

        }


    }
}
