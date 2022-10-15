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
using System.Text.RegularExpressions;

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
            //for CustomerMainForm home tab page
            InitializeComponent();
            this.fullname = fullname;
            pbEdit.Hide();
            lblSave.Hide();
            lblCancel.Hide();
            txtlabelFav.Show();
            txtlabelOrder.Show();
            
            lbloffering_name.Text = selected.OfferingName;
        }
        public OfferingDetailsForm(OfferingCardSmall selected, string fullname)
        {
            //for CustomerMainForm search tab page
            InitializeComponent();
            this.fullname = fullname;
            pbEdit.Hide();
            lblSave.Hide();
            lblCancel.Hide();
            txtlabelFav.Show();
            txtlabelOrder.Show();

            lbloffering_name.Text = selected.OfferingName;
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
            lbloffering_name.Text = selected.OfferingName;
        }
        public OfferingDetailsForm(OfferingCardFav selected, string fullname)
        {
            //for the favourites tab page
            InitializeComponent();
            this.fullname = fullname;

            pbEdit.Hide();
            lblSave.Hide();
            lblCancel.Hide();
            txtlabelFav.Hide();
            txtlabelOrder.Show();
            lbloffering_name.Text = selected.OfferingName;
        }
        public OfferingDetailsForm(OfferingCardLarge selected, string fullname)
        {
            //for the order tab page 
            InitializeComponent();
            this.fullname = fullname;

            pbEdit.Hide();
            lblSave.Hide();
            lblCancel.Hide();
            txtlabelFav.Show();
            txtlabelOrder.Hide();
            lbloffering_name.Text = selected.OfferingName;
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
                            if (lbloffering_name.Text == reader.GetString("offering_name"))
                            {
                                rid = reader.GetInt32("rid");
                                lblofferingType.Text = reader.GetString("offering_type");
                                lblcourse_of_meal.Text = reader.GetString("course_of_meal");
                                lblcousine.Text = reader.GetString("cuisine");
                                lblprice.Text = reader.GetString("price") + " ETB";
                                lblservice_options.Text += reader.GetString("service_options");
                                lblEWT.Text = reader.GetString("EWT");
                                lblETA.Text = reader.GetString("EAT");
                                pictureBox1.Image = ConvertByteArrToImage((byte[])reader[3]);
                                offeringPrice = reader.GetString("price");
                                image = (byte[])reader[3];
                            }
                        }
                        while (reader.Read())
                        {
                            if(reader.GetInt32("restaurant_id") == rid)
                                lblrestaurant_name.Text = reader.GetString("restaurant_name");
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
                                if (lbloffering_name.Text == reader.GetString("offering_name"))
                                {
                                    MessageBox.Show("This has already been set as favourite");
                                }
                                else
                                {
                                    using (MySqlCommand cmd1 = new MySqlCommand(query1, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@full_name", fullname);
                                        cmd.Parameters.AddWithValue("@offering_name", lbloffering_name.Text);
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
                                if (lbloffering_name.Text == reader.GetString("offering_name"))
                                {
                                    MessageBox.Show("This has already been ordered");
                                }
                                else
                                {
                                    using (MySqlCommand cmd1 = new MySqlCommand(query1, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@full_name", fullname);
                                        cmd.Parameters.AddWithValue("@offering_name", lbloffering_name.Text);
                                        cmd.Parameters.AddWithValue("@offering_image", image);
                                        cmd.Parameters.AddWithValue("@offering_type", lblofferingType.Text);
                                        cmd.Parameters.AddWithValue("@restaurant_name", lblrestaurant_name.Text);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            lblSave.Show();
            lblCancel.Show();

            lblofferingType.Hide();
            lblcourse_of_meal.Hide();
            lblcousine.Hide();
            lbloffering_name.Hide();
            lblprice.Hide();
            lblservice_options.Hide();
            lblEWT.Hide();
            lblETA.Hide();

            txtOfferingType.Show();
            txtCourseOfMeal.Show();
            txtCuisine.Show();
            txtOffering_name.Show();
            txtPrice.Show();
            txtServiceOptions.Show();
            txtEWT.Show();
            txtETA.Show();
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            string[] offering_type = new string[3];
            offering_type[0] = "Break Fast";
            offering_type[1] = "Lunch";
            offering_type[2] = "Dinner";
            string[] course_of_meal = new string[3];
            course_of_meal[0] = "Main";
            course_of_meal[1] = "Appetizer";
            course_of_meal[2] = "Desert";
            string[] couisine = new string[3];
            couisine[0] = "Ethiopian";
            couisine[1] = "American";
            couisine[2] = "Chinese";
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtOffering_name.Text))
            {
                MessageBox.Show("Offering name is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Offering Price is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtOfferingType.Text))
            {
                MessageBox.Show("Offering Type is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtCourseOfMeal.Text))
            {
                MessageBox.Show("Course of meal is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtCuisine.Text))
            {
                MessageBox.Show("Cuisine Type is required", "Error");
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

                if (!(reg[0].IsMatch(txtOffering_name.Text)))
                {
                    errorProvider1.SetError(txtOffering_name, "Incorrect Offering Name format!,\n Correct full name example: \"Happy Meal\"");
                }
                else if (!(reg[1].IsMatch(txtPrice.Text)))
                {
                    errorProvider1.SetError(txtPrice, "Invalid Price Format!,\n Correct phone number example: \"0921314151\"");
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
                    for(int i = 0 ; i < 3 ; i++)
                    {
                        if(txtOfferingType.Text != offering_type[i])
                        {
                            errorProvider1.SetError(txtOfferingType, "Incorrect Offering Type Name format!,\n Correct name example: \"Break Fast, Lunch or Dinenr\"");
                        }
                        else if (txtCourseOfMeal.Text != course_of_meal[i])
                        {
                            errorProvider1.SetError(txtCourseOfMeal, "Incorrect Course of Meal Name format!,\n Correct name example: \"Main, Appetizer, Desert\"");
                        }
                        else if (txtCuisine.Text != couisine[i])
                        {
                            errorProvider1.SetError(txtCuisine, "Incorrect Cuisine Name format!,\n Correct name example: \"Ethiopian, American or Chinese\"");
                        }
                    }
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
                        Offering off = new Offering();
                        off.Offering_image = image;
                        off.Offering_name = txtOffering_name.Text;
                        off.Price = int.Parse(txtPrice.Text);
                        off.ServiceOptions = txtServiceOptions.Text;
                        off.EWT = int.Parse(txtEWT.Text);
                        off.ETA = int.Parse(txtETA.Text);
                        off.offering_type = txtOfferingType.Text;
                        off.CourseOfMeal = txtCourseOfMeal.Text;
                        off.Cuisine = txtCuisine.Text;
                        off.save();

                        lblofferingType.Text = txtOfferingType.Text;
                        lblcourse_of_meal.Text = txtCourseOfMeal.Text;
                        lblcousine.Text = txtCuisine.Text;
                        lbloffering_name.Text = txtOffering_name.Text;
                        lblprice.Text = txtPrice.Text + " " + "ETB";
                        lblservice_options.Text = txtServiceOptions.Text;
                        lblEWT.Text = txtEWT.Text + " " + "min";
                        lblETA.Text = txtETA.Text + " " + "min";
                    }
                }
            }
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            lblCancel.Hide();
            lblSave.Hide();
            pbEdit.Hide();

            lblofferingType.Show();
            lblcourse_of_meal.Show();
            lblcousine.Show();
            lbloffering_name.Show();
            lblprice.Show();
            lblservice_options.Show();
            lblEWT.Show();
            lblETA.Show();

            txtOfferingType.Hide();
            txtCourseOfMeal.Hide();
            txtCuisine.Hide();
            txtOffering_name.Hide();
            txtPrice.Hide();
            txtServiceOptions.Hide();
            txtEWT.Hide();
            txtETA.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    image = ConvertImageToBytes(pictureBox1.Image);
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
