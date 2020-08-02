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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rayMemberItemMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.compteItemMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveItemMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnModification = new System.Windows.Forms.Button();
            this.listCompte = new System.Windows.Forms.ListBox();
            this.paramItemMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bonjour Inconnue";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rayMemberItemMenus,
            this.addItemMenus});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rayMemberItemMenus
            // 
            this.rayMemberItemMenus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compteItemMenus,
            this.paramItemMenus,
            this.leaveItemMenus});
            this.rayMemberItemMenus.Name = "rayMemberItemMenus";
            this.rayMemberItemMenus.Size = new System.Drawing.Size(83, 20);
            this.rayMemberItemMenus.Text = "RayMember";
            // 
            // compteItemMenus
            // 
            this.compteItemMenus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificationToolStripMenuItem,
            this.déconnexionToolStripMenuItem});
            this.compteItemMenus.Name = "compteItemMenus";
            this.compteItemMenus.Size = new System.Drawing.Size(180, 22);
            this.compteItemMenus.Text = "Compte";
            // 
            // leaveItemMenus
            // 
            this.leaveItemMenus.Name = "leaveItemMenus";
            this.leaveItemMenus.Size = new System.Drawing.Size(180, 22);
            this.leaveItemMenus.Text = "Quitter";
            this.leaveItemMenus.Click += new System.EventHandler(this.leaveItemMenus_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            // 
            // addItemMenus
            // 
            this.addItemMenus.Name = "addItemMenus";
            this.addItemMenus.Size = new System.Drawing.Size(58, 20);
            this.addItemMenus.Text = "Ajouter";
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAccount.Location = new System.Drawing.Point(151, 340);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(119, 34);
            this.btnShowAccount.TabIndex = 3;
            this.btnShowAccount.Text = "Afficher";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnModification
            // 
            this.btnModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModification.Location = new System.Drawing.Point(368, 340);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(119, 34);
            this.btnModification.TabIndex = 4;
            this.btnModification.Text = "Modifier";
            this.btnModification.UseVisualStyleBackColor = true;
            // 
            // listCompte
            // 
            this.listCompte.FormattingEnabled = true;
            this.listCompte.Location = new System.Drawing.Point(151, 116);
            this.listCompte.Name = "listCompte";
            this.listCompte.Size = new System.Drawing.Size(336, 199);
            this.listCompte.TabIndex = 5;
            // 
            // paramItemMenus
            // 
            this.paramItemMenus.Name = "paramItemMenus";
            this.paramItemMenus.Size = new System.Drawing.Size(180, 22);
            this.paramItemMenus.Text = "Parametre";
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(642, 455);
            this.Controls.Add(this.listCompte);
            this.Controls.Add(this.btnModification);
            this.Controls.Add(this.btnShowAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddAccount";
            this.Text = "Ajout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddAccount_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rayMemberItemMenus;
        private System.Windows.Forms.ToolStripMenuItem compteItemMenus;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveItemMenus;
        private System.Windows.Forms.ToolStripMenuItem addItemMenus;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.ListBox listCompte;
        private System.Windows.Forms.ToolStripMenuItem paramItemMenus;
    }
}