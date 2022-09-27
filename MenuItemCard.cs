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
    public partial class MenuItemCard : UserControl
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

        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value.ToString() + " ETB"; }
        }

        public MenuItemCard()
        {
            InitializeComponent();
        }

        public MenuItemCard(Offering offering1)
        {
            InitializeComponent();

            OfferingImage = offering1.Image;
            OfferingName = offering1.Name;
            Price = offering1.Price;
        }
    }
}
