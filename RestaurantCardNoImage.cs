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
    public partial class RestaurantCardNoImage : UserControl
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

        private string _serviceOptions;

        public string ServiceOptions
        {
            get { return _serviceOptions; }
            set { _serviceOptions = value; lblServiceOptions.Text = value; }
        }

        private string _workingHours;

        public string WorkingHours
        {
            get { return _workingHours; }
            set { _workingHours = value; lblWorkingHours.Text = value; }
        }

        public RestaurantCardNoImage()
        {
            InitializeComponent();
        }

        public RestaurantCardNoImage(Restaurant restaurant1)
        {
            InitializeComponent();

            RestaurantName = restaurant1.Name;
            Address = restaurant1.Address;
            PhoneNumber = restaurant1.Address;
            ServiceOptions = restaurant1.ServiceOptions;
            WorkingHours = restaurant1.WorkingHours;
        }
    }
}
