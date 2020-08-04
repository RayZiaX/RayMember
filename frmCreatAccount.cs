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
    public partial class FrmCreatAccount : Form
    {
        public FrmCreatAccount()
        {
            InitializeComponent();
        }

        private void frmCreatAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConfimCC_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Vous confirmez les données entrée ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string userName = inputUserNameCC.Text;
                string pswNoneEncrypt = inputPasswordCC.Text;
                Encrypt encrypt = new Encrypt();
                string psw = encrypt.Init(pswNoneEncrypt);
                string email = inputEmailCC.Text;
                string gender = cBGender.Text;
                string nationality = cbNationality.Text;
                DBUse dB = new DBUse();
                bool validate = dB.Inscription(userName, psw, email,nationality, gender);
                if (validate)
                {
                    MessageBox.Show("Vos données ont bien été rentrer","Confirmation",MessageBoxButtons.OK);
                    frmConnexion frmConnexion = new frmConnexion();
                    frmConnexion.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur","Attention",MessageBoxButtons.OK);
                }

            }
        }
    }
}
