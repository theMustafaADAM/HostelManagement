using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        void FillDataGridView()
        {
            try
            {
                connstring.Open();

                string query = "select * from EmployeeTbl";

                SqlDataAdapter adpt = new SqlDataAdapter(query, connstring);
                SqlCommandBuilder builder = new SqlCommandBuilder(adpt);

                var das = new DataSet();
                adpt.Fill(das);

                dataGridView1.DataSource = das.Tables[0];

                connstring.Close();
            }
            catch
            {
                MessageBox.Show("Data Faild", "Something Wrong",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        SqlConnection connstring = new SqlConnection(@"Data Source=IMAC\MSSQLSERVER2019;Integrated Security=True");

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            btnadd.Visible = false;
            btnnew.Visible = true;
        }

        string emp_id;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*tbempid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            emp_id = tbempid.Text;

            tbempname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbphone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbaddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim() == "Left")
                rbempleft.Checked = true;
            else
                rbempworking.Checked = true;

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Mess Staff")
                comboposition.SelectedIndex = 0;
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Accountant")
                comboposition.SelectedIndex = 1;
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Cleaner")
                comboposition.SelectedIndex = 2;
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Manager")
                comboposition.SelectedIndex = 3;*/            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String empid = tbempid.Text;
            String empname = tbempname.Text;
            String phone = tbphone.Text;
            String address = tbaddress.Text;

            string empstatus = "";

            if (comboposition.SelectedIndex < 0)
            {
                MessageBox.Show("Select Employee Position", "Employee Position NOT selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (empid.Length != 0 || empname.Length != 0
                || address.Length != 0 || phone.Length != 0)
            {
                try
                {
                    if (rbempworking.Checked)
                        empstatus = "Working";
                    else
                        empstatus = "Left";

                    connstring.Open();

                    string query = "insert into EmployeeTbl values('" + empid + "', '" + empname + "', '"
                        + phone + "', '" + address + "', '" + comboposition.SelectedItem.ToString() + "', '"
                        + empstatus + "');";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();

                    connstring.Close();

                    FillDataGridView();
                }
                catch
                {
                    MessageBox.Show("Employee Add Faild", "Something Wrong",
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
            btnadd.Visible = false;
            btnnew.Visible = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String empid = tbempid.Text;
            String empname = tbempname.Text;
            String phone = tbphone.Text;
            String address = tbaddress.Text;

            string empstatus = "";

            if (comboposition.SelectedIndex < 0)
            {
                MessageBox.Show("Select Employee Position", "Employee Position NOT selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(empid != emp_id)
            {
                MessageBox.Show("Can Not Change Employee ID", "NOT Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (empid.Length != 0 || empname.Length != 0
                || address.Length != 0 || phone.Length != 0)
            {
                try
                {
                    if (rbempworking.Checked)
                        empstatus = "Working";
                    else
                        empstatus = "Left";

                    connstring.Open();

                    string query = "update EmployeeTbl set EmpName = '" + empname + "', EmpPhone = '"
                        + phone + "', EmpAddress = '" + address + "', EmpPos = '" + comboposition.SelectedItem.ToString() +
                        "', EmpStatus = '" + empstatus + "' where EmpId = '" + empid + "';";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();

                    connstring.Close();

                    FillDataGridView();
                }
                catch
                {
                    MessageBox.Show("Employee Update Faild", "Something Wrong",
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
            
            if (tbempid.Text != emp_id)
            {
                MessageBox.Show("Can Not Change Employee ID", "NOT Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbempid.TextLength != 0 )
            {
                try
                {
                    connstring.Open();

                    string query = "delete from EmployeeTbl where EmpId = '" + tbempid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();

                    connstring.Close();

                    FillDataGridView();
                }
                catch
                {
                    MessageBox.Show("Employee Delete Faild", "Something Wrong",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Field Delete", "Data Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillDataGridView();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnnew.Visible = false;
            btnadd.Visible = true;
            tbempid.Text = "ID";
            tbempname.Text = "Name";
            tbphone.Text = "Phone";
            tbaddress.Text = "Address";
            comboposition.SelectedIndex = 0;
            tbempid.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbempid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            emp_id = tbempid.Text;

            tbempname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbphone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbaddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim() == "Left")
                rbempleft.Checked = true;
            else
                rbempworking.Checked = true;

            comboposition.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
