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
    public partial class SignupForm : KryptonForm
    {
        public SignupForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
        }

        private void llblGoToLoginForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            LoginForm loginForm1 = new LoginForm();
            loginForm1.ShowDialog();
            //Close();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Your Fullname is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                MessageBox.Show("Your Email Address is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("A Username is required", "Error");
            }
            else if (string.IsNullOrEmpty(mtxtPassword.Text))
            {
                MessageBox.Show("A Password is required", "Error");
            }
            else
            {
                Regex[] reg = new Regex[3];
                reg[0] = new Regex(@"^[A-Z]{1}[a-z]+[ ]{1}[A-Z]{1}[a-z]+$");//for fullname
                reg[1]= new Regex("^\\S+@\\S+\\.\\S+$");//for email
                reg[2] = new Regex(@"^[a-zA-Z]");//for username


                if (!(reg[0].IsMatch(txtFullName.Text)))
                {
                    errorProvider1.SetError(txtFullName, "Incorrect Name format!,\n Correct full name example: \"Julius Caesar\"");
                }
                else if (!(reg[1].IsMatch(txtEmailAddress.Text)))
                {
                    errorProvider1.SetError(txtEmailAddress, "Invalid email format!,\n Correct email example: \"example123@emailprovider.com\"");
                }
                else if (!(reg[2].IsMatch(txtUsername.Text)))
                {
                    errorProvider1.SetError(txtUsername, "First letter should be a letter");
                }
                else if (mtxtPassword.Text.Length < 6)
                {
                    errorProvider1.SetError(mtxtPassword, "Password too weak, must be atleast 6 characters");
                }
                else
                {
                    bool cool = true;
                    string email;
                    string username;
                    string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        string query = "select email, username from user_info ";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    email = reader.GetString("email");
                                    username = reader.GetString("username");
                                    if (txtEmailAddress.Text == email)
                                    {
                                        MessageBox.Show("Email already exists, Try Again", "Error");
                                        cool = false;
                                    }
                                    else if (txtUsername.Text == username)
                                    {
                                        MessageBox.Show("Username already exists, Try Loging In", "Error");
                                        cool = false;
                                    }
                                }
                            }
                        }
                    }
                    if (cool)
                    {
                        User usr = new User();
                        usr.AccountType = cbCustomer.Text;
                        usr.FullName = txtFullName.Text;
                        usr.EmailType = txtEmailAddress.Text;
                        usr.Username = txtUsername.Text;
                        usr.Password = mtxtPassword.Text;
                        usr.save();
                        if(cbCustomer.Text == "Customer")
                        {
                            this.Hide();
                            CustomerMainForm cmf = new CustomerMainForm();
                            cmf.Show();
                        }
                        else if(cbCustomer.Text == "Manager")
                        {
                            this.Hide();
                            ManagerMainForm mmf = new ManagerMainForm();
                            mmf.Show();
                        }
                    }
                }
            }
        }
    }
}
