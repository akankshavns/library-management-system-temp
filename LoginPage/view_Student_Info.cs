using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginPage
{
    public partial class view_Student_Info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False;");
        public view_Student_Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select*From AddBooks where EnrollmentNumber like('%"+ textBox1.Text+"%') and StudentName like('%"+ textBox2.Text+"%')";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Enroll.Text = dr["EnrollmentNumber"].ToString();
                    SName.Text = dr["StudentName"].ToString();
                    Rollno.Text = dr["RollNumber"].ToString();
                    //= dr["StudentPhoto"].ToString();
                   Department .Text = dr["Department"].ToString();
                   semester .Text = dr["Semester"].ToString();
                    contact.Text = dr["Contact"].ToString();
                    mail.Text = dr["Email"].ToString();
                    Address.Text = dr["Address"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
