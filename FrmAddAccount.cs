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
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
        }

        private void frmAddAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void leaveItemMenus_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Êtes-vous sûr de quittre l'application ?","Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tInformation 1: \n\tinformation 1\n \n\tInformation2 \n\tinformation2", "Information", MessageBoxButtons.OK);
        }
    }
}
