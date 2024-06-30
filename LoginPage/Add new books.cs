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

namespace LoginPage
{
    public partial class Add_new_books : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False;");
        public Add_new_books()
        {
            InitializeComponent();
        }

        private void Add_new_books_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into AddBooks values('"+ textBox1.Text +"','" + textBox2.Text+"','"+ textBox3.Text+"','"+dateTimePicker1.Text+"',"+ textBox5.Text+","+textBox6.Text+")";
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            MessageBox.Show("Book added successfully");
        }
    

   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
