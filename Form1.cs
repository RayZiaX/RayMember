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
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void lblCCompte_Click(object sender, EventArgs e)
        {
            frmCreatAccount frmCreatAccount = new frmCreatAccount();
            this.Hide();
            frmCreatAccount.Show();

        }

        private void lblCCompte_MouseHover(object sender, EventArgs e)
        {
            lblCCompte.ForeColor = Color.Blue;
        }

        private void lblCCompte_MouseLeave(object sender, EventArgs e)
        {
            lblCCompte.ForeColor = Color.Black;
        }

        private void frmConnexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            frmAddAccount frmAddAccount = new frmAddAccount();
            this.Hide();
            frmAddAccount.Show();
        }
    }
}
