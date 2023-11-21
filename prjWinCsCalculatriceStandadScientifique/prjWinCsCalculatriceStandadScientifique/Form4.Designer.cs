namespace prjWinCsCalculatriceStandadScientifique
{
    partial class Form4
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
            this.cboPays = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radFranc = new System.Windows.Forms.RadioButton();
            this.radDollars = new System.Windows.Forms.RadioButton();
            this.lblAffichage = new System.Windows.Forms.Label();
            this.lblFranc = new System.Windows.Forms.Label();
            this.lblDollars = new System.Windows.Forms.Label();
            this.lblDevise = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.btnConversion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUREAU XCHANGE";
            // 
            // cboPays
            // 
            this.cboPays.FormattingEnabled = true;
            this.cboPays.Location = new System.Drawing.Point(12, 136);
            this.cboPays.Name = "cboPays";
            this.cboPays.Size = new System.Drawing.Size(210, 21);
            this.cboPays.TabIndex = 2;
            this.cboPays.Text = "Select Country";
            this.cboPays.SelectedIndexChanged += new System.EventHandler(this.cboPays_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFranc);
            this.groupBox1.Controls.Add(this.radDollars);
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de conversion";
            // 
            // radFranc
            // 
            this.radFranc.AutoSize = true;
            this.radFranc.Location = new System.Drawing.Point(26, 51);
            this.radFranc.Name = "radFranc";
            this.radFranc.Size = new System.Drawing.Size(14, 13);
            this.radFranc.TabIndex = 1;
            this.radFranc.TabStop = true;
            this.radFranc.UseVisualStyleBackColor = true;
            this.radFranc.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radDollars
            // 
            this.radDollars.AutoSize = true;
            this.radDollars.Location = new System.Drawing.Point(26, 23);
            this.radDollars.Name = "radDollars";
            this.radDollars.Size = new System.Drawing.Size(14, 13);
            this.radDollars.TabIndex = 0;
            this.radDollars.TabStop = true;
            this.radDollars.UseVisualStyleBackColor = true;
            this.radDollars.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblAffichage
            // 
            this.lblAffichage.BackColor = System.Drawing.SystemColors.Control;
            this.lblAffichage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAffichage.Location = new System.Drawing.Point(38, 384);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(122, 23);
            this.lblAffichage.TabIndex = 4;
            this.lblAffichage.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFranc
            // 
            this.lblFranc.BackColor = System.Drawing.SystemColors.Control;
            this.lblFranc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFranc.Location = new System.Drawing.Point(357, 195);
            this.lblFranc.Name = "lblFranc";
            this.lblFranc.Size = new System.Drawing.Size(292, 23);
            this.lblFranc.TabIndex = 5;
            // 
            // lblDollars
            // 
            this.lblDollars.BackColor = System.Drawing.SystemColors.Control;
            this.lblDollars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDollars.Location = new System.Drawing.Point(357, 150);
            this.lblDollars.Name = "lblDollars";
            this.lblDollars.Size = new System.Drawing.Size(292, 23);
            this.lblDollars.TabIndex = 6;
            // 
            // lblDevise
            // 
            this.lblDevise.BackColor = System.Drawing.SystemColors.Window;
            this.lblDevise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDevise.Location = new System.Drawing.Point(387, 251);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(118, 23);
            this.lblDevise.TabIndex = 7;
            this.lblDevise.Click += new System.EventHandler(this.lblDevise_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(387, 289);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(118, 20);
            this.txtMontant.TabIndex = 8;
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(616, 247);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(104, 23);
            this.btnConversion.TabIndex = 9;
            this.btnConversion.Text = "Convertir";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(616, 305);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(104, 23);
            this.btnQuitter.TabIndex = 10;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(616, 276);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(104, 23);
            this.btnEffacer.TabIndex = 11;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblDevise);
            this.Controls.Add(this.lblDollars);
            this.Controls.Add(this.lblFranc);
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboPays);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form4";
            this.Text = "$ Bureau de change international";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFranc;
        private System.Windows.Forms.RadioButton radDollars;
        private System.Windows.Forms.Label lblAffichage;
        private System.Windows.Forms.Label lblFranc;
        private System.Windows.Forms.Label lblDollars;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEffacer;
    }
}