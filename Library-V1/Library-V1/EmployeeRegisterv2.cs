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
    public partial class EmployeeRegisterv2 : Form
    {
        public EmployeeRegisterv2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            txtEpf.Enabled = false;
            txtFname.Enabled = false;
            txtLName.Enabled = false;
            rdEmpMale.Enabled = false;
            rdEmpFemale.Enabled = false;





            if (txtEmployee.Text == "")
            {
                MessageBox.Show("Cannot search an empty value");
                txtEmployee.Select();
            }
            else
            {
                
                SqlConnection Cons = new SqlConnection(ConString);
                Cons.Open();

                try
                {
                    dgEmpdata.Rows.Clear();
                    SqlCommand Cmd = new SqlCommand("select * from Employee where Epf= '" + txtEmployee.Text + "' ", Cons);
                    SqlDataReader EmployeeDataReader = Cmd.ExecuteReader();

                    while (EmployeeDataReader.Read())
                    {
                        int EmpRowCnt = dgEmpdata.Rows.Add();
                        dgEmpdata.Rows[EmpRowCnt].Cells[0].Value = EmployeeDataReader["Epf"].ToString();
                        dgEmpdata.Rows[EmpRowCnt].Cells[1].Value = EmployeeDataReader["FirstName"].ToString();
                        dgEmpdata.Rows[EmpRowCnt].Cells[2].Value = EmployeeDataReader["LastName"].ToString();
                        dgEmpdata.Rows[EmpRowCnt].Cells[3].Value = EmployeeDataReader["Departments"].ToString();
                        dgEmpdata.Rows[EmpRowCnt].Cells[4].Value = EmployeeDataReader["Designation"].ToString();
                        dgEmpdata.Rows[EmpRowCnt].Cells[5].Value = EmployeeDataReader["Gender"].ToString();
                        string Empstatus = EmployeeDataReader["EmpStatus"].ToString();
                        string newstatus;
                        if (Empstatus == "1")
                        {
                            newstatus = "Active";
                            dgEmpdata.Rows[EmpRowCnt].Cells[6].Value = newstatus;

                        }
                        else
                        {
                            newstatus = "Not Active";
                            dgEmpdata.Rows[EmpRowCnt].Cells[6].Value = newstatus;
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

        private void EmployeeRegisterv2_Load(object sender, EventArgs e)
        {
            this.sectionsTableAdapter1.Fill(this.mtx_LibraryDataSet1.Sections);
            this.sectionsTableAdapter.Fill(this.mtx_LibraryDataSet.Sections);
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            txtEpf.Enabled = false;
            txtFname.Enabled = false;
            txtLName.Enabled = false;
            rdEmpFemale.Enabled = false;
            rdEmpMale.Enabled = false;
            cmdDepartment.Enabled = false;
            cmdDesignation.Enabled = false;


        }

        private void txtEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtEpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgEmpdata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgEmpdata.Rows[e.RowIndex];

                    txtEpf.Text = row.Cells["Column7"].Value.ToString();
                    txtFname.Text = row.Cells["Column1"].Value.ToString();
                    txtLName.Text = row.Cells["Column8"].Value.ToString();
                    string EmStatus = row.Cells["Column5"].Value.ToString();
                    if(EmStatus == "Active")
                    {
                        rdEmpActive.Select();
                    }
                    else
                    {
                        rdEmpInactive.Select();
                    }
                    string EmGender = row.Cells["Column3"].Value.ToString();
                    if(EmGender == "Male")
                    {
                        rdEmpMale.Select();
                    }
                    else
                    {
                        rdEmpFemale.Select();
                    }
                }

                txtEpf.Enabled = false;
                txtFname.Enabled = false;
                txtLName.Enabled = false;
                rdEmpFemale.Enabled = false;
                rdEmpMale.Enabled = false;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgEmpdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgEmpdata.Rows[e.RowIndex];

                    txtEpf.Text = row.Cells["Column7"].Value.ToString();
                    txtFname.Text = row.Cells["Column1"].Value.ToString();
                    txtLName.Text = row.Cells["Column8"].Value.ToString();
                    string EmStatus = row.Cells["Column5"].Value.ToString();
                    if (EmStatus == "Active")
                    {
                        rdEmpActive.Select();
                    }
                    else
                    {
                        rdEmpInactive.Select();
                    }
                    string EmGender = row.Cells["Column3"].Value.ToString();
                    if (EmGender == "Male")
                    {
                        rdEmpMale.Select();
                    }
                    else
                    {
                        rdEmpFemale.Select();
                    }

                    txtEpf.Enabled = false;
                    txtFname.Enabled = false;
                    txtLName.Enabled = false;
                    rdEmpFemale.Enabled = false;
                    rdEmpMale.Enabled = false;
                    btnSave.Enabled = false;
                    
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(txtEpf.Text == "" )
            {
                MessageBox.Show("EPF cannot be blank");
                txtEpf.Select();
            }
            else if(txtFname.Text == "")
            {
                MessageBox.Show("First name cannot be blank");
                txtFname.Select();
            }
            else if(txtLName.Text == "")
            {
                MessageBox.Show("Last name cannot be blank");
                txtLName.Select();
            }
            else if(rdEmpActive.Checked == false && rdEmpInactive.Checked == false)
            {
                MessageBox.Show("Employee status cannot be unchecked");
            }
            else if(rdEmpMale.Checked == false && rdEmpFemale.Checked == false)
            {
                MessageBox.Show("Employee gender cannot be uncheked");
            }
            else
            {
                SqlConnection Cons = new SqlConnection(ConString);
                Cons.Open();
                try
                {
                    String EmStatus, Emgender;

                    if (rdEmpActive.Checked)
                    {
                        EmStatus = "1";
                    }
                    else 
                    {
                        EmStatus = "0";
                    }
                    if(rdEmpMale.Checked)
                    {
                        Emgender = "Male";
                    }
                    else 
                    {
                        Emgender = "Female";
                    }

                    SqlCommand InsertEmployee = new SqlCommand("insert into Employee (Epf,FirstName,LastName,Designation,Departments,Gender,EmpStatus) values ('" + txtEpf.Text + "','" + txtFname.Text + "','" + txtLName.Text + "','" + cmdDesignation.SelectedValue.ToString() + "','"+cmdDepartment.SelectedValue.ToString()+"','"+Emgender+"','"+EmStatus+"')", Cons);
                    SqlDataReader InsertEmDR = InsertEmployee.ExecuteReader();
                    while(InsertEmDR.Read())
                    {

                    }
                    InsertEmDR.Close();

                    SqlCommand LoadDataCmd = new SqlCommand("select * from Employee", Cons);
                    SqlDataReader LoadDataDR = LoadDataCmd.ExecuteReader();
                    while(LoadDataDR.Read())
                    {
                        int EmpDataLoad = dgEmpdata.Rows.Add();
                        dgEmpdata.Rows[EmpDataLoad].Cells[0].Value = LoadDataDR["Epf"].ToString();
                        dgEmpdata.Rows[EmpDataLoad].Cells[1].Value = LoadDataDR["FirstName"].ToString();
                        dgEmpdata.Rows[EmpDataLoad].Cells[2].Value = LoadDataDR["LastName"].ToString();
                        dgEmpdata.Rows[EmpDataLoad].Cells[3].Value = LoadDataDR["Designation"].ToString();
                        dgEmpdata.Rows[EmpDataLoad].Cells[4].Value = LoadDataDR["Departments"].ToString();
                        dgEmpdata.Rows[EmpDataLoad].Cells[5].Value = LoadDataDR["Gender"].ToString();
                        string Empstatus = LoadDataDR["EmpStatus"].ToString();
                        string newstatus;
                        if (Empstatus == "1")
                        {
                            newstatus = "Active";
                            dgEmpdata.Rows[EmpDataLoad].Cells[6].Value = newstatus;

                        }
                        else
                        {
                            newstatus = "Not Active";
                            dgEmpdata.Rows[EmpDataLoad].Cells[6].Value = newstatus;
                        }
                        
                    }
                    LoadDataDR.Close();

                    MessageBox.Show("New employee added to the system");
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtEpf.Enabled = true;
            txtFname.Enabled = true;
            txtLName.Enabled = true;
            rdEmpFemale.Enabled = true;
            rdEmpMale.Enabled = true;
            cmdDepartment.Enabled = true;
            cmdDesignation.Enabled = true;
            txtEmployee.Text = "";
            txtEpf.Text = "";
            txtFname.Text = "";
            txtLName.Text = "";
            cmdDepartment.Text = "";
            cmdDesignation.Text = "";
            dgEmpdata.Rows.Clear();
            txtEpf.Select();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection Cons = new SqlConnection(ConString);
            Cons.Open();

            try
            {
                String EmStatus;

                if (rdEmpActive.Checked)
                {
                    EmStatus = "1";
                }
                else
                {
                    EmStatus = "0";
                }

                SqlCommand Empupdate = new SqlCommand(" update Employee set EmpStatus = '" + EmStatus + "', Designation = '"+ cmdDesignation.SelectedValue.ToString()+ "', Departments = '"+cmdDepartment.SelectedValue.ToString()+"' where(Epf = '" + txtEpf.Text + "')", Cons);
                SqlDataReader mealdr = Empupdate.ExecuteReader();
                while(mealdr.Read())
                {

                }

                MessageBox.Show("Updated Successfully.. ");
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

        private void txtEpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
