using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using ProjectBlue.Model_Classes;


namespace ProjectBlue
{
    public partial class AddRestaurantForm : KryptonForm
    {
        string filename;
        string fullname;
        byte[] image;
        int rid;
        public AddRestaurantForm(string fullname)
        {
            InitializeComponent();
            this.fullname = fullname;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbRestaurantImage_Click(object sender, EventArgs e)
        {
            // Let user choose and add image
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbRestaurantImage.Image = Image.FromFile(ofd.FileName);
                    filename = ofd.FileName;
                    image= ConvertImageToBytes(pbRestaurantImage.Image);
                }
            }
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtRestaurantName.Text))
            {
                MessageBox.Show("Restaurant name is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Restaurant Address is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Phone Number is required", "Error");
            }
            else
            {
                Regex[] reg = new Regex[2];
                reg[0] = new Regex(@"^[A-Z]{1}[a-z]+[ ]{1}[A-Z]{1}[a-z]+$");//for restaurant name 
                reg[1] = new Regex("[0]{1}[9]{1}[0-9]{8}");//for phone number


                if (!(reg[0].IsMatch(txtRestaurantName.Text)))
                {
                    errorProvider1.SetError(txtRestaurantName, "Incorrect Name format!,\n Correct full name example: \"Los pollos hermanos\"");
                }
                else if (!(reg[1].IsMatch(txtPhoneNumber.Text)))
                {
                    errorProvider1.SetError(txtPhoneNumber, "Invalid phone number format!,\n Correct phone number example: \"0921314151\"");
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
                        string query = "select `restaurant_name`, `restaurant_image`,`phone_number` from `restaurant`";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    restaurant_name = reader.GetString("restaurant_name");
                                    phone_number = reader.GetString("phone_number");
                                    if (txtRestaurantName.Text == restaurant_name)
                                    {
                                        MessageBox.Show("Restaurant name already exists, Try Again", "Error");
                                        cool = false;
                                    }
                                    else if (txtPhoneNumber.Text == phone_number)
                                    {
                                        MessageBox.Show("Phone number is already used on another restaurant, Try Again", "Error");
                                        cool = false;
                                    }
                                    else if (image == reader[1])
                                    {
                                        MessageBox.Show("This image is already used on another restaurant, Try Again", "Error");
                                        cool = false;
                                    }
                                }
                                if (cool)
                                {
                                    while (reader.Read())
                                    {
                                        if(txtRestaurantName.Text == reader.GetString("restaurant_name"))
                                        {
                                            rid = reader.GetInt32("restaurant_id");
                                        }
                                    }
                                }
                            }                            
                        }
                    }
                    if (cool)
                    { 
                        Restaurant res = new Restaurant();
                        res.Restaurant_Name = txtRestaurantName.Text;
                        res.Restaurant_Image = image;
                        res.Address = txtAddress.Text;
                        res.Address_OnMap = txtAddressOnMap.Text;
                        res.PhoneNumber = txtPhoneNumber.Text;
                        res.ServiceOptions = materialCheckbox1.Text + " " + materialCheckbox2.Text + " " + materialCheckbox3.Text;
                        res.WorkingHours = txtOpeningTime.Text + " - " + txtClosingTime.Text;
                        res.Address_OnMap = txtAddressOnMap.Text;
                        res.save();
                        string path = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
                        using (MySqlConnection conn = new MySqlConnection(path))
                        {
                            if (conn.State == ConnectionState.Closed)
                                conn.Open();
                            string query = "insert into restaurant_manager values(@full_name, @rid)";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@rid", rid);
                                cmd.Parameters.AddWithValue("@full_name", fullname);
                            }
                        }
                        this.Close();
                    }
                }
            }
        }
    }
}
