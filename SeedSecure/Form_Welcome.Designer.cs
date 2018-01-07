namespace SeedSecure
{
    partial class Form_Welcome
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Welcome));
            this.txtDonateAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCoin_Donate = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCopyDonate = new System.Windows.Forms.Button();
            this.buttondecrypt = new System.Windows.Forms.Button();
            this.buttonencrypt = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDonateAdress
            // 
            this.txtDonateAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonateAdress.Location = new System.Drawing.Point(10, 352);
            this.txtDonateAdress.Multiline = true;
            this.txtDonateAdress.Name = "txtDonateAdress";
            this.txtDonateAdress.ReadOnly = true;
            this.txtDonateAdress.Size = new System.Drawing.Size(349, 39);
            this.txtDonateAdress.TabIndex = 2;
            this.txtDonateAdress.Text = "Donate\r\n";
            this.toolTip1.SetToolTip(this.txtDonateAdress, "This is my reciving adress for the selected coin. If you like my software you can" +
        " choose a coin of you favor and send me some bucks for all the coffe needed deve" +
        "loping this tiny software ;)");
            this.txtDonateAdress.TextChanged += new System.EventHandler(this.txtDonateAdress_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Try the Software first and if you like it or think its useful\r\nyou can appreciate" +
    " my work with donating me a cup of coffee :)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbCoin_Donate
            // 
            this.cbCoin_Donate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCoin_Donate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoin_Donate.FormattingEnabled = true;
            this.cbCoin_Donate.Location = new System.Drawing.Point(397, 362);
            this.cbCoin_Donate.Name = "cbCoin_Donate";
            this.cbCoin_Donate.Size = new System.Drawing.Size(77, 21);
            this.cbCoin_Donate.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cbCoin_Donate, "Supported coins for donating");
            this.cbCoin_Donate.SelectedIndexChanged += new System.EventHandler(this.cbCoin_Donate_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 300;
            this.toolTip1.ReshowDelay = 30;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnCopyDonate
            // 
            this.btnCopyDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyDonate.Image = global::SeedSecure.Properties.Resources.Copy_16x;
            this.btnCopyDonate.Location = new System.Drawing.Point(365, 352);
            this.btnCopyDonate.Name = "btnCopyDonate";
            this.btnCopyDonate.Size = new System.Drawing.Size(26, 39);
            this.btnCopyDonate.TabIndex = 5;
            this.btnCopyDonate.UseVisualStyleBackColor = true;
            this.btnCopyDonate.Click += new System.EventHandler(this.btnCopyDonate_Click);
            // 
            // buttondecrypt
            // 
            this.buttondecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondecrypt.Image = ((System.Drawing.Image)(resources.GetObject("buttondecrypt.Image")));
            this.buttondecrypt.Location = new System.Drawing.Point(246, 72);
            this.buttondecrypt.Name = "buttondecrypt";
            this.buttondecrypt.Size = new System.Drawing.Size(228, 228);
            this.buttondecrypt.TabIndex = 1;
            this.buttondecrypt.UseVisualStyleBackColor = true;
            this.buttondecrypt.Click += new System.EventHandler(this.buttondecrypt_Click);
            // 
            // buttonencrypt
            // 
            this.buttonencrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonencrypt.Image = ((System.Drawing.Image)(resources.GetObject("buttonencrypt.Image")));
            this.buttonencrypt.Location = new System.Drawing.Point(10, 72);
            this.buttonencrypt.Name = "buttonencrypt";
            this.buttonencrypt.Size = new System.Drawing.Size(228, 228);
            this.buttonencrypt.TabIndex = 0;
            this.buttonencrypt.UseVisualStyleBackColor = true;
            this.buttonencrypt.Click += new System.EventHandler(this.buttonencrypt_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Image = global::SeedSecure.Properties.Resources.Question_16x;
            this.btnAbout.Location = new System.Drawing.Point(443, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(31, 42);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 399);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCopyDonate);
            this.Controls.Add(this.cbCoin_Donate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDonateAdress);
            this.Controls.Add(this.buttondecrypt);
            this.Controls.Add(this.buttonencrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Welcome";
            this.Text = "Secure Seed Storage";
            this.Load += new System.EventHandler(this.Form_Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonencrypt;
        private System.Windows.Forms.Button buttondecrypt;
        private System.Windows.Forms.TextBox txtDonateAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCoin_Donate;
        private System.Windows.Forms.Button btnCopyDonate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAbout;
    }
}

