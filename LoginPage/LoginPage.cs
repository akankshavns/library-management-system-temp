using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Principal;

namespace LoginPage
{
    public partial class LoginPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False;");
        int count = 0;
        private bool isPasswordVisible = false;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Librarian where userName ='" + Text_UserName.Text + "' and password = '" + text_password.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("Wrong userName and password.");
            }
            else
            {
                this.Hide();
                HomePage hp = new HomePage();
                hp.Show();
            }


        }


        private void LoginPage_Load(object sender, EventArgs e)
        {

            panel1.BackColor = Color.FromArgb(60, 0, 0, 0);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //NewAccount ac = new NewAccount();
            //ac.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Text_UserName_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_UserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (Text_UserName.Text == "User Name")
            {
                Text_UserName.Text = "";
            }
        }

        private void text_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (text_password.Text == "Password")
            {
                text_password.Text = "";
                text_password.UseSystemPasswordChar = !isPasswordVisible;
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            text_password.UseSystemPasswordChar = !isPasswordVisible;
            if (isPasswordVisible)
            {
                PasswordVisibility.Text = "Show"; // or set an eye icon for "Hide" state
            }
            else
            {
                PasswordVisibility.Text = "Hide"; // or set an eye icon for "Show" state
            }
        }
    }
}