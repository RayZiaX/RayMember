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
    public partial class FrmChangeAccounts : Form
    {
        private object m_idAccount;
        public FrmChangeAccounts()
        {
            InitializeComponent();
        }

        private void FrmChangeAccounts_Load(object sender, EventArgs e)
        {
            DBUse dB = new DBUse();
            bool verif = dB.SelectAccounts(m_idAccount);
            if (verif)
            {
                string id;
                List<string> tab = dB.ShowInfoUser();
                inputTypeChangeAccountAdd.Text = tab[0];
                inputUserNameAccountChange.Text = tab[1];
                inputEmailAccountChange.Text = tab[2];
                inputTagAccountChange.Text = tab[3];
                cbQuestion1Change.Text = tab[4];
                cbQuestion2Change.Text = tab[5];
                cbQuestion3Change.Text = tab[6];
                inputAnswer1Change.Text = tab[7];
                inputAnswer2Change.Text = tab[8];
                inputAnswer3Change.Text = tab[9];

            }
            else
            {
                MessageBox.Show("Erreur", "Attenttion", MessageBoxButtons.OK);
            }
        }

        public object IdAccount
        {
            get { return m_idAccount; }
            set { m_idAccount = value; }
        }

        private void FrmChangeAccounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddAccountChange_Click(object sender, EventArgs e)
        {
            try
            {
                Encrypt encrypt = new Encrypt();
                string psw = encrypt.Encryption(inputPasswordAccountChange.Text);
                DBUse dB = new DBUse();
                if(dB.ChangeAccoundAdd(inputTypeChangeAccountAdd.Text, inputUserNameAccountChange.Text, psw, inputEmailAccountChange.Text, inputTagAccountChange.Text, cbQuestion1Change.Text, cbQuestion2Change.Text, cbQuestion3Change.Text, inputAnswer1Change.Text, inputAnswer2Change.Text, inputAnswer3Change.Text, m_idAccount))
                {
                    MessageBox.Show("Vos données ont été modifier", "Confirmation", MessageBoxButtons.OK);
                    FrmMainMenu menu = new FrmMainMenu();
                    menu.Show();
                    this.Hide();

                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
                MessageBox.Show("Veuillez entrez un mot de passe", "Attention", MessageBoxButtons.OK);
            }
            
        }

        private void btnCancelAddChange_Click(object sender, EventArgs e)
        {
            FrmMainMenu menu = new FrmMainMenu();
            menu.Show();
            this.Hide();
        }
    }
}
