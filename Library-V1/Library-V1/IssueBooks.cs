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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        public static string IssueIsbn, IssueEpf;
        public string ConString = "Data Source=mtx-srv-fr001;Initial Catalog=Mtx_Library;Integrated Security=True";

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();

            try
            {          
                                    
               string issuedate = DateTime.Now.ToString("yyyy/MM/dd");
               string PickedDate = dateTimePicker1.Value.ToString("yyyy/MM/dd");
               string IssuedFlag = "1";
                  SqlCommand NewIssueBook = new SqlCommand("Insert into IssueBooks (Isbn,Epf,IssueDate,ExpectReturn,IssueFlag) values ('" + IssueIsbn + "','" + IssueEpf + "','" + issuedate + "','" + PickedDate + "','" + IssuedFlag + "')", Cons);
                  SqlDataReader IssueDr = NewIssueBook.ExecuteReader();
                    while (IssueDr.Read())
                    {
                       
                    }
                int EmpIssueRowCnt = dgIsses.Rows.Add();
                dgIsses.Rows[EmpIssueRowCnt].Cells[0].Value = IssueIsbn;
                dgIsses.Rows[EmpIssueRowCnt].Cells[1].Value = IssueEpf;
                dgIsses.Rows[EmpIssueRowCnt].Cells[2].Value = issuedate;
                dgIsses.Rows[EmpIssueRowCnt].Cells[3].Value = PickedDate;
                dgIsses.Rows[EmpIssueRowCnt].Cells[4].Value = "Issued";

                MessageBox.Show("Book is issued, Please handover the book to Employee");

                dgIsses.Rows.Clear();
                txtbooksearch.Text = "";
                txtbooksearch.Select();
                dgIsses.Rows.Clear();
                dgIssuebooks.Rows.Clear();
                dgIssuEmp.Rows.Clear();
                txtempsearch.Text = "";
                txtbooksearch.Select();


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

        private void button3_Click(object sender, EventArgs e)
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

        private void btnBooksrch_Click(object sender, EventArgs e)
        {
            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();
            dgIssuebooks.Rows.Clear();





            SqlCommand cmd = new SqlCommand("SELECT * from IssueBooks  where Isbn = '" + txtbooksearch.Text + "' ", Cons);
            SqlDataReader IssueFlagDr = cmd.ExecuteReader();
            
            while (IssueFlagDr.Read())
            {
                string Issuecheck = IssueFlagDr["IssueFlag"].ToString();

                //bool chknull = String.IsNullOrEmpty(Issuecheck);
                

                if (Issuecheck == "1")
                {
                    MessageBox.Show("This book is already issued from the system..");
                    txtbooksearch.Text = "";
                    txtbooksearch.Select();
                    dgIsses.Rows.Clear();
                    dgIssuebooks.Rows.Clear();
                    dgIssuEmp.Rows.Clear();
                    txtempsearch.Text = "";
                    txtbooksearch.Select();


                }
                
            }

            IssueFlagDr.Close();
            
                try
                {
                    
                            SqlCommand Issuecmd = new SqlCommand("select * from BookRegister where Isbn = '" + txtbooksearch.Text + "' ", Cons);
                            SqlDataReader IssuDr = Issuecmd.ExecuteReader();
                            while (IssuDr.Read())
                            {
                                int IssueRowCnt = dgIssuebooks.Rows.Add();
                                dgIssuebooks.Rows[IssueRowCnt].Cells[0].Value = IssuDr["Isbn"].ToString();
                                IssueIsbn = IssuDr["Isbn"].ToString();
                                dgIssuebooks.Rows[IssueRowCnt].Cells[1].Value = IssuDr["BookName"].ToString();
                                dgIssuebooks.Rows[IssueRowCnt].Cells[2].Value = IssuDr["Author"].ToString();
                                dgIssuebooks.Rows[IssueRowCnt].Cells[3].Value = IssuDr["BookType"].ToString();
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

        private void txtbooksearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtempsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnEmplsrch_Click(object sender, EventArgs e)
        {

            if (txtempsearch.Text == "")
            {
                MessageBox.Show("Cannot search empty fields");
            }
            else
            {
                SqlConnection Cons = new SqlConnection(ConString);
                Cons.Open();

                try
                {
                    dgIssuEmp.Rows.Clear();
                    SqlCommand Empdatacmd = new SqlCommand("select * from Employee where Epf = '" + txtempsearch.Text + "'", Cons);
                    SqlDataReader EmpdataDR = Empdatacmd.ExecuteReader();
                    while(EmpdataDR.Read())
                    {
                        int EmpRowCnt = dgIssuEmp.Rows.Add();
                        dgIssuEmp.Rows[EmpRowCnt].Cells[0].Value = EmpdataDR["Epf"].ToString();
                        IssueEpf = EmpdataDR["Epf"].ToString();

                        string finame,laname,funame;
                        finame = EmpdataDR["FirstName"].ToString();
                        laname = EmpdataDR["LastName"].ToString();
                        funame = finame + " " + laname;
                        dgIssuEmp.Rows[EmpRowCnt].Cells[1].Value = funame;

                        dgIssuEmp.Rows[EmpRowCnt].Cells[2].Value = EmpdataDR["Departments"].ToString();



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
