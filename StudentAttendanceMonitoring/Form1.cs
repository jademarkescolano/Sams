using System.Data;
using System.Data.SQLite;

namespace StudentAttendanceMonitoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var lst = new List<UserLogin>();
            using (var con = new SQLiteConnection($@"data source =  C:\Users\Xlayer\Downloads\StudentAttendanceMonitoringFinal\StudentAttendanceMonitoring.db"))
            {
                try
                {
                    con.Open();
                    var com = new SQLiteCommand($"SELECT * FROM UserLogin WHERE Username = @user and Password = @pass", con)
                    {
                        CommandType = CommandType.Text
                    };

                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@user", txtusername.Text);
                    com.Parameters.AddWithValue("@pass", txtpassword.Text);


                    var rdr = (SQLiteDataReader)com.ExecuteReader();
                    if (rdr.Read())
                    {
                        lst.Add(new UserLogin
                        {
                            UserID = Convert.ToInt32(rdr["UserID"]),
                            Username = rdr["Username"].ToString(),
                            Password = rdr["Password"].ToString(),
                        });

                        var Form = new Mainform();
                        Form.ShowDialog();
                        this.Hide();
                        this.Close();

                    }
                    else
                    {

                        MessageBox.Show($" Invalid Username or Password! ", " INVALID ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {

                    //throw;
                }
            }



            // var form = new Mainform();
            // form.ShowDialog();
            // this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}