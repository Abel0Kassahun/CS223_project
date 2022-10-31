using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using ProjectBlue.Model_Classes;



namespace ProjectBlue
{
    public partial class ViewAddedItemsForm : KryptonForm
    {
        string fullname;
        string nameOfRestaurant;
        string link  = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        int id;
        public ViewAddedItemsForm(string fullname)
        {
            InitializeComponent();
            this.fullname = fullname;

            txtboxlocation.Hide();
            materialTextBox3.Hide();
            materialTextBox4.Hide();
            materialTextBox6.Hide();

            materialLabel4.Hide();
            materialLabel5.Hide();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewAddedItemsForm_Load(object sender, EventArgs e)
        { 
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query1 = " select * from restaurant, restaurant_manager where rid = restaurant_id";
                string query2 = "select * from offerings";
                using (MySqlCommand com = new MySqlCommand(query1, conn))
                {
                    using(MySqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (fullname == reader.GetString("full_name"))
                            {
                                id = reader.GetInt32("rid");
                                if (id == reader.GetInt32("restaurant_id"))
                                {
                                    nameOfRestaurant = reader.GetString("restaurant_name");
                                    materialLabel16.Text = reader.GetString("restaurant_name");
                                    materialLabel17.Text = reader.GetString("address");

                                    materialLabel18.Text = reader.GetString("phone_number");
                                    materialLabel21.Text = reader.GetString("service_options");
                                    materialLabel20.Text = reader.GetString("opening_and_closing_time");

                                    pictureBox1.Image = ConvertByteArrToImage((byte[])reader[4]);
                                    materialLabel3.Text = reader.GetString("restaurant_name");
                                    materialLabel2.Text = reader.GetString("address");
                                    materialLabel1.Text = reader.GetString("phone_number");
                                }
                            }
                        }
                    }
                }
            
                using (MySqlCommand com = new MySqlCommand(query2, conn))
                {
                    using (MySqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (id == reader.GetInt32("rid"))
                            {
                                OfferingCardLarge ofcl = new OfferingCardLarge();
                                ofcl.OfferingName = reader.GetString("offering_name");
                                ofcl.RestaurantName = nameOfRestaurant;
                                ofcl.OfferingType = reader.GetString("offering_type");
                                ofcl.OfferingImage = ConvertByteArrToImage((byte[])reader[3]);
                                flowLayoutPanel2.Controls.Add(ofcl);
                                ofcl.Click += new EventHandler(offeringCardLarge_Click);
                            }
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

        private void pictureBox7_Click(object sender, EventArgs e)//this method is for when the edit icon is clicked
        {
            materialLabel16.Hide();
            materialLabel17.Hide();
            materialLabel18.Hide();
            materialLabel21.Hide();
            materialLabel20.Hide();
            materialLabel6.Hide();
            pictureBox7.Hide();


            txtboxlocation.Show();
            materialTextBox3.Show();
            materialTextBox4.Show();
            materialTextBox6.Show();

            materialLabel4.Show();
            materialLabel5.Show();

            txtboxlocation.Text = materialLabel17.Text;
            materialTextBox3.Text = materialLabel18.Text;
            materialTextBox4.Text = materialLabel20.Text;
        }

        private void materialLabel4_Click(object sender, EventArgs e)//this method is for when the "Save" label is clicked
        {           
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtboxlocation.Text))
            {
                MessageBox.Show("Restaurant Address is required", "Error");
            }
            else if (string.IsNullOrEmpty(materialTextBox3.Text))
            {
                MessageBox.Show("Phone Number is required", "Error");
            }
            else if (string.IsNullOrEmpty(materialTextBox6.Text))
            {
                MessageBox.Show("Restaurant Address on map is required", "Error");
            }
            else
            {
                Regex[] reg = new Regex[3];
                reg[0] = new Regex(@"^[0]{1}[9]{1}[0-9]{8}");//for phone number
                reg[1] = new Regex(@"^[a-zA-z]+$");//for address


                if (!(reg[0].IsMatch(materialTextBox3.Text)))
                {
                    errorProvider1.SetError(materialTextBox3, "Invalid phone number format!,\n Correct phone number example: \"0921314151\"");
                }
                /*
                else if (!(reg[1].IsMatch(txtboxlocation.Text)))
                {
                    errorProvider1.SetError(txtboxlocation, "First letter should be an alphabet");
                }
                */
                else
                {
                    bool cool = true;
                    string restaurant_name;
                    string phone_number;
                    string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        string query = "select restaurant_name, phone_number from restaurant";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    phone_number = reader.GetString("phone_number");
                                    if (materialTextBox3.Text == phone_number)
                                    {
                                        MessageBox.Show("Phone number is already used on another restaurant, Try Again", "Error");
                                        cool = false;
                                    }
                                }
                            }
                        }
                    }
                    if (cool)
                    {
                        materialLabel4.Hide();
                        materialLabel5.Hide();

                        string query = "update restaurant\n" +
                                       "set address = @address, address_on_map = @link, phone_number = @phone_number, " +
                                       "opening_and_closing_time = @opening_and_closing_time \n" +
                                       "where restaurant_id = @id";
                        string path = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
                        using (MySqlConnection con = new MySqlConnection(path))
                        {
                            if (con.State == ConnectionState.Closed)
                                con.Open();
                            using (MySqlCommand comm = new MySqlCommand(query, con))
                            {
                                comm.Parameters.AddWithValue("@address",txtboxlocation.Text);
                                comm.Parameters.AddWithValue("@link",materialTextBox6.Text);
                                comm.Parameters.AddWithValue("@phone_number",materialTextBox3.Text);
                                comm.Parameters.AddWithValue("@id",id);
                                comm.Parameters.AddWithValue("@opening_and_closing_time", materialTextBox4.Text);

                                comm.ExecuteNonQuery();
                            }
                        }


                        materialLabel17.Text = txtboxlocation.Text;
                        materialLabel18.Text = materialTextBox3.Text;
                        materialLabel20.Text = materialTextBox4.Text;
                        link = materialTextBox6.Text;
                        materialLabel2.Text = txtboxlocation.Text;
                        materialLabel1.Text = materialTextBox3.Text;
                        //this.Refresh();

                        txtboxlocation.Hide();
                        materialTextBox3.Hide();
                        materialTextBox4.Hide();
                        materialTextBox6.Hide();

                        materialLabel16.Show();
                        materialLabel17.Show();
                        materialLabel18.Show();
                        materialLabel21.Show();
                        materialLabel20.Show();
                        materialLabel6.Show();

                        materialLabel4.Hide();
                        materialLabel5.Hide();
                        pictureBox7.Show();
                    }
                }
            }
        }

        private void materialLabel5_Click_1(object sender, EventArgs e)//this event is for when the cancel button is clicked
        {
            materialLabel16.Show();
            materialLabel17.Show();
            materialLabel18.Show();
            materialLabel21.Show();
            materialLabel20.Show();
            materialLabel6.Show();

            txtboxlocation.Hide();
            materialTextBox3.Hide();
            materialTextBox4.Hide();
            materialTextBox6.Hide();

            materialLabel4.Hide();
            materialLabel5.Hide();
            pictureBox7.Show();
        }
        private void materialLabel6_Click(object sender, EventArgs e)//when the "Map link" label is clicked
        {
            Process.Start(link);
        }

        private void offeringCardLarge_Click(object sender, EventArgs e)
        {
            OfferingCardLarge ofcm = (OfferingCardLarge)sender;
            OfferingDetailsForm odf = new OfferingDetailsForm(ofcm, this);
            odf.Show();
        }
    }
}
