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
        private int m_idUser;
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
                FrmMainMenu frmMainMenu = new FrmMainMenu();
                frmMainMenu.Show();
                this.Hide();
            }
        }

        private void cbTypeAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentSelect = cbTypeAccount.SelectedIndex;
            switch (currentSelect)
            {
                case 0:
                    picTypeAccount.Image = picListAccount.Images[currentSelect];
                    lblTagAccount.Visible = false;
                    inputTagAccount.Visible = false;
                    lblQuestion1.Visible = false;
                    lblQuestion2.Visible = false;
                    lblQuestion3.Visible = false;
                    cbQuestion1.Visible = false;
                    cbQuestion2.Visible = false;
                    cbQuestion3.Visible = false;
                    lblAnswer1.Visible = false;
                    lblAnswer2.Visible = false;
                    lblAnswer3.Visible = false;
                    inputAnswer1.Visible = false;
                    inputAnswer2.Visible = false;
                    inputAnswer3.Visible = false;
                    break;
                case 1:
                    picTypeAccount.Image = picListAccount.Images[currentSelect];
                    lblTagAccount.Visible = true;
                    inputTagAccount.Visible = true;
                    lblQuestion1.Visible = false;
                    lblQuestion2.Visible = false;
                    lblQuestion3.Visible = false;
                    cbQuestion1.Visible = false;
                    cbQuestion2.Visible = false;
                    cbQuestion3.Visible = false;
                    lblAnswer1.Visible = false;
                    lblAnswer2.Visible = false;
                    lblAnswer3.Visible = false;
                    inputAnswer1.Visible = false;
                    inputAnswer2.Visible = false;
                    inputAnswer3.Visible = false;
                    break;
                case 2:
                    picTypeAccount.Image = picListAccount.Images[currentSelect];
                    lblTagAccount.Visible = true;
                    inputTagAccount.Visible = true;
                    lblQuestion1.Visible = false;
                    lblQuestion2.Visible = false;
                    lblQuestion3.Visible = false;
                    cbQuestion1.Visible = false;
                    cbQuestion2.Visible = false;
                    cbQuestion3.Visible = false;
                    lblAnswer1.Visible = false;
                    lblAnswer2.Visible = false;
                    lblAnswer3.Visible = false;
                    inputAnswer1.Visible = false;
                    inputAnswer2.Visible = false;
                    inputAnswer3.Visible = false;
                    break;
                case 3:
                    picTypeAccount.Image = picListAccount.Images[currentSelect];
                    lblTagAccount.Visible = false;
                    inputTagAccount.Visible = false;
                    lblQuestion1.Visible = false;
                    lblQuestion2.Visible = false;
                    lblQuestion3.Visible = false;
                    cbQuestion1.Visible = false;
                    cbQuestion2.Visible = false;
                    cbQuestion3.Visible = false;
                    lblAnswer1.Visible = false;
                    lblAnswer2.Visible = false;
                    lblAnswer3.Visible = false;
                    inputAnswer1.Visible = false;
                    inputAnswer2.Visible = false;
                    inputAnswer3.Visible = false;
                    break;
                case 4:
                    picTypeAccount.Image = picListAccount.Images[currentSelect];
                    lblTagAccount.Visible = false;
                    inputTagAccount.Visible = false;
                    lblQuestion1.Visible = false;
                    lblQuestion2.Visible = false;
                    lblQuestion3.Visible = false;
                    cbQuestion1.Visible = false;
                    cbQuestion2.Visible = false;
                    cbQuestion3.Visible = false;
                    lblAnswer1.Visible = false;
                    lblAnswer2.Visible = false;
                    lblAnswer3.Visible = false;
                    inputAnswer1.Visible = false;
                    inputAnswer2.Visible = false;
                    inputAnswer3.Visible = false;
                    break;
                case 5:
                    picTypeAccount.Image = picListAccount.Images[currentSelect];
                    lblTagAccount.Visible = false;
                    inputTagAccount.Visible = false;
                    lblQuestion1.Visible = true;
                    lblQuestion2.Visible = true;
                    lblQuestion3.Visible = true;
                    cbQuestion1.Visible = true;
                    cbQuestion2.Visible = true;
                    cbQuestion3.Visible = true;
                    lblAnswer1.Visible = true;
                    lblAnswer2.Visible = true;
                    lblAnswer3.Visible = true;
                    inputAnswer1.Visible = true;
                    inputAnswer2.Visible = true;
                    inputAnswer3.Visible = true;
                    break;
                case 6:
                    picTypeAccount.Image = picListAccount.Images[currentSelect];
                    lblTagAccount.Visible = false;
                    inputTagAccount.Visible = false;
                    lblQuestion1.Visible = false;
                    lblQuestion2.Visible = false;
                    lblQuestion3.Visible = false;
                    cbQuestion1.Visible = false;
                    cbQuestion2.Visible = false;
                    cbQuestion3.Visible = false;
                    lblAnswer1.Visible = false;
                    lblAnswer2.Visible = false;
                    lblAnswer3.Visible = false;
                    inputAnswer1.Visible = false;
                    inputAnswer2.Visible = false;
                    inputAnswer3.Visible = false;
                    break;
                case 7:
                    picTypeAccount.Image = picListAccount.Images[currentSelect];
                    lblTagAccount.Visible = false;
                    inputTagAccount.Visible = false;
                    lblQuestion1.Visible = false;
                    lblQuestion2.Visible = false;
                    lblQuestion3.Visible = false;
                    cbQuestion1.Visible = false;
                    cbQuestion2.Visible = false;
                    cbQuestion3.Visible = false;
                    lblAnswer1.Visible = false;
                    lblAnswer2.Visible = false;
                    lblAnswer3.Visible = false;
                    inputAnswer1.Visible = false;
                    inputAnswer2.Visible = false;
                    inputAnswer3.Visible = false;
                    break;
                case 8:
                    picTypeAccount.Image = picListAccount.Images[currentSelect];
                    lblTagAccount.Visible = false;
                    inputTagAccount.Visible = false;
                    lblQuestion1.Visible = false;
                    lblQuestion2.Visible = false;
                    lblQuestion3.Visible = false;
                    cbQuestion1.Visible = false;
                    cbQuestion2.Visible = false;
                    cbQuestion3.Visible = false;
                    lblAnswer1.Visible = false;
                    lblAnswer2.Visible = false;
                    lblAnswer3.Visible = false;
                    inputAnswer1.Visible = false;
                    inputAnswer2.Visible = false;
                    inputAnswer3.Visible = false;
                    break;
                case 9:
                    picTypeAccount.Image = picListAccount.Images[currentSelect];
                    lblTagAccount.Visible = false;
                    inputTagAccount.Visible = false;
                    lblQuestion1.Visible = false;
                    lblQuestion2.Visible = false;
                    lblQuestion3.Visible = false;
                    cbQuestion1.Visible = false;
                    cbQuestion2.Visible = false;
                    cbQuestion3.Visible = false;
                    lblAnswer1.Visible = false;
                    lblAnswer2.Visible = false;
                    lblAnswer3.Visible = false;
                    inputAnswer1.Visible = false;
                    inputAnswer2.Visible = false;
                    inputAnswer3.Visible = false;
                    break;
                case 10:
                    picTypeAccount.Image = null;
                    lblOtherAccountType.Visible = true;
                    inputOtherAccountCC.Visible = true;
                    lblTagAccount.Visible = true;
                    inputTagAccount.Visible = true;
                    lblQuestion1.Visible = true;
                    lblQuestion2.Visible = true;
                    lblQuestion3.Visible = true;
                    cbQuestion1.Visible = true;
                    cbQuestion2.Visible = true;
                    cbQuestion3.Visible = true;
                    lblAnswer1.Visible = true;
                    lblAnswer2.Visible = true;
                    lblAnswer3.Visible = true;
                    inputAnswer1.Visible = true;
                    inputAnswer2.Visible = true;
                    inputAnswer3.Visible = true;
                    break;
                default:
                    break;
            }
        }
        public int idUser
        {
            get { return m_idUser; }
            set { m_idUser = value; }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            string pswEncrypt = encrypt.Init(inputPasswordAccount.Text);
            DBUse dB = new DBUse();
            int currentSelect = cbTypeAccount.SelectedIndex;
            switch (currentSelect)
            {
                case 0:
                    inputTagAccount.Text = null;
                    cbQuestion1.Text = null;
                    cbQuestion2.Text = null;
                    cbQuestion3.Text = null;
                    inputAnswer1.Text = null;
                    inputAnswer2.Text = null;
                    inputAnswer3.Text = null;
                    if (dB.AddAccount(cbTypeAccount.Text, inputUserNameAccount.Text, pswEncrypt, inputEmailAccount.Text, m_idUser, inputTagAccount.Text, cbQuestion1.Text, cbQuestion2.Text, cbQuestion3.Text, inputAnswer1.Text, inputAnswer2.Text, inputAnswer3.Text))
                    {
                        if (MessageBox.Show("Vos données on été entrer", "Information", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            FrmMainMenu frmMainMenu = new FrmMainMenu();
                            frmMainMenu.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 1:
                    cbQuestion1.Text = null;
                    cbQuestion2.Text = null;
                    cbQuestion3.Text = null;
                    inputAnswer1.Text = null;
                    inputAnswer2.Text = null;
                    inputAnswer3.Text = null;
                    if (dB.AddAccount(cbTypeAccount.Text, inputUserNameAccount.Text, pswEncrypt, inputEmailAccount.Text, m_idUser, inputTagAccount.Text, cbQuestion1.Text, cbQuestion2.Text, cbQuestion3.Text, inputAnswer1.Text, inputAnswer2.Text, inputAnswer3.Text))
                    {
                        if (MessageBox.Show("Vos données on été entrer", "Information", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            FrmMainMenu frmMainMenu = new FrmMainMenu();
                            frmMainMenu.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 2:
                    cbQuestion1.Text = null;
                    cbQuestion2.Text = null;
                    cbQuestion3.Text = null;
                    inputAnswer1.Text = null;
                    inputAnswer2.Text = null;
                    inputAnswer3.Text = null;
                    if (dB.AddAccount(cbTypeAccount.Text, inputUserNameAccount.Text, pswEncrypt, inputEmailAccount.Text, m_idUser, inputTagAccount.Text, cbQuestion1.Text, cbQuestion2.Text, cbQuestion3.Text, inputAnswer1.Text, inputAnswer2.Text, inputAnswer3.Text))
                    {
                        if (MessageBox.Show("Vos données on été entrer", "Information", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            FrmMainMenu frmMainMenu = new FrmMainMenu();
                            frmMainMenu.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 3:
                    inputTagAccount.Text = null;
                    cbQuestion1.Text = null;
                    cbQuestion2.Text = null;
                    cbQuestion3.Text = null;
                    inputAnswer1.Text = null;
                    inputAnswer2.Text = null;
                    inputAnswer3.Text = null;
                    if (dB.AddAccount(cbTypeAccount.Text, inputUserNameAccount.Text, pswEncrypt, inputEmailAccount.Text, m_idUser, inputTagAccount.Text, cbQuestion1.Text, cbQuestion2.Text, cbQuestion3.Text, inputAnswer1.Text, inputAnswer2.Text, inputAnswer3.Text))
                    {
                        if (MessageBox.Show("Vos données on été entrer", "Information", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            FrmMainMenu frmMainMenu = new FrmMainMenu();
                            frmMainMenu.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 4:
                    inputTagAccount.Text = null;
                    cbQuestion1.Text = null;
                    cbQuestion2.Text = null;
                    cbQuestion3.Text = null;
                    inputAnswer1.Text = null;
                    inputAnswer2.Text = null;
                    inputAnswer3.Text = null;
                    if (dB.AddAccount(cbTypeAccount.Text, inputUserNameAccount.Text, pswEncrypt, inputEmailAccount.Text, m_idUser, inputTagAccount.Text, cbQuestion1.Text, cbQuestion2.Text, cbQuestion3.Text, inputAnswer1.Text, inputAnswer2.Text, inputAnswer3.Text))
                    {
                        if (MessageBox.Show("Vos données on été entrer", "Information", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            FrmMainMenu frmMainMenu = new FrmMainMenu();
                            frmMainMenu.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 5:
                    inputTagAccount.Text = null;
                    if (dB.AddAccount(cbTypeAccount.Text, inputUserNameAccount.Text, pswEncrypt, inputEmailAccount.Text, m_idUser, inputTagAccount.Text, cbQuestion1.Text, cbQuestion2.Text, cbQuestion3.Text, inputAnswer1.Text, inputAnswer2.Text, inputAnswer3.Text))
                    {
                        if (MessageBox.Show("Vos données on été entrer", "Information", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            FrmMainMenu frmMainMenu = new FrmMainMenu();
                            frmMainMenu.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 6:
                    inputTagAccount.Text = null;
                    cbQuestion1.Text = null;
                    cbQuestion2.Text = null;
                    cbQuestion3.Text = null;
                    inputAnswer1.Text = null;
                    inputAnswer2.Text = null;
                    inputAnswer3.Text = null;
                    if (dB.AddAccount(cbTypeAccount.Text, inputUserNameAccount.Text, pswEncrypt, inputEmailAccount.Text, m_idUser, inputTagAccount.Text, cbQuestion1.Text, cbQuestion2.Text, cbQuestion3.Text, inputAnswer1.Text, inputAnswer2.Text, inputAnswer3.Text))
                    {
                        if (MessageBox.Show("Vos données on été entrer", "Information", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            FrmMainMenu frmMainMenu = new FrmMainMenu();
                            frmMainMenu.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 7:
                    inputTagAccount.Text = null;
                    cbQuestion1.Text = null;
                    cbQuestion2.Text = null;
                    cbQuestion3.Text = null;
                    inputAnswer1.Text = null;
                    inputAnswer2.Text = null;
                    inputAnswer3.Text = null;
                    if (dB.AddAccount(cbTypeAccount.Text, inputUserNameAccount.Text, pswEncrypt, inputEmailAccount.Text, m_idUser, inputTagAccount.Text, cbQuestion1.Text, cbQuestion2.Text, cbQuestion3.Text, inputAnswer1.Text, inputAnswer2.Text, inputAnswer3.Text))
                    {
                        if (MessageBox.Show("Vos données on été entrer", "Information", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            FrmMainMenu frmMainMenu = new FrmMainMenu();
                            frmMainMenu.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 8:
                    inputTagAccount.Text = null;
                    cbQuestion1.Text = null;
                    cbQuestion2.Text = null;
                    cbQuestion3.Text = null;
                    inputAnswer1.Text = null;
                    inputAnswer2.Text = null;
                    inputAnswer3.Text = null;
                    if (dB.AddAccount(cbTypeAccount.Text, inputUserNameAccount.Text, pswEncrypt, inputEmailAccount.Text, m_idUser, inputTagAccount.Text, cbQuestion1.Text, cbQuestion2.Text, cbQuestion3.Text, inputAnswer1.Text, inputAnswer2.Text, inputAnswer3.Text))
                    {
                        if (MessageBox.Show("Vos données on été entrer", "Information", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            FrmMainMenu frmMainMenu = new FrmMainMenu();
                            frmMainMenu.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 9:
                    inputTagAccount.Text = null;
                    cbQuestion1.Text = null;
                    cbQuestion2.Text = null;
                    cbQuestion3.Text = null;
                    inputAnswer1.Text = null;
                    inputAnswer2.Text = null;
                    inputAnswer3.Text = null;
                    if (dB.AddAccount(cbTypeAccount.Text, inputUserNameAccount.Text, pswEncrypt, inputEmailAccount.Text, m_idUser, inputTagAccount.Text, cbQuestion1.Text, cbQuestion2.Text, cbQuestion3.Text, inputAnswer1.Text, inputAnswer2.Text, inputAnswer3.Text))
                    {
                        if (MessageBox.Show("Vos données on été entrer", "Information", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            FrmMainMenu frmMainMenu = new FrmMainMenu();
                            frmMainMenu.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 10:
                    break;
                default:
                    MessageBox.Show("Une donnée a été mal saisie", "Attention", MessageBoxButtons.OK);
                    break;
            }
        }
    }
}
