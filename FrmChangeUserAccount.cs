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
    public partial class FrmChangeUserAccount : Form
    {
        private int m_userId;
        public FrmChangeUserAccount()
        {
            InitializeComponent();
        }

        private void FrmChangeUserAccount_Load(object sender, EventArgs e)
        {
            DBUse dB = new DBUse();
            bool verif = dB.VerifAccount(m_userId);
            if (verif)
            {
                List<string> tab = dB.ShowInfoUser();
                inputUserNameChangeAccount.Text = tab[0];
                inputEmailChangeAccount.Text = tab[1];
                cbGenderChangeAccount.Text = tab[2];
                cbNationalityChangeAccount.Text = tab[3];
            }
            else
            {
                MessageBox.Show("erreur", "Attention", MessageBoxButtons.OK);
            }
        }

        public int userId
        {
            get { return m_userId; }
            set { m_userId = value; }
        }

        private void FrmChangeUserAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmChangeAccount_Click(object sender, EventArgs e)
        {
            DBUse dB = new DBUse();
            Encrypt encrypt = new Encrypt();
            string psw = encrypt.Hash(inputPasswordChangeAccount.Text);
            bool verif = dB.ChangeAccount(inputUserNameChangeAccount.Text, psw,inputEmailChangeAccount.Text, cbGenderChangeAccount.Text, cbNationalityChangeAccount.Text, m_userId);
            if(inputPasswordChangeAccount.Text == "")
            {
                MessageBox.Show("Vous devez mettre votre mot de passe ou en mettre un nouveau", "Attention", MessageBoxButtons.OK);
            }
            else
            {
                if (verif)
                {
                    MessageBox.Show("Les données on étaient modifiée", "information", MessageBoxButtons.OK);
                    frmConnexion frmConnexion = new frmConnexion();
                    frmConnexion.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur", "Attention", MessageBoxButtons.OK);

                }
            }
        }

        private void btnCancelChangeAccount_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            this.Hide();
        }
    }
}
