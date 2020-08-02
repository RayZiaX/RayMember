using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayMember
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void leaveItemMenus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de quittre l'application ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tInformation 1: \n\tinformation 1\n \n\tInformation2 \n\tinformation2", "Information", MessageBoxButtons.OK);
        }

        private void addItemMenus_Click(object sender, EventArgs e)
        {
            frmAddAccount frmAddAccount = new frmAddAccount();
            this.Hide();
            frmAddAccount.Show();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
