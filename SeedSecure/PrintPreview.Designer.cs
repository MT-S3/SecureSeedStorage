namespace SeedSecure
{
    partial class PrintPreview
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
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.chkcenter = new System.Windows.Forms.CheckBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioport = new System.Windows.Forms.RadioButton();
            this.radiolandsc = new System.Windows.Forms.RadioButton();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl1.Location = new System.Drawing.Point(12, 83);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(614, 655);
            this.printPreviewControl1.TabIndex = 0;
            // 
            // chkcenter
            // 
            this.chkcenter.AutoSize = true;
            this.chkcenter.Location = new System.Drawing.Point(12, 38);
            this.chkcenter.Name = "chkcenter";
            this.chkcenter.Size = new System.Drawing.Size(57, 17);
            this.chkcenter.TabIndex = 1;
            this.chkcenter.Text = "Center";
            this.chkcenter.UseVisualStyleBackColor = true;
            this.chkcenter.CheckedChanged += new System.EventHandler(this.chkcenter_CheckedChanged);
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(183, 12);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(119, 65);
            this.btnprint.TabIndex = 2;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiolandsc);
            this.groupBox1.Controls.Add(this.radioport);
            this.groupBox1.Location = new System.Drawing.Point(75, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Page Orientation";
            // 
            // radioport
            // 
            this.radioport.AutoSize = true;
            this.radioport.Checked = true;
            this.radioport.Location = new System.Drawing.Point(6, 19);
            this.radioport.Name = "radioport";
            this.radioport.Size = new System.Drawing.Size(58, 17);
            this.radioport.TabIndex = 0;
            this.radioport.TabStop = true;
            this.radioport.Text = "Portrait";
            this.radioport.UseVisualStyleBackColor = true;
            // 
            // radiolandsc
            // 
            this.radiolandsc.AutoSize = true;
            this.radiolandsc.Location = new System.Drawing.Point(6, 42);
            this.radiolandsc.Name = "radiolandsc";
            this.radiolandsc.Size = new System.Drawing.Size(78, 17);
            this.radiolandsc.TabIndex = 1;
            this.radiolandsc.Text = "Landscape";
            this.radiolandsc.UseVisualStyleBackColor = true;
            this.radiolandsc.CheckedChanged += new System.EventHandler(this.radiolandsc_CheckedChanged);
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(308, 12);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(119, 65);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // PrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(638, 750);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.chkcenter);
            this.Controls.Add(this.printPreviewControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PrintPreview";
            this.Text = "Preview QR Print";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.CheckBox chkcenter;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiolandsc;
        private System.Windows.Forms.RadioButton radioport;
        private System.Windows.Forms.Button btncancel;
    }
}