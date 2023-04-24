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

namespace HostelManagement
{
    public partial class SalaryForm : Form
    {
        public SalaryForm()
        {
            InitializeComponent();
        }

        SqlConnection connstring = new SqlConnection(@"Data Source=IMAC\MSSQLSERVER2019;Integrated Security=True");

        void FillDataGridView()
        {
            try
            {
                connstring.Open();

                string query = "select * from FeesTbl";

                SqlDataAdapter adpt = new SqlDataAdapter(query, connstring);
                SqlCommandBuilder builder = new SqlCommandBuilder(adpt);

                var das = new DataSet();
                adpt.Fill(das);

                paymentDGV.DataSource = das.Tables[0];

                connstring.Close();
            }
            catch
            {
                MessageBox.Show("Table Data Load Faild", "Something Wrong",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string emp_name, emp_pos;

        void fetchEmployeeData()
        {

            try
            {
                // Open connection
                connstring.Open();

                // query Statement
                string query = "select * from EmployeeTbl where EmpId = '" + comboempid.SelectedValue.ToString() + "';";

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
                MessageBox.Show("Employee Data Load Faild", "Something Wrong",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboempid_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchEmployeeData();
        }

        private void comboempid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchEmployeeData();
        }

        private void comboempid_SelectedValueChanged(object sender, EventArgs e)
        {
            fetchEmployeeData();
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            btnadd.Visible = false;
            btnnew.Visible = true;
            fetchEmployeeData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String studusn = combousn.SelectedValue.ToString();
            String studname = tbstudname.Text;
            String paymentid = tbpaymentid.Text;
            String studroom = tbroomnum.Text;
            String month = dateTimePicker1.Value.ToString();
            String amount = tbamount.Text;


            if (combousn.SelectedIndex < 0)
            {
                MessageBox.Show("Select Student Username", "Username NOT selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (studusn.Length != 0 || studname.Length != 0
                || paymentid.Length != 0 || studroom.Length != 0
                || month.Length != 0 || amount.Length != 0)
            {
                try
                {
                    connstring.Open();

                    string query = "insert into FeesTbl values(" + paymentid + ", '" + studusn + "', '"
                        + studname + "', " + studroom + ", '" + month + "', " + amount + ");";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();

                    connstring.Close();

                    FillDataGridView();
                }
                catch
                {
                    MessageBox.Show("Payemnt Fees Add Faild", "Something Wrong",
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
    }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnnew.Visible = false;
            btnadd.Visible = true;
            tbdate.Text = "Date :";
            tbsalaryid.Text = "ID :";
            tbamount.Clear();
            tbempname.Clear();
            tbposition.Clear();
            
            tbsalaryid.Focus();

            fetchEmployeeData();
        }
    }
}
