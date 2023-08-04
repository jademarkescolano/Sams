namespace StudentAttendanceMonitoring
{
    partial class Mainform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnstudlist = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblcount = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtidno = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnstudlist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 124);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentAttendanceMonitoring.Properties.Resources.istockphoto_1167651240_612x612_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(438, 40);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 44);
            this.button7.TabIndex = 2;
            this.button7.Text = "ATTENDANCE CHECK";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(619, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 44);
            this.button6.TabIndex = 1;
            this.button6.Text = "ATTENDANCE RECORD";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnstudlist
            // 
            this.btnstudlist.Location = new System.Drawing.Point(258, 40);
            this.btnstudlist.Name = "btnstudlist";
            this.btnstudlist.Size = new System.Drawing.Size(156, 44);
            this.btnstudlist.TabIndex = 0;
            this.btnstudlist.Text = "STUDENT LIST";
            this.btnstudlist.UseVisualStyleBackColor = true;
            this.btnstudlist.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.btnrefresh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.lblcount);
            this.panel2.Controls.Add(this.txtcontact);
            this.panel2.Controls.Add(this.txtaddress);
            this.panel2.Controls.Add(this.txtlname);
            this.panel2.Controls.Add(this.txtmname);
            this.panel2.Controls.Add(this.txtfname);
            this.panel2.Controls.Add(this.txtidno);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.DgvList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 541);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(388, 469);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 34);
            this.button9.TabIndex = 18;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(936, 336);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 32);
            this.btnrefresh.TabIndex = 17;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Visible = false;
            this.btnrefresh.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(664, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Students";
            this.label2.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(855, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 15;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(629, 342);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(220, 23);
            this.txtsearch.TabIndex = 14;
            this.txtsearch.Visible = false;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.White;
            this.lblcount.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.lblcount.Location = new System.Drawing.Point(691, 417);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(107, 86);
            this.lblcount.TabIndex = 11;
            this.lblcount.Text = "00";
            this.lblcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcount.Visible = false;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(300, 440);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.PlaceholderText = "Contact No.";
            this.txtcontact.Size = new System.Drawing.Size(244, 23);
            this.txtcontact.TabIndex = 10;
            this.txtcontact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcontact.Visible = false;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(300, 371);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PlaceholderText = "Address";
            this.txtaddress.Size = new System.Drawing.Size(244, 63);
            this.txtaddress.TabIndex = 9;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtaddress.Visible = false;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(300, 342);
            this.txtlname.Name = "txtlname";
            this.txtlname.PlaceholderText = "Last Name";
            this.txtlname.Size = new System.Drawing.Size(244, 23);
            this.txtlname.TabIndex = 8;
            this.txtlname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtlname.Visible = false;
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(41, 440);
            this.txtmname.Name = "txtmname";
            this.txtmname.PlaceholderText = "Middle Name";
            this.txtmname.Size = new System.Drawing.Size(244, 23);
            this.txtmname.TabIndex = 7;
            this.txtmname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmname.Visible = false;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(41, 389);
            this.txtfname.Name = "txtfname";
            this.txtfname.PlaceholderText = "First Name";
            this.txtfname.Size = new System.Drawing.Size(244, 23);
            this.txtfname.TabIndex = 6;
            this.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfname.Visible = false;
            // 
            // txtidno
            // 
            this.txtidno.Enabled = false;
            this.txtidno.Location = new System.Drawing.Point(41, 342);
            this.txtidno.Name = "txtidno";
            this.txtidno.PlaceholderText = "Student id No.";
            this.txtidno.Size = new System.Drawing.Size(244, 23);
            this.txtidno.TabIndex = 5;
            this.txtidno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtidno.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(855, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(936, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgvList
            // 
            this.DgvList.AllowUserToAddRows = false;
            this.DgvList.AllowUserToDeleteRows = false;
            this.DgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvList.BackgroundColor = System.Drawing.Color.White;
            this.DgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.Location = new System.Drawing.Point(12, 17);
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            this.DgvList.RowTemplate.Height = 25;
            this.DgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvList.Size = new System.Drawing.Size(999, 303);
            this.DgvList.TabIndex = 0;
            this.DgvList.Visible = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtcontact;
        private TextBox txtaddress;
        private TextBox txtlname;
        private TextBox txtmname;
        private TextBox txtfname;
        private TextBox txtidno;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView DgvList;
        private Label label2;
        private Button button4;
        private TextBox txtsearch;
        private Label lblcount;
        private Button button7;
        private Button button6;
        private Button btnstudlist;
        private Button btnrefresh;
        private Button button9;
        private PictureBox pictureBox1;
    }
}