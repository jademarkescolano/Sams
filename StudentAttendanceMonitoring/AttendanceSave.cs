using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceMonitoring
{
    public partial class AttendanceSave : Form
    {
        public AttendanceSave()
        {
            InitializeComponent();
        }

        private void AttendanceSave_Load(object sender, EventArgs e)
        {
           // this.dtp.Value = DateTime.Now;
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            using (var con = new SQLiteConnection($@"data source =  C:\Users\Xlayer\Downloads\StudentAttendanceMonitoringFinal\StudentAttendanceMonitoring.db"))
            {
                try
                {
                    con.Open();
                    var com = new SQLiteCommand($"INSERT INTO AttendanceRecord (StudentID,FirstName,MiddleName,LastName,Date,Status ) VALUES " +
                        "(@id,@fname,@mname,@lname,@date,@status)", con)



                    {
                        CommandType = CommandType.Text
                    };

                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@id", txtidno.Text);
                    com.Parameters.AddWithValue("@fname", txtfname.Text);
                    com.Parameters.AddWithValue("@mname", txtmname.Text);
                    com.Parameters.AddWithValue("@lname", txtlname.Text);
                    com.Parameters.AddWithValue("@date", dtpdate.Value.ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@status", txtstatus.Text);


                    i = com.ExecuteNonQuery();
                    con.Close();

                    if (i >= 1)
                    {
                       
                        MessageBox.Show("Successfully Save!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Transaction Cancelled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                           
                    }
                }
                catch (Exception ex)
                {

                    //throw;
                }
            }
        }
        }
    }

