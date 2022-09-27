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
    public partial class OfferingCardMedium : UserControl
    {
        private Image _offeringImage;
        public Image OfferingImage
        {
            get { return _offeringImage; }
            set { _offeringImage = value; pbOfferingImage.Image = value; }
        }

        private string _offeringName;
        public string OfferingName
        {
            get { return _offeringName; }
            set { _offeringName = value; lblOfferingName.Text = value; }
        }

        private decimal _offeringPrice;
        public decimal OfferingPrice
        {
            get { return _offeringPrice; }
            set { _offeringPrice = value; lblOfferingPrice.Text = value.ToString() + " ETB"; }
        }

        private string _restaurantName;
        public string RestaurantName
        {
            get { return _restaurantName; }
            set { _restaurantName = value; lblRestaurantName.Text = value; }
        }

        public OfferingCardMedium()
        {
            InitializeComponent();
        }

        public OfferingCardMedium(Offering offering)
        {
            InitializeComponent();

            OfferingImage = offering.Image;
            OfferingName = offering.Name;
            OfferingPrice = offering.Price;
            RestaurantName = offering.Restaurant.Name;
        }
    }
}
