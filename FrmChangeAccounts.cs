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
                List<string> tab = dB.ShowInfoUser();
                cbTypeAccountChange.Text = tab[0];
                inputUserNameAccountChange.Text = tab[1];
                inputEmailAccountChange.Text = tab[2];
                inputTagAccountChange.Text = tab[3];
                cbQuestion1Change.Text = tab[4];
                cbQuestion1Change.Text = tab[5];
                cbQuestion1Change.Text = tab[6];
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
    }
}
