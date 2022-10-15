using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBlue
{
    public partial class ManagerAccountForm : Form
    {
        string fullname;
        ManagerMainForm mmf;
        public ManagerAccountForm(string fullname, ManagerMainForm mmf)
        {
            InitializeComponent();
            this.fullname = fullname;
            this.mmf = mmf;
        }

        private void ManagerAccountForm_Load(object sender, EventArgs e)
        {
            lblFullName.Text = fullname;
            int rid;
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "select * from `user_info`";
                string query1 = "select * from `retaurant_manager`, `restaurant`";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (fullname == reader.GetString("full_name"))
                            {
                                lblUsername.Text = reader.GetString("username");
                                lblEmailAddress.Text = reader.GetString("email");
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
                            if (fullname == reader.GetString("full_name"))
                            {
                                rid = reader.GetInt32("rid");
                                if(rid == reader.GetInt32("restaurant_id"))
                                {
                                    lblPhoneNumber.Text = reader.GetString("phone_number");
                                }
                            }
                        }
                    }
                }

            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            mmf.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
