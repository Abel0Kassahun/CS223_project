using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using ProjectBlue.Model_Classes;
using System.Configuration;
using System.IO;

namespace ProjectBlue
{
    public partial class OfferingDetailsForm : KryptonForm
    {
        private byte[] image;
        private  string offeringPrice;
        private int rid;
        private string fullname;
        public OfferingDetailsForm()
        {
            InitializeComponent();

        }
        public OfferingDetailsForm(OfferingCardMedium selected, string fullname)
        {
            //for CustomerMainForm
            InitializeComponent();
            this.fullname = fullname;
            pbEdit.Hide();
            lblSave.Hide();
            lblCancel.Hide();
            txtlabelFav.Show();
            txtlabelOrder.Show();
            
            materialLabel7.Text = selected.OfferingName;
        }

        public OfferingDetailsForm(OfferingCardLarge selected, Form vaf)
        {
            //for ViewAddedItemsForm
            InitializeComponent();
            pbEdit.Show();
            lblSave.Hide();
            lblCancel.Hide();
            txtlabelFav.Hide();
            txtlabelOrder.Hide();
            materialLabel7.Text = selected.OfferingName;
        }
        public OfferingDetailsForm(OfferingCardFav selected, string fullname)
        {
            //for the favourites tab
            InitializeComponent();
            this.fullname = fullname;

            pbEdit.Hide();
            lblSave.Hide();
            lblCancel.Hide();
            txtlabelFav.Hide();
            txtlabelOrder.Show();
            materialLabel7.Text = selected.OfferingName;
        }
        public OfferingDetailsForm(OfferingCardLarge selected, string fullname)
        {
            //for the order tab
            InitializeComponent();
            this.fullname = fullname;

            pbEdit.Hide();
            lblSave.Hide();
            lblCancel.Hide();
            txtlabelFav.Show();
            txtlabelOrder.Hide();
            materialLabel7.Text = selected.OfferingName;
        }

        private void OfferingDetailsForm_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "select * from offerings, restaurant";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (materialLabel7.Text == reader.GetString("offering_name"))
                            {
                                rid = reader.GetInt32("rid");
                                label7.Text = reader.GetString("offering_type");
                                label6.Text = reader.GetString("course_of_meal");
                                label5.Text = reader.GetString("cuisine");
                                materialLabel6.Text = reader.GetString("price") + " ETB";
                                materialLabel4.Text += reader.GetString("service_options");
                                materialLabel10.Text = reader.GetString("EWT");
                                materialLabel9.Text = reader.GetString("EAT");
                                pictureBox1.Image = ConvertByteArrToImage((byte[])reader[3]);
                                offeringPrice = reader.GetString("price");
                                image = (byte[])reader[3];
                            }
                        }
                        while (reader.Read())
                        {
                            if(reader.GetInt32("restaurant_id") == rid)
                                materialLabel5.Text = reader.GetString("restaurant_name");
                        }
                    }
                }
            }
        }
        private Image ConvertByteArrToImage(byte[] byteArr)
        {
            using (MemoryStream ms = new MemoryStream(byteArr))
            {
                return Image.FromStream(ms);
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            CustomerMainForm cmf = new CustomerMainForm(fullname);
            this.Close();
            cmf.Show();
        }

        private void txtlabelFav_Click(object sender, EventArgs e)
        {
            int id;
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "Select * from `favourites`";
                string query1 = "insert into `favourites` values(@full_name, @offering_name, @offering_image, @price)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (fullname == reader.GetString("full_name"))
                            {
                                if (materialLabel7.Text == reader.GetString("offering_name"))
                                {
                                    MessageBox.Show("This has already been set as favourite");
                                }
                                else
                                {
                                    using (MySqlCommand cmd1 = new MySqlCommand(query1, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@full_name", fullname);
                                        cmd.Parameters.AddWithValue("@offering_name", materialLabel7.Text);
                                        cmd.Parameters.AddWithValue("@offering_image", image);
                                        cmd.Parameters.AddWithValue("@price", offeringPrice);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void txtlabelOrder_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "select * from orders";
                string query1 = "insert into `orders` values(@full_name, @offering_name, @restaurant_name, @offering_image, @offering_type)";
                using (MySqlCommand cmd = new MySqlCommand(query1, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (fullname == reader.GetString("full_name"))
                            {
                                if (materialLabel7.Text == reader.GetString("offering_name"))
                                {
                                    MessageBox.Show("This has already been ordered");
                                }
                                else
                                {
                                    using (MySqlCommand cmd1 = new MySqlCommand(query1, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@full_name", fullname);
                                        cmd.Parameters.AddWithValue("@offering_name", materialLabel7.Text);
                                        cmd.Parameters.AddWithValue("@offering_image", image);
                                        cmd.Parameters.AddWithValue("@offering_type", label7.Text);
                                        cmd.Parameters.AddWithValue("@restaurant_name", materialLabel5.Text);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
