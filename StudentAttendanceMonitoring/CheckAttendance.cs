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
    public partial class CheckAttendance : Form
    {
        public CheckAttendance()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DgvList.DataSource = null;
            var lst = new List<StudentList>();

            using (var con = new SQLiteConnection($@"data source =  C:\Users\Xlayer\Downloads\StudentAttendanceMonitoringFinal\StudentAttendanceMonitoring.db"))
            {
                try
                {
                    con.Open();
                    var com = new SQLiteCommand("SELECT StudentID,FirstName,MiddleName,LastName FROM StudentList", con)
                    {
                        CommandType = CommandType.Text
                    };

                    var rdr = (SQLiteDataReader)com.ExecuteReader();
                    while (rdr.Read())
                    {
                        lst.Add(new StudentList
                        {

                            StudentID = Convert.ToInt32(rdr["StudentID"]),
                            FirstName = rdr["FirstName"].ToString(),
                            MiddleName = rdr["MiddleName"].ToString(),
                            LastName = rdr["LastName"].ToString(),
                            //Address = rdr["Address"].ToString(),
                            //Contact = rdr["Contact"].ToString(),



                        });

                    }
                    
                    DgvList.DataSource = lst;
                    DgvList.Columns["Address"].Visible = false;
                    DgvList.Columns["Contact"].Visible = false;
                    con.Close();
                }
                catch (Exception ex)
                {

                    //   throw;
                }
            }
        }

        private void CheckAttendance_Load(object sender, EventArgs e)
        {
            btnrefresh2.PerformClick();
        }

        private void Fill(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                var attendance = new AttendanceSave();
                attendance.txtidno.Text = DgvList[2, DgvList.CurrentRow.Index].Value.ToString();
                attendance.txtfname.Text = DgvList[3, DgvList.CurrentRow.Index].Value.ToString();
                attendance.txtmname.Text = DgvList[4, DgvList.CurrentRow.Index].Value.ToString();
                attendance.txtlname.Text = DgvList[5, DgvList.CurrentRow.Index].Value.ToString();
                attendance.txtstatus.Text = "PRESENT";
                attendance.ShowDialog();

            }
            else if (e.ColumnIndex == 1)
            {
                var attendance = new AttendanceSave();
                attendance.txtidno.Text = DgvList[2, DgvList.CurrentRow.Index].Value.ToString();
                attendance.txtfname.Text = DgvList[3, DgvList.CurrentRow.Index].Value.ToString();
                attendance.txtmname.Text = DgvList[4, DgvList.CurrentRow.Index].Value.ToString();
                attendance.txtlname.Text = DgvList[5, DgvList.CurrentRow.Index].Value.ToString();
                attendance.txtstatus.Text = "ABSENT";
                attendance.ShowDialog();
            }
            else
            {
                //
            }
        }

        private void DgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
