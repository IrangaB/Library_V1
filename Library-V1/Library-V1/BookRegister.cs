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
    public partial class BookRegister : Form
    {
        public BookRegister()
        {
            InitializeComponent();
        }

        public string ConString = "Data Source=mtx-srv-fr001;Initial Catalog=Mtx_Library;Integrated Security=True";

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mtx_LibraryDataSet3.Sections' table. You can move, or remove it, as needed.
            this.sectionsTableAdapter1.Fill(this.mtx_LibraryDataSet3.Sections);
            // TODO: This line of code loads data into the 'mtx_LibraryDataSet2.Sections' table. You can move, or remove it, as needed.
            
            txtTranslatorName.Text = "No";
            txtTranslatorName.Enabled = false;
            txtAuthor.Enabled = false;
            txtBookName.Enabled = false;
            txtNewIsbn.Enabled = false;
            chkyes.Enabled = false;
            rdBookActive.Enabled = false;
            rdBookInactive.Enabled = false;
            cmbLanguange.Enabled = false;
            btnGenCode.Enabled = false;
            cmbBookType.Enabled = false;
            btnNewBook.Enabled = true;
            btnBarcode.Enabled = true;
            btnSaveBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            btnBarcode.Enabled = false;
            
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            if(txtNewIsbn.Text == "")
            {
                MessageBox.Show("ISBN or Barcode Number cannot be blank");
                txtNewIsbn.Select();
            }
            else if (txtBookName.Text == "")
            {
                MessageBox.Show("Book name cannot be blank");
                txtBookName.Select();
            }
            else if(txtAuthor.Text == "")
            {
                MessageBox.Show("Author name cannot be blank");
                txtAuthor.Select();
            }
            else if (rdBookActive.Checked == false && rdBookInactive.Checked == false)
            {
                MessageBox.Show("Book status cannot be blank");
            }
            
            else
            {
                SqlConnection Cons = new SqlConnection(ConString);
                Cons.Open();

                try
                {
                    String BookStatus;

                    if (rdBookActive.Checked)
                    {
                        BookStatus = "1";
                    }
                    else
                    {
                        BookStatus = "0";
                    }
                    string NewBookType = cmbBookType.SelectedItem.ToString();
                    string Newlanguange = cmbLanguange.SelectedItem.ToString();
                    string NowDatetime = DateTime.Now.ToString();
                    SqlCommand InsertBooks = new SqlCommand("Insert into BookRegister (Isbn,BookName,Author,BookType,BookStatus,Translate,Languange,Date) values ('" + txtNewIsbn.Text + "','" + txtBookName.Text + "','" + txtAuthor.Text + "','" + NewBookType + "','" + BookStatus + "','" + txtTranslatorName.Text + "','" + Newlanguange + "','" + NowDatetime + "')", Cons);
                    SqlDataReader InsertBookDR = InsertBooks.ExecuteReader();
                    while (InsertBookDR.Read())
                    {

                    }
                    InsertBookDR.Close();

                    MessageBox.Show("New Book added to the system successfully");
                    dgBookView.Rows.Clear();    

                    SqlCommand LoadBookDataCmd = new SqlCommand("select * from BookRegister", Cons);
                    SqlDataReader LoadDataDR = LoadBookDataCmd.ExecuteReader();
                    while (LoadDataDR.Read())
                    {
                        int BookDataLoad = dgBookView.Rows.Add();
                        dgBookView.Rows[BookDataLoad].Cells[0].Value = LoadDataDR["Date"].ToString();
                        dgBookView.Rows[BookDataLoad].Cells[1].Value = LoadDataDR["Isbn"].ToString();
                        dgBookView.Rows[BookDataLoad].Cells[2].Value = LoadDataDR["BookName"].ToString();
                        dgBookView.Rows[BookDataLoad].Cells[3].Value = LoadDataDR["BookType"].ToString();
                        dgBookView.Rows[BookDataLoad].Cells[4].Value = LoadDataDR["Languange"].ToString();
                        dgBookView.Rows[BookDataLoad].Cells[5].Value = LoadDataDR["Author"].ToString();
                        dgBookView.Rows[BookDataLoad].Cells[6].Value = LoadDataDR["Translate"].ToString();

                        string Bookstatus = LoadDataDR["BookStatus"].ToString();
                        string newstatus;
                        if (Bookstatus == "1")
                        {
                            newstatus = "Active";
                            dgBookView.Rows[BookDataLoad].Cells[7].Value = newstatus;

                        }
                        else
                        {
                            newstatus = "Not Active";
                            dgBookView.Rows[BookDataLoad].Cells[7].Value = newstatus;
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

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            BarcodeGenerator NewBarcodeGenerator = new BarcodeGenerator();
            NewBarcodeGenerator.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNewIsbn.Text = BarcodeGenerator.Bookbarcode;
        }

        private void cmbTranslator_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTranslator_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void chkyes_CheckedChanged(object sender, EventArgs e)
        {
            if(chkyes.Checked)
            {
                txtTranslatorName.Enabled = true;
            }
            else
            {
                txtTranslatorName.Text = "No";
                txtTranslatorName.Enabled = false;
            }
        }

        private void txtNewIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtIsbnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            dgBookView.Rows.Clear();
            txtNewIsbn.Text = "";
            txtTranslatorName.Text = "No";
            txtTranslatorName.Enabled = true;
            txtTranslatorName.Text = "";
            txtAuthor.Enabled = true;
            txtAuthor.Text = "";
            txtBookName.Enabled = true;
            txtBookName.Text = "";
            txtNewIsbn.Enabled = true;
            chkyes.Enabled = true;
            rdBookActive.Enabled = true;
            rdBookInactive.Enabled = true;
            cmbLanguange.Enabled = true;
            btnGenCode.Enabled = true;
            cmbBookType.Enabled = true;
            btnNewBook.Enabled = true;
            btnBarcode.Enabled = true;
            btnSaveBook.Enabled = true;
            btnUpdateBook.Enabled = false;
            btnBarcode.Enabled = true;

        }

        private void btnSearchIsbm_Click(object sender, EventArgs e)
        {
           
            if(txtIsbnSearch.Text == "")
            {
                MessageBox.Show("Cannot search emplty value");
                txtIsbnSearch.Select();
            }
            else
            {
                SqlConnection Cons = new SqlConnection(ConString);
                Cons.Open();

                try
                {
                    dgBookView.Rows.Clear();
                    SqlCommand NewBookSearchcmd = new SqlCommand("select * from BookRegister where Isbn = '" + txtIsbnSearch.Text + "'", Cons);
                    SqlDataReader NewbookDR = NewBookSearchcmd.ExecuteReader();
                    while(NewbookDR.Read())
                    {
                        int BookRowCnt = dgBookView.Rows.Add();
                        dgBookView.Rows[BookRowCnt].Cells[0].Value = NewbookDR["Date"].ToString();
                        dgBookView.Rows[BookRowCnt].Cells[1].Value = NewbookDR["Isbn"].ToString();
                        dgBookView.Rows[BookRowCnt].Cells[2].Value = NewbookDR["BookName"].ToString();
                        dgBookView.Rows[BookRowCnt].Cells[3].Value = NewbookDR["BookType"].ToString();
                        dgBookView.Rows[BookRowCnt].Cells[4].Value = NewbookDR["Languange"].ToString();
                        dgBookView.Rows[BookRowCnt].Cells[5].Value = NewbookDR["Author"].ToString();
                        dgBookView.Rows[BookRowCnt].Cells[6].Value = NewbookDR["Translate"].ToString();


                        string Bookstatus = NewbookDR["BookStatus"].ToString();
                        string newstatus;
                        if (Bookstatus == "1")
                        {
                            newstatus = "Active";
                            dgBookView.Rows[BookRowCnt].Cells[7].Value = newstatus;

                        }
                        else
                        {
                            newstatus = "Not Active";
                            dgBookView.Rows[BookRowCnt].Cells[7].Value = newstatus;
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

        private void dgBookView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateBook.Enabled = true;
            btnSaveBook.Enabled = false;
            btnNewBook.Enabled = true;
            rdBookActive.Enabled = true;
            rdBookInactive.Enabled = true;
            txtAuthor.Enabled = false;
            txtTranslatorName.Enabled = false;
            btnBarcode.Enabled = false;
            btnGenCode.Enabled = false;

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgBookView.Rows[e.RowIndex];

                    txtNewIsbn.Text = row.Cells["Column1"].Value.ToString();
                    txtBookName.Text = row.Cells["Column2"].Value.ToString();
                    //txtAuthor.Text = row.Cells["Column3"].Value.ToString();
                   // txtTranslatorName.Text = row.Cells["Column6"].Value.ToString();
                    string Bstatus = row.Cells["Column5"].Value.ToString();

                    if (Bstatus == "Active")
                    {
                        rdBookActive.Select();
                    }
                    else
                    {
                        rdBookInactive.Select();
                    }


                }
                else
                {

                }
            }


            catch
            {


            }


        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();
            try
            {
                string BookStatusUpdate;

                if(rdBookActive.Checked)
                {
                    BookStatusUpdate = "1";
                }
                else
                {
                    BookStatusUpdate = "0";
                }

                SqlCommand Bookupdate = new SqlCommand(" update BookRegister set BookStatus = '" + BookStatusUpdate + "' where(Isbn = '" + txtNewIsbn.Text + "')", Cons);
                SqlDataReader bookdr = Bookupdate.ExecuteReader();
                while (bookdr.Read())
                {

                }
                dgBookView.Rows.Clear();
                MessageBox.Show("Book status updated successfully");
                
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
}
