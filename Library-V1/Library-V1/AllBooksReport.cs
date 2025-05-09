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
    public partial class AllBooksReport : Form
    {
        public AllBooksReport()
        {
            InitializeComponent();
        }

        private void AllBooksReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mtx_LibraryDataSet2.BookRegister' table. You can move, or remove it, as needed.
            this.bookRegisterTableAdapter.Fill(this.mtx_LibraryDataSet2.BookRegister);
            // TODO: This line of code loads data into the 'mtx_LibraryDataSet2.BookRegister' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'mtx_LibraryDataSet2.BookRegister' table. You can move, or remove it, as needed.



            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rptAllBooks_Load(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
            
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
