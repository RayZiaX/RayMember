namespace RayMember
{
    partial class FrmMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rayMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationItemMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectItemMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.paramItemMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveItemMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnModifAccount = new System.Windows.Forms.Button();
            this.listAccount = new System.Windows.Forms.ListView();
            this.columnTypeAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserNameAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmailAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTagAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rayMemberToolStripMenuItem,
            this.addItemMenus});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rayMemberToolStripMenuItem
            // 
            this.rayMemberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compteItemMenu,
            this.paramItemMenus,
            this.leaveItemMenus});
            this.rayMemberToolStripMenuItem.Name = "rayMemberToolStripMenuItem";
            this.rayMemberToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.rayMemberToolStripMenuItem.Text = "RayMember";
            // 
            // compteItemMenu
            // 
            this.compteItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificationItemMenus,
            this.disconnectItemMenus});
            this.compteItemMenu.Name = "compteItemMenu";
            this.compteItemMenu.Size = new System.Drawing.Size(128, 22);
            this.compteItemMenu.Text = "Compte";
            // 
            // modificationItemMenus
            // 
            this.modificationItemMenus.Name = "modificationItemMenus";
            this.modificationItemMenus.Size = new System.Drawing.Size(144, 22);
            this.modificationItemMenus.Text = "Modifier";
            // 
            // disconnectItemMenus
            // 
            this.disconnectItemMenus.Name = "disconnectItemMenus";
            this.disconnectItemMenus.Size = new System.Drawing.Size(144, 22);
            this.disconnectItemMenus.Text = "Déconnexion";
            this.disconnectItemMenus.Click += new System.EventHandler(this.disconnectItemMenus_Click);
            // 
            // paramItemMenus
            // 
            this.paramItemMenus.Name = "paramItemMenus";
            this.paramItemMenus.Size = new System.Drawing.Size(128, 22);
            this.paramItemMenus.Text = "Parametre";
            // 
            // leaveItemMenus
            // 
            this.leaveItemMenus.Name = "leaveItemMenus";
            this.leaveItemMenus.Size = new System.Drawing.Size(128, 22);
            this.leaveItemMenus.Text = "Quitter";
            this.leaveItemMenus.Click += new System.EventHandler(this.leaveItemMenus_Click);
            // 
            // addItemMenus
            // 
            this.addItemMenus.Name = "addItemMenus";
            this.addItemMenus.Size = new System.Drawing.Size(58, 20);
            this.addItemMenus.Text = "Ajouter";
            this.addItemMenus.Click += new System.EventHandler(this.addItemMenus_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(137, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(285, 39);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Bonjour Inconnue";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.Location = new System.Drawing.Point(103, 347);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(110, 49);
            this.btnShowInfo.TabIndex = 3;
            this.btnShowInfo.Text = "Afficher";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(243, 347);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(112, 49);
            this.btnDeleteAccount.TabIndex = 4;
            this.btnDeleteAccount.Text = "Supprimer";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnModifAccount
            // 
            this.btnModifAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifAccount.Location = new System.Drawing.Point(382, 347);
            this.btnModifAccount.Name = "btnModifAccount";
            this.btnModifAccount.Size = new System.Drawing.Size(104, 49);
            this.btnModifAccount.TabIndex = 5;
            this.btnModifAccount.Text = "Modifier";
            this.btnModifAccount.UseVisualStyleBackColor = true;
            // 
            // listAccount
            // 
            this.listAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTypeAccount,
            this.columnUserNameAccount,
            this.columnEmailAccount,
            this.columnTagAccount});
            this.listAccount.FullRowSelect = true;
            this.listAccount.GridLines = true;
            this.listAccount.HideSelection = false;
            this.listAccount.Location = new System.Drawing.Point(103, 90);
            this.listAccount.Name = "listAccount";
            this.listAccount.Size = new System.Drawing.Size(383, 227);
            this.listAccount.TabIndex = 6;
            this.listAccount.UseCompatibleStateImageBehavior = false;
            this.listAccount.View = System.Windows.Forms.View.Details;
            // 
            // columnTypeAccount
            // 
            this.columnTypeAccount.Text = "Type de compte";
            // 
            // columnUserNameAccount
            // 
            this.columnUserNameAccount.Text = "Nom d\'utilisateur";
            // 
            // columnEmailAccount
            // 
            this.columnEmailAccount.Text = "Email";
            // 
            // columnTagAccount
            // 
            this.columnTagAccount.Text = "Tag";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 419);
            this.Controls.Add(this.listAccount);
            this.Controls.Add(this.btnModifAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainMenu";
            this.Text = "RayMember";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rayMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteItemMenu;
        private System.Windows.Forms.ToolStripMenuItem modificationItemMenus;
        private System.Windows.Forms.ToolStripMenuItem disconnectItemMenus;
        private System.Windows.Forms.ToolStripMenuItem paramItemMenus;
        private System.Windows.Forms.ToolStripMenuItem leaveItemMenus;
        private System.Windows.Forms.ToolStripMenuItem addItemMenus;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnModifAccount;
        private System.Windows.Forms.ListView listAccount;
        private System.Windows.Forms.ColumnHeader columnTypeAccount;
        private System.Windows.Forms.ColumnHeader columnUserNameAccount;
        private System.Windows.Forms.ColumnHeader columnEmailAccount;
        private System.Windows.Forms.ColumnHeader columnTagAccount;
    }
}