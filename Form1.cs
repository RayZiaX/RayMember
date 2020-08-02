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
            DBUse dB = new DBUse();
            string userNAme = inputUserName.Text;
            string password = inputPassword.Text;
            Encrypt encrypt = new Encrypt();
            string psw = encrypt.init(password);
            if (dB.Auth(userNAme, psw))
            {
                    frmMainMenu frmMainMenu = new frmMainMenu();
                    this.Hide();
                    frmMainMenu.Show();

            }
            else
            {
                MessageBox.Show("Mauvais données entrées", "Attention", MessageBoxButtons.OK);
            }
        }
    }
}
