namespace RayMember
{
    partial class frmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnexion));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.inputUserName = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.lblInfoCC = new System.Windows.Forms.Label();
            this.lblCCompte = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.picParam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picParam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(123, 91);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(155, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Nom d\'utilisateur";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(138, 189);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(130, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mot de passe";
            // 
            // inputUserName
            // 
            this.inputUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUserName.Location = new System.Drawing.Point(106, 119);
            this.inputUserName.Name = "inputUserName";
            this.inputUserName.Size = new System.Drawing.Size(193, 30);
            this.inputUserName.TabIndex = 2;
            // 
            // inputPassword
            // 
            this.inputPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPassword.Location = new System.Drawing.Point(106, 217);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Size = new System.Drawing.Size(193, 30);
            this.inputPassword.TabIndex = 3;
            this.inputPassword.UseSystemPasswordChar = true;
            // 
            // lblInfoCC
            // 
            this.lblInfoCC.AutoSize = true;
            this.lblInfoCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCC.Location = new System.Drawing.Point(111, 331);
            this.lblInfoCC.Name = "lblInfoCC";
            this.lblInfoCC.Size = new System.Drawing.Size(182, 20);
            this.lblInfoCC.TabIndex = 4;
            this.lblInfoCC.Text = "Tu n\'as pas de compte ?";
            // 
            // lblCCompte
            // 
            this.lblCCompte.AutoSize = true;
            this.lblCCompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCompte.Location = new System.Drawing.Point(159, 351);
            this.lblCCompte.Name = "lblCCompte";
            this.lblCCompte.Size = new System.Drawing.Size(71, 20);
            this.lblCCompte.TabIndex = 5;
            this.lblCCompte.Text = "Clique ici";
            this.lblCCompte.Click += new System.EventHandler(this.lblCCompte_Click);
            this.lblCCompte.MouseLeave += new System.EventHandler(this.lblCCompte_MouseLeave);
            this.lblCCompte.MouseHover += new System.EventHandler(this.lblCCompte_MouseHover);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(128, 269);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(150, 50);
            this.btnConnexion.TabIndex = 6;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // picParam
            // 
            this.picParam.Image = ((System.Drawing.Image)(resources.GetObject("picParam.Image")));
            this.picParam.Location = new System.Drawing.Point(351, 23);
            this.picParam.Name = "picParam";
            this.picParam.Size = new System.Drawing.Size(32, 32);
            this.picParam.TabIndex = 7;
            this.picParam.TabStop = false;
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 502);
            this.Controls.Add(this.picParam);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lblCCompte);
            this.Controls.Add(this.lblInfoCC);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmConnexion";
            this.Text = "Connexion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConnexion_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picParam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox inputUserName;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label lblInfoCC;
        private System.Windows.Forms.Label lblCCompte;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.PictureBox picParam;
    }
}

