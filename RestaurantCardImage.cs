using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectBlue.Model_Classes;

namespace ProjectBlue
{
    public partial class RestaurantCardImage : UserControl
    {
        private string _restaurantName;

        public string RestaurantName
        {
            get { return _restaurantName; }
            set { _restaurantName = value; lblRestaurantName.Text = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; lblAddress.Text = value; }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; lblPhoneNumber.Text = value; }
        }

        public RestaurantCardImage()
        {
            InitializeComponent();
        }

        public RestaurantCardImage(Restaurant restaurant1)
        {
            InitializeComponent();

            RestaurantName = restaurant1.Name;
            Address = restaurant1.Address;
            PhoneNumber = restaurant1.PhoneNumber;
        }
    }
}
