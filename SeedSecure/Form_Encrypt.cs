using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Reflection;

using ZXing;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

using R = System.Security.Cryptography.RandomNumberGenerator;



namespace SeedSecure
{
    public partial class Form_Encrypt : Form
    {
        int max_height_grpseedgen = 0;
        int time2wait_forsendkeys = 5; //Seconds to wait, so you can change window
        int time2wait_counter = 0;
        int differenz_in_height = 0;
        Size before_motion;
        bool block_chk_update = false;


        #region Non specific Form Designer Functions
        public Form_Encrypt()
        {
            InitializeComponent();

            set_anchor_nontop();


            Size old_size = grpseedgen.Size;
            max_height_grpseedgen = old_size.Height;
            // Shrink the Produce GroupBox, so you can´t see the manually part
            grpseedgen.Size = new Size(old_size.Width, 50);
            differenz_in_height = (old_size.Height - 50);
            // Shrink the Total Form as much as the GroupBox
            this.Height = this.Height - differenz_in_height;

            set_anchor_top();

            before_motion = this.Size;

            // Filling of Number of chars ComboBox
            for (int i = 1; i <= 100; i++)
                cbbNumChars.Items.Add(i + "");
            cbbNumChars.SelectedIndex = 80;

            // Select IOTA as default
            cbbcurrency.SelectedIndex = 0;

        }

        #endregion

        #region Random Seed Generation

        #region Random - Form Designer Functions

        private void btngenseed_Click(object sender, EventArgs e)
        {
            rtbseedgen.Text = produce_random(1000);
        }

        private void btnseedauto_Click(object sender, EventArgs e)
        {
            txtseed.Text = produce_random();
        }
        private void chkMoreOptions_CheckedChanged(object sender, EventArgs e)
        {
            before_motion = this.Size;
            set_anchor_nontop();
            timerexpand.Start();
        }
        private void timerexpand_Tick(object sender, EventArgs e)
        {
            Size old_grp = grpseedgen.Size;
            Size old_form = this.Size;

            if (chkmoreoptions.Checked) // Expand the GroupBox for Generation
            {
                if (old_grp.Height >= max_height_grpseedgen)
                {
                    timerexpand.Stop();

                    grpseedgen.Size = new Size(old_grp.Width, max_height_grpseedgen);
                    this.Size = new Size(old_form.Width, before_motion.Height + differenz_in_height);

                    Refresh(); // Just if it doesn´t refresh continously

                    set_anchor_top();
                }
                else
                {
                    grpseedgen.Size = new Size(old_grp.Width, old_grp.Height + 8);
                    this.Size = new Size(old_form.Width, old_form.Height + 8);
                }
            }
            else
            {
                if (old_grp.Height <= 50)
                {
                    timerexpand.Stop();

                    grpseedgen.Size = new Size(old_grp.Width, 50);
                    this.Size = new Size(old_form.Width, before_motion.Height - differenz_in_height);

                    Refresh(); // Just if it doesn´t refresh continously

                    set_anchor_top();
                }
                else
                {
                    grpseedgen.Size = new Size(old_grp.Width, old_grp.Height - 8);
                    this.Size = new Size(old_form.Width, old_form.Height - 8);
                }
            }

        }

        private void cbbcurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            block_chk_update = true;
            switch (cbbcurrency.SelectedIndex)
            {
                case 0: // IOTA
                    chkAZ.Checked = true;
                    chk9.Checked = true;

                    chkAZ_small.Checked = false;
                    chk08.Checked = false;
                    chkspecial1.Checked = false;
                    chkspecial2.Checked = false;

                    cbbNumChars.SelectedIndex = 80;
                    break;
                case 1: // All characters
                    chkAZ.Checked = true;
                    chk9.Checked = true;
                    chkAZ_small.Checked = true;
                    chk08.Checked = true;
                    chkspecial1.Checked = true;
                    chkspecial2.Checked = true;
                    break;
                default: // Custom
                    chkmoreoptions.Checked = true;
                    break;
            }
            block_chk_update = false;
        }
        private void chkAZ_CheckedChanged(object sender, EventArgs e)
        {
            if (!block_chk_update)
                cbbcurrency.SelectedIndex = 2;
        }

