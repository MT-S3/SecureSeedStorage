using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;


/// <summary>
/// TODO:
/// - check if seed is iota compatible
/// - SendKeys for special  chars not possible atm
/// </summary>


namespace SeedSecure
{
    public partial class Form_Welcome : Form
    {
        List<Donate_Adress> donation_adresses = new List<Donate_Adress>();
        public Form_Welcome()
        {
            InitializeComponent();

            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            string About = string.Format(CultureInfo.InvariantCulture, @"v{0}.{1}.{2} (r{3})", v.Major, v.Minor, v.Build, v.Revision);

            this.Text = "Secure Seed Storage "+About;


            // IOTA Donation Adresses
            donation_adresses.Add(new Donate_Adress(Coin.IOTA, "RRAKUKXSNUTDDSE9PQFRSY9DGCVQUGOWDWTDADCKSJOGCEHJHVJCVLKNET9YJJUZVOKMBKUCXWFEJLLU9VJVGUQFUC", DateTime.MinValue));
            donation_adresses.Add(new Donate_Adress(Coin.IOTA, "GSQLQ9LJDSHCHZBVJEQCEBUGDJX9XOUYRB9UAWADJZAMIRNKISBPWHRAVZGNKSOVUSFXT9ZMQCXJAIAY9MHBEZPPLW", new DateTime(2018,6,1)));
            donation_adresses.Add(new Donate_Adress(Coin.IOTA, "GYFC9IXKFZHCNCJZKEOWCPCIFHXLOYJOHKPDWUYHRRHWWQC9F9CJKOERIIZVDOCBXKAKHUUXLBIVWVVWZLKMIRFCEB", new DateTime(2018, 12, 31)));
            donation_adresses.Add(new Donate_Adress(Coin.IOTA, "JAQOUKIERLOSDZCYMWHLKLYGSLLKSLYAMNQBXRRDXVPXSTLFDIQCZQBFFUAUUJCKWZGBGLPXJRWMXZFMDY9JVMVRCB", new DateTime(2019, 12, 31)));
            donation_adresses.Add(new Donate_Adress(Coin.IOTA, "QZFUYVCKNGIETYPLUQWIBR9KTJGYHJXQALNKAOJOGTOCIJBINKNBLBWIFOS9DUBKNA9FASPXBVRIGQAKWIRIESQQUZ", new DateTime(2020, 12, 31)));

            //Lisk
            donation_adresses.Add(new Donate_Adress(Coin.Lisk, "5169948416574688295L", DateTime.MinValue));

            //LTC
            donation_adresses.Add(new Donate_Adress(Coin.LTC, "LYDvTbzq5E3Z7EMf1CXSUXZGdcvQVdUQTs", DateTime.MinValue));

            //Eth
            donation_adresses.Add(new Donate_Adress(Coin.ETH, "0x46e7D7923981e0f43B7Ac29c13350f380e1dA72A", DateTime.MinValue));

            //BTC
            donation_adresses.Add(new Donate_Adress(Coin.BTC, "1KdUEZrF6MH2a3n4zwU2nm4wFoNnvcN1SJ", DateTime.MinValue));

            //Monero
            donation_adresses.Add(new Donate_Adress(Coin.Monero, "41ssiLyGxr6G6mcS52Toa3YnakUNq2TR677w5LqkpYLf6UgtZZZHwrR7otZ5ZgA52VNzWAKPaP4k91mWZKGK1C9XQ6tPSK4", DateTime.MinValue));

            // Load ComboBox with Coins from Enum
            cbCoin_Donate.DataSource = Enum.GetValues(typeof(Coin));
            cbCoin_Donate.SelectedIndex = 0;
        }

        public string get_actual_adress(Coin coin)
        {
            string akt_adress = "";
            DateTime last_dt = DateTime.MinValue;

            foreach(Donate_Adress x in donation_adresses)
            {
                if(x.coin==coin)
                {
                    // Must be already valid (not in future) and must be the next one activated
                    if(x.valid_form.Ticks<DateTime.Now.Ticks && last_dt.Ticks<=x.valid_form.Ticks)
                    {
                        last_dt = x.valid_form;
                        akt_adress = x.adress;
                    }
                }
            }
            return akt_adress;
        }

        private void buttonencrypt_Click(object sender, EventArgs e)
        {
            Form_Encrypt frm = new Form_Encrypt();
            frm.Show();
            
        }

        private void buttondecrypt_Click(object sender, EventArgs e)
        {
            Form_Decrypt frm = new Form_Decrypt(this);
            frm.Show();
        }

        private void cbCoin_Donate_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonateAdress.Text= get_actual_adress((Coin)cbCoin_Donate.SelectedItem);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDonateAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void Form_Welcome_Load(object sender, EventArgs e)
        {

        }
    }

    public enum Coin { IOTA, BTC, ETH, LTC, Monero, Lisk };
    public class Donate_Adress
    {
        public Coin coin;
        public string adress;
        public DateTime valid_form;
        public Donate_Adress(Coin coin, string adress, DateTime valid_form)
        {
            this.coin = coin;
            this.adress = adress;
            this.valid_form = valid_form;
        }
    }
}
