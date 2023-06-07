using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KücükPrensManagment.Forms
{
    public partial class BarkodForm : Form
    {
        public BarkodForm()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void btnBarkod_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw brc =
                Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picBarkod.Image = brc.Draw(txtBarkodNo.Text, 250);
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_printpage;
            pd.Document = doc;
            doc.Print();
        }

        private void Doc_printpage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(picBarkod.Width, picBarkod.Height);
            picBarkod.DrawToBitmap(bm, new Rectangle(0, 0, picBarkod.Width, picBarkod.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
    }
}