        private void cbbNumChars_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnselnumberchars.Text = "Select random " + (cbbNumChars.SelectedIndex + 1) + " characters";
        }
        private void rtbseedgen_TextChanged(object sender, EventArgs e)
        {
            lblnumcharsseedgen.Text = rtbseedgen.Text.Length + " < --(Generated)Number of Characters";
        }

        private void rtbseedgen_SelectionChanged(object sender, EventArgs e)
        {
            lblnumselected.Text = rtbseedgen.SelectionLength + " < --Numbers Selected";
        }
        private void btntransfer_generated_ext_Click(object sender, EventArgs e)
        {
            // Check if there are just allowed chars, to avoid problems with send-keys (should be fixed in future)
            string allowed_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + chkspecial1.Text.Trim() + chkspecial2.Text.Trim();

            foreach (char ch in rtbseedgen.SelectedText)
            {
                if (allowed_chars.IndexOf(ch) < 0)
                {
                    MessageBox.Show("The selected text contains chars you have added yourself but this chars could possibly not sent correctly with this automated method.\r\n" +
                        "The first char found was: '" + ch + "'\r\n" +
                        "You can remove this char and add it in the target textbox by hand.\r\n" +
                        "There is intentionally no option for sending it anyway to ensure compatibility with future versions.",
                        "Not possible to send char '" + ch + "'", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


            timersendkeys.Start();
            time2wait_counter = time2wait_forsendkeys; // Start Counter at max. Time and count down

            btntransfer_generated_ext.Text = countdown(time2wait_forsendkeys, btntransfer_generated_ext.Text);
        }

        private void timersendkeys_Tick(object sender, EventArgs e)
        {
            btntransfer_generated_ext.Text = countdown(--time2wait_counter, btntransfer_generated_ext.Text);
            if (time2wait_counter == 0)
            {

                string send = Regex.Replace(rtbseedgen.SelectedText, "[+^%~(){}]", "{$0}");
                SendKeys.SendWait(send);
                timersendkeys.Stop();
            }
        }

        private void btntransferintern_Click(object sender, EventArgs e)
        {
            if (rtbseedgen.SelectedText.Length <= txtseed.MaxLength)
                txtseed.Text = rtbseedgen.SelectedText;
            else
                txtseed.Text = rtbseedgen.SelectedText.Substring(0, txtseed.MaxLength);
        }

        private void btnselnumberchars_Click(object sender, EventArgs e)
        {
            R randgen = R.Create();
            byte[] rand = new byte[10];

            randgen.GetBytes(rand);
            // Random Number between 0 - 255 --- we need between 0 - chars2generate
            int startselection = (int)Math.Floor(rand[2] * (rtbseedgen.TextLength - cbbNumChars.SelectedIndex + 1) / 255.0);
            if (startselection < 0) startselection = 0;
            rtbseedgen.Select(startselection, cbbNumChars.SelectedIndex + 1);
            rtbseedgen.Focus();

        }

        #endregion

        #region Random - Functions

        private void set_anchor_top()
        {
            if (chkmoreoptions.Checked)
                this.MinimumSize = new Size(this.MinimumSize.Width, 845);


            this.grpgenerateqr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            this.grpseed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        }
        private void set_anchor_nontop()
        {

            if (!chkmoreoptions.Checked)
                this.MinimumSize = new Size(this.MinimumSize.Width, 506);
            this.grpgenerateqr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            this.grpseed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        }

        private string get_char_set()
        {
            return (chkAZ.Checked ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ" : "") +
                (chkAZ_small.Checked ? "abcdefghijklmnopqrstuvwxyz" : "") +
                (chk08.Checked ? "012345678" : "") +
                (chk9.Checked ? "9" : "") +
                (chkspecial1.Checked ? chkspecial1.Text.Trim() : "") +
                (chkspecial2.Checked ? chkspecial2.Text.Trim() : "") + "";

        }
        private string countdown(int count, string text)
        {
            // Insert at the end of the Text a Countdown like "blablabla (4)" --> "blablabla (3)"
            if (text.Contains("("))
                text = text.Remove(text.Length - 3 - time2wait_forsendkeys.ToString().Length);
            text += " (" + count + ")";
            return text;
        }

        /// <summary>
        /// Produces 'Count' Random Characters from Character List
        /// </summary>
        /// <param name="count">Number of Chars to Produce</param>
        /// <param name="from_list">Char Array that holds possible Chars</param>
        /// <returns>String with Count Random Characters</returns>
        private string produce_random(int number = -1)
        {
            int count = 0;
            if (number == -1) count = cbbNumChars.SelectedIndex + 1;
            else count = number;

            char[] from_list = get_char_set().ToCharArray();

            if (from_list.Length == 0) return "";

            R randgen = R.Create();
            byte[] rand = new byte[5000];

            string ret = "";
            while (ret.Length < count)
            {
                randgen.GetNonZeroBytes(rand);

                foreach (byte x in rand)
                {
                    if (from_list.Contains((char)x))
                        ret += (char)x;
                    if (ret.Length >= count)
                        return ret;
                }
            }
            return ret;
        }
        #endregion
        #endregion

        #region Seed Handling & Encryption

        #region Seed Handling & Encryption - Designer Functions

        private void chkPassVisible_CheckedChanged(object sender, EventArgs e)
        {
            txtkey.UseSystemPasswordChar = !chkPassVisible.Checked;
        }


        private void txtencrypted_DoubleClick(object sender, EventArgs e)
        {
            txtencrypted.SelectAll();
        }
        private void txtseed_TextChanged(object sender, EventArgs e)
        {
            if (txtseed.Text.Length < txtseed.MaxLength)
                lblnumcharsseed.ForeColor = SystemColors.WindowText;
            else
                lblnumcharsseed.ForeColor = Color.Red;

            lblnumcharsseed.Text = txtseed.Text.Length + " < --Number of Characters";
            //txtencrypted.Text = xor_sha_en_decryption(txtseed.Text, txtkey.Text);
            txtencrypted.Text = aes_encryption(txtseed.Text, txtkey.Text);
            picboxqr.Image = null;
            //recalculate_aes();
        }

        private void txtqrdesc_TextChanged(object sender, EventArgs e)
        {
            add_qrdescription2image(picboxqr.Image, txtqrdesc.Text);
            picboxqr.Refresh();
        }

        private void txtkey_TextChanged(object sender, EventArgs e)
        {
            //txtencrypted.Text = xor_sha_en_decryption(txtseed.Text, txtkey.Text);
            txtencrypted.Text = aes_encryption(txtseed.Text, txtkey.Text);
            picboxqr.Image = null;
        }

        private void chkEditable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditable.Checked)
            {
                if (DialogResult.Yes !=
                                MessageBox.Show("You are going to edit the payload of the QR Code directly.\r\n" +
                                "You can do this if you want to create an QR Code of your receiving address for example.\r\n" +
                                "Do NOT edit the encrypted payload of your seed - it will NOT be possible to recover your seed if you change manually the encrypted payload!\r\n\r\n" +
                                "Do you want to create an QR Code with your own unencrypted data?", "You can add directly readable data to QR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    chkEditable.Checked = false;
                    return;
                }
            }
            txtseed.Enabled = !chkEditable.Checked;
            lblnumcharsseed.Enabled = !chkEditable.Checked;
            txtkey.Enabled = !chkEditable.Checked;
            lblkey.Enabled = !chkEditable.Checked;
            chkPassVisible.Enabled = !chkEditable.Checked;
            txtencrypted.ReadOnly = !chkEditable.Checked;

            if (!chkEditable.Checked) lblEncrypted.Text = "Encrypted data:";
            else lblEncrypted.Text = "Your own data:";

            if (!chkEditable.Checked)
                txtseed_TextChanged(sender, e); // Make sure that encrpted data is updated when unchecked
        }

        #endregion

        #region Seed Handling & Encryption - Functions

        private string aes_encryption(string seed, string pass)
        {
            string encrypted_data = AES.Encrypt(seed, Encoding.UTF8.GetBytes(pass));


            System.Version v = Assembly.GetExecutingAssembly().GetName().Version;
            string version = string.Format(CultureInfo.InvariantCulture, @"#v{0}.{1}.{2}.{3}_", v.Major, v.Minor, v.Build, v.Revision);

            encrypted_data += version;

            MD5 chksum = MD5.Create();
            string md5hash = ByteArrayToString(chksum.ComputeHash(Encoding.UTF8.GetBytes(encrypted_data)));

            return encrypted_data + md5hash;
        }

        /// <summary>
        /// Former used SHA512 + XOR Encryption - not used any more
        /// </summary>
        /// <param name="seed"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private string xor_sha_en_decryption(string seed, string key)
        {
            string ret = "";
            SHA512 sha_hash = SHA512.Create();
            byte[] hash_data = sha_hash.ComputeHash(Encoding.Default.GetBytes(key));
            string hash = ByteArrayToString(hash_data);

            // Strip Key Phrase when Text is shorter
            if (seed.Length < hash.Length)
                hash = hash.Remove(seed.Length);

            int counter = 0;
            // Expand Key Phrase until Text and Key have same length
            while (seed.Length > hash.Length)
                hash += hash[counter++];

            StringBuilder hex = new StringBuilder(seed.Length * 2);


            for (int i = 0; i < seed.Length; i++)
            {
                int charValue = Convert.ToInt32(seed[i]); //get the ASCII value of the character
                int keyvalue = Convert.ToInt32(hash[i]);
                int xor = charValue ^ keyvalue; //xor the value

                hex.AppendFormat("{0:x2}", xor); //convert back to string
            }
            ret = hex.ToString();

            // Checksum for encrypted data
            MD5 chksum = MD5.Create();
            string md5hash = ByteArrayToString(chksum.ComputeHash(Encoding.Default.GetBytes(ret)));

            return ret + md5hash;

        }

        /// <summary>
        /// Converts a Bytearray to a Base16 String
        /// </summary>
        /// <param name="ba"></param>
        /// <returns></returns>
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        #endregion
        #endregion

        #region QR Code

        #region QR Code - Designer Functions

        private void btngenerateqr_Click(object sender, EventArgs e)
        {
            //DialogResult res = MessageBox.Show("")
            try
            {
                var writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = new ZXing.QrCode.QrCodeEncodingOptions
                    {
                        Height = (int)(200 + txtencrypted.Text.Length * 1.5 * trackSize.Value / 7.0), //picboxqr.Height < 400 ? 600 : picboxqr.Height,
                        Width = (int)(200 + txtencrypted.Text.Length * 1.5 * trackSize.Value / 7.0), //picboxqr.Height < 400 ? 600 : picboxqr.Width,
                        Margin = 5,
                        ErrorCorrection = ErrorCorrectionLevel.H
                    },
                    Renderer = (IBarcodeRenderer<Bitmap>)Activator.CreateInstance(typeof(BitmapRenderer))
                };
                Image qr = writer.Write(txtencrypted.Text);

                Bitmap newImage = new Bitmap(qr.Width, qr.Height + 25, PixelFormat.Format24bppRgb);

                // Draws the image in the specified size with quality mode set to HighQuality
                Graphics graphics = Graphics.FromImage(newImage);

                //graphics.CompositingQuality = CompositingQuality.HighQuality;
                //graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.FillRectangle(Brushes.White, 0, 0, newImage.Width, newImage.Height);
                graphics.DrawImage(qr, 0, 24, qr.Width, qr.Height);



                picboxqr.Image = newImage;

                add_qrdescription2image(picboxqr.Image, txtqrdesc.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsaveqr_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPeg Image|*.jpg|Gif Image|*.gif";
            saveFile.Title = "Save an Image File";
            saveFile.ShowDialog();

            try
            {
                // If the file name is not an empty string open it for saving.
                if (saveFile.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.
                    using (FileStream fs = (FileStream)saveFile.OpenFile())
                    {
                        // Saves the Image in the appropriate ImageFormat based upon the
                        // File type selected in the dialog box.
                        // NOTE that the FilterIndex property is one-based.

                        ImageFormat imageFormat = null;
                        switch (saveFile.FilterIndex)
                        {
                            case 1:
                                imageFormat = ImageFormat.Png;
                                break;
                            case 2:
                                imageFormat = ImageFormat.Bmp;
                                break;
                            case 3:
                                imageFormat = ImageFormat.Jpeg;
                                break;
                            case 4:
                                imageFormat = ImageFormat.Gif;
                                break;
                            default:
                                MessageBox.Show("File extension is not supported", "Wrong extension", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        picboxqr.Image.Save(fs, imageFormat);
                        fs.Close();

                        MessageBox.Show("QR Code successfully saved as Picture", "QR Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving QR Code\r\nMessage: " + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnprintqr_Click(object sender, EventArgs e)
        {
            PrintPreview frm_pp = new PrintPreview(picboxqr.Image);
            frm_pp.ShowDialog();
        }
        private void trackSize_Scroll(object sender, EventArgs e)
        {
            btngenerateqr_Click(sender, e);
        }

        #endregion

        #region QR Code - Functions

        private void add_qrdescription2image(Image img, string desc)
        {
            if (img == null) return;
            Graphics e = Graphics.FromImage(img);
            Font fnt = new Font("Arial", 20);


            Rectangle rect1 = new Rectangle(0, 2, img.Width, 30);

            // Create a StringFormat object with the each line of text, and the block
            // of text centered on the page.
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            e.FillRectangle(Brushes.White, rect1); // Overwrite old text
            e.DrawString(txtqrdesc.Text, fnt, Brushes.Black, rect1, stringFormat);
        }
        #endregion
        #endregion

    }
}
