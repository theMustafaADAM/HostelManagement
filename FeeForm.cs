using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class FeeForm : Form
    {
        public FeeForm()
        {
            InitializeComponent();
        }

        SqlConnection connstring = new SqlConnection(@"Data Source=IMAC\MSSQLSERVER2019;Integrated Security=True");

        void FillStudUSNComboBox()
        {
            try
            {
                connstring.Open();

                // query statement
                string query = "select * from StudentTbl;";

                // command and reader statement
                SqlCommand cmd = new SqlCommand(query, connstring);
                SqlDataReader reader;

                // Execute reader
                reader = cmd.ExecuteReader();

                //Fill the DataTable with records from Table.
                DataTable datatbl = new DataTable();
                datatbl.Columns.Add("StudUsn", typeof(string));
                datatbl.Load(reader);

                //Assign DataTable as DataSource.
                combousn.DataSource = datatbl;
                combousn.ValueMember = "StudUsn";

                connstring.Close();
            }
            catch
            {
                //MessageBox.Show("Student USN Data Load Faild", "Something Wrong",
                  //MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string student_name, room_num;

        void fetchStudentData()
        {         
            
            try
            {
                // Open connection
                connstring.Open();

                // query Statement
                string query = "select * from StudentTbl where StudUsn = '" 
                    + combousn.SelectedValue.ToString() + "';";

                // command statement
                SqlCommand cmd = new SqlCommand(query, connstring);

                // DataTable statement
                DataTable dat = new DataTable();

                // Adpter statement
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);

                // fill adpter with table
                adpt.Fill(dat);

                // bring the data 
                foreach (DataRow drow in dat.Rows )
                {
                    student_name = drow["StudName"].ToString();
                    room_num = drow["StudRoom"].ToString();
                    tbstudname.Text = student_name;
                    tbroomnum.Text = room_num;
                }

                connstring.Close();
            }
            catch
            {
                //MessageBox.Show("Student USN Data Load Faild", "Something Wrong",
                  //MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

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

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tbdate.Text = dateTimePicker1.Value.Day.ToString() + "/"
                + dateTimePicker1.Value.Month.ToString() + "/"
                + dateTimePicker1.Value.Year.ToString();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnnew.Visible = false;
            btnadd.Visible = true;
            tbamount.Clear();
            tbpaymentid.Text = "ID";
            tbstudname.Text = "Name";
            tbroomnum.Text = "Room No.";
            tbpaymentid.Focus();
        }

        private void FeeForm_Load(object sender, EventArgs e)
        {
            FillStudUSNComboBox();
            FillDataGridView();
            btnadd.Visible = false;
            btnnew.Visible = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String studusn = combousn.SelectedValue.ToString();
            String studname = tbstudname.Text;
            String paymentid = tbpaymentid.Text;
            String studroom = tbroomnum.Text;
            String month = dateTimePicker1.Value.Month.ToString() 
                + dateTimePicker1.Value.Year.ToString();
            String amount = tbamount.Text;


            if(combousn.SelectedIndex < 0)
            {
                MessageBox.Show("Select Student Username", "Username NOT selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (studusn.Length == 0 || studname.Length == 0
                || paymentid.Length == 0 || studroom.Length == 0
                || month.Length == 0 || amount.Length == 0)
            {
                MessageBox.Show("Fill All Blanks", "Data Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                
                try
                {
                    connstring.Open();

                    // Make sure payment made for this month
                    string query = "SELECT COUNT(*) from FeesTbl where StudentUsn = '"
                        + combousn.SelectedValue.ToString() + "' and PaymentMonth '" + month + "';";
                    SqlDataAdapter adpt = new SqlDataAdapter(query, connstring);
                    DataTable dat = new DataTable();
                    adpt.Fill(dat);

                    if(dat.Rows[0][0].ToString()=="1")
                    {
                        MessageBox.Show("No Due for this Month", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        connstring.Close();
                        return;
                    }
                    else
                    {
                        try
                        {                            
                            string aquery = "insert into FeesTbl values(" + paymentid + ", '" + studusn + "', '"
                                + studname + "', " + studroom + ", '" + month + "', " + amount + ");";
                            SqlCommand cmd = new SqlCommand(aquery, connstring);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Payemnt Fees Add Maded");
                            connstring.Close();

                        }
                        catch
                        {
                            MessageBox.Show("Payemnt Fees Add Faild", "Something Wrong",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    connstring.Close();

                }
                catch
                {
                    MessageBox.Show("Find Record for Payemnt Fees Faild", "Something Wrong",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
            FillDataGridView();

            btnadd.Visible = false;
            btnnew.Visible = true;
        }

        private void combousn_SelectedValueChanged(object sender, EventArgs e)
        {
            fetchStudentData();
        }

        private void combousn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchStudentData();
        }

        int pymnt_id;

        private void btnupdate_Click(object sender, EventArgs e)
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

            if(pymnt_id != Convert.ToInt32(paymentid))
            {
                MessageBox.Show("Can NOT change payment ID", "NOT alloweed",
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

                    string query = "update FeesTbl set StudentUsn = '" + studusn + "', StudentName ='"  
                        + studname + "', StudRoom = " + studroom + ", PaymentMonth = '" + month + "', Amount =" + amount + 
                        " where PaymentId = " + paymentid + ";";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();

                    connstring.Close();

                    MessageBox.Show("Payment Updated");

                    FillDataGridView();
                }
                catch
                {
                    MessageBox.Show("Payemnt Fees Update Faild", "Something Wrong",
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

        private void paymentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbpaymentid.Text = paymentDGV.CurrentRow.Cells[0].Value.ToString();
            pymnt_id = Convert.ToInt32(tbpaymentid.Text);

            combousn.SelectedValue = paymentDGV.CurrentRow.Cells[1].Value.ToString();
            tbstudname.Text = paymentDGV.CurrentRow.Cells[2].Value.ToString();
            tbroomnum.Text = paymentDGV.CurrentRow.Cells[3].Value.ToString();
            tbdate.Text = paymentDGV.CurrentRow.Cells[4].Value.ToString();
            tbamount.Text = paymentDGV.CurrentRow.Cells[5].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String paymentid = tbpaymentid.Text;

            if (pymnt_id != Convert.ToInt32(paymentid))
            {
                MessageBox.Show("Can NOT change payment ID", "NOT alloweed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connstring.Open();

                string query = "delete from FeesTbl where PaymentId = " + paymentid + ";";
                SqlCommand cmd = new SqlCommand(query, connstring);
                cmd.ExecuteNonQuery();

                connstring.Close();

                MessageBox.Show("Payment deleted");

                FillDataGridView();
            }
            catch
            {
                MessageBox.Show("Payemnt Fees delete Faild", "Something Wrong",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combousn_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchStudentData();        
        }
    }
}
