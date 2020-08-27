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
            DBUse dB = new DBUse();
            Encrypt encrypt = new Encrypt();
            bool verif = dB.ShowInfo(listAccount.SelectedItems[0].Tag);
            if (verif)
            {
                List<string> tab = dB.ShowInfoUser();
                string psw = encrypt.Decryption(tab[1]);
                MessageBox.Show($"\tNom d'utilisateur: \n\t{tab[0]}\n \n\tmot de passe: \n\t{psw}", "Information", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Une erreur est survenue", "Attention", MessageBoxButtons.OK);

            }
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
                List<List<string>> tab = dB.TabAccount();
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

        private void listAccount_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            DBUse dB = new DBUse();
            Encrypt encrypt = new Encrypt();
            bool verif = dB.ShowInfo(listAccount.SelectedItems[0].Tag);
            Console.WriteLine(listAccount.SelectedItems[0].Tag);
            if (verif)
            {
                List<string> tab = dB.ShowInfoUser();
                string psw = encrypt.Decryption(tab[1]);
                MessageBox.Show($"\tNom d'utilisateur: \n\t{tab[0]}\n \n\tmot de passe: \n\t{psw}", "Information", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("Une erreur est survenue", "Attention", MessageBoxButtons.OK);

            }
        }

        private void btnModifAccount_Click(object sender, EventArgs e)
        {
            FrmChangeAccounts frmChangeAccounts = new FrmChangeAccounts();
            frmChangeAccounts.IdAccount = listAccount.SelectedItems[0].Tag;
            frmChangeAccounts.Show();
            this.Hide();
        }

        private void modificationItemMenus_Click(object sender, EventArgs e)
        {
            FrmChangeUserAccount frmChangeUserAccount = new FrmChangeUserAccount();
            frmChangeUserAccount.userId = m_userId;
            this.Hide();
            frmChangeUserAccount.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DBUse dB = new DBUse();
            if (MessageBox.Show("Voulez-vous vraiment supprimer le compte séléctionner ?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool verif = dB.DeleteAccounts(listAccount.SelectedItems[0].Tag);
                if (verif)
                {
                    MessageBox.Show("Les données ont été supprimer", "Information", MessageBoxButtons.OK);
                }
            }
            else
            {

            }
        }

    }
}
