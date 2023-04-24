using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        SqlConnection connstring = new SqlConnection(@"Data Source=IMAC\MSSQLSERVER2019;Integrated Security=True");

        void FillDataGridView()
        {
            try
            {
                connstring.Open();

                string query = "select * from StudentTbl";

                SqlDataAdapter adpt = new SqlDataAdapter(query, connstring);
                SqlCommandBuilder builder = new SqlCommandBuilder(adpt);

                var das = new DataSet();
                adpt.Fill(das);

                StudentDGV.DataSource = das.Tables[0];

                connstring.Close();
            }
            catch
            {
                //MessageBox.Show("Table Data Load Faild", "Something Wrong",
                  //  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UpdateBookedStatusOnDelete()
        {
            try
            {
                connstring.Open();

                string query = "update RoomTbl set Booked = 'Free' where RoomNum = " + comboroomnum.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(query, connstring);
                cmd.ExecuteNonQuery();

                connstring.Close();
            }
            catch
            {
                //MessageBox.Show("Room Update Faild", "Something Wrong",
                  //  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UpdateBookedStatus()
        {
            try
            {
                connstring.Open();

                string query = "update RoomTbl set Booked = 'Busy' where RoomNum = " + comboroomnum.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(query, connstring);
                cmd.ExecuteNonQuery();

                connstring.Close();
            }
            catch
            {
                //MessageBox.Show("Room Update Faild", "Something Wrong",
                  //  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillComboBox()
        {
            try
            {
                connstring.Open();

                string query = "select * from RoomTbl where RoomStatus = 'Not-Active' and Booked = 'Free';";

                SqlCommand cmd = new SqlCommand(query, connstring);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();

                //Fill the DataTable with records from Table.
                DataTable datatbl = new DataTable();
                datatbl.Columns.Add("RoomNum", typeof(int));
                datatbl.Load(reader);
                
                //Assign DataTable as DataSource.
                comboroomnum.DataSource = datatbl;
                comboroomnum.ValueMember = "RoomNum";

                connstring.Close();               

            }
            catch
            {
                //MessageBox.Show("Rooms Data Load Faild", "Something Wrong",
                  //  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillComboBoxBookedActive()
        {
            try
            {
                connstring.Open();

                string query = "select * from RoomTbl where Booked = 'Busy';";

                SqlCommand cmd = new SqlCommand(query, connstring);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();

                //Fill the DataTable with records from Table.
                DataTable datatbl = new DataTable();
                datatbl.Columns.Add("RoomNum", typeof(int));
                datatbl.Load(reader);

                //Assign DataTable as DataSource.
                comboroomnum.DataSource = datatbl;
                comboroomnum.ValueMember = "RoomNum";

                connstring.Close();

            }
            catch
            {
                //MessageBox.Show("Rooms Data Load Faild", "Something Wrong",
                  //  MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            String studusn = tbstudntusn.Text;
            String studname = tbstudname.Text;
            String father = tbfathername.Text;
            String mother = tbmothername.Text;
            String address = tbaddress.Text;
            String college = tbcollege.Text;

            string studstatus;

            if (comboroomnum.SelectedIndex < 0)
            {
                MessageBox.Show("Select Room Number", "Room Number NOT selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (studusn.Length != 0 || studname.Length != 0 
                || father.Length != 0 || mother.Length != 0
                || address.Length != 0 || college.Length != 0)
            {
                try
                {
                    if (rbstudliving.Checked)
                        studstatus = "Living";
                    else
                        studstatus = "Left";
                    
                    connstring.Open();

                    string query = "insert into StudentTbl values('" + studusn + "', '" + studname + "', '"
                        + father + "', '" + mother + "', '" + address + "', '" + college + "', "
                        + comboroomnum.SelectedValue.ToString() + ", '" + studstatus + "');";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();
                    
                    connstring.Close();
                    
                    UpdateBookedStatus();
                    FillComboBox();
                    FillDataGridView();
                }
                catch
                {
                    //MessageBox.Show("Student Add Faild", "Something Wrong",
                      //  MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void StudentForm_Load(object sender, EventArgs e)
        {
            FillComboBox();
            FillDataGridView();
            btnadd.Visible = false;
            btnnew.Visible = true;
        }

        string stuent_usn = "";

        private void StudentDGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillComboBoxBookedActive();

            tbstudntusn.Text = StudentDGV.CurrentRow.Cells[0].Value.ToString();
            stuent_usn = tbstudntusn.Text;

            tbstudname.Text = StudentDGV.CurrentRow.Cells[1].Value.ToString();
            tbfathername.Text = StudentDGV.CurrentRow.Cells[2].Value.ToString();
            tbmothername.Text = StudentDGV.CurrentRow.Cells[3].Value.ToString();
            tbaddress.Text = StudentDGV.CurrentRow.Cells[4].Value.ToString();
            tbcollege.Text = StudentDGV.CurrentRow.Cells[5].Value.ToString();
            
            //FillComboBoxBookedActive();
            //comboroomnum.SelectedValue = StudentDGV.CurrentRow.Cells[6].Value.ToString();

            if (StudentDGV.CurrentRow.Cells[7].Value.ToString() == "Living")
                rbstudliving.Checked = true;
            else
                rbstudleft.Checked = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String studusn = tbstudntusn.Text;
            String studname = tbstudname.Text;
            String father = tbfathername.Text;
            String mother = tbmothername.Text;
            String address = tbaddress.Text;
            String college = tbcollege.Text;

            string studstatus;

            if (comboroomnum.SelectedIndex < 0)
            {
                MessageBox.Show("Select Room Number", "Room Number NOT selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (studusn != stuent_usn)
            {
                MessageBox.Show("You can NOT change USN", "NOT Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Updating Room Number", "Attention", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            if (studusn.Length != 0 || studname.Length != 0
                || father.Length != 0 || mother.Length != 0
                || address.Length != 0 || college.Length != 0)
            {
                try
                {
                    if (rbstudliving.Checked)
                        studstatus = "Living";
                    else
                        studstatus = "Left";

                    connstring.Open();

                    string query = "update StudentTbl set StudName = '" + studname + "', FatherName = '"
                        + father + "', MotherName = '" + mother + "', StudAddress = '" + address + "', StudCollege = '" + college +
                        "', StudRoom = " + comboroomnum.SelectedValue.ToString() + ", StudStatus = '" + studstatus +
                        "' where StudUsn = '" + studusn + "';";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();

                    connstring.Close();

                    UpdateBookedStatus();
                    FillComboBox();
                    FillDataGridView();
                }
                catch
                {
                    //MessageBox.Show("Student Update Faild", "Something Wrong",
                      //  MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (tbstudntusn.Text != stuent_usn)
            {
                MessageBox.Show("You can NOT change USN", "NOT Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboroomnum.SelectedIndex < 0)
            {
                MessageBox.Show("No Room Number Selected", "NOT Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deleting Room Number", "Attention", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;


            if (tbstudntusn.TextLength != 0 )
            {
                try
                {
                    connstring.Open();

                    string query = "delete from StudentTbl where StudUsn = '" + tbstudntusn.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();

                    connstring.Close();

                    UpdateBookedStatusOnDelete();
                    FillComboBox();
                    FillDataGridView();
                }
                catch
                {
                    //MessageBox.Show("Student Delete Faild", "Something Wrong",
                      //  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Required USN", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillDataGridView();
        }

       
        private void StudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillComboBoxBookedActive();

            tbstudntusn.Text = StudentDGV.CurrentRow.Cells[0].Value.ToString();
            stuent_usn = tbstudntusn.Text;

            tbstudname.Text = StudentDGV.CurrentRow.Cells[1].Value.ToString();
            tbfathername.Text = StudentDGV.CurrentRow.Cells[2].Value.ToString();
            tbmothername.Text = StudentDGV.CurrentRow.Cells[3].Value.ToString();
            tbaddress.Text = StudentDGV.CurrentRow.Cells[4].Value.ToString();
            tbcollege.Text = StudentDGV.CurrentRow.Cells[5].Value.ToString();

            

            if (StudentDGV.CurrentRow.Cells[7].Value.ToString() == "Living")
                rbstudliving.Checked = true;
            else
                rbstudleft.Checked = true;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnnew.Visible = false;
            btnadd.Visible = true;
            tbstudntusn.Text = "USN";
            tbstudname.Text = "Name";
            tbfathername.Text = "Father";
            tbmothername.Text = "Mother";
            tbaddress.Text = "Address";
            tbcollege.Text = "College";
            tbstudntusn.Focus();

            FillComboBox();
        }
    }
}
