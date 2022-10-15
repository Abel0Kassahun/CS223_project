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
    public partial class AddOfferingForm : KryptonForm
    {
        private byte[] image;
        private int rid;
        public AddOfferingForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey700, Accent.Blue700, TextShade.WHITE );
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtOfferingName.Text))
            {
                MessageBox.Show("Offering name is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Offering Price is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtRestaurantName.Text))
            {
                MessageBox.Show("Restaurant name is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtEWT.Text))
            {
                MessageBox.Show("Estimated waiting time is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtETA.Text))
            {
                MessageBox.Show("Estimated time of arrival is required", "Error");
            }
            else
            {
                Regex[] reg = new Regex[3];
                reg[0] = new Regex(@"^[A-Z]{1}[a-z]+[ ]{1}[A-Z]{1}[a-z]+$");//for offering and restaurant name
                reg[1] = new Regex(@"[1-9]{1}[0-9]+$");//for price, EWT and ETA

                if (!(reg[0].IsMatch(txtOfferingName.Text)))
                {
                    errorProvider1.SetError(txtOfferingName, "Incorrect Offering Name format!,\n Correct full name example: \"Happy Meal\"");
                }
                else if (!(reg[1].IsMatch(txtPrice.Text)))
                {
                    errorProvider1.SetError(txtPrice, "Invalid Price Format!,\n Correct phone number example: \"0921314151\"");
                }
                else if (!(reg[0].IsMatch(txtRestaurantName.Text)))
                {
                    errorProvider1.SetError(txtRestaurantName, "Incorrect Restaurant Name format!,\n Correct name example: \"Burger King\"");
                }
                else if (reg[1].IsMatch(txtEWT.Text))
                {
                    errorProvider1.SetError(txtEWT, "Incorrect Estimated Waiting Time format!,\n Correct name example: \"45\"");
                }
                else if (reg[1].IsMatch(txtETA.Text))
                {
                    errorProvider1.SetError(txtETA, "Incorrect Estimated Time of Arrival format!,\n Correct name example: \"45\"");
                }
                else
                {
                    if (int.Parse(txtEWT.Text) > 59 && int.Parse(txtEWT.Text) <= 0)
                    {
                        MessageBox.Show("Estimated waiting time is supposed to be between 0 and 60 min", "Error");
                    }
                    else if (int.Parse(txtETA.Text) > 59 && int.Parse(txtETA.Text) <= 0)
                    {
                        MessageBox.Show("Estimated time of arrival is supposed to be between 0 and 60 min", "Error");
                    }
                    else
                    {
                        var item = gbMealOfTheDay.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);
                        var item2 = gpCourseOfMeal.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);
                        var item3 = gpCuisine.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);

                        if (item == null)
                        {
                            MessageBox.Show("You must choose what type of meal the offering is ", "Error");
                        }
                        else if (item2 == null)
                        {
                            MessageBox.Show("You must choose what course of meal the offering is ", "Error");
                        }
                        else if (item3 == null)
                        {
                            MessageBox.Show("You must choose what type of cousine the offering is ", "Error");
                        }
                        else
                        {
                            bool cool = true;
                            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
                            using (MySqlConnection conn = new MySqlConnection(connString))
                            {
                                if (conn.State == ConnectionState.Closed)
                                    conn.Open();
                                string query = "select `restaurant_name`, `offering_name`,`offering_image` from `restaurant`, `offerings`";
                                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                {
                                    using (MySqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            if (txtOfferingName.Text == reader.GetString("offering_name"))
                                            {
                                                if (txtRestaurantName.Text == reader.GetString("restaurant_name"))
                                                {
                                                    MessageBox.Show("This offering already exists in this restaurant, Try Again", "Error");
                                                    cool = false;
                                                }
                                            }
                                            else if (image == reader[2])
                                            {
                                                MessageBox.Show("This image is already used on another restaurant, Try Again", "Error");
                                                cool = false;
                                            }
                                            else if (cool)
                                            {
                                                if (txtRestaurantName.Text == reader.GetString("restaurant_name"))
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
                                Offering off = new Offering();
                                off.restaurant_id = rid;
                                off.Offering_image = image;
                                off.Offering_name = txtOfferingName.Text;
                                off.Price = int.Parse(txtPrice.Text);
                                off.ServiceOptions = materialCheckbox1.Text + " " + materialCheckbox2.Text + " " + materialCheckbox3.Text;
                                off.EWT = int.Parse(txtEWT.Text);
                                off.ETA = int.Parse(txtETA.Text);
                                var clicked = gbMealOfTheDay.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);
                                var clicked1 = gpCourseOfMeal.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);
                                var clicked2 = gpCuisine.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);
                                off.offering_type = clicked.Text;
                                off.CourseOfMeal = clicked1.Text;
                                off.Cuisine = clicked2.Text;
                                off.save();
                            }
                        }
                    }
                    
                }
            }
        }

        private void pbOfferingImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbOfferingImage.Image = Image.FromFile(ofd.FileName);
                    image = ConvertImageToBytes(pbOfferingImage.Image);
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
    }
}
