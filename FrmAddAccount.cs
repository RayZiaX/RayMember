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


        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Annuler l'ajout d'un compte ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
                this.Hide();
            }
        }
    }
}
