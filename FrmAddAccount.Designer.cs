namespace RayMember
{
    partial class frmAddAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAccount));
            this.lblTypeAccount = new System.Windows.Forms.Label();
            this.lblUserNameAccount = new System.Windows.Forms.Label();
            this.lblPasswordAccount = new System.Windows.Forms.Label();
            this.lblEmailAddAccount = new System.Windows.Forms.Label();
            this.cbTypeAccount = new System.Windows.Forms.ComboBox();
            this.inputUserNameAccount = new System.Windows.Forms.TextBox();
            this.inputPasswordAccount = new System.Windows.Forms.TextBox();
            this.inputEmailAccount = new System.Windows.Forms.TextBox();
            this.lblTagAccount = new System.Windows.Forms.Label();
            this.inputTagAccount = new System.Windows.Forms.TextBox();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.cbQuestion1 = new System.Windows.Forms.ComboBox();
            this.cbQuestion2 = new System.Windows.Forms.ComboBox();
            this.cbQuestion3 = new System.Windows.Forms.ComboBox();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.lblOtherAccountType = new System.Windows.Forms.Label();
            this.inputAnswer1 = new System.Windows.Forms.TextBox();
            this.inputAnswer2 = new System.Windows.Forms.TextBox();
            this.inputAnswer3 = new System.Windows.Forms.TextBox();
            this.inputOtherAccountCC = new System.Windows.Forms.TextBox();
            this.picTypeAccount = new System.Windows.Forms.PictureBox();
            this.picListAccount = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTypeAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTypeAccount
            // 
            this.lblTypeAccount.AutoSize = true;
            this.lblTypeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeAccount.Location = new System.Drawing.Point(12, 49);
            this.lblTypeAccount.Name = "lblTypeAccount";
            this.lblTypeAccount.Size = new System.Drawing.Size(196, 20);
            this.lblTypeAccount.TabIndex = 0;
            this.lblTypeAccount.Text = "Quel type de compte c\'est ";
            // 
            // lblUserNameAccount
            // 
            this.lblUserNameAccount.AutoSize = true;
            this.lblUserNameAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameAccount.Location = new System.Drawing.Point(12, 94);
            this.lblUserNameAccount.Name = "lblUserNameAccount";
            this.lblUserNameAccount.Size = new System.Drawing.Size(272, 20);
            this.lblUserNameAccount.TabIndex = 1;
            this.lblUserNameAccount.Text = "Nom d\'utilisateur du compte (pseudo)";
            // 
            // lblPasswordAccount
            // 
            this.lblPasswordAccount.AutoSize = true;
            this.lblPasswordAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordAccount.Location = new System.Drawing.Point(12, 138);
            this.lblPasswordAccount.Name = "lblPasswordAccount";
            this.lblPasswordAccount.Size = new System.Drawing.Size(184, 20);
            this.lblPasswordAccount.TabIndex = 2;
            this.lblPasswordAccount.Text = "Mot de passe du compte";
            // 
            // lblEmailAddAccount
            // 
            this.lblEmailAddAccount.AutoSize = true;
            this.lblEmailAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddAccount.Location = new System.Drawing.Point(12, 184);
            this.lblEmailAddAccount.Name = "lblEmailAddAccount";
            this.lblEmailAddAccount.Size = new System.Drawing.Size(127, 20);
            this.lblEmailAddAccount.TabIndex = 3;
            this.lblEmailAddAccount.Text = "Email du compte";
            // 
            // cbTypeAccount
            // 
            this.cbTypeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeAccount.FormattingEnabled = true;
            this.cbTypeAccount.Items.AddRange(new object[] {
            "Steam",
            "Discord",
            "Battle.net",
            "Uplay",
            "Origin",
            "Microsoft",
            "GOG",
            "Epic Game",
            "Twitch",
            "Amazon",
            "Autre"});
            this.cbTypeAccount.Location = new System.Drawing.Point(290, 49);
            this.cbTypeAccount.Name = "cbTypeAccount";
            this.cbTypeAccount.Size = new System.Drawing.Size(121, 28);
            this.cbTypeAccount.TabIndex = 4;
            this.cbTypeAccount.SelectedIndexChanged += new System.EventHandler(this.cbTypeAccount_SelectedIndexChanged);
            // 
            // inputUserNameAccount
            // 
            this.inputUserNameAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUserNameAccount.Location = new System.Drawing.Point(290, 93);
            this.inputUserNameAccount.Name = "inputUserNameAccount";
            this.inputUserNameAccount.Size = new System.Drawing.Size(121, 26);
            this.inputUserNameAccount.TabIndex = 5;
            // 
            // inputPasswordAccount
            // 
            this.inputPasswordAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPasswordAccount.Location = new System.Drawing.Point(290, 138);
            this.inputPasswordAccount.Name = "inputPasswordAccount";
            this.inputPasswordAccount.PasswordChar = '*';
            this.inputPasswordAccount.Size = new System.Drawing.Size(121, 26);
            this.inputPasswordAccount.TabIndex = 6;
            this.inputPasswordAccount.UseSystemPasswordChar = true;
            // 
            // inputEmailAccount
            // 
            this.inputEmailAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEmailAccount.Location = new System.Drawing.Point(290, 186);
            this.inputEmailAccount.Name = "inputEmailAccount";
            this.inputEmailAccount.Size = new System.Drawing.Size(121, 26);
            this.inputEmailAccount.TabIndex = 7;
            // 
            // lblTagAccount
            // 
            this.lblTagAccount.AutoSize = true;
            this.lblTagAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagAccount.Location = new System.Drawing.Point(500, 91);
            this.lblTagAccount.Name = "lblTagAccount";
            this.lblTagAccount.Size = new System.Drawing.Size(36, 20);
            this.lblTagAccount.TabIndex = 8;
            this.lblTagAccount.Text = "Tag";
            this.lblTagAccount.Visible = false;
            // 
            // inputTagAccount
            // 
            this.inputTagAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTagAccount.Location = new System.Drawing.Point(600, 91);
            this.inputTagAccount.Name = "inputTagAccount";
            this.inputTagAccount.Size = new System.Drawing.Size(54, 26);
            this.inputTagAccount.TabIndex = 9;
            this.inputTagAccount.Text = "#0000";
            this.inputTagAccount.Visible = false;
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion1.Location = new System.Drawing.Point(12, 260);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(157, 20);
            this.lblQuestion1.TabIndex = 10;
            this.lblQuestion1.Text = "Question secrete n°1";
            this.lblQuestion1.Visible = false;
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion2.Location = new System.Drawing.Point(12, 294);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(157, 20);
            this.lblQuestion2.TabIndex = 11;
            this.lblQuestion2.Text = "Question secrete n°2";
            this.lblQuestion2.Visible = false;
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.AutoSize = true;
            this.lblQuestion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion3.Location = new System.Drawing.Point(12, 325);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(157, 20);
            this.lblQuestion3.TabIndex = 12;
            this.lblQuestion3.Text = "Question secrete n°3";
            this.lblQuestion3.Visible = false;
            // 
            // cbQuestion1
            // 
            this.cbQuestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuestion1.FormattingEnabled = true;
            this.cbQuestion1.Location = new System.Drawing.Point(175, 259);
            this.cbQuestion1.Name = "cbQuestion1";
            this.cbQuestion1.Size = new System.Drawing.Size(164, 28);
            this.cbQuestion1.TabIndex = 13;
            this.cbQuestion1.Visible = false;
            // 
            // cbQuestion2
            // 
            this.cbQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuestion2.FormattingEnabled = true;
            this.cbQuestion2.Location = new System.Drawing.Point(175, 293);
            this.cbQuestion2.Name = "cbQuestion2";
            this.cbQuestion2.Size = new System.Drawing.Size(164, 28);
            this.cbQuestion2.TabIndex = 14;
            this.cbQuestion2.Visible = false;
            // 
            // cbQuestion3
            // 
            this.cbQuestion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuestion3.FormattingEnabled = true;
            this.cbQuestion3.Location = new System.Drawing.Point(175, 327);
            this.cbQuestion3.Name = "cbQuestion3";
            this.cbQuestion3.Size = new System.Drawing.Size(164, 28);
            this.cbQuestion3.TabIndex = 15;
            this.cbQuestion3.Visible = false;
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.Location = new System.Drawing.Point(355, 330);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(101, 20);
            this.lblAnswer3.TabIndex = 18;
            this.lblAnswer3.Text = "Réponse n°3";
            this.lblAnswer3.Visible = false;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.Location = new System.Drawing.Point(355, 299);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(101, 20);
            this.lblAnswer2.TabIndex = 17;
            this.lblAnswer2.Text = "Réponse n°2";
            this.lblAnswer2.Visible = false;
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.Location = new System.Drawing.Point(355, 265);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(101, 20);
            this.lblAnswer1.TabIndex = 16;
            this.lblAnswer1.Text = "Réponse n°1";
            this.lblAnswer1.Visible = false;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Location = new System.Drawing.Point(126, 393);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(158, 49);
            this.btnAddAccount.TabIndex = 22;
            this.btnAddAccount.Text = "Ajouter";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.Location = new System.Drawing.Point(432, 393);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(158, 49);
            this.btnCancelAdd.TabIndex = 23;
            this.btnCancelAdd.Text = "Retour";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // lblOtherAccountType
            // 
            this.lblOtherAccountType.AutoSize = true;
            this.lblOtherAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherAccountType.Location = new System.Drawing.Point(454, 50);
            this.lblOtherAccountType.Name = "lblOtherAccountType";
            this.lblOtherAccountType.Size = new System.Drawing.Size(140, 20);
            this.lblOtherAccountType.TabIndex = 24;
            this.lblOtherAccountType.Text = "un autre ? lequel ?";
            this.lblOtherAccountType.Visible = false;
            // 
            // inputAnswer1
            // 
            this.inputAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAnswer1.Location = new System.Drawing.Point(477, 264);
            this.inputAnswer1.Name = "inputAnswer1";
            this.inputAnswer1.Size = new System.Drawing.Size(154, 26);
            this.inputAnswer1.TabIndex = 25;
            this.inputAnswer1.Visible = false;
            // 
            // inputAnswer2
            // 
            this.inputAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAnswer2.Location = new System.Drawing.Point(477, 294);
            this.inputAnswer2.Name = "inputAnswer2";
            this.inputAnswer2.Size = new System.Drawing.Size(154, 26);
            this.inputAnswer2.TabIndex = 26;
            this.inputAnswer2.Visible = false;
            // 
            // inputAnswer3
            // 
            this.inputAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAnswer3.Location = new System.Drawing.Point(477, 325);
            this.inputAnswer3.Name = "inputAnswer3";
            this.inputAnswer3.Size = new System.Drawing.Size(154, 26);
            this.inputAnswer3.TabIndex = 27;
            this.inputAnswer3.Visible = false;
            // 
            // inputOtherAccountCC
            // 
            this.inputOtherAccountCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputOtherAccountCC.Location = new System.Drawing.Point(600, 43);
            this.inputOtherAccountCC.Name = "inputOtherAccountCC";
            this.inputOtherAccountCC.Size = new System.Drawing.Size(100, 26);
            this.inputOtherAccountCC.TabIndex = 28;
            this.inputOtherAccountCC.Visible = false;
            // 
            // picTypeAccount
            // 
            this.picTypeAccount.Location = new System.Drawing.Point(416, 49);
            this.picTypeAccount.Name = "picTypeAccount";
            this.picTypeAccount.Size = new System.Drawing.Size(32, 32);
            this.picTypeAccount.TabIndex = 29;
            this.picTypeAccount.TabStop = false;
            // 
            // picListAccount
            // 
            this.picListAccount.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("picListAccount.ImageStream")));
            this.picListAccount.TransparentColor = System.Drawing.Color.Transparent;
            this.picListAccount.Images.SetKeyName(0, "steam-logo.jpg");
            this.picListAccount.Images.SetKeyName(1, "Discord-logo.jpg");
            this.picListAccount.Images.SetKeyName(2, "BattleNEt-logo.png");
            this.picListAccount.Images.SetKeyName(3, "uplay-logo.jpg");
            this.picListAccount.Images.SetKeyName(4, "origin-logo.jpg");
            this.picListAccount.Images.SetKeyName(5, "microsoft-logo.jpg");
            this.picListAccount.Images.SetKeyName(6, "gog-logo.jpg");
            this.picListAccount.Images.SetKeyName(7, "epic_games-logo.jpg");
            this.picListAccount.Images.SetKeyName(8, "twitch-logo.jpg");
            this.picListAccount.Images.SetKeyName(9, "amazon-logo.jpg");
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 466);
            this.Controls.Add(this.picTypeAccount);
            this.Controls.Add(this.inputOtherAccountCC);
            this.Controls.Add(this.inputAnswer3);
            this.Controls.Add(this.inputAnswer2);
            this.Controls.Add(this.inputAnswer1);
            this.Controls.Add(this.lblOtherAccountType);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.cbQuestion3);
            this.Controls.Add(this.cbQuestion2);
            this.Controls.Add(this.cbQuestion1);
            this.Controls.Add(this.lblQuestion3);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.inputTagAccount);
            this.Controls.Add(this.lblTagAccount);
            this.Controls.Add(this.inputEmailAccount);
            this.Controls.Add(this.inputPasswordAccount);
            this.Controls.Add(this.inputUserNameAccount);
            this.Controls.Add(this.cbTypeAccount);
            this.Controls.Add(this.lblEmailAddAccount);
            this.Controls.Add(this.lblPasswordAccount);
            this.Controls.Add(this.lblUserNameAccount);
            this.Controls.Add(this.lblTypeAccount);
            this.Name = "frmAddAccount";
            this.Text = "Ajout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddAccount_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picTypeAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeAccount;
        private System.Windows.Forms.Label lblUserNameAccount;
        private System.Windows.Forms.Label lblPasswordAccount;
        private System.Windows.Forms.Label lblEmailAddAccount;
        private System.Windows.Forms.ComboBox cbTypeAccount;
        private System.Windows.Forms.TextBox inputUserNameAccount;
        private System.Windows.Forms.TextBox inputPasswordAccount;
        private System.Windows.Forms.TextBox inputEmailAccount;
        private System.Windows.Forms.Label lblTagAccount;
        private System.Windows.Forms.TextBox inputTagAccount;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.ComboBox cbQuestion1;
        private System.Windows.Forms.ComboBox cbQuestion2;
        private System.Windows.Forms.ComboBox cbQuestion3;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Label lblOtherAccountType;
        private System.Windows.Forms.TextBox inputAnswer1;
        private System.Windows.Forms.TextBox inputAnswer2;
        private System.Windows.Forms.TextBox inputAnswer3;
        private System.Windows.Forms.TextBox inputOtherAccountCC;
        private System.Windows.Forms.PictureBox picTypeAccount;
        private System.Windows.Forms.ImageList picListAccount;
    }
}