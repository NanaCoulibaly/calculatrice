namespace prjWinCsCalculatriceStandadScientifique
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionStandardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionScientifiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bureauxChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionEnLigneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterProgrammeCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statutBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmesToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmesToolStripMenuItem
            // 
            this.programmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatricesToolStripMenuItem,
            this.bureauxChangeToolStripMenuItem,
            this.quitterProgrammeCtrlXToolStripMenuItem});
            this.programmesToolStripMenuItem.Name = "programmesToolStripMenuItem";
            this.programmesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.programmesToolStripMenuItem.Text = "Programmes";
            // 
            // calculatricesToolStripMenuItem
            // 
            this.calculatricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionStandardToolStripMenuItem,
            this.versionScientifiqueToolStripMenuItem});
            this.calculatricesToolStripMenuItem.Image = global::prjWinCsCalculatriceStandadScientifique.Properties.Resources.img2;
            this.calculatricesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calculatricesToolStripMenuItem.Name = "calculatricesToolStripMenuItem";
            this.calculatricesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.calculatricesToolStripMenuItem.Text = "Calculatrices";
            this.calculatricesToolStripMenuItem.Click += new System.EventHandler(this.calculatricesToolStripMenuItem_Click);
            // 
            // versionStandardToolStripMenuItem
            // 
            this.versionStandardToolStripMenuItem.Name = "versionStandardToolStripMenuItem";
            this.versionStandardToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.versionStandardToolStripMenuItem.Text = "Version Standard";
            this.versionStandardToolStripMenuItem.Click += new System.EventHandler(this.versionStandardToolStripMenuItem_Click);
            // 
            // versionScientifiqueToolStripMenuItem
            // 
            this.versionScientifiqueToolStripMenuItem.Name = "versionScientifiqueToolStripMenuItem";
            this.versionScientifiqueToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.versionScientifiqueToolStripMenuItem.Text = "Version Scientifique";
            this.versionScientifiqueToolStripMenuItem.Click += new System.EventHandler(this.versionScientifiqueToolStripMenuItem_Click);
            // 
            // bureauxChangeToolStripMenuItem
            // 
            this.bureauxChangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionLocalToolStripMenuItem,
            this.versionEnLigneToolStripMenuItem});
            this.bureauxChangeToolStripMenuItem.Image = global::prjWinCsCalculatriceStandadScientifique.Properties.Resources.img2;
            this.bureauxChangeToolStripMenuItem.Name = "bureauxChangeToolStripMenuItem";
            this.bureauxChangeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.bureauxChangeToolStripMenuItem.Text = "Bureaux Change";
            this.bureauxChangeToolStripMenuItem.Click += new System.EventHandler(this.bureauxChangeToolStripMenuItem_Click);
            // 
            // versionLocalToolStripMenuItem
            // 
            this.versionLocalToolStripMenuItem.Name = "versionLocalToolStripMenuItem";
            this.versionLocalToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.versionLocalToolStripMenuItem.Text = "Version Local";
            this.versionLocalToolStripMenuItem.Click += new System.EventHandler(this.versionLocalToolStripMenuItem_Click);
            // 
            // versionEnLigneToolStripMenuItem
            // 
            this.versionEnLigneToolStripMenuItem.Name = "versionEnLigneToolStripMenuItem";
            this.versionEnLigneToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.versionEnLigneToolStripMenuItem.Text = "Version En Ligne";
            // 
            // quitterProgrammeCtrlXToolStripMenuItem
            // 
            this.quitterProgrammeCtrlXToolStripMenuItem.Name = "quitterProgrammeCtrlXToolStripMenuItem";
            this.quitterProgrammeCtrlXToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.quitterProgrammeCtrlXToolStripMenuItem.Text = "Quitter Programme Ctrl-X";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Checked = true;
            this.viewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statutBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.toolBarToolStripMenuItem.Text = "ToolBar";
            // 
            // statutBarToolStripMenuItem
            // 
            this.statutBarToolStripMenuItem.Checked = true;
            this.statutBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statutBarToolStripMenuItem.Name = "statutBarToolStripMenuItem";
            this.statutBarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.statutBarToolStripMenuItem.Text = "Statut Bar";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelUtilisateurToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // manuelUtilisateurToolStripMenuItem
            // 
            this.manuelUtilisateurToolStripMenuItem.Name = "manuelUtilisateurToolStripMenuItem";
            this.manuelUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.manuelUtilisateurToolStripMenuItem.Text = "Manuel Utilisateur";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aProposToolStripMenuItem.Text = "A propos ... ...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::prjWinCsCalculatriceStandadScientifique.Properties.Resources.img1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 353);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Institut Teccart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionStandardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionScientifiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bureauxChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionEnLigneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterProgrammeCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statutBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

