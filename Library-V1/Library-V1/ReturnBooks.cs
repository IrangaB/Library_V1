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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }
        public string ConString = "Data Source=mtx-srv-fr001;Initial Catalog=Mtx_Library;Integrated Security=True";
        string IssueIsbn, IssueEpf, IssuedDate, IssueReturn, IssueOverdue;

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSearchIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();

           // SqlCommand CheckReturn = new SqlCommand("select * from ReturnBooks where Isbn = '" + txtSearchIsbn.Text + "'", Cons);
           // SqlDataReader checkreturnDR = CheckReturn.ExecuteReader();
           // while(checkreturnDR.Read())
           // {
             //   string returnFlagNo = checkreturnDR["Returnflag"].ToString();

              //  if(returnFlagNo == "1")
              //  {
              //      MessageBox.Show("This book is already returend.. Check in the Issue section..");

               // }
               // checkreturnDR.Close();
               // txtSearchIsbn.Text = "";
               // txtSearchIsbn.Select();
           // }
            //checkreturnDR.Close();

            try
            {
                
                string RetunFlag = "1";
                SqlCommand InsertReturn = new SqlCommand("insert into ReturnBooks (Isbn,Epf,IssueDate,ReturnDate,OverdueDates,ReturnFlag) values ('" + IssueIsbn + "','" + IssueEpf + "','" + IssuedDate + "','" + IssueReturn + "','" + IssueOverdue + "','" + RetunFlag + "')", Cons);
                SqlDataReader ReturnDR = InsertReturn.ExecuteReader();
                while (ReturnDR.Read())
                {
                                        
                }

                ReturnDR.Close();
                
                MessageBox.Show("ISBN " + IssueIsbn + "  Returend to the system..");
                
                SqlCommand IssueFlagupdate = new SqlCommand(" update IssueBooks set IssueFlag = '0' where (Isbn = '" + txtSearchIsbn.Text + "')", Cons);
                SqlDataReader FlagUpdateDr = IssueFlagupdate.ExecuteReader();
                while (FlagUpdateDr.Read())
                {

                }
                MessageBox.Show("Issue pool has been updated..");
                dgReturnBooks.Rows.Clear();
                txtSearchIsbn.Text = "";

                FlagUpdateDr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                        
            finally
            {
                Cons.Close();
            }

        }

        private void btnSearchIsbn_Click(object sender, EventArgs e)
        {

            if (txtSearchIsbn.Text == "") 
            {
                MessageBox.Show("Cannot search empty field");

            }
            else
            {
                SqlConnection Cons = new SqlConnection(ConString);
                Cons.Open();

                try
                {
                    dgReturnBooks.Rows.Clear();

                    SqlCommand Cmd = new SqlCommand("select * from IssueBooks where Isbn= '" + txtSearchIsbn.Text + "' and IssueFlag = '1' ", Cons);
                    SqlDataReader IssueDataReader = Cmd.ExecuteReader();
                    while(IssueDataReader.Read())
                    {
                        int IssueRowCnt = dgReturnBooks.Rows.Add();
                        dgReturnBooks.Rows[IssueRowCnt].Cells[0].Value = IssueDataReader["Isbn"].ToString();
                        dgReturnBooks.Rows[IssueRowCnt].Cells[1].Value = IssueDataReader["Epf"].ToString();
                        dgReturnBooks.Rows[IssueRowCnt].Cells[2].Value = IssueDataReader["IssueDate"].ToString();
                        dgReturnBooks.Rows[IssueRowCnt].Cells[3].Value = IssueDataReader["ExpectReturn"].ToString();

                        string Exdate = IssueDataReader["ExpectReturn"].ToString();
                        string Todays = DateTime.Today.ToString();
                        DateTime DExdate = Convert.ToDateTime(Exdate);
                        DateTime DTodays = Convert.ToDateTime(Todays);
                        TimeSpan Diffdates = DTodays - DExdate;
                        string CalDates = Diffdates.ToString();
                        dgReturnBooks.Rows[IssueRowCnt].Cells[4].Value = CalDates;

                        IssueIsbn = IssueDataReader["Isbn"].ToString();
                        IssueEpf = IssueDataReader["Epf"].ToString();
                        IssuedDate = IssueDataReader["IssueDate"].ToString();
                        IssueReturn = IssueDataReader["ExpectReturn"].ToString();
                        IssueOverdue = CalDates;                        
                    }
                    
                }
                catch(Exception ex)
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
}
