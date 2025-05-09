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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string LoginUser,LEpf;
        SqlCommand Cmd;
        public string ConString = "Data Source=mtx-srv-fr001;Initial Catalog=Mtx_Library;Integrated Security=True";


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //txtusername.MaxLength = 18;
            //txtupwd.MaxLength = 15;
            txtusername.Text = "EPF";
            txtupwd.Text = "Password";      
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();
            

            //select * from Lib_Login    where Username = 'aaa' and Password = 'aaa'
            try
            {
                Cmd = new SqlCommand("select * from Login where Epf= '" + txtusername.Text + "' and Password='" + txtupwd.Text + "'", Cons);
                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                SqlDataReader dr = Cmd.ExecuteReader();

                while(dr.Read())
                {
                    LoginUser = dr["Username"].ToString();
                    LEpf = dr["Epf"].ToString();
                }

                int i = ds.Tables[0].Rows.Count;

                if(i==1)
                {
                    
                   // MessageBox.Show("Welcome " + LoginUser);
                    Portal LibPortal = new Portal();
                    LibPortal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                    txtusername.Text = "";
                    txtupwd.Text = "";
                    this.ActiveControl = txtusername;
                }


            }
            catch (SqlException exlogin)
            {
                MessageBox.Show(exlogin.Message);
                Application.Exit();

            }
            finally
            {
                Cons.Close();
            }
                                    
            
        }

        private void Pwreset_Click(object sender, EventArgs e)
        {
            PasswordRecovery NewPasswordRecovery = new PasswordRecovery();
            NewPasswordRecovery.Show();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtupwd_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
