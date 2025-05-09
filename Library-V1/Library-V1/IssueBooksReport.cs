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
    public partial class IssueBooksReport : Form
    {
        public IssueBooksReport()
        {
            InitializeComponent();
        }

        private void IssueBooksReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'issueBooksDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.issueBooksDataSet.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
