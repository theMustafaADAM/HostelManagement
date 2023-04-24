
namespace HostelManagement
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.phHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.lblBottom = new System.Windows.Forms.Label();
            this.pnsubheader = new System.Windows.Forms.Panel();
            this.pnroomlist = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnroomdata = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboposition = new System.Windows.Forms.ComboBox();
            this.rbempleft = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbempworking = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbempname = new System.Windows.Forms.TextBox();
            this.pntbroomnum = new System.Windows.Forms.Panel();
            this.tbempid = new System.Windows.Forms.TextBox();
            this.phHeader.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.pnsubheader.SuspendLayout();
            this.pnroomlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnroomdata.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pntbroomnum.SuspendLayout();
            this.SuspendLayout();
            // 
            // phHeader
            // 
            this.phHeader.BackColor = System.Drawing.Color.Crimson;
            this.phHeader.Controls.Add(this.panel2);
            this.phHeader.Controls.Add(this.lblExit);
            this.phHeader.Controls.Add(this.lblHeader);
            this.phHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.phHeader.Location = new System.Drawing.Point(0, 0);
            this.phHeader.Name = "phHeader";
            this.phHeader.Size = new System.Drawing.Size(1000, 70);
            this.phHeader.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 7);
            this.panel2.TabIndex = 4;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Montserrat Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblExit.Location = new System.Drawing.Point(952, 3);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(45, 46);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Alexandria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1000, 70);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "EMPLOYEE SCREEN";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Crimson;
            this.pnBottom.Controls.Add(this.lblBottom);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 625);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1000, 45);
            this.pnBottom.TabIndex = 4;
            // 
            // lblBottom
            // 
            this.lblBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBottom.Font = new System.Drawing.Font("Poiret One", 9.749999F);
            this.lblBottom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBottom.Location = new System.Drawing.Point(0, 0);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(1000, 45);
            this.lblBottom.TabIndex = 0;
            this.lblBottom.Text = "Powered By : MustafaADAM.com";
            this.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnsubheader
            // 
            this.pnsubheader.Controls.Add(this.pnroomlist);
            this.pnsubheader.Controls.Add(this.pnroomdata);
            this.pnsubheader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnsubheader.Location = new System.Drawing.Point(0, 70);
            this.pnsubheader.Name = "pnsubheader";
            this.pnsubheader.Size = new System.Drawing.Size(1000, 555);
            this.pnsubheader.TabIndex = 13;
            // 
            // pnroomlist
            // 
            this.pnroomlist.Controls.Add(this.dataGridView1);
            this.pnroomlist.Controls.Add(this.label1);
            this.pnroomlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnroomlist.Location = new System.Drawing.Point(350, 0);
            this.pnroomlist.Name = "pnroomlist";
            this.pnroomlist.Size = new System.Drawing.Size(650, 555);
            this.pnroomlist.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 31;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Crimson;
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(650, 496);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnroomdata
            // 
            this.pnroomdata.Controls.Add(this.panel3);
            this.pnroomdata.Controls.Add(this.panel1);
            this.pnroomdata.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnroomdata.Location = new System.Drawing.Point(0, 0);
            this.pnroomdata.Name = "pnroomdata";
            this.pnroomdata.Size = new System.Drawing.Size(350, 555);
            this.pnroomdata.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Controls.Add(this.btnnew);
            this.panel3.Controls.Add(this.btnback);
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Controls.Add(this.btndelete);
            this.panel3.Controls.Add(this.btnadd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 455);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 100);
            this.panel3.TabIndex = 13;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Montserrat Thin", 11.25F);
            this.btnnew.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnnew.Location = new System.Drawing.Point(47, 13);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(125, 34);
            this.btnnew.TabIndex = 8;
            this.btnnew.Text = "NEW";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnback.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Montserrat Thin", 11.25F);
            this.btnback.ForeColor = System.Drawing.Color.Crimson;
            this.btnback.Location = new System.Drawing.Point(178, 53);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(125, 34);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "BACK";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Montserrat Thin", 11.25F);
            this.btnupdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.Location = new System.Drawing.Point(178, 13);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(125, 34);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Montserrat Thin", 11.25F);
            this.btndelete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btndelete.Location = new System.Drawing.Point(47, 53);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(125, 34);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "DELETE";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Montserrat Thin", 11.25F);
            this.btnadd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.Location = new System.Drawing.Point(47, 13);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(125, 34);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "ADD";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.rbempleft);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbempworking);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pntbroomnum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 555);
            this.panel1.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Crimson;
            this.panel6.Controls.Add(this.comboposition);
            this.panel6.Location = new System.Drawing.Point(136, 277);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(179, 36);
            this.panel6.TabIndex = 15;
            // 
            // comboposition
            // 
            this.comboposition.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboposition.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboposition.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboposition.FormattingEnabled = true;
            this.comboposition.Items.AddRange(new object[] {
            "Mess Staff",
            "Accountant",
            "Cleaner",
            "Manager"});
            this.comboposition.Location = new System.Drawing.Point(0, 0);
            this.comboposition.Name = "comboposition";
            this.comboposition.Size = new System.Drawing.Size(179, 34);
            this.comboposition.TabIndex = 7;
            // 
            // rbempleft
            // 
            this.rbempleft.AutoSize = true;
            this.rbempleft.Font = new System.Drawing.Font("Montserrat Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbempleft.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbempleft.Location = new System.Drawing.Point(247, 333);
            this.rbempleft.Name = "rbempleft";
            this.rbempleft.Size = new System.Drawing.Size(65, 30);
            this.rbempleft.TabIndex = 11;
            this.rbempleft.Text = "Left";
            this.rbempleft.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(35, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbempworking
            // 
            this.rbempworking.AutoSize = true;
            this.rbempworking.Checked = true;
            this.rbempworking.Font = new System.Drawing.Font("Montserrat Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbempworking.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbempworking.Location = new System.Drawing.Point(140, 333);
            this.rbempworking.Name = "rbempworking";
            this.rbempworking.Size = new System.Drawing.Size(111, 30);
            this.rbempworking.TabIndex = 9;
            this.rbempworking.TabStop = true;
            this.rbempworking.Text = "Working";
            this.rbempworking.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 59);
            this.label4.TabIndex = 12;
            this.label4.Text = "Employee";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(35, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Position";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Crimson;
            this.panel7.Controls.Add(this.tbaddress);
            this.panel7.Location = new System.Drawing.Point(35, 225);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 33);
            this.panel7.TabIndex = 9;
            // 
            // tbaddress
            // 
            this.tbaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbaddress.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaddress.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbaddress.Location = new System.Drawing.Point(0, 0);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(280, 31);
            this.tbaddress.TabIndex = 4;
            this.tbaddress.Text = "Address";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Controls.Add(this.tbphone);
            this.panel5.Location = new System.Drawing.Point(35, 170);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 33);
            this.panel5.TabIndex = 7;
            // 
            // tbphone
            // 
            this.tbphone.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbphone.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbphone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbphone.Location = new System.Drawing.Point(0, 0);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(280, 31);
            this.tbphone.TabIndex = 4;
            this.tbphone.Text = "Phone";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Controls.Add(this.tbempname);
            this.panel4.Location = new System.Drawing.Point(35, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 33);
            this.panel4.TabIndex = 6;
            // 
            // tbempname
            // 
            this.tbempname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbempname.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbempname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbempname.Location = new System.Drawing.Point(0, 0);
            this.tbempname.Name = "tbempname";
            this.tbempname.Size = new System.Drawing.Size(280, 31);
            this.tbempname.TabIndex = 4;
            this.tbempname.Text = "Employee Name";
            // 
            // pntbroomnum
            // 
            this.pntbroomnum.BackColor = System.Drawing.Color.Crimson;
            this.pntbroomnum.Controls.Add(this.tbempid);
            this.pntbroomnum.Location = new System.Drawing.Point(35, 60);
            this.pntbroomnum.Name = "pntbroomnum";
            this.pntbroomnum.Size = new System.Drawing.Size(280, 33);
            this.pntbroomnum.TabIndex = 5;
            // 
            // tbempid
            // 
            this.tbempid.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbempid.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbempid.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbempid.Location = new System.Drawing.Point(0, 0);
            this.tbempid.Name = "tbempid";
            this.tbempid.Size = new System.Drawing.Size(280, 31);
            this.tbempid.TabIndex = 4;
            this.tbempid.Text = "Employee ID";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.pnsubheader);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.phHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.phHeader.ResumeLayout(false);
            this.phHeader.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.pnsubheader.ResumeLayout(false);
            this.pnroomlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnroomdata.ResumeLayout(false);
            this.pnroomdata.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pntbroomnum.ResumeLayout(false);
            this.pntbroomnum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel phHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Panel pnsubheader;
        private System.Windows.Forms.Panel pnroomdata;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbempleft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbempworking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboposition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbempname;
        private System.Windows.Forms.Panel pntbroomnum;
        private System.Windows.Forms.TextBox tbempid;
        private System.Windows.Forms.Panel pnroomlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel panel6;
    }
}