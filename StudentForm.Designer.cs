
namespace HostelManagement
{
    partial class StudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.phHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.lblBottom = new System.Windows.Forms.Label();
            this.pnsubheader = new System.Windows.Forms.Panel();
            this.pnroomlist = new System.Windows.Forms.Panel();
            this.StudentDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnroomdata = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbstudleft = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbstudliving = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboroomnum = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbcollege = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbmothername = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbfathername = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbstudname = new System.Windows.Forms.TextBox();
            this.pntbroomnum = new System.Windows.Forms.Panel();
            this.tbstudntusn = new System.Windows.Forms.TextBox();
            this.pncombo = new System.Windows.Forms.Panel();
            this.phHeader.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.pnsubheader.SuspendLayout();
            this.pnroomlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).BeginInit();
            this.pnroomdata.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pntbroomnum.SuspendLayout();
            this.pncombo.SuspendLayout();
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
            this.phHeader.TabIndex = 2;
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
            this.lblHeader.Text = "STUDENT SCREEN";
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
            this.pnBottom.TabIndex = 3;
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
            this.pnsubheader.TabIndex = 12;
            // 
            // pnroomlist
            // 
            this.pnroomlist.Controls.Add(this.StudentDGV);
            this.pnroomlist.Controls.Add(this.label1);
            this.pnroomlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnroomlist.Location = new System.Drawing.Point(350, 0);
            this.pnroomlist.Name = "pnroomlist";
            this.pnroomlist.Size = new System.Drawing.Size(650, 555);
            this.pnroomlist.TabIndex = 3;
            // 
            // StudentDGV
            // 
            this.StudentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.StudentDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StudentDGV.ColumnHeadersHeight = 31;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 14.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.StudentDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentDGV.GridColor = System.Drawing.Color.Crimson;
            this.StudentDGV.Location = new System.Drawing.Point(0, 59);
            this.StudentDGV.Name = "StudentDGV";
            this.StudentDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.StudentDGV.RowTemplate.Height = 31;
            this.StudentDGV.Size = new System.Drawing.Size(650, 496);
            this.StudentDGV.TabIndex = 2;
            this.StudentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDGV_CellContentClick);
            this.StudentDGV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDGV_CellEnter);
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
            this.label1.Text = "Students List";
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
            this.btnnew.TabIndex = 0;
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
            this.btnupdate.TabIndex = 11;
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
            this.btndelete.TabIndex = 12;
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
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "ADD";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pncombo);
            this.panel1.Controls.Add(this.rbstudleft);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbstudliving);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pntbroomnum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 555);
            this.panel1.TabIndex = 12;
            // 
            // rbstudleft
            // 
            this.rbstudleft.AutoSize = true;
            this.rbstudleft.Font = new System.Drawing.Font("Montserrat Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbstudleft.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbstudleft.Location = new System.Drawing.Point(247, 353);
            this.rbstudleft.Name = "rbstudleft";
            this.rbstudleft.Size = new System.Drawing.Size(65, 30);
            this.rbstudleft.TabIndex = 9;
            this.rbstudleft.Text = "Left";
            this.rbstudleft.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(35, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbstudliving
            // 
            this.rbstudliving.AutoSize = true;
            this.rbstudliving.Checked = true;
            this.rbstudliving.Font = new System.Drawing.Font("Montserrat Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbstudliving.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbstudliving.Location = new System.Drawing.Point(154, 353);
            this.rbstudliving.Name = "rbstudliving";
            this.rbstudliving.Size = new System.Drawing.Size(87, 30);
            this.rbstudliving.TabIndex = 8;
            this.rbstudliving.TabStop = true;
            this.rbstudliving.Text = "Living";
            this.rbstudliving.UseVisualStyleBackColor = true;
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
            this.label4.Text = "Student";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboroomnum
            // 
            this.comboroomnum.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboroomnum.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboroomnum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboroomnum.FormattingEnabled = true;
            this.comboroomnum.Location = new System.Drawing.Point(0, 0);
            this.comboroomnum.Name = "comboroomnum";
            this.comboroomnum.Size = new System.Drawing.Size(137, 34);
            this.comboroomnum.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Crimson;
            this.panel8.Controls.Add(this.tbcollege);
            this.panel8.Location = new System.Drawing.Point(35, 265);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 33);
            this.panel8.TabIndex = 10;
            // 
            // tbcollege
            // 
            this.tbcollege.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcollege.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcollege.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbcollege.Location = new System.Drawing.Point(0, 0);
            this.tbcollege.Name = "tbcollege";
            this.tbcollege.Size = new System.Drawing.Size(280, 31);
            this.tbcollege.TabIndex = 6;
            this.tbcollege.Text = "Student College";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(35, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Room Num.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Crimson;
            this.panel7.Controls.Add(this.tbaddress);
            this.panel7.Location = new System.Drawing.Point(35, 224);
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
            this.tbaddress.TabIndex = 5;
            this.tbaddress.Text = "Student Address";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Crimson;
            this.panel6.Controls.Add(this.tbmothername);
            this.panel6.Location = new System.Drawing.Point(35, 183);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 33);
            this.panel6.TabIndex = 8;
            // 
            // tbmothername
            // 
            this.tbmothername.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbmothername.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmothername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbmothername.Location = new System.Drawing.Point(0, 0);
            this.tbmothername.Name = "tbmothername";
            this.tbmothername.Size = new System.Drawing.Size(280, 31);
            this.tbmothername.TabIndex = 4;
            this.tbmothername.Text = "Mother Name";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Controls.Add(this.tbfathername);
            this.panel5.Location = new System.Drawing.Point(35, 142);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 33);
            this.panel5.TabIndex = 7;
            // 
            // tbfathername
            // 
            this.tbfathername.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbfathername.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfathername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbfathername.Location = new System.Drawing.Point(0, 0);
            this.tbfathername.Name = "tbfathername";
            this.tbfathername.Size = new System.Drawing.Size(280, 31);
            this.tbfathername.TabIndex = 3;
            this.tbfathername.Text = "Father Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Controls.Add(this.tbstudname);
            this.panel4.Location = new System.Drawing.Point(35, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 33);
            this.panel4.TabIndex = 6;
            // 
            // tbstudname
            // 
            this.tbstudname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbstudname.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbstudname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbstudname.Location = new System.Drawing.Point(0, 0);
            this.tbstudname.Name = "tbstudname";
            this.tbstudname.Size = new System.Drawing.Size(280, 31);
            this.tbstudname.TabIndex = 2;
            this.tbstudname.Text = "Student Name";
            // 
            // pntbroomnum
            // 
            this.pntbroomnum.BackColor = System.Drawing.Color.Crimson;
            this.pntbroomnum.Controls.Add(this.tbstudntusn);
            this.pntbroomnum.Location = new System.Drawing.Point(35, 60);
            this.pntbroomnum.Name = "pntbroomnum";
            this.pntbroomnum.Size = new System.Drawing.Size(280, 33);
            this.pntbroomnum.TabIndex = 5;
            // 
            // tbstudntusn
            // 
            this.tbstudntusn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbstudntusn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbstudntusn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbstudntusn.Location = new System.Drawing.Point(0, 0);
            this.tbstudntusn.Name = "tbstudntusn";
            this.tbstudntusn.Size = new System.Drawing.Size(280, 31);
            this.tbstudntusn.TabIndex = 1;
            this.tbstudntusn.Text = "Student USN";
            // 
            // pncombo
            // 
            this.pncombo.BackColor = System.Drawing.Color.Crimson;
            this.pncombo.Controls.Add(this.comboroomnum);
            this.pncombo.Location = new System.Drawing.Point(178, 308);
            this.pncombo.Name = "pncombo";
            this.pncombo.Size = new System.Drawing.Size(137, 36);
            this.pncombo.TabIndex = 16;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.pnsubheader);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.phHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.phHeader.ResumeLayout(false);
            this.phHeader.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.pnsubheader.ResumeLayout(false);
            this.pnroomlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).EndInit();
            this.pnroomdata.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pntbroomnum.ResumeLayout(false);
            this.pntbroomnum.PerformLayout();
            this.pncombo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel phHeader;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Panel pntbroomnum;
        private System.Windows.Forms.TextBox tbstudntusn;
        private System.Windows.Forms.ComboBox comboroomnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnroomlist;
        private System.Windows.Forms.DataGridView StudentDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbstudleft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbstudliving;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbcollege;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbmothername;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbfathername;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbstudname;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel pncombo;
    }
}