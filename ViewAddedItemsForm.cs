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


// Reminder to add an edit option on the offerings(cousines) and make them editable and the editing form that pops when the edit option is selected is the infamous OfferingDetailsForm.cs
// Reminder to completely change the database
// Reminder to add a couple of conditions to whatever the user (in this case the restaurant manager) inputs when trying to edit previous information about the restaurant or the offerings they offer 

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

            materialTextBox1.Hide();
            materialTextBox2.Hide();
            materialTextBox3.Hide();
            materialTextBox5.Hide();
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
                string query1 = " select * from restaurant, restaurant_manager";
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


            materialTextBox1.Show();
            materialTextBox2.Show();
            materialTextBox3.Show();
            materialTextBox5.Show();
            materialTextBox4.Show();
            materialTextBox6.Show();

            materialLabel4.Show();
            materialLabel5.Show();

            materialTextBox1.Text = materialLabel16.Text;
            materialTextBox2.Text = materialLabel17.Text;
            materialTextBox3.Text = materialLabel18.Text;
            materialTextBox5.Text = materialLabel21.Text;
            materialTextBox4.Text = materialLabel20.Text;
        }

        private void materialLabel4_Click(object sender, EventArgs e)//this method is for when the "Save" label is clicked
        {
            //Reminder to put a code to check whatever the user inputs is valid or not use regex and error providers ----------------done
            //The code below is supposed to be in a final else when the rest of the conditions is verified           ----------------done
            
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(materialTextBox1.Text))
            {
                MessageBox.Show("Restaurant name is required", "Error");
            }
            else if (string.IsNullOrEmpty(materialTextBox2.Text))
            {
                MessageBox.Show("Restaurant Address is required", "Error");
            }
            else if (string.IsNullOrEmpty(materialTextBox3.Text))
            {
                MessageBox.Show("Phone Number is required", "Error");
            }
            else
            {
                Regex[] reg = new Regex[3];
                reg[0] = new Regex(@"^[A-Z]{1}[a-z]+[ ]{1}[A-Z]{1}[a-z]+$");//for restaurant name 
                reg[1] = new Regex("[0]{1}[9]{1}[0-9]{8}");//for phone number
                reg[2] = new Regex(@"[A-Z]{1}$");//for address


                if (!(reg[0].IsMatch(materialTextBox1.Text)))
                {
                    errorProvider1.SetError(materialTextBox1, "Incorrect Name format!,\n Correct full name example: \"Los pollos hermanos\"");
                }
                else if (!(reg[1].IsMatch(materialTextBox3.Text)))
                {
                    errorProvider1.SetError(materialTextBox3, "Invalid phone number format!,\n Correct phone number example: \"0921314151\"");
                }
                else if (!(reg[2].IsMatch(materialTextBox2.Text)))
                {
                    errorProvider1.SetError(materialTextBox2, "First letter should be an alphabet");
                }
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
                        string query = "select `restaurant_name`, `phone_number` from `restaurant`";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    restaurant_name = reader.GetString("restaurant_name");
                                    phone_number = reader.GetString("phone_number");
                                    if (materialTextBox1.Text == restaurant_name)
                                    {
                                        MessageBox.Show("Restaurant name already exists, Try Again", "Error");
                                        cool = false;
                                    }
                                    else if (materialTextBox3.Text == phone_number)
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

                        Restaurant res = new Restaurant();
                        res.Restaurant_Name = materialTextBox1.Text;
                        res.Address = materialTextBox2.Text;
                        res.Address_OnMap = materialTextBox6.Text;
                        res.PhoneNumber = materialTextBox3.Text;
                        res.ServiceOptions = materialTextBox5.Text;
                        res.WorkingHours = materialTextBox4.Text;
                        res.Address_OnMap = materialTextBox6.Text;
                        res.save();

                        materialLabel16.Text = materialTextBox1.Text;
                        materialLabel17.Text = materialTextBox2.Text;
                        materialLabel18.Text = materialTextBox3.Text;
                        materialLabel21.Text = materialTextBox5.Text;
                        materialLabel20.Text = materialTextBox4.Text;
                        link = materialTextBox6.Text;
                    }

                }
                materialTextBox1.Hide();
                materialTextBox2.Hide();
                materialTextBox3.Hide();
                materialTextBox5.Hide();
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

        private void materialLabel5_Click_1(object sender, EventArgs e)
        {
            materialLabel16.Show();
            materialLabel17.Show();
            materialLabel18.Show();
            materialLabel21.Show();
            materialLabel20.Show();
            materialLabel6.Show();

            materialTextBox1.Hide();
            materialTextBox2.Hide();
            materialTextBox3.Hide();
            materialTextBox5.Hide();
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
            this.Hide();
            odf.Show();
        }
    }
}
