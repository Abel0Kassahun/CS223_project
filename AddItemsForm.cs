using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBlue
{
    public partial class AddItemsForm : Form
    {
        public AddItemsForm()
        {
            InitializeComponent();
        }

        private void cardAddRestaurant_Click(object sender, EventArgs e)
        {
            Hide();
            AddRestaurantForm addRestaurantForm1 = new AddRestaurantForm();
            addRestaurantForm1.ShowDialog();
        }

        private void cardAddOffering_Click(object sender, EventArgs e)
        {
            Hide();
            AddOfferingForm addOfferingForm1 = new AddOfferingForm();
            addOfferingForm1.ShowDialog();
        }
    }
}
