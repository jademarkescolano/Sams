namespace StudentAttendanceMonitoring
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(388, 479);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 34);
            this.button9.TabIndex = 34;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(936, 346);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 32);
            this.btnrefresh.TabIndex = 33;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(664, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Total Students";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(855, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 31;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(629, 352);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(220, 23);
            this.txtsearch.TabIndex = 30;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.White;
            this.lblcount.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.lblcount.Location = new System.Drawing.Point(691, 427);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(107, 86);
            this.lblcount.TabIndex = 29;
            this.lblcount.Text = "00";
            this.lblcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcount.Click += new System.EventHandler(this.lblcount_Click);
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(300, 450);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.PlaceholderText = "Contact No.";
            this.txtcontact.Size = new System.Drawing.Size(244, 23);
            this.txtcontact.TabIndex = 28;
            this.txtcontact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(300, 381);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PlaceholderText = "Address";
            this.txtaddress.Size = new System.Drawing.Size(244, 63);
            this.txtaddress.TabIndex = 27;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(300, 352);
            this.txtlname.Name = "txtlname";
            this.txtlname.PlaceholderText = "Last Name";
            this.txtlname.Size = new System.Drawing.Size(244, 23);
            this.txtlname.TabIndex = 26;
            this.txtlname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(41, 450);
            this.txtmname.Name = "txtmname";
            this.txtmname.PlaceholderText = "Middle Name";
            this.txtmname.Size = new System.Drawing.Size(244, 23);
            this.txtmname.TabIndex = 25;
            this.txtmname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(41, 399);
            this.txtfname.Name = "txtfname";
            this.txtfname.PlaceholderText = "First Name";
            this.txtfname.Size = new System.Drawing.Size(244, 23);
            this.txtfname.TabIndex = 24;
            this.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtidno
            // 
            this.txtidno.Enabled = false;
            this.txtidno.Location = new System.Drawing.Point(41, 352);
            this.txtidno.Name = "txtidno";
            this.txtidno.PlaceholderText = "Student id No.";
            this.txtidno.Size = new System.Drawing.Size(244, 23);
            this.txtidno.TabIndex = 23;
            this.txtidno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(855, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 22;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(936, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
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
            this.DgvList.Location = new System.Drawing.Point(12, 27);
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            this.DgvList.RowHeadersVisible = false;
            this.DgvList.RowTemplate.Height = 25;
            this.DgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvList.Size = new System.Drawing.Size(999, 303);
            this.DgvList.TabIndex = 19;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtidno);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvList);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1023, 541);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button9;
        private Button btnrefresh;
        private Label label2;
        private Button button4;
        private TextBox txtsearch;
        private Label lblcount;
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
    }
}
