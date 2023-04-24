
namespace HostelManagement
{
    partial class RoomsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnsubheader = new System.Windows.Forms.Panel();
            this.pnroomlist = new System.Windows.Forms.Panel();
            this.RoomDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnroomdata = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pntbroomnum = new System.Windows.Forms.Panel();
            this.tbroomnum = new System.Windows.Forms.TextBox();
            this.rbnotbooked = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboroomstatus = new System.Windows.Forms.ComboBox();
            this.rbyesbooked = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.phHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.pancombo = new System.Windows.Forms.Panel();
            this.pnsubheader.SuspendLayout();
            this.pnroomlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDGV)).BeginInit();
            this.pnroomdata.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pntbroomnum.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.phHeader.SuspendLayout();
            this.pancombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnsubheader
            // 
            this.pnsubheader.Controls.Add(this.pnroomlist);
            this.pnsubheader.Controls.Add(this.pnroomdata);
            this.pnsubheader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnsubheader.Location = new System.Drawing.Point(0, 70);
            this.pnsubheader.Name = "pnsubheader";
            this.pnsubheader.Size = new System.Drawing.Size(1000, 555);
            this.pnsubheader.TabIndex = 11;
            // 
            // pnroomlist
            // 
            this.pnroomlist.Controls.Add(this.RoomDGV);
            this.pnroomlist.Controls.Add(this.label1);
            this.pnroomlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnroomlist.Location = new System.Drawing.Point(350, 0);
            this.pnroomlist.Name = "pnroomlist";
            this.pnroomlist.Size = new System.Drawing.Size(650, 555);
            this.pnroomlist.TabIndex = 3;
            // 
            // RoomDGV
            // 
            this.RoomDGV.AllowUserToOrderColumns = true;
            this.RoomDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.RoomDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RoomDGV.ColumnHeadersHeight = 31;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.RoomDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomDGV.GridColor = System.Drawing.Color.Crimson;
            this.RoomDGV.Location = new System.Drawing.Point(0, 59);
            this.RoomDGV.Name = "RoomDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.RoomDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RoomDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RoomDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.RoomDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.RoomDGV.RowTemplate.Height = 31;
            this.RoomDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomDGV.Size = new System.Drawing.Size(650, 496);
            this.RoomDGV.TabIndex = 2;
            this.RoomDGV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomDGV_CellEnter);
            this.RoomDGV.SelectionChanged += new System.EventHandler(this.RoomDGV_SelectionChanged);
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
            this.label1.Text = "Rooms List";
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
            this.panel1.Controls.Add(this.pancombo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pntbroomnum);
            this.panel1.Controls.Add(this.rbnotbooked);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbyesbooked);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 555);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 59);
            this.label4.TabIndex = 12;
            this.label4.Text = "Room";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pntbroomnum
            // 
            this.pntbroomnum.BackColor = System.Drawing.Color.Crimson;
            this.pntbroomnum.Controls.Add(this.tbroomnum);
            this.pntbroomnum.Location = new System.Drawing.Point(35, 60);
            this.pntbroomnum.Name = "pntbroomnum";
            this.pntbroomnum.Size = new System.Drawing.Size(280, 33);
            this.pntbroomnum.TabIndex = 5;
            // 
            // tbroomnum
            // 
            this.tbroomnum.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbroomnum.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbroomnum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbroomnum.Location = new System.Drawing.Point(0, 0);
            this.tbroomnum.Name = "tbroomnum";
            this.tbroomnum.Size = new System.Drawing.Size(280, 31);
            this.tbroomnum.TabIndex = 4;
            this.tbroomnum.Text = "Room Number";
            // 
            // rbnotbooked
            // 
            this.rbnotbooked.AutoSize = true;
            this.rbnotbooked.Checked = true;
            this.rbnotbooked.Font = new System.Drawing.Font("Montserrat Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnotbooked.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbnotbooked.Location = new System.Drawing.Point(159, 218);
            this.rbnotbooked.Name = "rbnotbooked";
            this.rbnotbooked.Size = new System.Drawing.Size(71, 30);
            this.rbnotbooked.TabIndex = 11;
            this.rbnotbooked.TabStop = true;
            this.rbnotbooked.Text = "Free";
            this.rbnotbooked.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rooms Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboroomstatus
            // 
            this.comboroomstatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboroomstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboroomstatus.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboroomstatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboroomstatus.Items.AddRange(new object[] {
            "Active",
            "Not-Active"});
            this.comboroomstatus.Location = new System.Drawing.Point(0, 0);
            this.comboroomstatus.Name = "comboroomstatus";
            this.comboroomstatus.Size = new System.Drawing.Size(280, 34);
            this.comboroomstatus.TabIndex = 7;
            // 
            // rbyesbooked
            // 
            this.rbyesbooked.AutoSize = true;
            this.rbyesbooked.Font = new System.Drawing.Font("Montserrat Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbyesbooked.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbyesbooked.Location = new System.Drawing.Point(235, 218);
            this.rbyesbooked.Name = "rbyesbooked";
            this.rbyesbooked.Size = new System.Drawing.Size(76, 30);
            this.rbyesbooked.TabIndex = 9;
            this.rbyesbooked.Text = "Busy";
            this.rbyesbooked.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(35, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Booked";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Crimson;
            this.pnBottom.Controls.Add(this.lblBottom);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 625);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1000, 45);
            this.pnBottom.TabIndex = 12;
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
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Alexandria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1000, 70);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "ROOMS SCREEN";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.phHeader.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 7);
            this.panel2.TabIndex = 3;
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
            // pancombo
            // 
            this.pancombo.BackColor = System.Drawing.Color.Crimson;
            this.pancombo.Controls.Add(this.comboroomstatus);
            this.pancombo.Location = new System.Drawing.Point(35, 157);
            this.pancombo.Name = "pancombo";
            this.pancombo.Size = new System.Drawing.Size(280, 36);
            this.pancombo.TabIndex = 16;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.pnsubheader);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.phHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            this.pnsubheader.ResumeLayout(false);
            this.pnroomlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomDGV)).EndInit();
            this.pnroomdata.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pntbroomnum.ResumeLayout(false);
            this.pntbroomnum.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.phHeader.ResumeLayout(false);
            this.phHeader.PerformLayout();
            this.pancombo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnsubheader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnroomdata;
        private System.Windows.Forms.RadioButton rbyesbooked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboroomstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pntbroomnum;
        private System.Windows.Forms.TextBox tbroomnum;
        private System.Windows.Forms.Panel pnroomlist;
        private System.Windows.Forms.DataGridView RoomDGV;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.RadioButton rbnotbooked;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel phHeader;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel pancombo;
    }
}