using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
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
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
        }

        private void llblGoToSignupForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SignupForm signupForm1 = new SignupForm();
            signupForm1.ShowDialog();
            //Close();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username field is required", "Error");
            }
            else if (string.IsNullOrEmpty(mtxtPassword.Text))
            {
                MessageBox.Show("Password field is required", "Error");
            }
            else
            {
                int found = 0;
                string account_type;
                string username;
                string password;
                string fullname;
                
                string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string query = "select account_type, full_name, username, _password from `user_info`; ";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                account_type = reader.GetString("account_type");
                                username = reader.GetString("username");
                                password = reader.GetString("_password");
                                fullname = reader.GetString("full_name");
                                if (username == txtUsername.Text)
                                {
                                    if (password == mtxtPassword.Text)
                                    {
                                        if (account_type == "Customer")
                                        {
                                            this.Hide();
                                            CustomerMainForm cmf = new CustomerMainForm(fullname);
                                            cmf.Show();
                                            //this.Close();
                                        }
                                        if (account_type == "Manager")
                                        {
                                            this.Hide();
                                            ManagerMainForm mmf = new ManagerMainForm(fullname);
                                            mmf.Show();
                                            //this.Close();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Password!!", "Error");
                                    }
                                    found++;
                                }
                            }
                            if(found == 0)
                            {
                                MessageBox.Show("Username not found!!","Error");
                            }
                        }
                    }
                }
            }
        }
    }
}