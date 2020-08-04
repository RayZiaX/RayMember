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
    public partial class FrmMainMenu : Form
    {
        private static string m_UserName = null;
        private static int m_userId;
        public FrmMainMenu()
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
            frmAddAccount.idUser = m_userId;
            frmAddAccount.Show();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public string userName
        {
            get { return m_UserName; }
            set { m_UserName = value; }
        }
        public int userId
        {
            get { return m_userId; }
            set { m_userId = value; }
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Bonjour {m_UserName}";
            listAccount.Items.Clear();
            DBUse dB = new DBUse();
            bool verif = dB.AddAccountList(m_userId);
            if(verif)
            {
                List<List<string>> tab = dB.tabAccount();
                for (int i = 0; i < tab.Count; i++)
                {
                    List<string> t = tab[i];
                    string[] row = new string[] {t[1], t[2], t[3], t[4]};
                    ListViewItem lvi = new ListViewItem(row);
                    lvi.Tag = t[0];
                    listAccount.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas de donnée enregistrer veuillez en ajouter", "Remarque", MessageBoxButtons.OK);
            }
        }

        private void disconnectItemMenus_Click(object sender, EventArgs e)
        {
            frmConnexion frmConnexion = new frmConnexion();
            m_userId = 0;
            m_UserName = null;
            frmConnexion.Show();
            this.Hide();
        }
    }
}
