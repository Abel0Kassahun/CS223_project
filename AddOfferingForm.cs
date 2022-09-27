using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProjectBlue
{
    public partial class AddOfferingForm : KryptonForm
    {
        public AddOfferingForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey700, Accent.Blue700, TextShade.WHITE );
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
