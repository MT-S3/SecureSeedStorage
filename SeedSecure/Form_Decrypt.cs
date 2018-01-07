using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;
using System.Security.Cryptography;
using System.Threading;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace SeedSecure
{
    public partial class Form_Decrypt : Form
    {
        private struct Device
        {
            public int Index;
            public string Name;
            public override string ToString()
            {
                return Name;
            }
        }

        private CameraDevices camDevices;
        private Bitmap currentBitmapForDecoding;
        private Thread decodingThread;
        private Result currentResult;
        private readonly Pen resultRectPen;

        int time2wait_forsendkeys = 5; //Seconds to wait, so you can change window
        int time2wait_counter = 0;

        int height_expanded;
        Form_Welcome frm_main;


        public Form_Decrypt(Form_Welcome frm_main)
        {
            InitializeComponent();

            height_expanded = this.Size.Height;
            set_anchor_top();
            this.MinimumSize = new Size(this.MinimumSize.Width, 652);
            this.Size = new Size(this.Size.Width, this.Size.Height - 120);
            set_anchor_nontop();

            this.frm_main = frm_main; // For access to Donation Adresses

            camDevices = new CameraDevices();

            resultRectPen = new Pen(Color.Green, 10);

            // Load ComboBox with Coins from Enum
            cbCoin_Donate.DataSource = Enum.GetValues(typeof(Coin));
            cbCoin_Donate.SelectedIndex = 0;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadDevicesToCombobox();
        }

        private void Form_Decrypt_Load(object sender, EventArgs e)
        {

        }
        private void set_anchor_top()
        {


            this.grpimportqr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            this.grpDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            this.grpdonate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        }
        private void set_anchor_nontop()
        {

            this.grpimportqr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            this.grpDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            this.grpdonate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        }

        private void picbox_webcam_Paint(object sender, PaintEventArgs e)
        {
            if (currentResult == null)
                return;

            if (currentResult.ResultPoints != null && currentResult.ResultPoints.Length > 0)
            {
                var resultPoints = currentResult.ResultPoints;
                var rect = new Rectangle((int)resultPoints[0].X, (int)resultPoints[0].Y, 1, 1);
                foreach (var point in resultPoints)
                {
                    if (point.X < rect.Left)
                        rect = new Rectangle((int)point.X, rect.Y, rect.Width + rect.X - (int)point.X, rect.Height);
                    if (point.X > rect.Right)
                        rect = new Rectangle(rect.X, rect.Y, rect.Width + (int)point.X - rect.X, rect.Height);
                    if (point.Y < rect.Top)
                        rect = new Rectangle(rect.X, (int)point.Y, rect.Width, rect.Height + rect.Y - (int)point.Y);
                    if (point.Y > rect.Bottom)
                        rect = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height + (int)point.Y - rect.Y);
                }
                using (var g = picbox_webcam.CreateGraphics())
                {
                    g.DrawRectangle(resultRectPen, rect);
                }
            }
        }

        private void LoadDevicesToCombobox()
        {
            cmbDevice.Items.Clear();
            for (var index = 0; index < camDevices.Devices.Count; index++)
            {
                cmbDevice.Items.Add(new Device { Index = index, Name = camDevices.Devices[index].Name });
            }
        }

        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (camDevices.Current != null)
            {
                camDevices.Current.NewFrame -= Current_NewFrame;
                if (camDevices.Current.IsRunning)
                {
                    camDevices.Current.SignalToStop();
                }
            }

            camDevices.SelectCamera(((Device)(cmbDevice.SelectedItem)).Index);
            camDevices.Current.NewFrame += Current_NewFrame;
            camDevices.Current.Start();

            decodingThread = new Thread(DecodeBarcode);
            decodingThread.Start();
        }

        private void Current_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (IsDisposed)
            {
                return;
            }

            try
            {
                if (currentBitmapForDecoding == null)
                {
                    currentBitmapForDecoding = (Bitmap)eventArgs.Frame.Clone();
                }
                Invoke(new Action<Bitmap>(ShowFrame), eventArgs.Frame.Clone());
            }
            catch (ObjectDisposedException)
            {
                // not sure, why....
            }
        }

        private void ShowFrame(Bitmap frame)
        {/*
            if (picbox_webcam.Width < frame.Width)
            {
                picbox_webcam.Width = frame.Width;
            }
            if (picbox_webcam.Height < frame.Height)
            {
                picbox_webcam.Height = frame.Height;
            }*/
            picbox_webcam.Image = frame;
        }

        private void DecodeBarcode()
        {
            var reader = new BarcodeReader();
            try
            {
                while (true)
                {
                    if (currentBitmapForDecoding != null)
                    {
                        var result = reader.Decode(currentBitmapForDecoding);
                        if (result != null)
                        {
                            Invoke(new Action<Result>(ShowResult), result);
                        }
                        currentBitmapForDecoding.Dispose();
                        currentBitmapForDecoding = null;
                    }
                    Thread.Sleep(80);
                }
            }
            catch { }
        }

        private void ShowResult(Result result)
        {
            currentResult = result;

            txtPayload.Text = result.Text;

            txtPayload.BackColor = Color.PaleGreen;
            timerSigNewEncode.Start();
        }

        private void Form_Decrypt_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            if (!e.Cancel)
            {
                close_webcam();
            }
        }

        private void close_webcam(bool reset_image = true)
        {
            if (decodingThread != null && decodingThread.IsAlive) decodingThread.Abort();
            if (camDevices.Current != null)
            {
                camDevices.Current.NewFrame -= Current_NewFrame;
                if (camDevices.Current.IsRunning)
                {
                    camDevices.Current.SignalToStop();
                }
            }
            if (reset_image) picbox_webcam.Image = null;
            picbox_webcam.Refresh();
        }

        private void tabCtrl_decrypt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrl_decrypt.SelectedIndex != 0)
            {
                close_webcam();
            }
        }

        private void txtPayload_TextChanged(object sender, EventArgs e)
        {
            picChksum_Failed.Visible = false;
            picChksum_Checked.Visible = false;
            if (check_payload(txtPayload.Text))
            {
                picChksum_Checked.Visible = true;
                txtSeed.Text = aes_decryption(txtPayload.Text, txtPassword.Text);
                //txtPayload.BackColor = Color.PaleGreen;
            }
            else
            {
                picChksum_Failed.Visible = true;
                //txtPayload.BackColor = Color.LightCoral;
            }

        }

        /// <summary>
        /// This Function checks if the recived payload is correct
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        private bool check_payload(string payload)
        {
            MD5 hash = MD5.Create();
            if (payload.Length < 32) return false;
            string data = payload.Substring(0, payload.Length - 32);
            string chksum = payload.Substring(payload.Length - 32);

            string chksum_payload = ByteArrayToString(hash.ComputeHash(Encoding.UTF8.GetBytes(data)));

            if (chksum == chksum_payload)
            {
                close_webcam(false);
                return true; // Good
            }
            else
                return false; // uii, not good

        }
        private string aes_decryption(string data, string pass)
        {
            if (data.Length >= 32)
                data = data.Substring(0, data.Length - 32);

            txtPassword.BackColor = Color.White;

            // Remove Version String if existent
            if (data.LastIndexOf("#v") != -1)
            {
                data = data.Remove(data.LastIndexOf("#v"));
            }

            try
            {
                string decrypted_data = AES.Decrypt(data, Encoding.UTF8.GetBytes(pass));

                txtPassword.BackColor = Color.PaleGreen;

                return decrypted_data;
            }
            catch (CryptographicException cex)
            {
                // This happens when your password is not correct
                txtPassword.BackColor = Color.LightCoral;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error decrypting your data.\r\nPlease try again and make sure your data is correct.\r\nError Message: " + ex.Message, "Error while decrypting data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        /// <summary>
        /// Former used routine with sha xor encryption
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private string xor_sha_en_decryption(string text, string key)
        {
            if (text.Length >= 32)
                text = text.Substring(0, text.Length - 32);

            string ret = "";
            SHA512 sha_hash = SHA512.Create();
            byte[] hash_data = sha_hash.ComputeHash(Encoding.Default.GetBytes(key));
            string hash = ByteArrayToString(hash_data);

            // Strip Key Phrase when Text is shorter
            if (text.Length / 2 < hash.Length)
                hash = hash.Remove(text.Length / 2);

            int counter = 0;
            // Expand Key Phrase until Text and Key have same length
            while (text.Length / 2 > hash.Length)
                hash += hash[counter++];

            StringBuilder hex = new StringBuilder(text.Length * 2);

            try
            {
                for (int i = 0; i < text.Length / 2; i++)
                {
                    int charValue = Int32.Parse(text[2 * i] + "" + text[2 * i + 1], NumberStyles.HexNumber); //get the ASCII value of the character
                    int keyvalue = Convert.ToInt32(hash[i]);
                    int xor = charValue ^ keyvalue; //xor the value
                    ret += (char)xor;
                    hex.AppendFormat("{0:x2}", xor); //convert back to string
                }
            }
            catch
            {
                ret = "Decryption failed (Probably non HEX Characters in Payload)";
            }
            return ret;

        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            //txtSeed.Text = xor_sha_en_decryption(txtPayload.Text, txtPassword.Text);
            txtSeed.Text = aes_decryption(txtPayload.Text, txtPassword.Text);
        }

        private void btnTransferSeed_Click(object sender, EventArgs e)
        {
            if (picChksum_Failed.Visible == true)
            {
                DialogResult res = MessageBox.Show("The Data loaded from the QR Code couldn´t be proven correct.\r\n" +
                    "If you generated this QR Code with this software try to feed the QR Code again into the software to get the green Symbol.\r\n" +
                    "Try for example with better light conditions or a better camera. You can also take a picture and load it into the software.\r\n\r\n" +
                    "Do you want to proceed with possibly wrong data (not recommended)?",
                    "QR Code Data corrupt - Try once more",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (res != DialogResult.Yes)
                    return;
            }

            Form_Encrypt fe = new Form_Encrypt();

            // Check if there are just allowed chars, to avoid problems with send-keys (should be fixed in future)
            string allowed_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + fe.chkspecial1.Text.Trim() + fe.chkspecial2.Text.Trim();

            fe.Dispose();

            foreach (char ch in txtSeed.Text)
            {
                if (allowed_chars.IndexOf(ch) < 0)
                {
                    MessageBox.Show("The selected text contains chars you have added yourself but this chars could possibly not sent correctly with this automated method.\r\n"+
                        "The first char found was: '" + ch + "'\r\n"+
                        "You can remove this char and add it in the target textbox by hand.\r\n"+
                        "There is intentionally no option for sending it anyway to ensure compatibility with future versions.",
                        "Not possible to send char '" + ch + "'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            set_anchor_top();
            timerexpand.Start();

            timerSendKeys.Start();
            time2wait_counter = time2wait_forsendkeys; // Start Counter at max. Time and count down

            btnTransferSeed.Text = countdown(time2wait_forsendkeys, btnTransferSeed.Text);
        }

        private void timerSendKeys_Tick(object sender, EventArgs e)
        {
            btnTransferSeed.Text = countdown(--time2wait_counter, btnTransferSeed.Text);
            if (time2wait_counter == 0)
            {
                string send = Regex.Replace(txtSeed.Text, "[+^%~(){}]", "{$0}");
                SendKeys.SendWait(send);
                timerSendKeys.Stop();

                // Reset TextBoxes after Keys have been sent
                if (chkPayload.Checked) txtPayload.Text = "";
                if (chkPassword.Checked) txtPassword.Text = "";
                if (chkSeed.Checked) txtSeed.Text = "";

                // Close Webcam
                close_webcam();
            }
        }
        private string countdown(int count, string text)
        {
            // Insert at the end of the Text a Countdown like "blablabla (4)" --> "blablabla (3)"
            if (text.Contains("("))
                text = text.Remove(text.Length - 3 - time2wait_forsendkeys.ToString().Length);
            text += " (" + count + ")";
            return text;
        }

        private void chkPassVisible_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkPassVisible.Checked;
        }

        private void btnOpenImg_Click(object sender, EventArgs e)
        {
            using (var openDlg = new OpenFileDialog())
            {
                openDlg.Multiselect = false;
                openDlg.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                try
                {
                    if (openDlg.ShowDialog(this) == DialogResult.OK)
                    {
                        var fileName = openDlg.FileName;
                        if (File.Exists(fileName))
                        {
                            if (fileName.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                            {
                                picPicture.Image = null;
                                foreach (var bitmap in PdfSupport.GetBitmapsFromPdf(fileName))
                                {
                                    picPicture.Image = bitmap;
                                    break;
                                }
                            }
                            else
                            {
                                picPicture.Load(fileName);
                            }

                            var reader = new BarcodeReader();
                            var result = reader.Decode((Bitmap)picPicture.Image);

                            if (result != null)
                            {
                                txtPayload.Text = result.Text;

                                txtPayload.BackColor = Color.PaleGreen;
                                timerSigNewEncode.Start(); // To Reset BackColor
                            }
                            else
                            {
                                txtPayload.Text = "No QR Code found or QR Decryption failed. Please try again with a better Image.";
                                txtPayload.BackColor = Color.LightCoral;
                                timerSigNewEncode.Start(); // To Reset BackColor
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("There was an Error opening your File. Probably it had a not supported extension.\r\nError: " + exp.InnerException, "Error loading File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timerSigNewEncode_Tick(object sender, EventArgs e)
        {
            txtPayload.BackColor = SystemColors.Window;
            timerSigNewEncode.Stop();
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            try
            {
                Visible = false;
                Thread.Sleep(1000);
                picPicture.Image = ScreenCapture.CaptureScreen();
                Visible = true;
                Refresh();
                Thread.Sleep(500); // For better recognization for the work done after Screenshot

                var reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)picPicture.Image);
                if (result != null)
                {
                    txtPayload.Text = result.Text;

                    txtPayload.BackColor = Color.PaleGreen;
                    timerSigNewEncode.Start(); // To Reset BackColor
                }
                else
                {
                    txtPayload.Text = "No QR Code found or QR Decryption failed. Please try again with a better Image.";
                    txtPayload.BackColor = Color.LightCoral;
                    timerSigNewEncode.Start(); // To Reset BackColor
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, exc.ToString(), "Error by capturing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Visible = true;
            }
        }

        private void btnReffresh_Cam_Click(object sender, EventArgs e)
        {
            close_webcam();
            camDevices = new CameraDevices();
            LoadDevicesToCombobox();
        }

        private void chkSeedVisible_CheckedChanged(object sender, EventArgs e)
        {
            txtSeed.UseSystemPasswordChar = !chkSeedVisible.Checked;
        }

        private void btnCopyDonate_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(txtDonateAdress.Text);
            txtDonateAdress.BackColor = Color.PaleGreen;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDonateAdress.BackColor = SystemColors.Control;
            timer1.Stop();
        }

        private void cbCoin_Donate_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonateAdress.Text = frm_main.get_actual_adress((Coin)cbCoin_Donate.SelectedItem);
        }

        private void timerexpand_Tick(object sender, EventArgs e)
        {
            if (this.Size.Height >= height_expanded)
            {
                timerexpand.Stop();
                this.MinimumSize = new Size(this.MinimumSize.Width, 772);

                Refresh(); // Just if it doesn´t refresh continously

                set_anchor_nontop();
            }
            else
            {
                this.Size = new Size(this.Size.Width, this.Size.Height + 8);
            }
        }
    }

    internal class CameraDevices
    {
        public FilterInfoCollection Devices { get; private set; }
        public VideoCaptureDevice Current { get; private set; }

        public CameraDevices()
        {
            Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        public void SelectCamera(int index)
        {
            if (index >= Devices.Count)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            Current = new VideoCaptureDevice(Devices[index].MonikerString);
        }
    }

}
