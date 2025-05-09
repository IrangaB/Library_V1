using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_V1
{
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
        }

        public string ConString = "Data Source=mtx-srv-fr001;Initial Catalog=Mtx_Library;Integrated Security=True";

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();

            if(txtBooksearch.Text=="")
            {
                MessageBox.Show("Cannot search empty values");
                txtBooksearch.Select();
            }
            else
            {
                try
                {
                    dgbookstatus.Rows.Clear();


                    SqlCommand Cmd = new SqlCommand("select * from BookRegister where Isbn = '" + txtBooksearch.Text + "' ", Cons);
                    SqlDataReader BookSearchDataReader = Cmd.ExecuteReader();
                    while (BookSearchDataReader.Read())
                    {
                        int BooksRowCnt = dgbookstatus.Rows.Add();
                        dgbookstatus.Rows[BooksRowCnt].Cells[0].Value = BookSearchDataReader["Isbn"].ToString();
                        dgbookstatus.Rows[BooksRowCnt].Cells[1].Value = BookSearchDataReader["BookName"].ToString();
                        dgbookstatus.Rows[BooksRowCnt].Cells[2].Value = BookSearchDataReader["BookType"].ToString();
                        dgbookstatus.Rows[BooksRowCnt].Cells[3].Value = BookSearchDataReader["Author"].ToString();
                        dgbookstatus.Rows[BooksRowCnt].Cells[4].Value = BookSearchDataReader["Translate"].ToString();

                        string BookSearchStatus = BookSearchDataReader["BookStatus"].ToString();
                        if (BookSearchStatus == "1")
                        {
                            dgbookstatus.Rows[BooksRowCnt].Cells[5].Value = "Active".ToString();
                        }
                        else
                        {
                            dgbookstatus.Rows[BooksRowCnt].Cells[5].Value = "Not Active".ToString();
                        }

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cons.Close();
                }



            }



        }

        private void txtBooksearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
