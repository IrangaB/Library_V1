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
    public partial class NotIssueReport : Form
    {
        public NotIssueReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotIssueReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notIssuedDS.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.notIssuedDS.DataTable1);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
