namespace SeedSecure
{
    partial class Form_Decrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Decrypt));
            this.grpimportqr = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayload = new System.Windows.Forms.TextBox();
            this.tabCtrl_decrypt = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpDecrypt = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkCloseWebcam = new System.Windows.Forms.CheckBox();
            this.chkPassVisible = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkSeed = new System.Windows.Forms.CheckBox();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.chkPayload = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTransferSeed = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.timerSendKeys = new System.Windows.Forms.Timer(this.components);
            this.timerSigNewEncode = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkSeedVisible = new System.Windows.Forms.CheckBox();
            this.cbCoin_Donate = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonateAdress = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpdonate = new System.Windows.Forms.GroupBox();
            this.timerexpand = new System.Windows.Forms.Timer(this.components);
            this.btnCopyDonate = new System.Windows.Forms.Button();
            this.picChksum_Failed = new System.Windows.Forms.PictureBox();
            this.picChksum_Checked = new System.Windows.Forms.PictureBox();
            this.btnReffresh_Cam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picbox_webcam = new System.Windows.Forms.PictureBox();
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.btnOpenImg = new System.Windows.Forms.Button();
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.grpimportqr.SuspendLayout();
            this.tabCtrl_decrypt.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpDecrypt.SuspendLayout();
            this.grpdonate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChksum_Failed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChksum_Checked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_webcam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // grpimportqr
            // 
            this.grpimportqr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpimportqr.Controls.Add(this.picChksum_Failed);
            this.grpimportqr.Controls.Add(this.picChksum_Checked);
            this.grpimportqr.Controls.Add(this.label2);
            this.grpimportqr.Controls.Add(this.txtPayload);
            this.grpimportqr.Controls.Add(this.tabCtrl_decrypt);
            this.grpimportqr.Location = new System.Drawing.Point(12, 12);
            this.grpimportqr.Name = "grpimportqr";
            this.grpimportqr.Size = new System.Drawing.Size(611, 370);
            this.grpimportqr.TabIndex = 0;
            this.grpimportqr.TabStop = false;
            this.grpimportqr.Text = "Import QR Code";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Payload QR";
            // 
            // txtPayload
            // 
            this.txtPayload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayload.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayload.Location = new System.Drawing.Point(6, 290);
            this.txtPayload.Multiline = true;
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.Size = new System.Drawing.Size(595, 74);
            this.txtPayload.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtPayload, "This is the Payload - the data stored in the QR Code");
            this.txtPayload.TextChanged += new System.EventHandler(this.txtPayload_TextChanged);
            // 
            // tabCtrl_decrypt
            // 
            this.tabCtrl_decrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl_decrypt.Controls.Add(this.tabPage1);
            this.tabCtrl_decrypt.Controls.Add(this.tabPage2);
            this.tabCtrl_decrypt.Location = new System.Drawing.Point(6, 19);
            this.tabCtrl_decrypt.Name = "tabCtrl_decrypt";
            this.tabCtrl_decrypt.SelectedIndex = 0;
            this.tabCtrl_decrypt.Size = new System.Drawing.Size(599, 252);
            this.tabCtrl_decrypt.TabIndex = 0;
            this.tabCtrl_decrypt.SelectedIndexChanged += new System.EventHandler(this.tabCtrl_decrypt_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReffresh_Cam);
            this.tabPage1.Controls.Add(this.cmbDevice);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.picbox_webcam);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Webcam";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbDevice
            // 
            this.cmbDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(77, 6);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(468, 21);
            this.cmbDevice.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbDevice, "Select your Cameradevice here for capturing the QR Code.\r\nIf you don´t see any de" +
        "vices try the Reload-Button or use the Fileimport section.");
            this.cmbDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnScreenshot);
            this.tabPage2.Controls.Add(this.btnOpenImg);
            this.tabPage2.Controls.Add(this.picPicture);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpDecrypt
            // 
            this.grpDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDecrypt.Controls.Add(this.chkSeedVisible);
            this.grpDecrypt.Controls.Add(this.label7);
            this.grpDecrypt.Controls.Add(this.chkCloseWebcam);
            this.grpDecrypt.Controls.Add(this.chkPassVisible);
            this.grpDecrypt.Controls.Add(this.label6);
            this.grpDecrypt.Controls.Add(this.chkSeed);
            this.grpDecrypt.Controls.Add(this.chkPassword);
            this.grpDecrypt.Controls.Add(this.chkPayload);
            this.grpDecrypt.Controls.Add(this.label5);
            this.grpDecrypt.Controls.Add(this.btnTransferSeed);
            this.grpDecrypt.Controls.Add(this.label4);
            this.grpDecrypt.Controls.Add(this.txtSeed);
            this.grpDecrypt.Controls.Add(this.label3);
            this.grpDecrypt.Controls.Add(this.txtPassword);
            this.grpDecrypt.Location = new System.Drawing.Point(12, 388);
            this.grpDecrypt.Name = "grpDecrypt";
            this.grpDecrypt.Size = new System.Drawing.Size(611, 216);
            this.grpDecrypt.TabIndex = 1;
            this.grpDecrypt.TabStop = false;
            this.grpDecrypt.Text = "Decrypt && Use Seed";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(420, 43);
            this.label7.TabIndex = 18;
            this.label7.Text = "After pressing the button you have 5 seconds to switch to the wallet and put the " +
    "cursor into the seed textbox. After the 5 seconds the program starts automatical" +
    "ly with typing your seed.";
            // 
            // chkCloseWebcam
            // 
            this.chkCloseWebcam.AutoSize = true;
            this.chkCloseWebcam.Checked = true;
            this.chkCloseWebcam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCloseWebcam.Location = new System.Drawing.Point(215, 187);
            this.chkCloseWebcam.Name = "chkCloseWebcam";
            this.chkCloseWebcam.Size = new System.Drawing.Size(98, 17);
            this.chkCloseWebcam.TabIndex = 17;
            this.chkCloseWebcam.Text = "Close Webcam";
            this.toolTip1.SetToolTip(this.chkCloseWebcam, "After the Transfer all this checked data is reset, so you cannot forget it here u" +
        "nencrypted.");
            this.chkCloseWebcam.UseVisualStyleBackColor = true;
            // 
            // chkPassVisible
            // 
            this.chkPassVisible.AutoSize = true;
            this.chkPassVisible.Location = new System.Drawing.Point(329, 21);
            this.chkPassVisible.Name = "chkPassVisible";
            this.chkPassVisible.Size = new System.Drawing.Size(104, 17);
            this.chkPassVisible.TabIndex = 16;
            this.chkPassVisible.Text = "Password visible";
            this.chkPassVisible.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkPassVisible.UseVisualStyleBackColor = true;
            this.chkPassVisible.CheckedChanged += new System.EventHandler(this.chkPassVisible_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Automatically Reset those fields after Key is sent:";
            // 
            // chkSeed
            // 
            this.chkSeed.AutoSize = true;
            this.chkSeed.Checked = true;
            this.chkSeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSeed.Location = new System.Drawing.Point(158, 187);
            this.chkSeed.Name = "chkSeed";
            this.chkSeed.Size = new System.Drawing.Size(51, 17);
            this.chkSeed.TabIndex = 14;
            this.chkSeed.Text = "Seed";
            this.toolTip1.SetToolTip(this.chkSeed, "After the Transfer all this checked data is reset, so you cannot forget it here u" +
        "nencrypted.");
            this.chkSeed.UseVisualStyleBackColor = true;
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Checked = true;
            this.chkPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPassword.Location = new System.Drawing.Point(80, 187);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(72, 17);
            this.chkPassword.TabIndex = 13;
            this.chkPassword.Text = "Password";
            this.toolTip1.SetToolTip(this.chkPassword, "After the Transfer all this checked data is reset, so you cannot forget it here u" +
        "nencrypted.");
            this.chkPassword.UseVisualStyleBackColor = true;
            // 
            // chkPayload
            // 
            this.chkPayload.AutoSize = true;
            this.chkPayload.Checked = true;
            this.chkPayload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPayload.Location = new System.Drawing.Point(10, 187);
            this.chkPayload.Name = "chkPayload";
            this.chkPayload.Size = new System.Drawing.Size(64, 17);
            this.chkPayload.TabIndex = 12;
            this.chkPayload.Text = "Payload";
            this.toolTip1.SetToolTip(this.chkPayload, "After the Transfer all this checked data is reset, so you cannot forget it here u" +
        "nencrypted.");
            this.chkPayload.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "To prevent your seed from beeing stolen from copy/paste clipboard this software s" +
    "ends your seed to the wallet and act for this reason as a keyboard.";
            // 
            // btnTransferSeed
            // 
            this.btnTransferSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferSeed.Location = new System.Drawing.Point(6, 87);
            this.btnTransferSeed.Name = "btnTransferSeed";
            this.btnTransferSeed.Size = new System.Drawing.Size(163, 81);
            this.btnTransferSeed.TabIndex = 10;
            this.btnTransferSeed.Text = "Transfer Seed anywhere without Copy && Paste";
            this.toolTip1.SetToolTip(this.btnTransferSeed, "Transfer Seed as decribed");
            this.btnTransferSeed.UseVisualStyleBackColor = true;
            this.btnTransferSeed.Click += new System.EventHandler(this.btnTransferSeed_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seed";
            // 
            // txtSeed
            // 
            this.txtSeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeed.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeed.Location = new System.Drawing.Point(6, 61);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(595, 20);
            this.txtSeed.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtSeed, "This is your Seed stored in the QR Code. Use the button below to transfer it to t" +
        "he inputfield of your wallet.");
            this.txtSeed.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(65, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(258, 20);
            this.txtPassword.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtPassword, "Use your password you used for encrypting your Seed.\r\nIf you forgot your password" +
        " there is NO way to get your Seed back.");
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // timerSendKeys
            // 
            this.timerSendKeys.Interval = 1000;
            this.timerSendKeys.Tick += new System.EventHandler(this.timerSendKeys_Tick);
            // 
            // timerSigNewEncode
            // 
            this.timerSigNewEncode.Interval = 500;
            this.timerSigNewEncode.Tick += new System.EventHandler(this.timerSigNewEncode_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 300;
            this.toolTip1.ReshowDelay = 30;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // chkSeedVisible
            // 
            this.chkSeedVisible.AutoSize = true;
            this.chkSeedVisible.Location = new System.Drawing.Point(44, 44);
            this.chkSeedVisible.Name = "chkSeedVisible";
            this.chkSeedVisible.Size = new System.Drawing.Size(83, 17);
            this.chkSeedVisible.TabIndex = 19;
            this.chkSeedVisible.Text = "Seed visible";
            this.chkSeedVisible.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkSeedVisible.UseVisualStyleBackColor = true;
            this.chkSeedVisible.CheckedChanged += new System.EventHandler(this.chkSeedVisible_CheckedChanged);
            // 
            // cbCoin_Donate
            // 
            this.cbCoin_Donate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCoin_Donate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoin_Donate.FormattingEnabled = true;
            this.cbCoin_Donate.Location = new System.Drawing.Point(529, 76);
            this.cbCoin_Donate.Name = "cbCoin_Donate";
            this.cbCoin_Donate.Size = new System.Drawing.Size(77, 21);
            this.cbCoin_Donate.TabIndex = 8;
            this.toolTip1.SetToolTip(this.cbCoin_Donate, "Supported coins for donating");
            this.cbCoin_Donate.SelectedIndexChanged += new System.EventHandler(this.cbCoin_Donate_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.PaleGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(600, 47);
            this.label8.TabIndex = 7;
            this.label8.Text = "I hope everything worked out well :)\r\nWith the adress below you can invite me to " +
    "a digital cup of coffee or a beer if you want to ;)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDonateAdress
            // 
            this.txtDonateAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonateAdress.Location = new System.Drawing.Point(6, 66);
            this.txtDonateAdress.Multiline = true;
            this.txtDonateAdress.Name = "txtDonateAdress";
            this.txtDonateAdress.ReadOnly = true;
            this.txtDonateAdress.Size = new System.Drawing.Size(485, 39);
            this.txtDonateAdress.TabIndex = 6;
            this.txtDonateAdress.Text = "Donate\r\n";
            this.toolTip1.SetToolTip(this.txtDonateAdress, "This is my reciving adress for the selected coin. If you like my software you can" +
        " choose a coin of you favor and send me some bucks for all the coffe needed deve" +
        "loping this tiny software ;)");
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpdonate
            // 
            this.grpdonate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpdonate.BackColor = System.Drawing.SystemColors.Control;
            this.grpdonate.Controls.Add(this.label8);
            this.grpdonate.Controls.Add(this.btnCopyDonate);
            this.grpdonate.Controls.Add(this.txtDonateAdress);
            this.grpdonate.Controls.Add(this.cbCoin_Donate);
            this.grpdonate.Location = new System.Drawing.Point(12, 610);
            this.grpdonate.Name = "grpdonate";
            this.grpdonate.Size = new System.Drawing.Size(612, 111);
            this.grpdonate.TabIndex = 10;
            this.grpdonate.TabStop = false;
            // 
            // timerexpand
            // 
            this.timerexpand.Interval = 20;
            this.timerexpand.Tick += new System.EventHandler(this.timerexpand_Tick);
            // 
            // btnCopyDonate
            // 
            this.btnCopyDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyDonate.Image = global::SeedSecure.Properties.Resources.Copy_16x;
            this.btnCopyDonate.Location = new System.Drawing.Point(497, 66);
            this.btnCopyDonate.Name = "btnCopyDonate";
            this.btnCopyDonate.Size = new System.Drawing.Size(26, 39);
            this.btnCopyDonate.TabIndex = 9;
            this.btnCopyDonate.UseVisualStyleBackColor = true;
            this.btnCopyDonate.Click += new System.EventHandler(this.btnCopyDonate_Click);
            // 
            // picChksum_Failed
            // 
            this.picChksum_Failed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picChksum_Failed.BackColor = System.Drawing.SystemColors.Window;
            this.picChksum_Failed.Image = ((System.Drawing.Image)(resources.GetObject("picChksum_Failed.Image")));
            this.picChksum_Failed.Location = new System.Drawing.Point(561, 324);
            this.picChksum_Failed.Name = "picChksum_Failed";
            this.picChksum_Failed.Size = new System.Drawing.Size(39, 39);
            this.picChksum_Failed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChksum_Failed.TabIndex = 4;
            this.picChksum_Failed.TabStop = false;
            this.toolTip1.SetToolTip(this.picChksum_Failed, resources.GetString("picChksum_Failed.ToolTip"));
            this.picChksum_Failed.Visible = false;
            // 
            // picChksum_Checked
            // 
            this.picChksum_Checked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picChksum_Checked.BackColor = System.Drawing.SystemColors.Window;
            this.picChksum_Checked.Image = ((System.Drawing.Image)(resources.GetObject("picChksum_Checked.Image")));
            this.picChksum_Checked.Location = new System.Drawing.Point(561, 324);
            this.picChksum_Checked.Name = "picChksum_Checked";
            this.picChksum_Checked.Size = new System.Drawing.Size(39, 39);
            this.picChksum_Checked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChksum_Checked.TabIndex = 3;
            this.picChksum_Checked.TabStop = false;
            this.toolTip1.SetToolTip(this.picChksum_Checked, "This sign means that the data read from QR Code is correct. This has nothing todo" +
        " with your password.");
            this.picChksum_Checked.Visible = false;
            // 
            // btnReffresh_Cam
            // 
            this.btnReffresh_Cam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReffresh_Cam.Image = global::SeedSecure.Properties.Resources.Refresh_grey_16x;
            this.btnReffresh_Cam.Location = new System.Drawing.Point(551, 6);
            this.btnReffresh_Cam.Name = "btnReffresh_Cam";
            this.btnReffresh_Cam.Size = new System.Drawing.Size(34, 22);
            this.btnReffresh_Cam.TabIndex = 4;
            this.btnReffresh_Cam.UseVisualStyleBackColor = true;
            this.btnReffresh_Cam.Click += new System.EventHandler(this.btnReffresh_Cam_Click);
            // 
            // label1
            // 
            this.label1.Image = global::SeedSecure.Properties.Resources.Camera_16x;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picbox_webcam
            // 
            this.picbox_webcam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_webcam.BackColor = System.Drawing.Color.DarkGray;
            this.picbox_webcam.Location = new System.Drawing.Point(6, 33);
            this.picbox_webcam.Name = "picbox_webcam";
            this.picbox_webcam.Size = new System.Drawing.Size(579, 187);
            this.picbox_webcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_webcam.TabIndex = 0;
            this.picbox_webcam.TabStop = false;
            this.toolTip1.SetToolTip(this.picbox_webcam, resources.GetString("picbox_webcam.ToolTip"));
            this.picbox_webcam.Paint += new System.Windows.Forms.PaintEventHandler(this.picbox_webcam_Paint);
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreenshot.Image = global::SeedSecure.Properties.Resources.FullScreenshot_16x;
            this.btnScreenshot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreenshot.Location = new System.Drawing.Point(448, 6);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(137, 23);
            this.btnScreenshot.TabIndex = 2;
            this.btnScreenshot.Text = "Take Screenshot";
            this.toolTip1.SetToolTip(this.btnScreenshot, "Take a Screenshot of your actual screen if you have your QR Code opened somewhere" +
        " visible");
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // btnOpenImg
            // 
            this.btnOpenImg.Image = global::SeedSecure.Properties.Resources.Folder_16xMD;
            this.btnOpenImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenImg.Location = new System.Drawing.Point(8, 6);
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.Size = new System.Drawing.Size(191, 23);
            this.btnOpenImg.TabIndex = 1;
            this.btnOpenImg.Text = "Open picture containing QR";
            this.toolTip1.SetToolTip(this.btnOpenImg, "You can load different types of Images and also PDF containig your QR Code.");
            this.btnOpenImg.UseVisualStyleBackColor = true;
            this.btnOpenImg.Click += new System.EventHandler(this.btnOpenImg_Click);
            // 
            // picPicture
            // 
            this.picPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPicture.BackColor = System.Drawing.Color.DarkGray;
            this.picPicture.Location = new System.Drawing.Point(6, 35);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(579, 185);
            this.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPicture.TabIndex = 0;
            this.picPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.picPicture, "File Preview");
            // 
            // Form_Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 733);
            this.Controls.Add(this.grpdonate);
            this.Controls.Add(this.grpDecrypt);
            this.Controls.Add(this.grpimportqr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 660);
            this.Name = "Form_Decrypt";
            this.Text = "Restore Seed from QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Decrypt_FormClosing);
            this.Load += new System.EventHandler(this.Form_Decrypt_Load);
            this.grpimportqr.ResumeLayout(false);
            this.grpimportqr.PerformLayout();
            this.tabCtrl_decrypt.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpDecrypt.ResumeLayout(false);
            this.grpDecrypt.PerformLayout();
            this.grpdonate.ResumeLayout(false);
            this.grpdonate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChksum_Failed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChksum_Checked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_webcam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpimportqr;
        private System.Windows.Forms.TabControl tabCtrl_decrypt;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox picbox_webcam;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPayload;
        private System.Windows.Forms.GroupBox grpDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTransferSeed;
        private System.Windows.Forms.Timer timerSendKeys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSeed;
        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.CheckBox chkPayload;
        private System.Windows.Forms.CheckBox chkPassVisible;
        private System.Windows.Forms.CheckBox chkCloseWebcam;
        private System.Windows.Forms.Button btnOpenImg;
        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerSigNewEncode;
        private System.Windows.Forms.Button btnScreenshot;
        private System.Windows.Forms.PictureBox picChksum_Checked;
        private System.Windows.Forms.PictureBox picChksum_Failed;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnReffresh_Cam;
        private System.Windows.Forms.CheckBox chkSeedVisible;
        private System.Windows.Forms.Button btnCopyDonate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpdonate;
        private System.Windows.Forms.ComboBox cbCoin_Donate;
        private System.Windows.Forms.TextBox txtDonateAdress;
        private System.Windows.Forms.Timer timerexpand;
    }
}