using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SeedSecure
{
    public partial class PrintPreview : Form
    {
        Image toprint = null;
        public PrintPreview(Image toprint)
        {
            InitializeComponent();
            this.toprint = toprint;

            reload_document();
        }

        private void reload_document()
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;
            doc.DefaultPageSettings.Landscape = radiolandsc.Checked;
            printPreviewControl1.Document = doc;
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (toprint == null) return;

            if (chkcenter.Checked)
                e.Graphics.DrawImage(toprint, (e.PageBounds.Width - toprint.Width) / 2, (e.PageBounds.Height - toprint.Height) / 2, toprint.Width, toprint.Height);
            else
                e.Graphics.DrawImage(toprint, new Point(20, 20));
        }


        private void btnprint_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printPreviewControl1.Document;

            pageSetupDialog1.PageSettings.Landscape = radiolandsc.Checked;

            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDialog1.PrinterSettings = pageSetupDialog1.PrinterSettings;

                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    pageSetupDialog1.Document.Print();
                    this.Close();
                    
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radiolandsc_CheckedChanged(object sender, EventArgs e)
        {
            reload_document();
        }

        private void chkcenter_CheckedChanged(object sender, EventArgs e)
        {
            reload_document();
        }
    }
}
