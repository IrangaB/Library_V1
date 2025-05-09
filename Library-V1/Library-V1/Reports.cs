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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
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

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            AllBooksReport newallBooksReport = new AllBooksReport();
            newallBooksReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IssueBooksReport newissueBooksReport = new IssueBooksReport();
            newissueBooksReport.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NotIssueReport NewnotIssueReport = new NotIssueReport();
            NewnotIssueReport.Show();
        }
    }
}
