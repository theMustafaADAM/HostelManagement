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
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
        }

        void FillDataGridView()
        {
            try
            {
                connstring.Open();

                string query = "select * from RoomTbl";
                
                SqlDataAdapter adpt = new SqlDataAdapter(query, connstring);
                SqlCommandBuilder builder = new SqlCommandBuilder(adpt);
                
                var das = new DataSet();
                adpt.Fill(das);
                
                RoomDGV.DataSource = das.Tables[0];

                connstring.Close();
            }
            catch
            {
                //MessageBox.Show("Data Faild", "Something Wrong",
                  //  MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String roomnumb = tbroomnum.Text;
                        
            String roombook;

            if (comboroomstatus.SelectedIndex < 0)
            {
                MessageBox.Show("Select Room Status", "Room Status NOT selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (roomnumb.Length != 0 )
            {
                try
                {
                    if (rbyesbooked.Checked)
                        roombook = "Busy";
                    else
                        roombook = "Free";
                    
                    connstring.Open();

                    string query = "insert into RoomTbl values(" + roomnumb + ", '" + comboroomstatus.SelectedItem.ToString() + "', '" + roombook + "');";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();

                    connstring.Close();
                }
                catch
                {
                    //MessageBox.Show("Room Add Faild", "Something Wrong", 
                      //  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter the Room Number", "Room Number Empty", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillDataGridView();
            rbnotbooked.Checked = true;
            btnadd.Visible = false;
            btnnew.Visible = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String roomnumb = tbroomnum.Text;

            if (roomnumb != room_num)
            {
                MessageBox.Show("You can NOT change Room Number", "NOT Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (roomnumb.Length != 0)
            {
                try
                {                    
                    connstring.Open();

                    string query = "delete from RoomTbl where RoomNum = " + roomnumb + ";";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();

                    connstring.Close();
                }
                catch
                {
                    //MessageBox.Show("Room Delete Faild", "Something Wrong",
                      //  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("Enter the Room Number", "Room Number Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillDataGridView();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String roomnumb = tbroomnum.Text;
            String roombook;

            if (comboroomstatus.SelectedIndex < 0)
            {
                MessageBox.Show("Select Room Status", "Room Status NOT selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (roomnumb != room_num)
            {
                MessageBox.Show("You can NOT change Room Number", "NOT Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (roomnumb.Length != 0)
            {
                try
                {
                    if (rbyesbooked.Checked)
                        roombook = "Busy";
                    else
                        roombook = "Free";

                    connstring.Open();

                    string query = "update RoomTbl set RoomStatus = '" + comboroomstatus.SelectedItem.ToString() +
                        "', Booked = '" + roombook + "' where RoomNum = " + roomnumb + ";";
                    SqlCommand cmd = new SqlCommand(query, connstring);
                    cmd.ExecuteNonQuery();

                    connstring.Close();
                }
                catch
                {
                   // MessageBox.Show("Room Update Faild", "Something Wrong",
                     //   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter the Room Number", "Room Number Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillDataGridView();
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            comboroomstatus.SelectedIndex = 0;
            rbnotbooked.Checked = true;
            btnadd.Visible = false;
            btnnew.Visible = true;
        }

         private void RoomDGV_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        string room_num = "";
        private void RoomDGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbroomnum.Text = RoomDGV.CurrentRow.Cells[0].Value.ToString();
            room_num = tbroomnum.Text;
            
            if (RoomDGV.CurrentRow.Cells[1].Value.ToString() == "Active")
                comboroomstatus.SelectedIndex = 0;
            else
                comboroomstatus.SelectedIndex = 1;
            
            if (RoomDGV.CurrentRow.Cells[2].Value.ToString() == "Busy")
                rbyesbooked.Checked = true;
            else 
                rbnotbooked.Checked = true;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnnew.Visible = false;
            btnadd.Visible = true;
           tbroomnum.Text = "No.";
            rbnotbooked.Checked = true;
        }
    }
}
