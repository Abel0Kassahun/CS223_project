using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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
        string fullname;
        public CustomerMainForm(string full_name)
        {
            InitializeComponent();
            this.fullname = full_name;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
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
                            if (reader.GetString("course_of_meal") == "Entree")
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
                using (MySqlCommand cmd = new MySqlCommand(query1, conn))
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
                            lblFullName.Text = reader.GetString("full_name");
                            lblUsername.Text = reader.GetString("username");
                            lblEmailAddress.Text = reader.GetString("email");
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
            OfferingDetailsForm odf = new OfferingDetailsForm(ofcm, fullname);
            this.Hide();
            odf.Show();
        }
        private void offeringCardFav_Click(object sender, EventArgs e)
        {
            OfferingCardFav ofav = (OfferingCardFav)sender;
            OfferingDetailsForm odf = new OfferingDetailsForm(ofav, fullname);
            this.Hide();
            odf.Show();
        }
        private void offeringCardLarge_Click(object sender, EventArgs e)
        {
            OfferingCardLarge ofcl = (OfferingCardLarge)sender;
            OfferingDetailsForm odf = new OfferingDetailsForm(ofcl, fullname);
            this.Hide();
            odf.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
        /*
         *                  if (reader.GetString("offering_type") == toBeServed)
                            {
                                OfferingCardMedium medium_card = new OfferingCardMedium();
                                medium_card.OfferingName = reader.GetString("offering_name");
                                medium_card.OfferingPrice = reader.GetInt32("price");
                                medium_card.OfferingType = reader.GetString("offering_type");
                                medium_card.OfferingImage = ConvertByteArrToImage((byte[])reader[3]);
                                flpMealOfTheDay.Controls.Add(medium_card);
                                medium_card.Click += new EventHandler(offeringCardMedium_Click);//every loaded offerings are subscribed here
                            }
                            if (reader.GetString("cuisine") == "Ethiopian")
                            {
                                OfferingCardMedium medium_card1 = new OfferingCardMedium();
                                medium_card1.OfferingName = reader.GetString("offering_name");
                                medium_card1.OfferingPrice = reader.GetInt32("price");
                                medium_card1.OfferingType = reader.GetString("offering_type");
                                medium_card1.OfferingImage = ConvertByteArrToImage((byte[])reader[3]);
                                flpEthiopianCuisine.Controls.Add(medium_card1);
                                medium_card1.Click += new EventHandler(offeringCardMedium_Click);//every loaded offerings are subscribed here
                            }
                            if (reader.GetString("cuisine") == "American")
                            {
                                OfferingCardMedium medium_card2 = new OfferingCardMedium();
                                medium_card2.OfferingName = reader.GetString("offering_name");
                                medium_card2.OfferingPrice = reader.GetInt32("price");
                                medium_card2.OfferingType = reader.GetString("offering_type");
                                medium_card2.OfferingImage = ConvertByteArrToImage((byte[])reader[3]);
                                flpAmericanCuisine.Controls.Add(medium_card2);
                                medium_card2.Click += new EventHandler(offeringCardMedium_Click);//every loaded offerings are subscribed here
                            }
                            if (reader.GetString("cuisine") == "Chinese")
                            {
                                OfferingCardMedium medium_card3 = new OfferingCardMedium();
                                medium_card3.OfferingName = reader.GetString("offering_name");
                                medium_card3.OfferingPrice = reader.GetInt32("price");
                                medium_card3.OfferingType = reader.GetString("offering_type");
                                medium_card3.OfferingImage = ConvertByteArrToImage((byte[])reader[3]);
                                flpChineseCuisine.Controls.Add(medium_card3);
                                medium_card3.Click += new EventHandler(offeringCardMedium_Click);//every loaded offerings are subscribed here
                            }
                            if (reader.GetString("course_of_meal") == "Entree")
                            {
                                OfferingCardMedium medium_card4 = new OfferingCardMedium();
                                medium_card4.OfferingName = reader.GetString("offering_name");
                                medium_card4.OfferingPrice = reader.GetInt32("price");
                                medium_card4.OfferingType = reader.GetString("offering_type");
                                medium_card4.OfferingImage = ConvertByteArrToImage((byte[])reader[3]);
                                flpEntrees.Controls.Add(medium_card4);
                                medium_card4.Click += new EventHandler(offeringCardMedium_Click);//every loaded offerings are subscribed here
                            }
                            if (reader.GetString("course_of_meal") == "Dessert")
                            {
                                OfferingCardMedium medium_card5 = new OfferingCardMedium();
                                medium_card5.OfferingName = reader.GetString("offering_name");
                                medium_card5.OfferingPrice = reader.GetInt32("price");
                                medium_card5.OfferingType = reader.GetString("offering_type");
                                medium_card5.OfferingImage = ConvertByteArrToImage((byte[])reader[3]);
                                flpDesserts.Controls.Add(medium_card5);
                                medium_card5.Click += new EventHandler(offeringCardMedium_Click);//every loaded offerings are subscribed here
                            }
                            if (reader.GetString("course_of_meal") == "Appetizer")
                            {
                                OfferingCardMedium medium_card6 = new OfferingCardMedium();
                                medium_card6.OfferingName = reader.GetString("offering_name");
                                medium_card6.OfferingPrice = reader.GetInt32("price");
                                medium_card6.OfferingType = reader.GetString("offering_type");
                                medium_card6.OfferingImage = ConvertByteArrToImage((byte[])reader[3]);
                                flpAppetizers.Controls.Add(medium_card6);
                                medium_card6.Click += new EventHandler(offeringCardMedium_Click);//every loaded offerings are subscribed here
                            }
         * */
    }
}
