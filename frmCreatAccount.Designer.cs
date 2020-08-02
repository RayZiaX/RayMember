namespace RayMember
{
    partial class frmCreatAccount
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
            this.lblUserNameCC = new System.Windows.Forms.Label();
            this.lblPasswordCC = new System.Windows.Forms.Label();
            this.lvlEmailCC = new System.Windows.Forms.Label();
            this.inputUserNameCC = new System.Windows.Forms.TextBox();
            this.inputPasswordCC = new System.Windows.Forms.TextBox();
            this.inputEmailCC = new System.Windows.Forms.TextBox();
            this.lblGenderCC = new System.Windows.Forms.Label();
            this.cBGender = new System.Windows.Forms.ComboBox();
            this.btnConfimCC = new System.Windows.Forms.Button();
            this.btnCancelCC = new System.Windows.Forms.Button();
            this.lblNationality = new System.Windows.Forms.Label();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUserNameCC
            // 
            this.lblUserNameCC.AutoSize = true;
            this.lblUserNameCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameCC.Location = new System.Drawing.Point(35, 65);
            this.lblUserNameCC.Name = "lblUserNameCC";
            this.lblUserNameCC.Size = new System.Drawing.Size(155, 25);
            this.lblUserNameCC.TabIndex = 0;
            this.lblUserNameCC.Text = "Nom d\'utilisateur";
            // 
            // lblPasswordCC
            // 
            this.lblPasswordCC.AutoSize = true;
            this.lblPasswordCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordCC.Location = new System.Drawing.Point(46, 137);
            this.lblPasswordCC.Name = "lblPasswordCC";
            this.lblPasswordCC.Size = new System.Drawing.Size(130, 25);
            this.lblPasswordCC.TabIndex = 0;
            this.lblPasswordCC.Text = "Mot de passe";
            // 
            // lvlEmailCC
            // 
            this.lvlEmailCC.AutoSize = true;
            this.lvlEmailCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlEmailCC.Location = new System.Drawing.Point(80, 206);
            this.lvlEmailCC.Name = "lvlEmailCC";
            this.lvlEmailCC.Size = new System.Drawing.Size(60, 25);
            this.lvlEmailCC.TabIndex = 0;
            this.lvlEmailCC.Text = "Email";
            // 
            // inputUserNameCC
            // 
            this.inputUserNameCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUserNameCC.Location = new System.Drawing.Point(206, 70);
            this.inputUserNameCC.Name = "inputUserNameCC";
            this.inputUserNameCC.Size = new System.Drawing.Size(168, 30);
            this.inputUserNameCC.TabIndex = 1;
            // 
            // inputPasswordCC
            // 
            this.inputPasswordCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPasswordCC.Location = new System.Drawing.Point(206, 137);
            this.inputPasswordCC.Name = "inputPasswordCC";
            this.inputPasswordCC.Size = new System.Drawing.Size(168, 30);
            this.inputPasswordCC.TabIndex = 2;
            this.inputPasswordCC.UseSystemPasswordChar = true;
            // 
            // inputEmailCC
            // 
            this.inputEmailCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEmailCC.Location = new System.Drawing.Point(206, 206);
            this.inputEmailCC.Name = "inputEmailCC";
            this.inputEmailCC.Size = new System.Drawing.Size(168, 30);
            this.inputEmailCC.TabIndex = 3;
            // 
            // lblGenderCC
            // 
            this.lblGenderCC.AutoSize = true;
            this.lblGenderCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderCC.Location = new System.Drawing.Point(438, 75);
            this.lblGenderCC.Name = "lblGenderCC";
            this.lblGenderCC.Size = new System.Drawing.Size(69, 25);
            this.lblGenderCC.TabIndex = 0;
            this.lblGenderCC.Text = "Civilité";
            // 
            // cBGender
            // 
            this.cBGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBGender.FormattingEnabled = true;
            this.cBGender.Items.AddRange(new object[] {
            "Homme",
            "Femme",
            "Autre"});
            this.cBGender.Location = new System.Drawing.Point(540, 76);
            this.cBGender.Name = "cBGender";
            this.cBGender.Size = new System.Drawing.Size(121, 28);
            this.cBGender.TabIndex = 4;
            // 
            // btnConfimCC
            // 
            this.btnConfimCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfimCC.Location = new System.Drawing.Point(137, 291);
            this.btnConfimCC.Name = "btnConfimCC";
            this.btnConfimCC.Size = new System.Drawing.Size(147, 48);
            this.btnConfimCC.TabIndex = 5;
            this.btnConfimCC.Text = "Confirmer";
            this.btnConfimCC.UseVisualStyleBackColor = true;
            this.btnConfimCC.Click += new System.EventHandler(this.btnConfimCC_Click);
            // 
            // btnCancelCC
            // 
            this.btnCancelCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCC.Location = new System.Drawing.Point(514, 291);
            this.btnCancelCC.Name = "btnCancelCC";
            this.btnCancelCC.Size = new System.Drawing.Size(147, 48);
            this.btnCancelCC.TabIndex = 6;
            this.btnCancelCC.Text = "Annuler";
            this.btnCancelCC.UseVisualStyleBackColor = true;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.Location = new System.Drawing.Point(409, 137);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(125, 25);
            this.lblNationality.TabIndex = 7;
            this.lblNationality.Text = "Nationnalitée";
            // 
            // cbNationality
            // 
            this.cbNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Items.AddRange(new object[] {
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
            this.cbNationality.Location = new System.Drawing.Point(540, 134);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(121, 28);
            this.cbNationality.TabIndex = 8;
            // 
            // frmCreatAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.cbNationality);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.btnCancelCC);
            this.Controls.Add(this.btnConfimCC);
            this.Controls.Add(this.cBGender);
            this.Controls.Add(this.lblGenderCC);
            this.Controls.Add(this.inputEmailCC);
            this.Controls.Add(this.inputPasswordCC);
            this.Controls.Add(this.inputUserNameCC);
            this.Controls.Add(this.lvlEmailCC);
            this.Controls.Add(this.lblPasswordCC);
            this.Controls.Add(this.lblUserNameCC);
            this.Name = "frmCreatAccount";
            this.Text = "frmCreatAccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreatAccount_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserNameCC;
        private System.Windows.Forms.Label lblPasswordCC;
        private System.Windows.Forms.Label lvlEmailCC;
        private System.Windows.Forms.TextBox inputUserNameCC;
        private System.Windows.Forms.TextBox inputPasswordCC;
        private System.Windows.Forms.TextBox inputEmailCC;
        private System.Windows.Forms.Label lblGenderCC;
        private System.Windows.Forms.ComboBox cBGender;
        private System.Windows.Forms.Button btnConfimCC;
        private System.Windows.Forms.Button btnCancelCC;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.ComboBox cbNationality;
    }
}