namespace StudentAttendanceMonitoring
{
    partial class AttendanceSave
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
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtidno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtstatus
            // 
            this.txtstatus.Enabled = false;
            this.txtstatus.Location = new System.Drawing.Point(294, 185);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(244, 23);
            this.txtstatus.TabIndex = 25;
            this.txtstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstatus.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(294, 87);
            this.txtlname.Name = "txtlname";
            this.txtlname.PlaceholderText = "Last Name";
            this.txtlname.Size = new System.Drawing.Size(244, 23);
            this.txtlname.TabIndex = 23;
            this.txtlname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(35, 185);
            this.txtmname.Name = "txtmname";
            this.txtmname.PlaceholderText = "Middle Name";
            this.txtmname.Size = new System.Drawing.Size(244, 23);
            this.txtmname.TabIndex = 22;
            this.txtmname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmname.TextChanged += new System.EventHandler(this.txtmname_TextChanged);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(35, 134);
            this.txtfname.Name = "txtfname";
            this.txtfname.PlaceholderText = "First Name";
            this.txtfname.Size = new System.Drawing.Size(244, 23);
            this.txtfname.TabIndex = 21;
            this.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtidno
            // 
            this.txtidno.Enabled = false;
            this.txtidno.Location = new System.Drawing.Point(35, 87);
            this.txtidno.Name = "txtidno";
            this.txtidno.PlaceholderText = "Student id No.";
            this.txtidno.Size = new System.Drawing.Size(244, 23);
            this.txtidno.TabIndex = 20;
            this.txtidno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtidno.TextChanged += new System.EventHandler(this.txtidno_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(294, 134);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(244, 23);
            this.dtpdate.TabIndex = 27;
            // 
            // AttendanceSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(573, 294);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtidno);
            this.Controls.Add(this.button1);
            this.Name = "AttendanceSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceSave";
            this.Load += new System.EventHandler(this.AttendanceSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        public TextBox txtstatus;
        public TextBox txtlname;
        public TextBox txtmname;
        public TextBox txtfname;
        public TextBox txtidno;
        public DateTimePicker dtpdate;
    }
}