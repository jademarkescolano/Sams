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
    public partial class Dashboard : UserControl
    {
        private readonly Form _f = Application.OpenForms["Mainform"];

        private static Dashboard _instance;
        public static Dashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Dashboard();
                return _instance;

            }
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            btnrefresh.PerformClick();
            lblcount.Text = DgvList.Rows.Count.ToString();
        }
        public string _transaction { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_transaction == "Save")
            {
                int i = 0;

                using (var con = new SQLiteConnection($@"data source =  C:\Users\Xlayer\Downloads\StudentAttendanceMonitoringFinal\StudentAttendanceMonitoring.db"))
                {
                    try
                    {
                        con.Open();
                        var com = new SQLiteCommand($"INSERT INTO StudentList (FirstName,MiddleName,LastName,Address,Contact ) VALUES " +
                            "(@fname,@mname,@lname,@address,@contact)", con)



                        {
                            CommandType = CommandType.Text
                        };

                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@fname", txtfname.Text);
                        com.Parameters.AddWithValue("@mname", txtmname.Text);
                        com.Parameters.AddWithValue("@lname", txtlname.Text);
                        com.Parameters.AddWithValue("@address", txtaddress.Text);
                        com.Parameters.AddWithValue("@contact", txtaddress.Text);


                        i = com.ExecuteNonQuery();
                        con.Close();

                        if (i >= 1)
                        {
                            _transaction = "Save";
                            MessageBox.Show("Successfully Save!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Transaction Cancelled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {

                        //throw;
                    }
                }
            }
            if (_transaction == "Update")
            {
                int i = 0;
                using (var con = new SQLiteConnection($@"data source =  C:\Users\Xlayer\Downloads\StudentAttendanceMonitoringFinal\StudentAttendanceMonitoring.db"))
                {
                    try
                    {
                        con.Open();
                        var com = new SQLiteCommand($"UPDATE StudentList SET FirstName=@fname,MiddleName=@mname,LastName=@lname,Address=@address,Contact=@contact " +
                            "WHERE StudentID =@id ", con)



                        {
                            CommandType = CommandType.Text
                        };

                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@id", txtidno.Text);
                        com.Parameters.AddWithValue("@fname", txtfname.Text);
                        com.Parameters.AddWithValue("@mname", txtmname.Text);
                        com.Parameters.AddWithValue("@lname", txtlname.Text);
                        com.Parameters.AddWithValue("@address", txtaddress.Text);
                        com.Parameters.AddWithValue("@contact", txtcontact.Text);


                        i = com.ExecuteNonQuery();
                        con.Close();

                        if (i >= 1)
                        {

                            MessageBox.Show("Successfully Updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Transaction Cancelled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {

                        //throw;
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtidno.Clear();
            txtfname.Clear();
            txtmname.Clear();
            txtlname.Clear();
            txtaddress.Clear();
            txtcontact.Clear();
            _transaction = "Save";
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            DgvList.DataSource = null;
            var lst = new List<StudentList>();

            using (var con = new SQLiteConnection($@"data source =  C:\Users\Xlayer\Downloads\StudentAttendanceMonitoringFinal\StudentAttendanceMonitoring.db"))
            {
                try
                {
                    con.Open();
                    var com = new SQLiteCommand("SELECT * FROM StudentList", con)
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
                            Address = rdr["Address"].ToString(),
                            Contact = rdr["Contact"].ToString(),


                        });

                    }

                    _transaction = "Save";
                    DgvList.DataSource = lst;
                    lblcount.Text = DgvList.Rows.Count.ToString();

                    con.Close();
                }
                catch (Exception ex)
                {

                    //   throw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Do You Want To Delete This Record?", "Warning", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {

                int i = 0;
                using (var con = new SQLiteConnection($@"data source =  C:\Users\Xlayer\Downloads\StudentAttendanceMonitoringFinal\StudentAttendanceMonitoring.db"))
                {
                    try
                    {
                        con.Open();
                        var com = new SQLiteCommand($"DELETE FROM StudentList WHERE StudentID = @id ", con)



                        {
                            CommandType = CommandType.Text
                        };

                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@id", DgvList[0, DgvList.CurrentRow.Index].Value.ToString());


                        i = com.ExecuteNonQuery();
                        con.Close();

                        if (i >= 1)
                        {
                            _transaction = "Save";
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

        private void button4_Click(object sender, EventArgs e)
        {
            DgvList.DataSource = null;
            var lst = new List<StudentList>();
            using (var con = new SQLiteConnection($@"data source =  C:\Users\Xlayer\Downloads\StudentAttendanceMonitoringFinal\StudentAttendanceMonitoring.db"))
            {
                try
                {
                    con.Open();
                    var com = new SQLiteCommand($"SELECT * FROM StudentList WHERE StudentID = @id or FirstName = @fname or MiddleName = @mname or LastName = @lname or Address = @address or Contact = @contact", con)
                    {
                        CommandType = CommandType.Text
                    };

                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@id", txtsearch.Text);
                    com.Parameters.AddWithValue("@fname", txtsearch.Text);
                    com.Parameters.AddWithValue("@mname", txtsearch.Text);
                    com.Parameters.AddWithValue("@lname", txtsearch.Text);
                    com.Parameters.AddWithValue("@address", txtsearch.Text);
                    com.Parameters.AddWithValue("@contact", txtsearch.Text);



                    var rdr = (SQLiteDataReader)com.ExecuteReader();
                    while (rdr.Read())
                    {
                        lst.Add(new StudentList
                        {
                            StudentID = Convert.ToInt32(rdr["StudentID"]),
                            FirstName = rdr["FirstName"].ToString(),
                            MiddleName = rdr["MiddleName"].ToString(),
                            LastName = rdr["LastName"].ToString(),
                            Address = rdr["Address"].ToString(),
                            Contact = rdr["Contact"].ToString(),
                        });


                    }
                    _transaction = "Save";
                    DgvList.DataSource = lst;
                    con.Close();
                }
                catch (Exception)
                {

                    //throw;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtidno.Text = DgvList[0, DgvList.CurrentRow.Index].Value.ToString();
            txtfname.Text = DgvList[1, DgvList.CurrentRow.Index].Value.ToString();
            txtmname.Text = DgvList[2, DgvList.CurrentRow.Index].Value.ToString();
            txtlname.Text = DgvList[3, DgvList.CurrentRow.Index].Value.ToString();
            txtaddress.Text = DgvList[4, DgvList.CurrentRow.Index].Value.ToString();
            txtcontact.Text = DgvList[5, DgvList.CurrentRow.Index].Value.ToString();
            _transaction = "Update";
        }

        private void lblcount_Click(object sender, EventArgs e)
        {

        }
    }
}
