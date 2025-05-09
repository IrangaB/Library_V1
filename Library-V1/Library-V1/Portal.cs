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
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
        }

        public string ConString = "Data Source=mtx-srv-fr001;Initial Catalog=Mtx_Library;Integrated Security=True";
        String USettings, BookSrch, BookRegister, EmpRegister, IssueBooks, ReturnBooks, ReportAll;

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();

            try
            {
                SqlCommand Cmd = new SqlCommand("select * from Permissions where Epf= '" + Login.LEpf + "' ", Cons);
                SqlDataReader PermisionDataReader = Cmd.ExecuteReader();

                while (PermisionDataReader.Read())
                {
                    BookSrch = PermisionDataReader["BookSearch"].ToString();

                }

                if (BookSrch == "1")
                {
                    BookSearch NewBookSearch = new BookSearch();
                    NewBookSearch.Show();
                }
                else
                {
                    MessageBox.Show("You dont have access to Books Search.. Please contact your System Administrator");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
                        
        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();

            try
            {
                SqlCommand Cmd = new SqlCommand("select * from Permissions where Epf= '" + Login.LEpf + "' ", Cons);
                SqlDataReader PermisionDataReader = Cmd.ExecuteReader();

                while (PermisionDataReader.Read())
                {
                    ReportAll = PermisionDataReader["Reports"].ToString();

                }

                if (ReportAll == "1")
                {
                    Reports newReports = new Reports();
                    newReports.Show();
                }
                else
                {
                    MessageBox.Show("You dont have access to Reports.. Please contact your System Administrator");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();

            try
            {
                SqlCommand Cmd = new SqlCommand("select * from Permissions where Epf= '" + Login.LEpf + "' ", Cons);
                SqlDataReader PermisionDataReader = Cmd.ExecuteReader();

                while (PermisionDataReader.Read())
                {
                    BookRegister = PermisionDataReader["BookRegister"].ToString();

                }

                if (BookRegister == "1")
                {
                    BookRegister NewBookRegister = new BookRegister();
                    NewBookRegister.Show();
                }
                else
                {
                    MessageBox.Show("You dont have access to Books Register.. Please contact your System Administrator");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
                                   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();

            try
            {
                SqlCommand Cmd = new SqlCommand("select * from Permissions where Epf= '" + Login.LEpf + "' ", Cons);
                SqlDataReader PermisionDataReader = Cmd.ExecuteReader();

                while (PermisionDataReader.Read())
                {
                    IssueBooks = PermisionDataReader["IssueBooks"].ToString();

                }

                if (IssueBooks == "1")
                {
                    IssueBooks NewIssueBooks = new IssueBooks();
                    NewIssueBooks.Show();
                }
                else
                {
                    MessageBox.Show("You dont have access to Issue Books.. Please contact your System Administrator");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

                        
        }

        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();

            try
            {
                SqlCommand Cmd = new SqlCommand("select * from Permissions where Epf= '" + Login.LEpf + "' ", Cons);
                SqlDataReader PermisionDataReader = Cmd.ExecuteReader();

                while (PermisionDataReader.Read())
                {
                    ReturnBooks = PermisionDataReader["ReturnBooks"].ToString();

                }

                if (ReturnBooks == "1")
                {
                    ReturnBooks NewReturnBooks = new ReturnBooks();
                    NewReturnBooks.Show();
                }
                else
                {
                    MessageBox.Show("You dont have access to Return Books.. Please contact your System Administrator");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();

            try
            {
                SqlCommand Cmd = new SqlCommand("select * from Permissions where Epf= '" + Login.LEpf + "' ",Cons);
                SqlDataReader PermisionDataReader = Cmd.ExecuteReader();

                while(PermisionDataReader.Read())
                {
                    EmpRegister = PermisionDataReader["EmployeeRegister"].ToString();

                }

                if (EmpRegister == "1")
                {
                    EmployeeRegisterv2 NewEmployeeRegister = new EmployeeRegisterv2();
                    NewEmployeeRegister.Show();
                }
                else
                {
                    MessageBox.Show("You dont have access to Employee Register.. Please contact your System Administrator");
                }
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
                                    
        }

        private void label2_Click(object sender, EventArgs e)
        {

            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();

            try
            {
                SqlCommand Cmd = new SqlCommand("select * from Permissions where Epf= '" + Login.LEpf + "' ", Cons);
                SqlDataReader PermisionDataReader = Cmd.ExecuteReader();

                while (PermisionDataReader.Read())
                {
                    USettings = PermisionDataReader["UserSettings"].ToString();

                }

                if (USettings == "1")
                {
                    UserSetttings NewUserSettings = new UserSetttings();
                    NewUserSettings.Show();
                }
                else
                {
                    MessageBox.Show("You dont have access to chage the System settings.. Please contact your System Administrator");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
                        
        }

        private void Portal_Load(object sender, EventArgs e)
        {
            lblPortalUser.Text = Login.LoginUser;
        }
    }
}
