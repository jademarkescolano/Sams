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
    public partial class AttendanceRecord : UserControl
    {

        private readonly Form _f = Application.OpenForms["Mainform"];

        private static AttendanceRecord _instance;
        public static AttendanceRecord Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AttendanceRecord();
                return _instance;

            }
        }
        public AttendanceRecord()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AttendanceRecord_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvAttendanceList.DataSource = null;
            var lst = new List<AttendanceRecordList>();

            using (var con = new SQLiteConnection($@"data source =  C:\Users\Administrator\Documents\Database\StudentAttendanceMonitoring.db"))
            {
                try
                {
                    con.Open();
                    var com = new SQLiteCommand("SELECT * FROM AttendanceRecord", con)
                    {
                        CommandType = CommandType.Text
                    };

                    var rdr = (SQLiteDataReader)com.ExecuteReader();
                    while (rdr.Read())
                    {
                        lst.Add(new AttendanceRecordList
                        {

                            StudentID = Convert.ToInt32(rdr["StudentID"]),
                            FirstName = rdr["FirstName"].ToString(),
                            MiddleName = rdr["MiddleName"].ToString(),
                            LastName = rdr["LastName"].ToString(),
                            Date = Convert.ToDateTime(rdr["Date"]),
                            Status = rdr["Status"].ToString(),


                        });

                    }


                    dgvAttendanceList.DataSource = lst;

                    con.Close();
                }
                catch (Exception ex)
                {

                    //   throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Do You Want To Delete This Record?", "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {

                int i = 0;
                using (var con = new SQLiteConnection($@"data source =  C:\Users\Administrator\Documents\Database\StudentAttendanceMonitoring.db"))
                {
                    try
                    {
                        con.Open();
                        var com = new SQLiteCommand($"DELETE FROM AttendanceRecord WHERE StudentID = @id ", con)



                        {
                            CommandType = CommandType.Text
                        };

                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@id", dgvAttendanceList[0, dgvAttendanceList.CurrentRow.Index].Value.ToString());


                        i = com.ExecuteNonQuery();
                        con.Close();

                        if (i >= 1)
                        {

                            MessageBox.Show("Successfully Deleted!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Transaction Cancelled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception)
                    {

                        //throw;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvAttendanceList.DataSource = null;
            var lst = new List<AttendanceRecordList>();
            using (var con = new SQLiteConnection($@"data source =  C:\Users\Administrator\Documents\Database\StudentAttendanceMonitoring.db"))
            {
                try
                {
                    con.Open();
                    var com = new SQLiteCommand($"SELECT * FROM AttendanceRecord WHERE StudentID = @id or FirstName = @fname or MiddleName = @mname or LastName = @lname or Date = @date or Status = @status", con)
                    {
                        CommandType = CommandType.Text
                    };

                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@id", txtsearch.Text);
                    com.Parameters.AddWithValue("@fname", txtsearch.Text);
                    com.Parameters.AddWithValue("@mname", txtsearch.Text);
                    com.Parameters.AddWithValue("@lname", txtsearch.Text);
                    com.Parameters.AddWithValue("@date", txtsearch.Text);
                    com.Parameters.AddWithValue("@status", txtsearch.Text);



                    var rdr = (SQLiteDataReader)com.ExecuteReader();
                    while (rdr.Read())
                    {
                        lst.Add(new AttendanceRecordList
                        {
                            StudentID = Convert.ToInt32(rdr["StudentID"]),
                            FirstName = rdr["FirstName"].ToString(),
                            MiddleName = rdr["MiddleName"].ToString(),
                            LastName = rdr["LastName"].ToString(),
                            Date = Convert.ToDateTime(rdr["Date"]),
                            Status = rdr["Status"].ToString(),

                        });


                    }
                   
                    dgvAttendanceList.DataSource = lst;
                    con.Close();
                }
                catch (Exception)
                {

                    //throw;
                }
            }
        }

        private void dgvAttendanceList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvAttendanceList.Columns[e.ColumnIndex].HeaderText.Equals("Status"))
            {
                if (e.Value.Equals("PRESENT"))
                    e.CellStyle.BackColor = Color.Green;
                else if (e.Value.Equals("ABSENT"))
                    e.CellStyle.BackColor = Color.Red;
                else
                    e.CellStyle.BackColor = this.dgvAttendanceList.DefaultCellStyle.BackColor;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dgvAttendanceList.DataSource = null;
            var lst = new List<AttendanceRecordList>();
            using (var con = new SQLiteConnection($@"data source =  C:\Users\Administrator\Documents\Database\StudentAttendanceMonitoring.db"))
            {
                try
                {
                    con.Open();
                    var com = new SQLiteCommand($"SELECT * FROM AttendanceRecord WHERE (Date = @date)", con)
                    {
                        CommandType = CommandType.Text
                    };

                    com.Parameters.Clear();

                    com.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));




                    var rdr = (SQLiteDataReader)com.ExecuteReader();
                    while (rdr.Read())
                    {
                        lst.Add(new AttendanceRecordList
                        {

                            StudentID = Convert.ToInt32(rdr["StudentID"]),
                            FirstName = rdr["FirstName"].ToString(),
                            MiddleName = rdr["MiddleName"].ToString(),
                            LastName = rdr["LastName"].ToString(),
                            Date = Convert.ToDateTime(rdr["Date"]),
                            Status = rdr["Status"].ToString(),


                        });


                    }

                    dgvAttendanceList.DataSource = lst;
                    con.Close();
                }
                catch (Exception)
                {

                    //throw;
                }
            }

        }
    }
}
