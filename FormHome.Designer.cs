
namespace HostelManagement
{
    partial class FormHome
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
            this.phHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.pnSections = new System.Windows.Forms.Panel();
            this.btnrooms = new System.Windows.Forms.Button();
            this.btnsalary = new System.Windows.Forms.Button();
            this.btnstudents = new System.Windows.Forms.Button();
            this.btnfees = new System.Windows.Forms.Button();
            this.btnemployees = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.lblBottom = new System.Windows.Forms.Label();
            this.pnsubheader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.phHeader.SuspendLayout();
            this.pnSections.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.pnsubheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // phHeader
            // 
            this.phHeader.BackColor = System.Drawing.Color.Crimson;
            this.phHeader.Controls.Add(this.lblExit);
            this.phHeader.Controls.Add(this.lblHeader);
            this.phHeader.Controls.Add(this.panel2);
            this.phHeader.Controls.Add(this.pnSections);
            this.phHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.phHeader.Location = new System.Drawing.Point(0, 0);
            this.phHeader.Name = "phHeader";
            this.phHeader.Size = new System.Drawing.Size(1000, 136);
            this.phHeader.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 3);
            this.panel2.TabIndex = 2;
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
            this.lblExit.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnSections
            // 
            this.pnSections.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnSections.Controls.Add(this.btnrooms);
            this.pnSections.Controls.Add(this.btnsalary);
            this.pnSections.Controls.Add(this.btnstudents);
            this.pnSections.Controls.Add(this.btnfees);
            this.pnSections.Controls.Add(this.btnemployees);
            this.pnSections.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSections.Location = new System.Drawing.Point(0, 76);
            this.pnSections.Name = "pnSections";
            this.pnSections.Size = new System.Drawing.Size(1000, 60);
            this.pnSections.TabIndex = 8;
            // 
            // btnrooms
            // 
            this.btnrooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrooms.BackColor = System.Drawing.Color.DimGray;
            this.btnrooms.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnrooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrooms.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrooms.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnrooms.Location = new System.Drawing.Point(12, 8);
            this.btnrooms.Name = "btnrooms";
            this.btnrooms.Size = new System.Drawing.Size(175, 45);
            this.btnrooms.TabIndex = 3;
            this.btnrooms.Text = "ROOMS";
            this.btnrooms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrooms.UseVisualStyleBackColor = false;
            this.btnrooms.Click += new System.EventHandler(this.btnrooms_Click);
            // 
            // btnsalary
            // 
            this.btnsalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalary.BackColor = System.Drawing.Color.DimGray;
            this.btnsalary.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnsalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalary.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalary.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnsalary.Location = new System.Drawing.Point(736, 8);
            this.btnsalary.Name = "btnsalary";
            this.btnsalary.Size = new System.Drawing.Size(175, 45);
            this.btnsalary.TabIndex = 7;
            this.btnsalary.Text = "SALARY";
            this.btnsalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalary.UseVisualStyleBackColor = false;
            this.btnsalary.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnstudents
            // 
            this.btnstudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnstudents.BackColor = System.Drawing.Color.DimGray;
            this.btnstudents.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnstudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstudents.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudents.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnstudents.Location = new System.Drawing.Point(193, 8);
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.Size = new System.Drawing.Size(175, 45);
            this.btnstudents.TabIndex = 4;
            this.btnstudents.Text = "STUDENTS";
            this.btnstudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnstudents.UseVisualStyleBackColor = false;
            this.btnstudents.Click += new System.EventHandler(this.btnstudents_Click);
            // 
            // btnfees
            // 
            this.btnfees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfees.BackColor = System.Drawing.Color.DimGray;
            this.btnfees.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnfees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfees.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfees.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnfees.Location = new System.Drawing.Point(555, 8);
            this.btnfees.Name = "btnfees";
            this.btnfees.Size = new System.Drawing.Size(175, 45);
            this.btnfees.TabIndex = 6;
            this.btnfees.Text = "FEES";
            this.btnfees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnfees.UseVisualStyleBackColor = false;
            this.btnfees.Click += new System.EventHandler(this.btnfees_Click);
            // 
            // btnemployees
            // 
            this.btnemployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnemployees.BackColor = System.Drawing.Color.DimGray;
            this.btnemployees.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnemployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemployees.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployees.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnemployees.Location = new System.Drawing.Point(374, 8);
            this.btnemployees.Name = "btnemployees";
            this.btnemployees.Size = new System.Drawing.Size(175, 45);
            this.btnemployees.TabIndex = 5;
            this.btnemployees.Text = "EMPLOYEES";
            this.btnemployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnemployees.UseVisualStyleBackColor = false;
            this.btnemployees.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("PMingLiU-ExtB", 24F);
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1000, 73);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "HOSTEL MANAGEMENT SYSTEM";
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
            this.pnBottom.TabIndex = 2;
            // 
            // lblBottom
            // 
            this.lblBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBottom.Font = new System.Drawing.Font("Poiret One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBottom.Location = new System.Drawing.Point(0, 0);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(1000, 45);
            this.lblBottom.TabIndex = 0;
            this.lblBottom.Text = "Powered By : MustafaADAM.com          ";
            this.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnsubheader
            // 
            this.pnsubheader.Controls.Add(this.pictureBox1);
            this.pnsubheader.Controls.Add(this.label1);
            this.pnsubheader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnsubheader.Location = new System.Drawing.Point(0, 139);
            this.pnsubheader.Name = "pnsubheader";
            this.pnsubheader.Size = new System.Drawing.Size(1000, 486);
            this.pnsubheader.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HostelManagement.Properties.Resources.stHostel22;
            this.pictureBox1.Location = new System.Drawing.Point(368, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 486);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcom\r\nto\r\nSTUDENTS\r\nHOSTEL\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 3);
            this.panel3.TabIndex = 9;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.pnsubheader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.phHeader);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.phHeader.ResumeLayout(false);
            this.phHeader.PerformLayout();
            this.pnSections.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.pnsubheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel phHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Button btnrooms;
        private System.Windows.Forms.Button btnstudents;
        private System.Windows.Forms.Button btnemployees;
        private System.Windows.Forms.Button btnfees;
        private System.Windows.Forms.Button btnsalary;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel pnSections;
        private System.Windows.Forms.Panel pnsubheader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

