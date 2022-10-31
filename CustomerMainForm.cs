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
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace ProjectBlue
{
    public partial class CustomerMainForm : MaterialForm
    {
        string fullname;
        bool cool = false;
        string offering_name;
        public CustomerMainForm(string full_name)
        {
            InitializeComponent();
            this.fullname = full_name;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
            materialLabel9.Hide();
            materialTextBox22.Text = "" + materialSlider1.Value;
            materialButtonRefresh.Hide();
            /*
            flpAppetizers.Controls.Clear();
            flpChineseCuisine.Controls.Clear();
            flpAmericanCuisine.Controls.Clear();
            flpEthiopianCuisine.Controls.Clear();
            flpMealOfTheDay.Controls.Clear();
            flpEntrees.Controls.Clear();
            flpDesserts.Controls.Clear();
            */
        }
        private void CustomerMainForm_Load(object sender, EventArgs e)
        {
            string toBeServed = " ";
            DateTime now = DateTime.Now;
            if (now.Hour >= 6 && now.Hour < 12)
            {
                toBeServed = "Breakfast";
                materialLabel5.Text = "Good Morning";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                toBeServed = "Lunch";
                materialLabel5.Text = "Good Afternoon";
            }
            else if (now.Hour >= 18 && now.Hour < 24)
            {
                toBeServed = "Dinner";
                materialLabel5.Text = "Good Evening";
            }

            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "select * from offerings";
                string query1 = "select * from favourites";
                string query2 = "select * from orders";
                string query3 = "select * from user_info";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString("offering_type") == toBeServed)
                            {
                                OfferingCardMedium medium_card = new OfferingCardMedium();
                                LoadMediumCard(reader, medium_card);
                                flpMealOfTheDay.Controls.Add(medium_card);
                            }
                            if (reader.GetString("cuisine") == "Ethiopian")
                            {
                                OfferingCardMedium medium_card1 = new OfferingCardMedium();
                                LoadMediumCard(reader, medium_card1);
                                flpEthiopianCuisine.Controls.Add(medium_card1);
                            }
                            if (reader.GetString("cuisine") == "American")
                            {
                                OfferingCardMedium medium_card2 = new OfferingCardMedium();
                                LoadMediumCard(reader, medium_card2);
                                flpAmericanCuisine.Controls.Add(medium_card2);
                            }
                            if (reader.GetString("cuisine") == "Chinese")
                            {
                                OfferingCardMedium medium_card3 = new OfferingCardMedium();
                                LoadMediumCard(reader, medium_card3);
                                flpChineseCuisine.Controls.Add(medium_card3);
                            }
                            if (reader.GetString("course_of_meal") == "Entrée")
                            {
                                OfferingCardMedium medium_card4 = new OfferingCardMedium();
                                LoadMediumCard(reader, medium_card4);
                                flpEntrees.Controls.Add(medium_card4);
                            }
                            if (reader.GetString("course_of_meal") == "Dessert")
                            {
                                OfferingCardMedium medium_card5 = new OfferingCardMedium();
                                LoadMediumCard(reader, medium_card5);
                                flpDesserts.Controls.Add(medium_card5);
                            }
                            if (reader.GetString("course_of_meal") == "Appetizer")
                            {
                                OfferingCardMedium medium_card6 = new OfferingCardMedium();
                                LoadMediumCard(reader, medium_card6);
                                flpAppetizers.Controls.Add(medium_card6);
                            }
                        }
                    }
                }
                using (MySqlCommand cmd = new MySqlCommand(query1, conn))//this loades favourites in the favourites tab page
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OfferingCardFav ofav = new OfferingCardFav();
                            ofav.OfferingName = reader.GetString("offering_name");
                            ofav.OfferingPrice = reader.GetInt32("price");
                            ofav.OfferingImage = ConvertByteArrToImage((byte[])reader[2]);
                            flpFavorites.Controls.Add(ofav);
                            ofav.Click += new EventHandler(offeringCardFav_Click);//every loaded favourite offerings are subscribed here
                        }
                    }
                }
                using (MySqlCommand cmd = new MySqlCommand(query2, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OfferingCardLarge ofcl = new OfferingCardLarge();
                            ofcl.OfferingName = reader.GetString("offering_name");
                            ofcl.OfferingType = reader.GetString("offering_type");
                            ofcl.RestaurantName = reader.GetString("restaurant_name");
                            ofcl.OfferingImage = ConvertByteArrToImage((byte[])reader[3]);
                            flpCurrentOrders.Controls.Add(ofcl); ;
                            ofcl.Click += new EventHandler(offeringCardLarge_Click);//every ordered offerings are subscribed here
                        }
                    }
                }
                using (MySqlCommand cmd = new MySqlCommand(query3, conn))//Account Information is loaded here
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (fullname == reader.GetString("full_name"))
                            {
                                lblFullName.Text = reader.GetString("full_name");
                                lblUsername.Text = reader.GetString("username");
                                lblEmailAddress.Text = reader.GetString("email");
                            }
                        }
                    }
                }
            }
        }
        private void LoadMediumCard(MySqlDataReader reader, OfferingCardMedium medium_card)
        {
            medium_card.OfferingName = reader.GetString("offering_name");
            medium_card.OfferingPrice = reader.GetInt32("price");
            medium_card.OfferingType = reader.GetString("offering_type");
            medium_card.OfferingImage = ConvertByteArrToImage((byte[])reader[3]);
            medium_card.Click += new EventHandler(offeringCardMedium_Click);//every loaded offerings are subscribed here
        }
        private Image ConvertByteArrToImage(byte[] byteArr)
        {
            using (MemoryStream ms = new MemoryStream(byteArr))
            {
                return Image.FromStream(ms);
            }
        }

        private void offeringCardMedium_Click(object sender, EventArgs e)
        {
            OfferingCardMedium ofcm = (OfferingCardMedium)sender;
            OfferingDetailsForm odf = new OfferingDetailsForm(ofcm, fullname, new CustomerMainForm(fullname));
            odf.Show();
            Hide();
        }
        private void offeringCardFav_Click(object sender, EventArgs e)
        {
            OfferingCardFav ofav = (OfferingCardFav)sender;
            OfferingDetailsForm odf = new OfferingDetailsForm(ofav, fullname, new CustomerMainForm(fullname));
            odf.Show();
            Hide();
        }
        private void offeringCardLarge_Click(object sender, EventArgs e)
        {
            OfferingCardLarge ofcl = (OfferingCardLarge)sender;
            OfferingDetailsForm odf = new OfferingDetailsForm(ofcl, fullname, new CustomerMainForm(fullname));
            odf.Show();
            Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void materialTextBox21_KeyDown(object sender, KeyEventArgs e)
        {
            flpSearchResults.Controls.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                materialLabel9.Hide();
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(materialTextBox21.Text))
                {
                    MessageBox.Show("You haven't Entered an Offering Name to be Searched, Try Again", "Error");
                }
                else
                {
                    Regex reg = new Regex(@"^[A-Z]{1}[a-zA-Z ]+$");
                    if (!(reg.IsMatch(materialTextBox21.Text)))
                    {
                        errorProvider1.SetError(materialTextBox21, "Incorrect Offering Name format!,\n Correct full name example: \"Happy Meal\"");
                    }
                    else
                    {
                        bool notFound = true;
                        var item = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);

                        string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
                        using (MySqlConnection conn = new MySqlConnection(connString))
                        {
                            if (conn.State == ConnectionState.Closed)
                                conn.Open();
                            string query = "select * from offerings";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        if (materialTextBox21.Text == reader.GetString("offering_name"))
                                        {
                                            notFound = false;
                                            if (item != null)
                                            {
                                                if (item.Text == reader.GetString("offering_type"))
                                                {
                                                    if (materialTextBox22.Text == reader.GetString("price"))
                                                    {
                                                        save(reader);
                                                    }
                                                    else
                                                    {
                                                        save(reader);
                                                    }
                                                }
                                                else
                                                {
                                                    save(reader);
                                                }
                                            }
                                            else
                                            {
                                                if (materialTextBox22.Text == reader.GetString("price"))
                                                {
                                                    save(reader);
                                                }
                                                else
                                                {
                                                    save(reader);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (notFound)
                        {
                            materialLabel9.Show();
                            materialLabel9.ForeColor = System.Drawing.Color.Red;
                            materialLabel9.Text = "Search result not found";
                        }
                    }
                }
            }
        }
        
        private void save(MySqlDataReader reader)
        {
            OfferingCardSmall ofcs = new OfferingCardSmall();
            ofcs.OfferingName = reader.GetString("offering_name");
            offering_name = reader.GetString("offering_name");
            ofcs.OfferingPrice = reader.GetInt32("price");
            ofcs.OfferingImage = ConvertByteArrToImage((byte[])reader[3]);
            flpSearchResults.Controls.Add(ofcs);
            ofcs.Click += new EventHandler(offeringCardSmall_Click);
        }
        
        private void offeringCardSmall_Click(object sender, EventArgs e)
        {
            OfferingCardSmall ofcs = (OfferingCardSmall)sender;
            OfferingDetailsForm odf = new OfferingDetailsForm(ofcs, fullname, new CustomerMainForm(fullname));
            odf.Show();
            Hide();
        }
        private void materialSlider1_onValueChanged(object sender, int newValue)
        {
            materialTextBox22.Text = ""+materialSlider1.Value;
        }

        private void searchbyFilterOnly_Click(object sender, EventArgs e)
        {
            flpSearchResults.Controls.Clear();

            if (searchbyFilterOnly.Text == "Back")
            {
                materialButtonRefresh.Hide();
                searchbyFilterOnly.Text = "Search by filter only";
                materialTextBox21.Show();
            }
            else
            {
                materialButtonRefresh.Show();
                searchbyFilterOnly.Text = "Back";

                materialTextBox21.Hide();
            }
        }

        private void materialButtonRefresh_Click(object sender, EventArgs e)
        {
            flpSearchResults.Controls.Clear();

            var item = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "select * from offerings";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (item != null)
                            {
                                if (item.Text == reader.GetString("offering_type"))
                                {
                                    if (materialTextBox22.Text == reader.GetString("price"))
                                    {
                                        save(reader);
                                    }
                                    else
                                    {
                                        save(reader);
                                    }
                                }
                            }
                            if (materialTextBox22.Text == reader.GetString("price"))
                            {
                                save(reader);
                            }
                        }
                    }
                }
            }
        }

        private void materialTextBox22_KeyDown(object sender, KeyEventArgs e)// Whenever we enter a price value in the price textbox, we wold also want the price slider to change accordingly 
        {
            if (e.KeyCode == Keys.Enter)
            {
                materialSlider1.Value = int.Parse(materialTextBox22.Text);
            }
        }
    }
}
