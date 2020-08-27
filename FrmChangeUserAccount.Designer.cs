namespace RayMember
{
    partial class FrmChangeUserAccount
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
            this.lblUserNameChangeAccount = new System.Windows.Forms.Label();
            this.lblPasswordChangeAccount = new System.Windows.Forms.Label();
            this.lblEmailChangeAccount = new System.Windows.Forms.Label();
            this.inputUserNameChangeAccount = new System.Windows.Forms.TextBox();
            this.inputPasswordChangeAccount = new System.Windows.Forms.TextBox();
            this.inputEmailChangeAccount = new System.Windows.Forms.TextBox();
            this.lblGenderChangeAccount = new System.Windows.Forms.Label();
            this.cbGenderChangeAccount = new System.Windows.Forms.ComboBox();
            this.cbNationalityChangeAccount = new System.Windows.Forms.ComboBox();
            this.lblNationalityChangeAccount = new System.Windows.Forms.Label();
            this.btnConfirmChangeAccount = new System.Windows.Forms.Button();
            this.btnCancelChangeAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserNameChangeAccount
            // 
            this.lblUserNameChangeAccount.AutoSize = true;
            this.lblUserNameChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameChangeAccount.Location = new System.Drawing.Point(12, 111);
            this.lblUserNameChangeAccount.Name = "lblUserNameChangeAccount";
            this.lblUserNameChangeAccount.Size = new System.Drawing.Size(155, 25);
            this.lblUserNameChangeAccount.TabIndex = 0;
            this.lblUserNameChangeAccount.Text = "Nom d\'utilisateur";
            // 
            // lblPasswordChangeAccount
            // 
            this.lblPasswordChangeAccount.AutoSize = true;
            this.lblPasswordChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordChangeAccount.Location = new System.Drawing.Point(26, 153);
            this.lblPasswordChangeAccount.Name = "lblPasswordChangeAccount";
            this.lblPasswordChangeAccount.Size = new System.Drawing.Size(130, 25);
            this.lblPasswordChangeAccount.TabIndex = 1;
            this.lblPasswordChangeAccount.Text = "Mot de passe";
            // 
            // lblEmailChangeAccount
            // 
            this.lblEmailChangeAccount.AutoSize = true;
            this.lblEmailChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailChangeAccount.Location = new System.Drawing.Point(56, 193);
            this.lblEmailChangeAccount.Name = "lblEmailChangeAccount";
            this.lblEmailChangeAccount.Size = new System.Drawing.Size(60, 25);
            this.lblEmailChangeAccount.TabIndex = 2;
            this.lblEmailChangeAccount.Text = "Email";
            // 
            // inputUserNameChangeAccount
            // 
            this.inputUserNameChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUserNameChangeAccount.Location = new System.Drawing.Point(207, 115);
            this.inputUserNameChangeAccount.Name = "inputUserNameChangeAccount";
            this.inputUserNameChangeAccount.Size = new System.Drawing.Size(149, 30);
            this.inputUserNameChangeAccount.TabIndex = 3;
            // 
            // inputPasswordChangeAccount
            // 
            this.inputPasswordChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPasswordChangeAccount.Location = new System.Drawing.Point(207, 153);
            this.inputPasswordChangeAccount.Name = "inputPasswordChangeAccount";
            this.inputPasswordChangeAccount.Size = new System.Drawing.Size(149, 30);
            this.inputPasswordChangeAccount.TabIndex = 4;
            // 
            // inputEmailChangeAccount
            // 
            this.inputEmailChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEmailChangeAccount.Location = new System.Drawing.Point(207, 190);
            this.inputEmailChangeAccount.Name = "inputEmailChangeAccount";
            this.inputEmailChangeAccount.Size = new System.Drawing.Size(149, 30);
            this.inputEmailChangeAccount.TabIndex = 5;
            // 
            // lblGenderChangeAccount
            // 
            this.lblGenderChangeAccount.AutoSize = true;
            this.lblGenderChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderChangeAccount.Location = new System.Drawing.Point(408, 116);
            this.lblGenderChangeAccount.Name = "lblGenderChangeAccount";
            this.lblGenderChangeAccount.Size = new System.Drawing.Size(69, 25);
            this.lblGenderChangeAccount.TabIndex = 6;
            this.lblGenderChangeAccount.Text = "Civilité";
            // 
            // cbGenderChangeAccount
            // 
            this.cbGenderChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenderChangeAccount.FormattingEnabled = true;
            this.cbGenderChangeAccount.Items.AddRange(new object[] {
            "Homme",
            "Femme",
            "Autre"});
            this.cbGenderChangeAccount.Location = new System.Drawing.Point(528, 109);
            this.cbGenderChangeAccount.Name = "cbGenderChangeAccount";
            this.cbGenderChangeAccount.Size = new System.Drawing.Size(121, 33);
            this.cbGenderChangeAccount.TabIndex = 7;
            // 
            // cbNationalityChangeAccount
            // 
            this.cbNationalityChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNationalityChangeAccount.FormattingEnabled = true;
            this.cbNationalityChangeAccount.Items.AddRange(new object[] {
            "United-States",
            "France",
            "United Kingdom",
            "German",
            "Poland",
            "Spanish",
            "Italia",
            "Brazilia",
            "Canada",
            "Japan",
            "Chinese",
            "Russian"});
            this.cbNationalityChangeAccount.Location = new System.Drawing.Point(528, 151);
            this.cbNationalityChangeAccount.Name = "cbNationalityChangeAccount";
            this.cbNationalityChangeAccount.Size = new System.Drawing.Size(121, 33);
            this.cbNationalityChangeAccount.TabIndex = 9;
            // 
            // lblNationalityChangeAccount
            // 
            this.lblNationalityChangeAccount.AutoSize = true;
            this.lblNationalityChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalityChangeAccount.Location = new System.Drawing.Point(384, 158);
            this.lblNationalityChangeAccount.Name = "lblNationalityChangeAccount";
            this.lblNationalityChangeAccount.Size = new System.Drawing.Size(114, 25);
            this.lblNationalityChangeAccount.TabIndex = 8;
            this.lblNationalityChangeAccount.Text = "Nationnalité";
            // 
            // btnConfirmChangeAccount
            // 
            this.btnConfirmChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmChangeAccount.Location = new System.Drawing.Point(115, 271);
            this.btnConfirmChangeAccount.Name = "btnConfirmChangeAccount";
            this.btnConfirmChangeAccount.Size = new System.Drawing.Size(152, 54);
            this.btnConfirmChangeAccount.TabIndex = 10;
            this.btnConfirmChangeAccount.Text = "Confirmer";
            this.btnConfirmChangeAccount.UseVisualStyleBackColor = true;
            this.btnConfirmChangeAccount.Click += new System.EventHandler(this.btnConfirmChangeAccount_Click);
            // 
            // btnCancelChangeAccount
            // 
            this.btnCancelChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChangeAccount.Location = new System.Drawing.Point(452, 271);
            this.btnCancelChangeAccount.Name = "btnCancelChangeAccount";
            this.btnCancelChangeAccount.Size = new System.Drawing.Size(152, 54);
            this.btnCancelChangeAccount.TabIndex = 11;
            this.btnCancelChangeAccount.Text = "Annuler";
            this.btnCancelChangeAccount.UseVisualStyleBackColor = true;
            this.btnCancelChangeAccount.Click += new System.EventHandler(this.btnCancelChangeAccount_Click);
            // 
            // FrmChangeUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 361);
            this.Controls.Add(this.btnCancelChangeAccount);
            this.Controls.Add(this.btnConfirmChangeAccount);
            this.Controls.Add(this.cbNationalityChangeAccount);
            this.Controls.Add(this.lblNationalityChangeAccount);
            this.Controls.Add(this.cbGenderChangeAccount);
            this.Controls.Add(this.lblGenderChangeAccount);
            this.Controls.Add(this.inputEmailChangeAccount);
            this.Controls.Add(this.inputPasswordChangeAccount);
            this.Controls.Add(this.inputUserNameChangeAccount);
            this.Controls.Add(this.lblEmailChangeAccount);
            this.Controls.Add(this.lblPasswordChangeAccount);
            this.Controls.Add(this.lblUserNameChangeAccount);
            this.Name = "FrmChangeUserAccount";
            this.Text = "modification du compte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmChangeUserAccount_FormClosed);
            this.Load += new System.EventHandler(this.FrmChangeUserAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserNameChangeAccount;
        private System.Windows.Forms.Label lblPasswordChangeAccount;
        private System.Windows.Forms.Label lblEmailChangeAccount;
        private System.Windows.Forms.TextBox inputUserNameChangeAccount;
        private System.Windows.Forms.TextBox inputPasswordChangeAccount;
        private System.Windows.Forms.TextBox inputEmailChangeAccount;
        private System.Windows.Forms.Label lblGenderChangeAccount;
        private System.Windows.Forms.ComboBox cbGenderChangeAccount;
        private System.Windows.Forms.ComboBox cbNationalityChangeAccount;
        private System.Windows.Forms.Label lblNationalityChangeAccount;
        private System.Windows.Forms.Button btnConfirmChangeAccount;
        private System.Windows.Forms.Button btnCancelChangeAccount;
    }
}