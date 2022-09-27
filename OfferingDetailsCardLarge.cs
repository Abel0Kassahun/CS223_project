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
    public partial class OfferingDetailsCardLarge : UserControl
    {
        private string _offeringName;

        public string OfferingName
        {
            get { return _offeringName; }
            set { _offeringName = value; lblOfferingName.Text = value; }
        }

        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value.ToString() + " ETB"; }
        }

        private string _restaurantName;

        public string RestaurantName
        {
            get { return _restaurantName; }
            set { _restaurantName = value; lblRestaurantName.Text = value; }
        }

        private string _serviceOptions;

        public string ServiceOptions
        {
            get { return _serviceOptions; }
            set { _serviceOptions = value; lblServiceOptions.Text = value; }
        }

        private int _ewt;

        public int EWT
        {
            get { return _ewt; }
            set { _ewt = value; lblEWT.Text = value.ToString() + " min"; }
        }

        private int _eta;

        public int ETA
        {
            get { return _eta; }
            set { _eta = value; lblETA.Text = value.ToString() + " min"; }
        }

        public OfferingDetailsCardLarge()
        {
            InitializeComponent();
        }

        public OfferingDetailsCardLarge(Offering offering1)
        {
            InitializeComponent();

            OfferingName = offering1.Name;
            Price = offering1.Price;
            RestaurantName = offering1.Restaurant.Name;
            ServiceOptions = offering1.ServiceOptions;
            EWT = offering1.EWT;
            ETA = offering1.ETA;
        }
    }
}
