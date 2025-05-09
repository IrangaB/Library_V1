using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_V1
{
    public partial class BarcodeGenerator : Form
    {
        public BarcodeGenerator()
        {
            InitializeComponent();
        }
        public static string Bookbarcode;

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picBarcode.Image = barcode.Draw(txtBookNo.Text,50);
            Bookbarcode = txtBookNo.Text;
            BtnSaveBarcode.Enabled = true;
        }

        private void BtnSaveBarcode_Click(object sender, EventArgs e)
        {
            if(picBarcode.Image == null)
            return;
            using (SaveFileDialog SaveFileNew = new SaveFileDialog() { Filter = "PNG|*.png" })
            {
                if (SaveFileNew.ShowDialog() == DialogResult.OK)
                    picBarcode.Image.Save(SaveFileNew.FileName);
                MessageBox.Show("Barcode Saved");
                this.Close();
            }
        }

        private void BarcodeGenerator_Load(object sender, EventArgs e)
        {
            BtnSaveBarcode.Enabled = false;
        }
    }
}
