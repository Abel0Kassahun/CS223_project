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

namespace ProjectBlue
{
    public partial class ManagerMainForm : KryptonForm
    {
        public ManagerMainForm()
        {
            InitializeComponent();

            LoadForm(new ViewAddedItemsForm());
            SidePanelIndicator.Top = btnView.Top;
        }

        public void LoadForm(object Form)
        {
            if (pnlMain.Controls.Count > 0)
            {
                pnlMain.Controls.RemoveAt(0);
            }

            Form formToBeDisplayed = Form as Form;
            formToBeDisplayed.TopLevel = false;
            formToBeDisplayed.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(formToBeDisplayed);
            pnlMain.Tag = formToBeDisplayed;

            formToBeDisplayed.Show();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SidePanelIndicator.Top = btnView.Top;
            LoadForm(new ViewAddedItemsForm());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SidePanelIndicator.Top = btnAdd.Top;
            LoadForm(new AddItemsForm());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            SidePanelIndicator.Top = btnAccount.Top;
            LoadForm(new ManagerAccountForm());
        }
    }
}
