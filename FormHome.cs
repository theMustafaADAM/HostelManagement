using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeForm myemp = new EmployeeForm();
            myemp.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SalaryFrm myslry = new SalaryFrm();
            myslry.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout of HM", "LogOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnrooms_Click(object sender, EventArgs e)
        {
            RoomsForm myroom = new RoomsForm();
            myroom.ShowDialog();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            StudentForm mystuden = new StudentForm();
            mystuden.ShowDialog();
        }

        private void btnfees_Click(object sender, EventArgs e)
        {
            FeeForm myfee = new FeeForm();
            myfee.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
