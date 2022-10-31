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
        private string fullname;
        private byte[] image = null;
        private int rid;
        bool visible = false;
        bool visible2 = false;
        public AddOfferingForm(string fullname)
        {
            InitializeComponent();
            this.fullname = fullname;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey700, Accent.Blue700, TextShade.WHITE );
            
            materialLabel2.Hide();
            txtEWT.Hide();
            label3.Hide();

            materialLabel4.Hide();
            txtETA.Hide();
            label4.Hide();
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
            else if (image == null)
            {
                MessageBox.Show("Offering image is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Offering Price is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtEWT.Text) && visible)
            {
                MessageBox.Show("Estimated waiting time is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtETA.Text) && visible2)
            {
                MessageBox.Show("Estimated time of arrival is required", "Error");
            }

            else
            {
                Regex[] reg = new Regex[3];
                reg[0] = new Regex(@"^[A-Z]{1}[a-zA-Z ]+$");//for offering and restaurant name
                reg[1] = new Regex(@"^[0-9]+$");//for price, EWT and ETA

                if (!(reg[0].IsMatch(txtOfferingName.Text)))
                {
                    errorProvider1.SetError(txtOfferingName, "Incorrect Offering Name format!,\n Correct full name example: \"Happy Meal\"");
                }
                else if (!(reg[1].IsMatch(txtPrice.Text)))
                {
                    errorProvider1.SetError(txtPrice, "Invalid Price Format!");
                }
                else if (!(reg[1].IsMatch(txtEWT.Text)) && visible)
                {
                    errorProvider1.SetError(txtEWT, "Incorrect Estimated Waiting Time format!,\n Correct name example: \"45\"");
                }
                else if (!(reg[1].IsMatch(txtETA.Text)) && visible2)
                {
                    errorProvider1.SetError(txtETA, "Incorrect Estimated Time of Arrival format!,\n Correct name example: \"45\"");
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
                            string query = "select offering_name, offering_image from offerings";
                            string query1 = "select * from restaurant_manager";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        if (txtOfferingName.Text == reader.GetString("offering_name"))
                                        {
                                            MessageBox.Show("This offering already exists, Try Again", "Error");
                                            cool = false;
                                        }
                                        else if (image == reader[1])
                                        {
                                            MessageBox.Show("This image is already in use by another offering, Try Again", "Error");
                                            cool = false;
                                        }
                                    }
                                }
                            }
                            if (cool)
                            {
                                using (MySqlCommand cmd = new MySqlCommand(query1, conn))
                                {
                                    using (MySqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            if (fullname == reader.GetString("full_name"))
                                            {
                                                rid = reader.GetInt32("rid");
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
                            off.Price = float.Parse(txtPrice.Text);

                            var clicked = gbMealOfTheDay.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);
                            var clicked1 = gpCourseOfMeal.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);
                            var clicked2 = gpCuisine.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);
                            off.offering_type = clicked.Text;
                            off.CourseOfMeal = clicked1.Text;
                            off.Cuisine = clicked2.Text;

                            if (materialCheckbox1.Checked)
                            {
                                off.ServiceOptions = materialCheckbox1.Text;
                            }
                            else if (materialCheckbox2.Checked)
                            {
                                off.ServiceOptions += " " + materialCheckbox2.Text;
                            }
                            else if (materialCheckbox3.Checked)
                            {
                                off.ServiceOptions += " " + materialCheckbox3.Text;
                            }

                            if (visible)
                            {
                                off.EWT = txtEWT.Text;
                            }
                            else if (!visible)
                            {
                                off.EWT = null;
                            }


                            if (visible2)
                            {
                                off.ETA = txtETA.Text;
                            }
                            else if (!visible2)
                            {
                                off.ETA = null;
                            }

                            off.save();
                            MessageBox.Show("A New Offering Has Been Added", "Success");
                            this.Close();
                            AddOfferingForm aof = new AddOfferingForm(fullname);
                            aof.Show();            
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

        private void materialCheckbox1_Click(object sender, EventArgs e)
        {
            if (materialCheckbox1.Checked)
            {
                materialLabel2.Show();
                txtEWT.Show();
                label3.Show();
                visible = true;
            }
            else if (!(materialCheckbox1.Checked))
            {
                materialLabel2.Hide();
                txtEWT.Hide();
                label3.Hide();
                visible = false;
            }
        }
        private void materialCheckbox3_Click(object sender, EventArgs e)
        {
            if (materialCheckbox3.Checked)
            {
                materialLabel4.Show();
                txtETA.Show();
                label4.Show();
                visible2 = true;
            }
            else if (!(materialCheckbox3.Checked))
            {
                materialLabel4.Hide();
                txtETA.Hide();
                label4.Hide();
                visible2 = false;
            }
        }
    }
}
