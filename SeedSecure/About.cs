using System;
using System.Windows.Forms;

namespace SeedSecure
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = Environment.CurrentDirectory + "\\S3_SecureSeedStorage_Description.pdf";

                if (!System.IO.File.Exists(filename))
                {
                    byte[] pdf_byte = global::SeedSecure.Properties.Resources.S3_SecureSeedStorage_Description;
                    System.IO.File.WriteAllBytes(filename, pdf_byte);
                }

                if (System.IO.File.Exists(filename))
                    System.Diagnostics.Process.Start(filename);
            }
            catch(Exception ex)
            {
                MessageBox.Show("You wanted to open the pdf help-file. This software tried to create a PDF-File in the same folder as you have this executable running from.\r\n" +
                                "There was a problem creating this file. Probably the software didn´t have the rights to write a file in that location.\r\n" +
                                "Error Message: " + ex.Message + "\r\n\r\n" +
                                "You can give the software the rights to write a file or just use the PDF description from GITHUB. It´s the same file.", "Problem while creating and opening help-file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
