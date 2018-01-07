namespace SeedSecure
{
    partial class Form_Encrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Encrypt));
            this.txtseed = new System.Windows.Forms.TextBox();
            this.grpseed = new System.Windows.Forms.GroupBox();
            this.txtencrypted = new System.Windows.Forms.TextBox();
            this.chkEditable = new System.Windows.Forms.CheckBox();
            this.chkPassVisible = new System.Windows.Forms.CheckBox();
            this.lblEncrypted = new System.Windows.Forms.Label();
            this.lblkey = new System.Windows.Forms.Label();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.lblnumcharsseed = new System.Windows.Forms.Label();
            this.grpseedgen = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbNumChars = new System.Windows.Forms.ComboBox();
            this.chkspecial2 = new System.Windows.Forms.CheckBox();
            this.chkspecial1 = new System.Windows.Forms.CheckBox();
            this.chk9 = new System.Windows.Forms.CheckBox();
            this.chk08 = new System.Windows.Forms.CheckBox();
            this.chkAZ_small = new System.Windows.Forms.CheckBox();
            this.chkAZ = new System.Windows.Forms.CheckBox();
            this.btntransfer_generated_ext = new System.Windows.Forms.Button();
            this.btntransferintern = new System.Windows.Forms.Button();
            this.btnselnumberchars = new System.Windows.Forms.Button();
            this.rtbseedgen = new System.Windows.Forms.RichTextBox();
            this.chkmoreoptions = new System.Windows.Forms.CheckBox();
            this.btnseedauto = new System.Windows.Forms.Button();
            this.lblnumselected = new System.Windows.Forms.Label();
            this.lblnumcharsseedgen = new System.Windows.Forms.Label();
            this.cbbcurrency = new System.Windows.Forms.ComboBox();
            this.btngenseed = new System.Windows.Forms.Button();
            this.timerexpand = new System.Windows.Forms.Timer(this.components);
            this.timersendkeys = new System.Windows.Forms.Timer(this.components);
            this.grpgenerateqr = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackSize = new System.Windows.Forms.TrackBar();
            this.txtqrdesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsaveqr = new System.Windows.Forms.Button();
            this.btnprintqr = new System.Windows.Forms.Button();
            this.picboxqr = new System.Windows.Forms.PictureBox();
            this.btngenerateqr = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpseed.SuspendLayout();
            this.grpseedgen.SuspendLayout();
            this.grpgenerateqr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxqr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtseed
            // 
            this.txtseed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtseed.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtseed.Location = new System.Drawing.Point(6, 19);
            this.txtseed.MaxLength = 250;
            this.txtseed.Name = "txtseed";
            this.txtseed.Size = new System.Drawing.Size(598, 20);
            this.txtseed.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtseed, "Type here your Seed or Phrase you want to encrypt and save as QR Code");
            this.txtseed.TextChanged += new System.EventHandler(this.txtseed_TextChanged);
            // 
            // grpseed
            // 
            this.grpseed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpseed.Controls.Add(this.txtencrypted);
            this.grpseed.Controls.Add(this.chkEditable);
            this.grpseed.Controls.Add(this.chkPassVisible);
            this.grpseed.Controls.Add(this.lblEncrypted);
            this.grpseed.Controls.Add(this.lblkey);
            this.grpseed.Controls.Add(this.txtkey);
            this.grpseed.Controls.Add(this.lblnumcharsseed);
            this.grpseed.Controls.Add(this.txtseed);
            this.grpseed.Location = new System.Drawing.Point(12, 407);
            this.grpseed.Name = "grpseed";
            this.grpseed.Size = new System.Drawing.Size(616, 165);
            this.grpseed.TabIndex = 1;
            this.grpseed.TabStop = false;
            this.grpseed.Text = "Type (a part of) your Seed to Encrypt";
            // 
            // txtencrypted
            // 
            this.txtencrypted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtencrypted.Location = new System.Drawing.Point(109, 71);
            this.txtencrypted.Multiline = true;
            this.txtencrypted.Name = "txtencrypted";
            this.txtencrypted.ReadOnly = true;
            this.txtencrypted.Size = new System.Drawing.Size(498, 84);
            this.txtencrypted.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtencrypted, "This is the data produced from your Seed and your Password");
            this.txtencrypted.DoubleClick += new System.EventHandler(this.txtencrypted_DoubleClick);
            // 
            // chkEditable
            // 
            this.chkEditable.AutoSize = true;
            this.chkEditable.Location = new System.Drawing.Point(9, 138);
            this.chkEditable.Name = "chkEditable";
            this.chkEditable.Size = new System.Drawing.Size(70, 17);
            this.chkEditable.TabIndex = 18;
            this.chkEditable.Text = "Edit Data";
            this.toolTip1.SetToolTip(this.chkEditable, "You can change ");
            this.chkEditable.UseVisualStyleBackColor = true;
            this.chkEditable.CheckedChanged += new System.EventHandler(this.chkEditable_CheckedChanged);
            // 
            // chkPassVisible
            // 
            this.chkPassVisible.AutoSize = true;
            this.chkPassVisible.Checked = true;
            this.chkPassVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPassVisible.Location = new System.Drawing.Point(365, 47);
            this.chkPassVisible.Name = "chkPassVisible";
            this.chkPassVisible.Size = new System.Drawing.Size(105, 17);
            this.chkPassVisible.TabIndex = 17;
            this.chkPassVisible.Text = "Password Visible";
            this.chkPassVisible.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkPassVisible.UseVisualStyleBackColor = true;
            this.chkPassVisible.CheckedChanged += new System.EventHandler(this.chkPassVisible_CheckedChanged);
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.Location = new System.Drawing.Point(6, 82);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(97, 25);
            this.lblEncrypted.TabIndex = 6;
            this.lblEncrypted.Text = "Encrypted data:";
            // 
            // lblkey
            // 
            this.lblkey.Location = new System.Drawing.Point(6, 42);
            this.lblkey.Name = "lblkey";
            this.lblkey.Size = new System.Drawing.Size(97, 30);
            this.lblkey.TabIndex = 4;
            this.lblkey.Text = "Password for encrypting seed:";
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(109, 45);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(250, 20);
            this.txtkey.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtkey, "Type here your Password. If you forget it, its NOT POSSIBLE to recover your Seed " +
        "from the QR Code");
            this.txtkey.TextChanged += new System.EventHandler(this.txtkey_TextChanged);
            // 
            // lblnumcharsseed
            // 
            this.lblnumcharsseed.AutoSize = true;
            this.lblnumcharsseed.Location = new System.Drawing.Point(470, 42);
            this.lblnumcharsseed.Name = "lblnumcharsseed";
            this.lblnumcharsseed.Size = new System.Drawing.Size(133, 13);
            this.lblnumcharsseed.TabIndex = 2;
            this.lblnumcharsseed.Text = "0 <-- Number of characters";
            // 
            // grpseedgen
            // 
            this.grpseedgen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpseedgen.Controls.Add(this.label8);
            this.grpseedgen.Controls.Add(this.cbbNumChars);
            this.grpseedgen.Controls.Add(this.chkspecial2);
            this.grpseedgen.Controls.Add(this.chkspecial1);
            this.grpseedgen.Controls.Add(this.chk9);
            this.grpseedgen.Controls.Add(this.chk08);
            this.grpseedgen.Controls.Add(this.chkAZ_small);
            this.grpseedgen.Controls.Add(this.chkAZ);
            this.grpseedgen.Controls.Add(this.btntransfer_generated_ext);
            this.grpseedgen.Controls.Add(this.btntransferintern);
            this.grpseedgen.Controls.Add(this.btnselnumberchars);
            this.grpseedgen.Controls.Add(this.rtbseedgen);
            this.grpseedgen.Controls.Add(this.chkmoreoptions);
            this.grpseedgen.Controls.Add(this.btnseedauto);
            this.grpseedgen.Controls.Add(this.lblnumselected);
            this.grpseedgen.Controls.Add(this.lblnumcharsseedgen);
            this.grpseedgen.Controls.Add(this.cbbcurrency);
            this.grpseedgen.Controls.Add(this.btngenseed);
            this.grpseedgen.Location = new System.Drawing.Point(12, 12);
            this.grpseedgen.Name = "grpseedgen";
            this.grpseedgen.Size = new System.Drawing.Size(616, 389);
            this.grpseedgen.TabIndex = 3;
            this.grpseedgen.TabStop = false;
            this.grpseedgen.Text = "Generate New Seed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Number of characters";
            // 
            // cbbNumChars
            // 
            this.cbbNumChars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNumChars.FormattingEnabled = true;
            this.cbbNumChars.Location = new System.Drawing.Point(324, 60);
            this.cbbNumChars.Name = "cbbNumChars";
            this.cbbNumChars.Size = new System.Drawing.Size(64, 21);
            this.cbbNumChars.TabIndex = 16;
            this.toolTip1.SetToolTip(this.cbbNumChars, "Select the character-set you want to use");
            this.cbbNumChars.SelectedIndexChanged += new System.EventHandler(this.cbbNumChars_SelectedIndexChanged);
            // 
            // chkspecial2
            // 
            this.chkspecial2.AutoSize = true;
            this.chkspecial2.Location = new System.Drawing.Point(498, 73);
            this.chkspecial2.Name = "chkspecial2";
            this.chkspecial2.Size = new System.Drawing.Size(72, 17);
            this.chkspecial2.TabIndex = 15;
            this.chkspecial2.Text = ".:,;\'/[]\"<>*";
            this.chkspecial2.UseVisualStyleBackColor = true;
            this.chkspecial2.CheckedChanged += new System.EventHandler(this.chkAZ_CheckedChanged);
            // 
            // chkspecial1
            // 
            this.chkspecial1.AutoSize = true;
            this.chkspecial1.Location = new System.Drawing.Point(498, 50);
            this.chkspecial1.Name = "chkspecial1";
            this.chkspecial1.Size = new System.Drawing.Size(77, 17);
            this.chkspecial1.TabIndex = 14;
            this.chkspecial1.Text = "=!?$%#+-()";
            this.chkspecial1.UseVisualStyleBackColor = true;
            this.chkspecial1.CheckedChanged += new System.EventHandler(this.chkAZ_CheckedChanged);
            // 
            // chk9
            // 
            this.chk9.AutoSize = true;
            this.chk9.Location = new System.Drawing.Point(451, 73);
            this.chk9.Name = "chk9";
            this.chk9.Size = new System.Drawing.Size(32, 17);
            this.chk9.TabIndex = 13;
            this.chk9.Text = "9";
            this.chk9.UseVisualStyleBackColor = true;
            this.chk9.CheckedChanged += new System.EventHandler(this.chkAZ_CheckedChanged);
            // 
            // chk08
            // 
            this.chk08.AutoSize = true;
            this.chk08.Location = new System.Drawing.Point(451, 50);
            this.chk08.Name = "chk08";
            this.chk08.Size = new System.Drawing.Size(41, 17);
            this.chk08.TabIndex = 12;
            this.chk08.Text = "0-8";
            this.chk08.UseVisualStyleBackColor = true;
            this.chk08.CheckedChanged += new System.EventHandler(this.chkAZ_CheckedChanged);
            // 
            // chkAZ_small
            // 
            this.chkAZ_small.AutoSize = true;
            this.chkAZ_small.Location = new System.Drawing.Point(402, 73);
            this.chkAZ_small.Name = "chkAZ_small";
            this.chkAZ_small.Size = new System.Drawing.Size(40, 17);
            this.chkAZ_small.TabIndex = 11;
            this.chkAZ_small.Text = "a-z";
            this.chkAZ_small.UseVisualStyleBackColor = true;
            this.chkAZ_small.CheckedChanged += new System.EventHandler(this.chkAZ_CheckedChanged);
            // 
            // chkAZ
            // 
            this.chkAZ.AutoSize = true;
            this.chkAZ.Location = new System.Drawing.Point(402, 50);
            this.chkAZ.Name = "chkAZ";
            this.chkAZ.Size = new System.Drawing.Size(43, 17);
            this.chkAZ.TabIndex = 10;
            this.chkAZ.Text = "A-Z";
            this.chkAZ.UseVisualStyleBackColor = true;
            this.chkAZ.CheckedChanged += new System.EventHandler(this.chkAZ_CheckedChanged);
            // 
            // btntransfer_generated_ext
            // 
            this.btntransfer_generated_ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransfer_generated_ext.Location = new System.Drawing.Point(420, 311);
            this.btntransfer_generated_ext.Name = "btntransfer_generated_ext";
            this.btntransfer_generated_ext.Size = new System.Drawing.Size(187, 67);
            this.btntransfer_generated_ext.TabIndex = 9;
            this.btntransfer_generated_ext.Text = "Transfer it anywhere without Copy && Paste";
            this.toolTip1.SetToolTip(this.btntransfer_generated_ext, "Click to transfer the Seed anywhere without Copy & Paste. \r\nAfter clicking you ha" +
        "ve 5 Seconds to change the coursor to somewhere else, then the software starts t" +
        "yping the characters.");
            this.btntransfer_generated_ext.UseVisualStyleBackColor = true;
            this.btntransfer_generated_ext.Click += new System.EventHandler(this.btntransfer_generated_ext_Click);
            // 
            // btntransferintern
            // 
            this.btntransferintern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransferintern.Location = new System.Drawing.Point(230, 311);
            this.btntransferintern.Name = "btntransferintern";
            this.btntransferintern.Size = new System.Drawing.Size(184, 67);
            this.btntransferintern.TabIndex = 8;
            this.btntransferintern.Text = "Transfer it to\r\n\'Seed to Encrypt\' - Box\r\nwithout Copy && Paste";
            this.toolTip1.SetToolTip(this.btntransferintern, "Click to transfer the selected characters to the TextBox below without using Copy" +
        " & Paste");
            this.btntransferintern.UseVisualStyleBackColor = true;
            this.btntransferintern.Click += new System.EventHandler(this.btntransferintern_Click);
            // 
            // btnselnumberchars
            // 
            this.btnselnumberchars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselnumberchars.Location = new System.Drawing.Point(118, 311);
            this.btnselnumberchars.Name = "btnselnumberchars";
            this.btnselnumberchars.Size = new System.Drawing.Size(106, 67);
            this.btnselnumberchars.TabIndex = 7;
            this.btnselnumberchars.Text = "Select random 81 characters";
            this.toolTip1.SetToolTip(this.btnselnumberchars, "Click to select random 81 characters");
            this.btnselnumberchars.UseVisualStyleBackColor = true;
            this.btnselnumberchars.Click += new System.EventHandler(this.btnselnumberchars_Click);
            // 
            // rtbseedgen
            // 
            this.rtbseedgen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbseedgen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbseedgen.HideSelection = false;
            this.rtbseedgen.Location = new System.Drawing.Point(6, 96);
            this.rtbseedgen.Name = "rtbseedgen";
            this.rtbseedgen.Size = new System.Drawing.Size(601, 186);
            this.rtbseedgen.TabIndex = 4;
            this.rtbseedgen.Text = "";
            this.toolTip1.SetToolTip(this.rtbseedgen, "You can also edit this field by yourself by adding or deleting random characters");
            this.rtbseedgen.SelectionChanged += new System.EventHandler(this.rtbseedgen_SelectionChanged);
            this.rtbseedgen.TextChanged += new System.EventHandler(this.rtbseedgen_TextChanged);
            // 
            // chkmoreoptions
            // 
            this.chkmoreoptions.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkmoreoptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkmoreoptions.Location = new System.Drawing.Point(469, 11);
            this.chkmoreoptions.Name = "chkmoreoptions";
            this.chkmoreoptions.Size = new System.Drawing.Size(141, 32);
            this.chkmoreoptions.TabIndex = 6;
            this.chkmoreoptions.Text = "More Options";
            this.chkmoreoptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.chkmoreoptions, "Press for more Options to produce a Random Seed");
            this.chkmoreoptions.UseVisualStyleBackColor = true;
            this.chkmoreoptions.CheckedChanged += new System.EventHandler(this.chkMoreOptions_CheckedChanged);
            // 
            // btnseedauto
            // 
            this.btnseedauto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseedauto.Location = new System.Drawing.Point(147, 11);
            this.btnseedauto.Name = "btnseedauto";
            this.btnseedauto.Size = new System.Drawing.Size(316, 33);
            this.btnseedauto.TabIndex = 5;
            this.btnseedauto.Text = "Generate Seed";
            this.toolTip1.SetToolTip(this.btnseedauto, "At the moment this produces always 81 characters from the selected character-set");
            this.btnseedauto.UseVisualStyleBackColor = true;
            this.btnseedauto.Click += new System.EventHandler(this.btnseedauto_Click);
            // 
            // lblnumselected
            // 
            this.lblnumselected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnumselected.Location = new System.Drawing.Point(248, 285);
            this.lblnumselected.Name = "lblnumselected";
            this.lblnumselected.Size = new System.Drawing.Size(135, 23);
            this.lblnumselected.TabIndex = 4;
            this.lblnumselected.Text = "0 <--Numbers Selected";
            this.lblnumselected.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblnumcharsseedgen
            // 
            this.lblnumcharsseedgen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnumcharsseedgen.Location = new System.Drawing.Point(389, 285);
            this.lblnumcharsseedgen.Name = "lblnumcharsseedgen";
            this.lblnumcharsseedgen.Size = new System.Drawing.Size(221, 23);
            this.lblnumcharsseedgen.TabIndex = 3;
            this.lblnumcharsseedgen.Text = "0 <-- (Generated) Number of Characters";
            this.lblnumcharsseedgen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbbcurrency
            // 
            this.cbbcurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbcurrency.FormattingEnabled = true;
            this.cbbcurrency.Items.AddRange(new object[] {
            "IOTA",
            "All Characters",
            "Custom"});
            this.cbbcurrency.Location = new System.Drawing.Point(6, 19);
            this.cbbcurrency.Name = "cbbcurrency";
            this.cbbcurrency.Size = new System.Drawing.Size(129, 21);
            this.cbbcurrency.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbbcurrency, "Select the character-set you want to use");
            this.cbbcurrency.SelectedIndexChanged += new System.EventHandler(this.cbbcurrency_SelectedIndexChanged);
            // 
            // btngenseed
            // 
            this.btngenseed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenseed.Location = new System.Drawing.Point(6, 311);
            this.btngenseed.Name = "btngenseed";
            this.btngenseed.Size = new System.Drawing.Size(106, 67);
            this.btngenseed.TabIndex = 1;
            this.btngenseed.Text = "Generate random characters";
            this.toolTip1.SetToolTip(this.btngenseed, "Press to generate 1000 new characters");
            this.btngenseed.UseVisualStyleBackColor = true;
            this.btngenseed.Click += new System.EventHandler(this.btngenseed_Click);
            // 
            // timerexpand
            // 
            this.timerexpand.Interval = 10;
            this.timerexpand.Tick += new System.EventHandler(this.timerexpand_Tick);
            // 
            // timersendkeys
            // 
            this.timersendkeys.Interval = 1000;
            this.timersendkeys.Tick += new System.EventHandler(this.timersendkeys_Tick);
            // 
            // grpgenerateqr
            // 
            this.grpgenerateqr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpgenerateqr.Controls.Add(this.label7);
            this.grpgenerateqr.Controls.Add(this.label6);
            this.grpgenerateqr.Controls.Add(this.label5);
            this.grpgenerateqr.Controls.Add(this.label4);
            this.grpgenerateqr.Controls.Add(this.trackSize);
            this.grpgenerateqr.Controls.Add(this.txtqrdesc);
            this.grpgenerateqr.Controls.Add(this.label3);
            this.grpgenerateqr.Controls.Add(this.btnsaveqr);
            this.grpgenerateqr.Controls.Add(this.btnprintqr);
            this.grpgenerateqr.Controls.Add(this.picboxqr);
            this.grpgenerateqr.Controls.Add(this.btngenerateqr);
            this.grpgenerateqr.Location = new System.Drawing.Point(12, 578);
            this.grpgenerateqr.Name = "grpgenerateqr";
            this.grpgenerateqr.Size = new System.Drawing.Size(616, 216);
            this.grpgenerateqr.TabIndex = 4;
            this.grpgenerateqr.TabStop = false;
            this.grpgenerateqr.Text = "QR Code";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 95);
            this.label7.TabIndex = 10;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Size of QR Code";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "lager";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "smaller";
            // 
            // trackSize
            // 
            this.trackSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackSize.Location = new System.Drawing.Point(457, 35);
            this.trackSize.Maximum = 14;
            this.trackSize.Minimum = 1;
            this.trackSize.Name = "trackSize";
            this.trackSize.Size = new System.Drawing.Size(104, 45);
            this.trackSize.TabIndex = 6;
            this.toolTip1.SetToolTip(this.trackSize, "Adjust the Size of the produced QR Code");
            this.trackSize.Value = 7;
            this.trackSize.Scroll += new System.EventHandler(this.trackSize_Scroll);
            // 
            // txtqrdesc
            // 
            this.txtqrdesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtqrdesc.Location = new System.Drawing.Point(262, 86);
            this.txtqrdesc.Name = "txtqrdesc";
            this.txtqrdesc.Size = new System.Drawing.Size(229, 20);
            this.txtqrdesc.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtqrdesc, "You can here directly add a note to the QR Code Image - for example: IOTA Wallet1" +
        " - so that you can assign the QR to a corresponding wallet ");
            this.txtqrdesc.TextChanged += new System.EventHandler(this.txtqrdesc_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add description to QR Code:";
            // 
            // btnsaveqr
            // 
            this.btnsaveqr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsaveqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveqr.Image = global::SeedSecure.Properties.Resources.Save_grey_16x;
            this.btnsaveqr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaveqr.Location = new System.Drawing.Point(262, 112);
            this.btnsaveqr.Name = "btnsaveqr";
            this.btnsaveqr.Size = new System.Drawing.Size(88, 45);
            this.btnsaveqr.TabIndex = 3;
            this.btnsaveqr.Text = "Save";
            this.toolTip1.SetToolTip(this.btnsaveqr, "Save the QR Code with Description as a Picturefile");
            this.btnsaveqr.UseVisualStyleBackColor = true;
            this.btnsaveqr.Click += new System.EventHandler(this.btnsaveqr_Click);
            // 
            // btnprintqr
            // 
            this.btnprintqr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprintqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintqr.Image = global::SeedSecure.Properties.Resources.PrintStatusBar4_16x;
            this.btnprintqr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprintqr.Location = new System.Drawing.Point(262, 163);
            this.btnprintqr.Name = "btnprintqr";
            this.btnprintqr.Size = new System.Drawing.Size(88, 45);
            this.btnprintqr.TabIndex = 2;
            this.btnprintqr.Text = "Print";
            this.toolTip1.SetToolTip(this.btnprintqr, "Print the QR Code directly on paper, or with PDF Printer to PDF");
            this.btnprintqr.UseVisualStyleBackColor = true;
            this.btnprintqr.Click += new System.EventHandler(this.btnprintqr_Click);
            // 
            // picboxqr
            // 
            this.picboxqr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxqr.BackColor = System.Drawing.Color.DarkGray;
            this.picboxqr.Location = new System.Drawing.Point(6, 19);
            this.picboxqr.Name = "picboxqr";
            this.picboxqr.Size = new System.Drawing.Size(250, 188);
            this.picboxqr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxqr.TabIndex = 1;
            this.picboxqr.TabStop = false;
            this.toolTip1.SetToolTip(this.picboxqr, "QR Code containing your Seed - keep it secure");
            // 
            // btngenerateqr
            // 
            this.btngenerateqr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btngenerateqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerateqr.Image = global::SeedSecure.Properties.Resources.Process_16x;
            this.btngenerateqr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngenerateqr.Location = new System.Drawing.Point(262, 18);
            this.btngenerateqr.Name = "btngenerateqr";
            this.btngenerateqr.Size = new System.Drawing.Size(189, 45);
            this.btngenerateqr.TabIndex = 0;
            this.btngenerateqr.Text = "Generate QR Code";
            this.toolTip1.SetToolTip(this.btngenerateqr, "Generate a QR Code from the Encrypted Data");
            this.btngenerateqr.UseVisualStyleBackColor = true;
            this.btngenerateqr.Click += new System.EventHandler(this.btngenerateqr_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form_Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 806);
            this.Controls.Add(this.grpgenerateqr);
            this.Controls.Add(this.grpseedgen);
            this.Controls.Add(this.grpseed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(653, 555);
            this.Name = "Form_Encrypt";
            this.Text = "Store Seed to QR Code";
            this.grpseed.ResumeLayout(false);
            this.grpseed.PerformLayout();
            this.grpseedgen.ResumeLayout(false);
            this.grpseedgen.PerformLayout();
            this.grpgenerateqr.ResumeLayout(false);
            this.grpgenerateqr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxqr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtseed;
        private System.Windows.Forms.GroupBox grpseed;
        private System.Windows.Forms.Label lblnumcharsseed;
        private System.Windows.Forms.Button btngenerateqr;
        private System.Windows.Forms.GroupBox grpseedgen;
        private System.Windows.Forms.ComboBox cbbcurrency;
        private System.Windows.Forms.Button btngenseed;
        private System.Windows.Forms.Label lblnumcharsseedgen;
        private System.Windows.Forms.Label lblnumselected;
        private System.Windows.Forms.CheckBox chkmoreoptions;
        private System.Windows.Forms.Button btnseedauto;
        private System.Windows.Forms.Timer timerexpand;
        private System.Windows.Forms.RichTextBox rtbseedgen;
        private System.Windows.Forms.Button btntransferintern;
        private System.Windows.Forms.Button btnselnumberchars;
        private System.Windows.Forms.Button btntransfer_generated_ext;
        private System.Windows.Forms.Timer timersendkeys;
        private System.Windows.Forms.GroupBox grpgenerateqr;
        private System.Windows.Forms.Label lblEncrypted;
        private System.Windows.Forms.TextBox txtencrypted;
        private System.Windows.Forms.Label lblkey;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.PictureBox picboxqr;
        private System.Windows.Forms.Button btnsaveqr;
        private System.Windows.Forms.Button btnprintqr;
        private System.Windows.Forms.TextBox txtqrdesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.CheckBox chkPassVisible;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk9;
        private System.Windows.Forms.CheckBox chk08;
        private System.Windows.Forms.CheckBox chkAZ_small;
        private System.Windows.Forms.CheckBox chkAZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbNumChars;
        private System.Windows.Forms.CheckBox chkEditable;
        public System.Windows.Forms.CheckBox chkspecial2;
        public System.Windows.Forms.CheckBox chkspecial1;
    }
}