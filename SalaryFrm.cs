using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class SalaryFrm : Form
    {
        public SalaryFrm()
        {
            InitializeComponent();
        }

        SqlConnection connstring = new SqlConnection(@"Data Source=IMAC\MSSQLSERVER2019;Integrated Security=True");

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnnew.Visible = false;
            btnadd.Visible = true;
            tbdate.Text = "Date :";
            tbsalaryid.Text = "ID";
            
            // fetch combo emp id

            tbempname.Text = "Employee Name :";
            tbposition.Text = "Employee Position :";
            tbamount.Clear();
            
            tbsalaryid.Focus();

            //FillEmployeesComboBox();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String salaryid = tbsalaryid.Text;
            String empid = comboempid.SelectedValue.ToString();
            String empname = tbempname.Text;
            String emppos = tbposition.Text;
            String month = dateTimePicker1.Value.ToString();
            String amount = tbamount.Text;

            if (comboempid.SelectedIndex < 0)
            {
                MessageBox.Show("Select Employee ID", "Employee ID NOT selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (salaryid.Length != 0 || empid.Length != 0
                || empname.Length != 0 || emppos.Length != 0
                || month.Length != 0 || amount.Length != 0)
            {
                try
                {

                    connstring.Open();

                    string query = "insert into SalaryTbl values(" + salaryid + ", '" + empid + "', '"
                        + empname + "', '" + emppos + "', '" + month + "', " + amount + ");";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salary Added");
                    connstring.Close();
                }
                catch
                {
                    MessageBox.Show("Salary Add Faild", "Something Wrong",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill All Blanks", "Data Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillDataGridView();

            btnnew.Visible = true;
            btnadd.Visible = false;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string emp_name, emp_pos;

        void FillDataGridView()
        {
            try
            {
                connstring.Open();

                string query = "select * from SalaryTbl";

                SqlDataAdapter adpt = new SqlDataAdapter(query, connstring);
                SqlCommandBuilder builder = new SqlCommandBuilder(adpt);

                var das = new DataSet();
                adpt.Fill(das);

                salaryDGV.DataSource = das.Tables[0];

                connstring.Close();
            }
            catch
            {
                MessageBox.Show("Salary Data Load to DGV Faild", "Something Wrong",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillEmployeeComboBox()
        {
            try
            {
                connstring.Open();

                string query = "select * from EmployeeTbl;";

                SqlCommand cmd = new SqlCommand(query, connstring);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();

                //Fill the DataTable with records from Table.
                DataTable datatbl = new DataTable();
                datatbl.Columns.Add("EmpId", typeof(string));
                datatbl.Load(reader);

                //Assign DataTable as DataSource.
                comboempid.DataSource = datatbl;
                comboempid.ValueMember = "EmpId";

                connstring.Close();

            }
            catch
            {
                MessageBox.Show("Employee Data Load to Combo Faild", "Something Wrong",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalaryFrm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            FillEmployeeComboBox();
        }

        int sal_id;
        private void salaryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbsalaryid.Text = salaryDGV.CurrentRow.Cells[0].Value.ToString();
            sal_id = Convert.ToInt32(tbsalaryid.Text);

            comboempid.SelectedValue = salaryDGV.CurrentRow.Cells[1].Value.ToString();
            tbempname.Text = salaryDGV.CurrentRow.Cells[2].Value.ToString();
            tbposition.Text = salaryDGV.CurrentRow.Cells[3].Value.ToString();
            tbdate.Text = salaryDGV.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String salaryid = tbsalaryid.Text;
            String empid = comboempid.SelectedValue.ToString();
            String empname = tbempname.Text;
            String emppos = tbposition.Text;
            String month = dateTimePicker1.Value.ToString();
            String amount = tbamount.Text;

            if (comboempid.SelectedIndex < 0)
            {
                MessageBox.Show("Select Employee ID", "Employee ID NOT selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sal_id != Convert.ToInt32(salaryid))
            {
                MessageBox.Show("Can NOT change this ID", "NOT Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (salaryid.Length != 0 || empid.Length != 0
                || empname.Length != 0 || emppos.Length != 0
                || month.Length != 0 || amount.Length != 0)
            {
                try
                {
                    connstring.Open();

                    string query = "update SalaryTbl set SalAmount = '" + amount + "' where SalId = " + salaryid + ";";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salary Update");
                    connstring.Close();
                }
                catch
                {
                    MessageBox.Show("Salary Update Faild", "Something Wrong",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill All Blanks", "Data Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillDataGridView();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String salaryid = tbsalaryid.Text;

            if (comboempid.SelectedIndex < 0)
            {
                MessageBox.Show("Select Employee ID", "Employee ID NOT selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sal_id != Convert.ToInt32(salaryid))
            {
                MessageBox.Show("Can NOT change this ID", "NOT Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
                try
                {
                    connstring.Open();

                    string query = "delete from SalaryTbl where SalId = " + salaryid + ";";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salary Deleted");
                    connstring.Close();
                }
                catch
                {
                    MessageBox.Show("Salary Delete Faild", "Something Wrong",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            FillDataGridView();
        }

        private void comboempid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Open connection
                connstring.Open();

                // query Statement
                string query = "select * from EmployeeTbl where EmpId = '"
                    + comboempid.SelectedValue.ToString() + "';";

                // command statement
                SqlCommand cmd = new SqlCommand(query, connstring);

                // DataTable statement
                DataTable dat = new DataTable();

                // Adpter statement
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);

                // fill adpter with table
                adpt.Fill(dat);

                // bring the data 
                foreach (DataRow drow in dat.Rows)
                {
                    emp_name = drow["EmpName"].ToString();
                    emp_pos = drow["EmpPos"].ToString();
                    tbempname.Text = emp_name;
                    tbposition.Text = emp_pos;
                }

                connstring.Close();
            }
            catch
            {
                //MessageBox.Show("Employee Data Load to txtBox Faild", "Something Wrong",
                //MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
